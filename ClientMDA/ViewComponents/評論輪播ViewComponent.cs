using ClientMDA.Models;
using ClientMDA.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClientMDA.ViewConponents
{
    public class 評論輪播ViewComponent : ViewComponent //須繼承ViewComponent
    {
        private readonly MDAContext _MDAcontext;

        public 評論輪播ViewComponent(MDAContext MDAcontext)  //相依性注入
        {
            _MDAcontext = MDAcontext;
            _MDAcontext.評論圖片明細commentImagesLists.ToList();
            _MDAcontext.評論圖片總表commentImages.ToList();
        }
        //用這個 async Task<IViewComponentResult> InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync(List<CCommentViewModel> datas)
        {
            var mPoster = _MDAcontext.評論圖片明細commentImagesLists.Select(i => i);
            datas = _MDAcontext.電影評論movieComments.OrderBy(c => c.評論編號commentId).Select
                    (c => new CCommentViewModel
                    {
                        comment = c,
                        評論內容comments = StripHTML(c.評論內容comments),
                        暱稱nickName = c.會員編號member.暱稱nickName,
                        cImgFrList = _MDAcontext.評論圖片明細commentImagesLists.Where(i => i.評論編號commentId == c.評論編號commentId)
                        .Select(c => c.評論圖庫編號commentImage.圖片image).ToList()
                    }).Take(6).ToList();
            return View(datas);
        }


        public static string StripHTML(string input)
        {
            if (input == null)
                return "";
            return Regex.Replace(input, "<[a-zA-Z/].*?>", String.Empty);
        }
    }
}
