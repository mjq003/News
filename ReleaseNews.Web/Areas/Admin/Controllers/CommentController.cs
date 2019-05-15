﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReleaseNews.Models.Response;
using ReleaseNews.Service;

namespace ReleaseNews.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private CommentService _commentService;
        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult Index()
        {
            return View(_commentService.GetCommentList(c => true));
        }
        [HttpPost]
        public JsonResult DelComment(int id)
        {
            if (id <= 0)
                return Json(new ResponseModel { code = 0, result = "参数有误" });
            return Json(_commentService.DeleteComment(id));
        }
    }
}