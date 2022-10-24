using ClientMDA.Models;
using ClientMDA.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class MemberController : Controller
    {
        private readonly MDAContext _MDAcontext;

        public MemberController(MDAContext MDAcontext)  //相依性注入
        {
            _MDAcontext = MDAcontext;
        }
        List<CMemberDemoViewModel> members = new List<CMemberDemoViewModel>();
        CMemberDemoViewModel memberDemo1 = new CMemberDemoViewModel
        {
            MemberID = 2,
            Cellphone = "0902002002",
            Email = "002@gmail.com",
            Password = "0000",
            Formal = false,
            Permission = 0,
            CreatedTime = DateTime.Now,
        };
        CMemberDemoViewModel memberDemo2 = new CMemberDemoViewModel
        {
            MemberID = 1,
            Cellphone = "0901001001",
            Email = "001@gmail.com",
            Password = "0000",
            Formal = true,
            Permission = 0,
            Address = "台北市",
            BirthDate = new DateTime(1990, 1, 1),
            F_Name = "Wei",
            L_Name = "Wang",
            NickName = "Yuka",
            Gender = 1,
            Bonus = 100,
            CreatedTime = new DateTime(2022, 6, 15),
        };
        public IActionResult MemberMain()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vModel)
        {
            string jsonUserPhone = JsonSerializer.Serialize(vModel.txtphone);
            HttpContext.Session.SetString(CDictionary.SK_USER_PHONE, jsonUserPhone);

            bool isExist = _MDAcontext.會員members.Any(m => m.會員電話cellphone == vModel.txtphone);
            if (isExist)
                return RedirectToAction("Login2");
            else
                return RedirectToAction("SignUp");//, new { phone = vModel.txtphone }
        }

        public IActionResult checkExist(string phone)
        {
            bool isExist = _MDAcontext.會員members.Any(m => m.會員電話cellphone == phone);
            return Content(isExist.ToString(), "text/plain");
        }

        public IActionResult Login2(/*string phone*/)
        {
            //ViewBag.phone = phone;
            var a = HttpContext.Session.GetString(CDictionary.SK_USER_PHONE);
            ViewBag.phone = JsonSerializer.Deserialize<string>(a);
            //CLogin2ViewModel mem = new CLogin2ViewModel();
            //mem.txtphone = phone;
            return View();
        }
        [HttpPost]
        public IActionResult Login2(CLogin2ViewModel vModel)
        {
            會員member mem = _MDAcontext.會員members.FirstOrDefault(t => t.會員電話cellphone.Equals(vModel.txtPhone));
            if (mem != null && mem.密碼password.Equals(vModel.txtPassword))
            {
                string jsonUser = JsonSerializer.Serialize(mem);
                HttpContext.Session.SetString(CDictionary.SK_LOGINED_USER, jsonUser);
                return RedirectToAction("MemberMain");
            }

            else
            {
                ViewBag.phone = vModel.txtPhone;
                ViewBag.txtError = false;
                return View();
            }
        }
        public bool checkPsw(string psw)
        {
            bool isPsw = _MDAcontext.會員members.Any(m => m.密碼password == psw);
            return isPsw;
        }
        public IActionResult SignUp()
        {
            var a = HttpContext.Session.GetString(CDictionary.SK_USER_PHONE);
            ViewBag.phone = JsonSerializer.Deserialize<string>(a);
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(CSignUpViewModel vModel)
        {
            會員member m = new 會員member();
            m.會員電話cellphone = vModel.txtPhone;
            m.電子信箱email = vModel.txtEmail;
            m.密碼password = vModel.txtPassword;
            m.會員權限permission = 0;
            m.正式會員formal = false;
            _MDAcontext.會員members.Add(m);
            _MDAcontext.SaveChanges();

            string jsonUser = JsonSerializer.Serialize(m);
            HttpContext.Session.SetString(CDictionary.SK_LOGINED_USER, jsonUser);

            return Content("save", "text/plain");
            //return RedirectToAction("MemberMain");
        }
        public IActionResult MemberEdit()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            return View();
        }

        public IActionResult CommentList(CKeywordViewModel model)
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            else
            {
                var a = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                會員member mem = JsonSerializer.Deserialize<會員member>(a);
                IEnumerable<電影評論movieComment> datas = null;
                var q = _MDAcontext.電影評論movieComments.Where(c => c.會員編號memberId == mem.會員編號memberId);
                if (string.IsNullOrEmpty(model.txtKeyword))
                {
                    datas = q;
                }
                else
                    datas = q.Where(c => c.評論標題commentTitle.Contains(model.txtKeyword));
                return View(datas);
            }

        }
        public IActionResult CommentEdit(int? id)
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            else
            {
                var a = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                會員member mem = JsonSerializer.Deserialize<會員member>(a);
                if (mem.正式會員formal == false)
                {
                    return RedirectToAction("NotFormal");
                }
                return View();
            }
        }

        public IActionResult WatchList()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            else
            {
                //var a = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                //會員member mem = JsonSerializer.Deserialize<會員member>(a);
                //if (mem.正式會員formal == false)
                //{
                //    return RedirectToAction("NotFormal");
                //}
                return View();
            }
        }

        public IActionResult PasswordEdit()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(CDictionary.SK_LOGINED_USER);
            return View();
        }
        public IActionResult MemberBonusList()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            return View();
        }
        public IActionResult MemberDiscount()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            return View();
        }
        public IActionResult OrderList()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            return View();
        }
        public IActionResult NotFormal()
        {
            return View();
        }
        public IActionResult test()
        {
            return View();
        }
        public IActionResult test2()
        {
            return View();
        }
        public IActionResult WriteComment()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            else
            {
                var a = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                會員member mem = JsonSerializer.Deserialize<會員member>(a);
                if (mem.正式會員formal == false)
                {
                    return RedirectToAction("NotFormal");
                }
                return View();
            }
        }
        public IActionResult WishList() //followList
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            else
            {
                //var a = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                //會員member mem = JsonSerializer.Deserialize<會員member>(a);
                //if (mem.正式會員formal == false)
                //{
                //    return RedirectToAction("NotFormal");
                //}
                return View();
            }
        }

        //讀取所有城市資料
        public IActionResult City()
        {
            var cities = _MDAcontext.地址addresses.Select(a => a.City).Distinct();
            return Json(cities);

        }
        //依據城市名稱讀取鄉鎮區資料
        public IActionResult Site(string city)
        {
            var sites = _MDAcontext.地址addresses.Where(a => a.City == city).Select(a => a.SiteId).Distinct();
            return Json(sites);

        }
        //依據城市名稱讀取鄉鎮區資料
        public IActionResult Road(string site)
        {
            var roads = _MDAcontext.地址addresses.Where(a => a.SiteId == site).Select(a => a.Road).Distinct();
            return Json(roads);

        }
        public IActionResult autoCmpMovie(string movie)
        {
            var movies = _MDAcontext.電影movies.Where(m => m.中文標題titleCht.Contains(movie) || m.英文標題titleEng.ToUpper().Contains(movie.ToUpper())).Select(p => p.中文標題titleCht);
            return Json(movies);

        }
    }
}
