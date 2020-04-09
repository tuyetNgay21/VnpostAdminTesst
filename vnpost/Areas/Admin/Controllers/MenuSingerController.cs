using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vnpost.Models.Services;

namespace vnpost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuSingerController : Controller
    {
        private readonly IIsMenuSinger1 IThem;
        public MenuSingerController(IIsMenuSinger1 Them)
        {
            IThem = Them;
        }
        private static int maMenuDauTien;
        [Route("SettingMenu")]
        public IActionResult Index()
        {
            ViewBag.HienThiRaTatCaMenu = IThem.GetAll();
            var h= IThem.GetAllThemeHaveId(maMenuDauTien);
            ViewBag.DanhSachDangChon = IThem.GetAllSingerMenu(h.ToList());
            ViewBag.AllTheme = IThem.GetAllTheme();
            return View();
        }
        [Route("MenuDauTien")]
        public IActionResult KhoiTaoCaroSeo(int id)
        {
            maMenuDauTien = IThem.AddNavBegin(id);
            return Redirect("SettingMenu");
        }
        // chon ca
        [Route("MenuChon")]
        public IActionResult chonCaroSeo(int id)
        {
            maMenuDauTien = id;
            return Redirect("SettingMenu");
        }
        //them mới vao thành pphaanf đang chọn 
        [Route("ThemThanhPhanMenu")]
        public IActionResult ThemThanhPhanCaroSeo(int id)
        {
            IThem.Add(id, maMenuDauTien);
            return Redirect("SettingMenu");
        }
        [Route("DeleteSettingMenuAdmin")]
        public IActionResult DeleteThemeAdmin(int id)
        {
            IThem.Delete(id);
            return Redirect("SettingMenu");
        }
        [HttpPost]
        public JsonResult UpLoadCKEditor(IFormFile upload)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImagePost", fileName);
            upload.CopyToAsync(new FileStream(file, FileMode.Create));
            return Json("ImagePost/" + fileName);
        }
    }
}