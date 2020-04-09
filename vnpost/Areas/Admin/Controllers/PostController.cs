using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {
        private readonly IIsPost IThem;
        public PostController(IIsPost Them)
        {
            IThem = Them;
        }
        [Route("PostAdmin")]
        public IActionResult Index(IsPost The, int id)
        {
            if (id == 0)
            {
                if (The.PostId == 0 && The.Title != null && The.Content != null && The.AvataIndex != null)
                {
                    IThem.Add(The);
                }
                else if (The.PostId != 0 && The.Title != null && The.Content != null && The.AvataIndex != null)
                {
                    IThem.Edit(The);
                }
                else
                {

                }
            }
            else
            {
                The = IThem.GetOne(id);
            }
            ViewBag.AllBaiViet = IThem.GetAll();
            ViewBag.AllChuDe = IThem.GetAllChuDe();
            ViewBag.AllLoaiChuDe = IThem.GetAllLoaiChuDe();
            return View(The);
        }
        [Route("DeletePostAdmin")]
        public IActionResult DeleteThemeAdmin(int id)
        {
            IThem.Delete(id);
            return Redirect("PostAdmin");
        }
        [HttpPost]
        public IActionResult UpLoadCKEditor(IFormFile upload)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImagePost", fileName);
            upload.CopyToAsync(new FileStream(file, FileMode.Create));
            // return new JsonResult(new { path = "/wwwroot/Image/" + fileName });
            return new JsonResult(new
            {
                uploaded = 1,
                url = "ImagePost/" + fileName
            });
        }
        public JsonResult UpLoadCKEditorSingGer(IFormFile upload)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImagePost", fileName);
            upload.CopyToAsync(new FileStream(file, FileMode.Create));
            return Json("ImagePost/" + fileName);
        }
    }
}