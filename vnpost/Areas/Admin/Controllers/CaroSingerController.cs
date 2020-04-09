using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CaroSingerController : Controller
    {
        private readonly IIsNavbar IThem;
        public CaroSingerController(IIsNavbar Them)
        {
            IThem = Them;
        }
        private static int maCaroDauTien;
        [Route("ThanhTruot")]
        public IActionResult Index()
        {

            ViewBag.DanhSachNav = IThem.GetAllSingger();
            var h = IThem.GetNavBo(maCaroDauTien);
            ViewBag.maCaroDauTien = IThem.GetAllSinggerChiTiet(h.ToList());
            ViewBag.chuoiMA = IThem.ChuoiMaTHanhTruot();
            ViewBag.LayBoDangDung = h;
            return View();
        }
        // khoi tao 1 caroseo
        [Route("CaroDauTien")]
        public IActionResult KhoiTaoCaroSeo(int id)
        {
            maCaroDauTien = IThem.AddNavBegin(id);
            return Redirect("ThanhTruot");
        }
        // chon ca
        [Route("CaroChon")]
        public IActionResult chonCaroSeo(int id)
        {
            maCaroDauTien = id;
            return Redirect("ThanhTruot");
        }
        [Route("ThemThanhPhan")]
        public IActionResult ThemThanhPhanCaroSeo(int id)
        {
            IThem.Add(id, maCaroDauTien);
            return Redirect("ThanhTruot");
        }
        [Route("ChinhViTri")]
        public IActionResult ChinhViTriCaroSeo(List<IsNavbar> ik)
        {
            return Redirect("ThanhTruot");
        }
    }
}