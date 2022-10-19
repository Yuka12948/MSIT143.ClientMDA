using ClientMDA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.ViewModels
{
    public class CTheater
    {

        private  電影movie _movie;
        private  影廳cinema _Cinema;
        private 電影院theater _theater;

        public CTheater()
        {
            _movie = new 電影movie();
            _Cinema = new 影廳cinema();
            _theater = new 電影院theater();
        }
        public 電影院theater theater
        {
            get { return _theater; }
            set { _theater = value; }
        }
        public 影廳cinema Cinema
        {
            get { return _Cinema; }
            set { _Cinema = value; }
        }


        public 電影movie movie
        {
            get { return _movie; }
            set { _movie = value; }
        }

        public int 電影編號movieId
        {
            get { return _movie.電影編號movieId; }
            set { _movie.電影編號movieId = value; }
        }
        public int? 系列編號seriesId
        {
            get { return _movie.系列編號seriesId; }
            set { _movie.系列編號seriesId = value; }
        }
        public string 中文標題titleCht
        {
            get { return _movie.中文標題titleCht; }
            set { _movie.中文標題titleCht = value; }
        }
        public string 英文標題titleEng
        {
            get { return _movie.英文標題titleEng; }
            set { _movie.英文標題titleEng = value; }
        }
        public int 上映年份releaseYear
        {
            get { return _movie.上映年份releaseYear; }
            set { _movie.上映年份releaseYear = value; }
        }
        public DateTime? 上映日期releaseDate
        {
            get { return _movie.上映日期releaseDate; }
            set { _movie.上映日期releaseDate = value; }
        }
        public int 片長runtime
        {
            get { return _movie.片長runtime; }
            set { _movie.片長runtime = value; }
        }
        public int 電影分級編號ratingId
        {
            get { return _movie.電影分級編號ratingId; }
            set { _movie.電影分級編號ratingId = value; }
        }
        public decimal? 評分rate
        {
            get { return _movie.評分rate; }
            set { _movie.評分rate = value; }
        }
        public decimal? 期待度anticipation
        {
            get { return _movie.期待度anticipation; }
            set { _movie.期待度anticipation = value; }
        }
        public string 票房boxOffice
        {
            get { return _movie.票房boxOffice; }
            set { _movie.票房boxOffice = value; }
        }
        public string 劇情大綱plot
        {
            get { return _movie.劇情大綱plot; }
            set { _movie.劇情大綱plot = value; }
        }
        public string 分級級數ratingLevel
        {get; set;  }

        public string 影廳名稱cinemaName
        { get; set; }
        public int 電影院編號theaterId
        {
            get { return _theater.電影院編號theaterId; }
            set { _theater.電影院編號theaterId = value; }
        }
        public string 廳種名稱cinemaClsName
        {
            get { return _Cinema.廳種名稱cinemaClsName; }
            set { _Cinema.廳種名稱cinemaClsName = value; }
        }
        public string 座位資訊seatInfo
        {
            get { return _Cinema.座位資訊seatInfo; }
            set { _Cinema.座位資訊seatInfo = value; }
        }

        public string 電影院名稱theaterName
        {
            get { return _theater.電影院名稱theaterName; }
            set { _theater.電影院名稱theaterName = value; }
        }
        public string 地址address
        {
            get { return _theater.地址address; }
            set { _theater.地址address = value; }
        }

        public List<string> cinemas影廳種類 { get; set; }
    }
}
