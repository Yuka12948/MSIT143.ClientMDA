using ClientMDA.Models;
using ClientMDA.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class TheaterController : Controller
    {
        private readonly MDAContext _MDA;

        public TheaterController(MDAContext MDA)
        {
            _MDA = MDA;
        }

        public IActionResult Index()
        {
            return View();
        } //完工

        public IActionResult 即將上映page1()
        {
            return View();
        }//完工


        public IActionResult 阮玲玉()
        {
            return View();
        }  //完工

        public IActionResult LettheBulletsFly()
        {
            return View();
        } //完工
        public IActionResult 捍衛戰士2()
        {
            return View();
        } //完工

        public IActionResult hot()
        {
            List<CTheater> datas = null;
            datas = _MDA.電影movies.OrderByDescending(p => p.票房boxOffice).Select
            (p => new CTheater
            {
                movie = p,
                分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
            }).ToList();
            return ViewComponent("現正熱映", datas);
        }
        public IActionResult 測試業面()
        {
            List<CTheater> datas = null;
            datas =_MDA.電影movies.OrderByDescending(p=>p.票房boxOffice).Select
            (p => new CTheater
            {
                movie = p,
                分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
            }).ToList();
            return View(datas);
        } //完工
        public IActionResult now()
        {
            List<CTheater> datas = null;
            datas = _MDA.電影movies.OrderByDescending(p => p.上映日期releaseDate).Select
            (p => new CTheater
            {
                movie = p,
                分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
            }).ToList();
            return ViewComponent("即將上映",datas);
        } //完工
        public IActionResult 快定頁面測試(int id)
        {
            CTheater datas = null;
            datas = _MDA.電影movies.Where(p => p.電影編號movieId==id).Select
                (p => new CTheater
                {
                 movie = p,
                 分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                 }).FirstOrDefault();
            return View(datas);
           
        } //完工
        public IActionResult nowpage(int num)
        {
            int i = 12, j = 0;
           List<CTheater> datas = null;
            if (num == 1)
            {
                datas = _MDA.電影movies.OrderByDescending(p => p.上映日期releaseDate).Select
                (p => new CTheater
                {
                    movie = p,
                    分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                }).ToList();
                return ViewComponent("即將上映", datas);
            }
            else if (num >= 2) {
                j = 12;
                i = i * num;
            }
                datas = _MDA.電影movies.OrderByDescending(p => p.上映日期releaseDate).Select
                (p => new CTheater
                {
                    movie = p,
                    分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                }).Skip(i - j).Take(i).ToList();
                return ViewComponent("即將上映", datas);
        } //完工
        public IActionResult hotpage(int num)
        {
            int i = 12, j = 0;
            List<CTheater> datas = null;
            if (num == 1)
            {
                datas = _MDA.電影movies.OrderByDescending(p => p.票房boxOffice).Select
                (p => new CTheater
                {
                    movie = p,
                    分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                }).ToList();
                return ViewComponent("現正熱映", datas);
            }
            else if (num >= 2)
            {
                j = 12;
                i = i * num;
            }
            datas = _MDA.電影movies.OrderByDescending(p => p.票房boxOffice).Select
            (p => new CTheater
            {
                movie = p,
                分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
            }).Skip(i - j).Take(i).ToList();
            return ViewComponent("現正熱映", datas);
        }
        public IActionResult page()
        {

            return ViewComponent("頁數");
        } //完工
    }
}
