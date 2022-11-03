﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientMDA.Models;
using ClientMDA.ViewModels;
using ClientMDA.ViewModel.WenViewModel;
using ClientMDA.ViewModels.WenViewModel;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using MailKit.Net.Smtp;
using MimeKit;


namespace ClientMDA.Controllers
{
    public class WenShoppingCartController : Controller
    {
        private readonly MDAContext _context;

        public WenShoppingCartController(MDAContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            var datas = from t in _context.商品資料products
                        select t;
            List<CShoppingProd> list = new List<CShoppingProd>();
            foreach (商品資料product t in datas)
            {
                CShoppingProd vm = new CShoppingProd();
                vm.product = t;
                list.Add(vm);
            }
            return View(list);
        }

        public IActionResult TestSearchKeyword(string keyword)
        {
            var product = _context.商品資料products
              .Where(p => p.商品名稱productName.Contains(keyword) ||
              p.商品介紹introduce.Contains(keyword) ||
              p.電影院編號theater.電影院名稱theaterName.Contains(keyword)
              )
              .Select(p => new
              {
                  p.電影院編號theater.電影院名稱theaterName,
                  p.商品編號productId,
                  p.商品名稱productName,
                  p.商品價格productPrice,
                  p.商品介紹introduce,
                  p.類別category,
                  p.商品圖片路徑imagePath
              });

            return Json(product);
        }

        public IActionResult AddToCart(int? id)
        {
            商品資料product prod = _context.商品資料products.FirstOrDefault(t => t.商品編號productId == id);
            if (prod == null)
                return RedirectToAction("CartView");
            return View(prod);
        }
        List<WenCAddToCartItem> list = null;

        [HttpPost]
        public ActionResult AddToCart(WenCAddToCartItem vModel)
        {
            商品資料product prod = _context.商品資料products.FirstOrDefault(t => t.商品編號productId == vModel.商品編號productId);
            if (prod == null)
                return RedirectToAction("CartView");
            string jsonCart = "";
            //List<WenCAddToCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(WenCDictionary.SK_PURCHASED_PRODUCTS))//session沒有東西
                list = new List<WenCAddToCartItem>();
            else
            {
                jsonCart = HttpContext.Session.GetString(WenCDictionary.SK_PURCHASED_PRODUCTS);
                list = JsonSerializer.Deserialize<List<WenCAddToCartItem>>(jsonCart);
            }
            var 電影院名稱theaterName = _context.電影院theaters.Where(x => x.電影院編號theaterId == prod.電影院編號theaterId).Select(i => i.電影院名稱theaterName).First();
            WenCAddToCartItem item = new WenCAddToCartItem()
            {
                count = vModel.count,
                商品價格productPrice = (decimal)prod.商品價格productPrice,
                商品名稱productName = prod.商品名稱productName,
                電影院名稱theaterName = 電影院名稱theaterName,
                電影院編號theaterId = prod.電影院編號theaterId,
                商品編號productId = vModel.商品編號productId,
                商品介紹introduce = prod.商品介紹introduce,
                商品圖片路徑imagePath = prod.商品圖片路徑imagePath,
                product = prod
            };
            list.Add(item);
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(WenCDictionary.SK_PURCHASED_PRODUCTS, jsonCart);
            return RedirectToAction("CartView");
        }
        List<WenCAddToCartItem> cart = null;

