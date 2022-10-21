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
            _MDA.電影圖片movieIimagesLists.ToList();
            _MDA.電影圖片總表movieImages.ToList();
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
            var q = _MDA.電影圖片movieIimagesLists.Select(i => i);
            datas = _MDA.電影movies.OrderByDescending(p => p.票房boxOffice).Select
            (p => new CTheater
            {
                movie = p,
                分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                MPimg = _MDA.電影圖片movieIimagesLists.Where(i => i.電影編號movieId == p.電影編號movieId)
                .Select(c =>c.圖片編號image.圖片雲端imageImdb).ToList()

            }).ToList();
            return View(datas);
        } //完工
        public IActionResult now()
        {
            List<CTheater> datas = null;
            List<int> img = _MDA.電影圖片movieIimagesLists.Select(p => p.電影圖片編號miId).ToList();
            datas = _MDA.電影movies.OrderByDescending(p => p.上映日期releaseDate).Select
                      (p => new CTheater
                      {
                          movie = p,
                          分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                          MPimg = _MDA.電影圖片movieIimagesLists.Where(i => i.電影編號movieId == p.電影編號movieId)
                                  .Select(c => c.圖片編號image.圖片雲端imageImdb).ToList()

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
        public IActionResult area(string keyword,int id)
        {
            List<CTheater> datas = null;
            int mcid = this._MDA.電影代碼movieCodes.Where(p => p.電影編號movieId == id).Select(x => x.電影代碼編號movieCodeId).FirstOrDefault(); 
            if (String.IsNullOrEmpty(keyword))
            {return View();}
            if (keyword == "北區")
            {
                datas = _MDA.電影院theaters.Where(p => p.地址address.Contains("基隆") ||
                p.地址address.Contains("北市") || p.地址address.Contains("台東") ||
                p.地址address.Contains("花蓮")
                ).Select
                    (i => new CTheater
                    {
                        theater = i,
                        cinemas影廳種類 = _MDA.影廳cinemas.Where(c => c.電影院編號theaterId == i.電影院編號theaterId).Select(c => new CcinemaViewMode
                        {
                            CinemaID = c.影廳編號cinemaId,
                            CinemaName = c.廳種名稱cinemaClsName,
                            放映時間 = c.場次screenings.Where(x=>x.電影代碼movieCode==mcid).Select(s => s.放映開始時間playTime).ToList(),
                            場次ID = c.場次screenings.Where(x => x.電影代碼movieCode == mcid).Select(s => s.場次編號screeningId).ToList(),
                            
                        }).ToList()
                    }).ToList();
            }
            else if (keyword == "桃竹苗") {
                datas = _MDA.電影院theaters.Where(p => p.地址address.Contains("桃") ||
                p.地址address.Contains("苗") || p.地址address.Contains("竹") 
                ).Select
                (i => new CTheater
                {
                    theater = i,
                    cinemas影廳種類 = _MDA.影廳cinemas.Where(c => c.電影院編號theaterId == i.電影院編號theaterId).Select(c => new CcinemaViewMode
                    {
                        CinemaID = c.影廳編號cinemaId,
                        CinemaName = c.廳種名稱cinemaClsName,
                        放映時間 = c.場次screenings.Where(x => x.電影代碼movieCode == mcid).Select(s => s.放映開始時間playTime).ToList(),
                        場次ID = c.場次screenings.Where(x => x.電影代碼movieCode == mcid).Select(s => s.場次編號screeningId).ToList(),


                    }).ToList()

                }).ToList();
            }
            else if (keyword == "中區")
            {
                datas = _MDA.電影院theaters.Where(p => p.地址address.Contains("台中") ||
                p.地址address.Contains("雲林") 
                ).Select
                (i => new CTheater
                {
                    theater = i,
                    cinemas影廳種類 = _MDA.影廳cinemas.Where(c => c.電影院編號theaterId == i.電影院編號theaterId).Select(c => new CcinemaViewMode
                    {
                        CinemaID = c.影廳編號cinemaId,
                        CinemaName = c.廳種名稱cinemaClsName,
                        放映時間 = c.場次screenings.Where(x => x.電影代碼movieCode == mcid).Select(s => s.放映開始時間playTime).ToList(),
                        場次ID = c.場次screenings.Where(x => x.電影代碼movieCode == mcid).Select(s => s.場次編號screeningId).ToList(),
                    }).ToList()
                }).ToList();
            }
            else {
                datas = _MDA.電影院theaters.Where(p => p.地址address.Contains("高雄") ||
                p.地址address.Contains("嘉義") || p.地址address.Contains("台南")
                ).Select
                (i => new CTheater
                {
                    theater = i,
                    cinemas影廳種類 = _MDA.影廳cinemas.Where(c => c.電影院編號theaterId == i.電影院編號theaterId).Select(c => new CcinemaViewMode
                    {
                        CinemaID = c.影廳編號cinemaId,
                        CinemaName = c.廳種名稱cinemaClsName,
                        放映時間 = c.場次screenings.Where(x => x.電影代碼movieCode == mcid).Select(s => s.放映開始時間playTime).ToList(),
                        場次ID = c.場次screenings.Where(x => x.電影代碼movieCode == mcid).Select(s => s.場次編號screeningId).ToList(),
                    }).ToList()
                }).ToList();
            }
            return ViewComponent("時間",datas);
        } //完工





    }
}
