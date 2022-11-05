using ClientMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClientMDA.ViewModels
{
    public class CQANDAViewModel
    {
        public List<問題總類questionType> 問題總類questionType { get; set; }
        public List<問題總表question> 問題總表Question{get;set;}
        public List<一般資訊generaInformation> 一般資訊GeneraInformation { get; set; }
        public List<問題總表question> 會員問題Q { get; set; }
        public List<問題總表question> 評分問題Q { get; set; }

    }
}
