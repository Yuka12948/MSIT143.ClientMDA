using ClientMDA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClientMDA.Controllers
{
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;
        private readonly MDAContext _MDA;
        Random rd = new Random();

        public ApiController(ILogger<ApiController> logger, MDAContext MDA)
        {
            _logger = logger;
            _MDA = MDA;
            _MDA.電影圖片movieIimagesLists.ToList();
            _MDA.電影圖片總表movieImages.ToList();
            _MDA.電影movies.ToList();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult checklogink()
        {
            //if (!HttpContext.Session.Keys.Contains(ADictionary.SK_LOGINED_USER))
            //    return RedirectToAction("~/Member/Login");
            return View();

        }


        public IActionResult showrankposter()
        {
            var q = from a in _MDA.電影圖片總表movieImages
                    join b in _MDA.電影排行movieRanks on a.電影名稱movieName equals b.電影movie
                    where a.電影名稱movieName == b.電影movie
                    orderby b.排行編號rankId ascending
                    select a.圖片雲端imageImdb;
            return Json(q);
        }

        public IActionResult showrankmovie()
        {
            var q1 = from a in _MDA.電影排行movieRanks
                     where a.電影排名movieRank != null
                     select a.電影movie;
            return Json(q1);
        }

        public IActionResult shownewmovie()
        {
            var q2 = _MDA.電影圖片movieIimagesLists.Where(m => m.電影編號movie.上映日期releaseDate >= (DateTime.Now.AddDays(-7)) && m.電影編號movie.上映日期releaseDate <= (DateTime.Now.AddDays(7))).OrderBy(d => d.電影編號movie.上映日期releaseDate).Select(v => v.電影編號movie.中文標題titleCht);
            return Json(q2);
        }

        public IActionResult shownewposter()
        {
            var q = _MDA.電影圖片movieIimagesLists.Where(m => m.電影編號movie.上映日期releaseDate >= (DateTime.Now.AddDays(-7)) && m.電影編號movie.上映日期releaseDate <= (DateTime.Now.AddDays(7))).OrderBy(d => d.電影編號movie.上映日期releaseDate).Select(u => u.圖片編號image.圖片雲端imageImdb);
            return Json(q);
        }


        public IActionResult showrecommendposter()
        {
            List<string> list = new List<string>(0);
            List<int> listNumbers = new List<int>();
            //var q = _MDA.電影圖片movieIimagesLists.Where(m => m.電影編號movie.上映日期releaseDate < DateTime.Now.AddDays(-30)).OrderBy(d => d.電影編號movie).Select(u => u.圖片編號image.圖片雲端imageImdb);

            //var q1 = _MDA.電影圖片movieIimagesLists.Where(p => p.電影編號movie.上映日期releaseDate < DateTime.Now.AddDays(-30)).OrderBy(d => d.電影編號movieId).Select(o => o.電影編號movieId).First();
            //var q2 = _MDA.電影圖片movieIimagesLists.Where(p => p.電影編號movie.上映日期releaseDate < DateTime.Now.AddDays(-30)).OrderBy(d => d.電影編號movieId).Select(o => o.電影編號movieId).Last();

            int number;
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    //資料庫要新增很多東西才可以跳更多推薦
                    number = rd.Next(1, 25);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }
            for (int i = 0; i < listNumbers.Count(); i++)
            {
                var q3 = _MDA.電影圖片movieIimagesLists.AsEnumerable().Where(p => p.電影編號movieId == listNumbers[i]).FirstOrDefault().圖片編號image.圖片雲端imageImdb;
                list.Add(q3);
            }

            return Json(list);
        }
    }
}
