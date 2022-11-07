﻿using ClientMDA.Models;
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
    public class CommentController : Controller
    {
        private readonly MDAContext _MDAcontext;

        public CommentController(MDAContext MDAcontext)  //相依性注入
        {
            _MDAcontext = MDAcontext;
        }

        public IActionResult 評論首頁() //最新/熱門/關注評論
        {
            return View();
        }

        public IActionResult 電影評論(int? id) //電影單則評論
        {
            CCommentViewModel datas = null;
            datas = _MDAcontext.電影評論movieComments.Where(c => c.評論編號commentId == id).Select
            (c => new CCommentViewModel
            {
                comment = c,
                公開等級public = c.公開等級編號public.公開等級public,
                中文標題titleCht = c.電影編號movie.中文標題titleCht,
                暱稱nickName = c.會員編號member.暱稱nickName,
                會員照片image = c.會員編號member.會員照片image,
            }).FirstOrDefault();
            return View(datas);
        }

        public IActionResult 會員評論(int id) //會員個別評論頁面
        {
            CMemberCommentViewModel datas = null;
            //var c = _MDAcontext.電影評論movieComments.Select(c => c);
            datas = _MDAcontext.會員members.Where(m => m.會員編號memberId == id).Select
            (m => new CMemberCommentViewModel
            {
                member = m,
                會員編號memberId = m.會員編號memberId,
                暱稱nickName = m.暱稱nickName,
                會員照片image = m.會員照片image,
                建立時間createdTime = m.建立時間createdTime,
                commentCount = m.電影評論movieComments.Where(c => c.會員編號memberId == id).Count(),
                memberfollow = m.我的追蹤清單myFollowLists.Where(f => f.對象targetId == 1 || f.追讚倒編號actionTypeId == 0 || f.連接編號connectId == id)
                .Count(),
            }).FirstOrDefault();
            return View(datas);
        }
        #region follow report
        public IActionResult checkLogin(string page, int? id)
        {
            HttpContext.Session.SetString(CDictionary.SK登後要前往的頁面, $"~/Comment/{page}/{id}");
            return Redirect("~/Member/Login");
        }
        [HttpPost]
        public IActionResult Report檢舉(CReportViewModel vm)
        {
            string user = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
            會員member mem = JsonSerializer.Deserialize<會員member>(user);
            //if (string.IsNullOrEmpty(user))
            //{
            //    HttpContext.Session.SetString(CDictionary.SK登後要前往的頁面, $"~/Comment/電影評論/{vm.連接編號connectId}");
            //    return Redirect("~/Member/Login");
            //}

            我的追蹤清單myFollowList follow = new 我的追蹤清單myFollowList()
            {
                會員編號memberId = mem.會員編號memberId,
                對象targetId = vm.對象targetId,
                追讚倒編號actionTypeId = vm.追讚倒編號actionTypeId,
                連接編號connectId = vm.連接編號connectId,
                檢舉理由reportReason = vm.檢舉理由reportReason,
                處理狀態status = 0,
            };
            _MDAcontext.我的追蹤清單myFollowLists.Add(follow);
            _MDAcontext.SaveChanges();
            string page = "";
            int id = vm.連接編號connectId;
            if (vm.對象targetId == 1)
                page = "會員評論";
            else if (vm.對象targetId == 2)
                page = "電影評論";
            else
            {
                page = "電影評論";
                //id=
            }
            return RedirectToAction(page, new { id = id });
        }
        public IActionResult follow(int connectid, int target) //點按追蹤
        {
            string user = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);

            //if (string.IsNullOrEmpty(user))
            //{
            //    HttpContext.Session.SetString(CDictionary.SK登後要前往的頁面, $"~/Comment/會員評論/{connectid}");
            //    return Redirect("~/Member/Login");
            //}
            string res = "";
            會員member mem = JsonSerializer.Deserialize<會員member>(user);
            var check = _MDAcontext.我的追蹤清單myFollowLists.ToList().Find(l => l.會員編號memberId == mem.會員編號memberId && l.追讚倒編號actionTypeId == 0 && l.對象targetId == target && l.連接編號connectId == connectid);
            if (check == null)
            {
                我的追蹤清單myFollowList follow = new 我的追蹤清單myFollowList()
                {
                    會員編號memberId = mem.會員編號memberId,
                    對象targetId = target, //1會員/2評論
                    追讚倒編號actionTypeId = 0, //追蹤
                    連接編號connectId = connectid,
                };
                _MDAcontext.我的追蹤清單myFollowLists.Add(follow);
                res = "add";
            }
            else
            {
                _MDAcontext.我的追蹤清單myFollowLists.Remove(check);
                res = "rem";
            }
            _MDAcontext.SaveChanges();
            return Content(res, "text/plain");
        }

        public IActionResult checkFollow(int? memid, int followid, int target)
        {
            string res = "";
            if (memid != null)
            {
                var q = _MDAcontext.我的追蹤清單myFollowLists.Where(l => l.會員編號memberId == memid && l.追讚倒編號actionTypeId == 0 && l.對象targetId == target && l.連接編號connectId == followid).ToList();
                if (q.Count > 0)
                    res = "y";
                else
                    res = "n";
            }
            return Content(res, "text/plain");
        }
        #endregion
    }
}