        public IActionResult CartView()
        {
            if (HttpContext.Session.Keys.Contains(WenCDictionary.SK_PURCHASED_PRODUCTS))//session有東西
            {
                string jsonCart = HttpContext.Session.GetString(WenCDictionary.SK_PURCHASED_PRODUCTS);
                cart = JsonSerializer.Deserialize<List<WenCAddToCartItem>>(jsonCart);
                return View(cart);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        //delete編輯中
        public IActionResult ProductDelete(int id)
        {
            if (HttpContext.Session.Keys.Contains(WenCDictionary.SK_PURCHASED_PRODUCTS))
            {
                string jsonCart = HttpContext.Session.GetString(WenCDictionary.SK_PURCHASED_PRODUCTS);
                list = JsonSerializer.Deserialize<List<WenCAddToCartItem>>(jsonCart);

                int index = list.FindIndex(m => m.商品編號productId == id);
                list.RemoveAt(index);
                jsonCart = JsonSerializer.Serialize(list);
                HttpContext.Session.SetString(WenCDictionary.SK_PURCHASED_PRODUCTS, jsonCart);
            }
            return RedirectToAction("CartView");

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateReceipt(List<WenCAddToCartItem> v)
        {
            List<購買商品明細receipt> CRList = new List<購買商品明細receipt>();
            for (int i = 0; i < v.Count; i++)
            {
                購買商品明細receipt item = new 購買商品明細receipt()
                {
                    商品數量qty = v[i].count,
                    商品編號productId = v[i].商品編號productId,
                    訂單編號orderId = 4,                   
                };
                CRList.Add(item);
                _context.購買商品明細receipts.Add(item);
            }
            _context.SaveChanges();

            MimeMessage message = new MimeMessage();
            BodyBuilder builder = new BodyBuilder();
            //var image = builder.LinkedResources.Add("C:\Users\Student\Documents\123\ClientMDA\wwwroot\images\Ticketing\3.jpg");
            //==>這裡可以放入圖片路徑

            builder.HtmlBody = "親愛的客戶您好,訂單已成立" + $"當前時間:{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            //=>內容

            message.From.Add(new MailboxAddress("M.D.A.購物商城", "rainbow_kapok@hotmail.com"));
            message.To.Add(new MailboxAddress("Wennie", "rainbow.wenwen@gmail.com"));
            string orderid = "";
           
            foreach (var item in CRList)
            {
                orderid += item.購買商品明細編號receiptId+",";               
            }
            string jsonCart = HttpContext.Session.GetString(WenCDictionary.SK_PURCHASED_PRODUCTS);
            list = JsonSerializer.Deserialize<List<WenCAddToCartItem>>(jsonCart);

            //int index = list.FindIndex(m => m.訂單編號Order_ID.Equals(oid));          
            string name = "";
            string amount = "";
            string price = "";
            string stotal = "";
            foreach (var item in list)
            {
                name += item.商品名稱productName+",";
                amount+=item.count+",";
                price += item.商品價格productPrice.ToString("0") + ",";
                stotal += item.小計.ToString("0") + ",";
            }

            builder.HtmlBody =
             $"<div style='border: 1px solid black;text-align: left;'>" +
             $"<h3>訂單明細</h3>" +
             $"<p>商品明細編號{orderid}</p>" +
             $"<p>商品名稱: {name}</p>" +
             $"<p>數量: {amount}</p>" +
             $"<p>單價: {price}</p>" +
             $"<p>小計: {stotal}</p>" +
             $"</div>";
            message.Subject = "您好，訂單已成立"; //==>標題          
            message.Body = builder.ToMessageBody();
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.outlook.com", 25, MailKit.Security.SecureSocketOptions.StartTls);
                //第二個參數是port
                //outlook.com smtp.outlook.com port:25
                //yahoo smtp.mail.yahoo.com.tw port:465
                //gmail smtp.gmail.com port:587
                client.Authenticate("rainbow_kapok@hotmail.com", "rainbowwenwen1104");
                client.Send(message);
                client.Disconnect(true);
            }
            return RedirectToAction("ThankU");

        }
        public IActionResult ThankU()
        {
            return View();
        }

        public IActionResult Optiontheater()
        {
            return View();

        }
        public IActionResult OptTheater()
        {
            if (HttpContext.Session.Keys.Contains(WenCDictionary.SK_PURCHASED_PRODUCTS))//session有東西
            {
                string jsonCart = HttpContext.Session.GetString(WenCDictionary.SK_PURCHASED_PRODUCTS);
                cart = JsonSerializer.Deserialize<List<WenCAddToCartItem>>(jsonCart);
                //string last =(cart.Last().電影院編號theaterId).ToString();
                WenCAddToCartItem T = new WenCAddToCartItem()
                {
                    電影院名稱theaterName = cart[cart.Count - 1].電影院名稱theaterName,
                    電影院編號theaterId = cart[cart.Count - 1].電影院編號theaterId

                };


                return Json(T);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        //List<WenIndexItem> mylist = null;
        //[HttpPost]
        //public IActionResult Index(WenIndexItem vModel)
        //{
        //    商品資料product prod = _context.商品資料products.FirstOrDefault(m => m.電影院編號theater.Equals(vModel.電影院編號theaterId));
        //    if (prod == null)
        //        return RedirectToAction("Index");
        //    string S = "";
        //    if (!HttpContext.Session.Keys.Contains(WenCDictionary.SK_記錄商品畫面))
        //        mylist = new List<WenIndexItem>();
        //    else
        //    {
        //        S = HttpContext.Session.GetString(WenCDictionary.SK_記錄商品畫面);
        //        mylist = JsonSerializer.Deserialize<List<WenIndexItem>>(S);
        //    }
        //    var 電影院名稱theaterName = _context.電影院theaters.Where(x => x.電影院編號theaterId == prod.電影院編號theaterId).Select(i => i.電影院名稱theaterName).First();
        //    WenIndexItem item = new WenIndexItem()
        //    {
        //        電影院編號theaterId = vModel.電影院編號theaterId,
        //        電影院名稱theaterName = 電影院名稱theaterName,
        //        product = prod
        //    };
        //    mylist.Add(item);
        //    S = JsonSerializer.Serialize(mylist);
        //    HttpContext.Session.SetString(WenCDictionary.SK_記錄商品畫面, S);
        //    return RedirectToAction("Index");
        //}
        public IActionResult SearchKeyword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchKeyword(string keyword)
        {
            return View();
        }


        public IActionResult CardProduct(int myTheaterId)
        {
            var product = _context.商品資料products
                .Where(p => p.電影院編號theaterId == myTheaterId)
                .Select(p => new
                {
                    p.商品編號productId,
                    p.商品名稱productName,
                    p.商品價格productPrice,
                    p.商品介紹introduce,
                    p.商品圖片路徑imagePath
                });
            return Json(product);
        }

        //public ActionResult AddToCard(int? id)
        //{
        //    商品資料product prod = _context.商品資料products.FirstOrDefault(p => p.商品編號productId == id);
        //    if (prod != null)
        //        return View(prod);
        //    return RedirectToAction("Index");
        //}


        //public IActionResult CIndex()
        //{
        //    var datas = from t in (new MDAContext()).商品資料products
        //                select t;

        //    List<CShoppingProd> list = new List<CShoppingProd>();

        //    foreach (商品資料product t in datas)
        //    {
        //        CShoppingProd vm = new CShoppingProd();
        //        vm.product = t;
        //        list.Add(vm);
        //    }

        //    return View(list);
        //}

        public IActionResult Theater()
        {
            var query = from m in _context.電影院theaters
                        select m;

            return Json(query);

        }
        public IActionResult Category(int TheaterId)
        {
            var q = _context.商品資料products
                .Where(p => p.電影院編號theaterId == TheaterId)
                .GroupBy(p => new { p.類別category })
                .Select(p => p.Key.類別category.ToString()).ToList();

            return Json(q);
        }
        public IActionResult Prod(string categoryName, int TheaterId)
        {
            var q = _context.商品資料products
                .Where(p => p.類別category == categoryName && p.電影院編號theaterId == TheaterId)
                .OrderBy(p => p.類別category)
                .Select(p => p).ToList();
            return Json(q);
        }

        public IActionResult expoint(string Coupon_Code)
        {
            //var redpoint = this._context.會員members.Select(m => m.紅利點數bonus);
            //var Coupon=this._context.

            var q = _context.優惠總表coupons
                .Where(c => c.優惠代碼couponCode == Coupon_Code)
                .Select(c => c.優惠折扣couponDiscount);
            return Json(q);
        }
        //public IActionResult Theater()
        //{
        //    var query = from m in _context.電影院theaters
        //                select m;/*new { m.電影院名稱theaterName,m.電影院編號theaterId}*/  //object    

        //    return Json(query);
        //}
        //public IActionResult Category(int TheaterId)
        //{
        //    var q = _context.商品資料products
        //        .Where(p => p.電影院編號theaterId == TheaterId)
        //        .GroupBy(p=>new { p.類別category})
        //        .Select(p =>
        //        new { 
        //        ByCategory=p.Key                
        //        });

        //    return Json(q);
        //}
        //public IActionResult Prod(int categoryName)
        //{
        //    var q = _context.商品資料products
        //        .Where(p => p.類別category.Equals(categoryName))               
        //        .Select(p =>
        //        new {
        //           p.商品名稱productName,
        //           p.商品介紹introduce,
        //           p.商品價格productPrice
        //        });

        //    return Json(q);
        //}

    }
}
