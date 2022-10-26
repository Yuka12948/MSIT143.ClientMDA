using ClientMDA.Models;
using ClientMDA.ViewModels;
using Microsoft.AspNetCore.Mvc;
using prj_MDA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class MovieController : Controller
    {
        private readonly MDAContext _MDAcontext;

        public MovieController(MDAContext MDAcontext)  //相依性注入
        {
            _MDAcontext = MDAcontext;
            _MDAcontext.電影圖片movieIimagesLists.ToList();
            _MDAcontext.電影圖片總表movieImages.ToList();
        }

        public ActionResult 排行首頁(CKeywordViewModel model)
        {
            MDAContext db = new MDAContext();
            IEnumerable<電影movie> datas = null;

            if (string.IsNullOrEmpty(model.txtKeyword))
                datas = from p in db.電影movies
                        select p;
            else
                datas = db.電影movies.Where(p => p.中文標題titleCht.Contains(model.txtKeyword) ||
                                                 p.英文標題titleEng.Contains(model.txtKeyword));

            return View(datas);
        }

        public IActionResult 電影介紹(int? id) //電影資訊/電影評論 int? id
        {
            CMovieViewModel datas = null;
            var q = _MDAcontext.電影圖片movieIimagesLists.Select(i => i);
            datas = _MDAcontext.電影movies.Where(m => m.電影編號movieId == id).Select
            (m => new CMovieViewModel
            {
                movie = m,
                //演員中文名字nameCht = m.電影主演casts,
                分級級數ratingLevel = m.電影分級編號rating.分級級數ratingLevel,
                分級圖片ratingImage = m.電影分級編號rating.分級圖片ratingImage,
                系列名稱seriesName = m.系列編號series.系列名稱seriesName,
                //圖片雲端imageImdb = _MDAcontext.電影圖片movieIimagesLists.Where(i=>i.電影編號movieId == m.電影編號movieId)
                //.FirstOrDefault(c=>c.圖片編號image.圖片雲端imageImdb)
                mCountryName = _MDAcontext.電影產地movieOrigins.Where(i => i.電影編號movieId == m.電影編號movieId)
                .Select(c => c.國家編號country.國家名稱countryName).ToList(),
                mCountryImg = _MDAcontext.電影產地movieOrigins.Where(i => i.電影編號movieId == m.電影編號movieId)
                .Select(c => c.國家編號country.國旗countryImage).ToList(),
                mImgFrList = _MDAcontext.電影圖片movieIimagesLists.Where(i => i.電影編號movieId == m.電影編號movieId)
                .Select(c => c.圖片編號image.圖片雲端imageImdb).ToList()

            }).FirstOrDefault();
            return View(datas);
        }

        public IActionResult 電影劇照牆()
        {
            return View();
        }

        public IActionResult 電影劇照()
        {
            return View();
        }


        public FileResult ShowPhoto(int id)
        {
            電影分級movieRating rating = _MDAcontext.電影分級movieRatings.Find(id);
            byte[] context = rating.分級圖片ratingImage;
            return File(context, "image/jpeg");
        }
    }
}
