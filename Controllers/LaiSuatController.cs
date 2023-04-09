using LaiSuat.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaiSuat.Controllers
{
    public class LaiSuatController : Controller
    {
        
        public IActionResult LaiSuat()
        {

            ModelBankInterest ls = new ModelBankInterest();

            return View(ls);
        }

        [HttpPost]
        public IActionResult LaiSuat(uint soTien, double laiSuat, uint kyHan)
        {
            uint tien_lai = (uint)(soTien * laiSuat / 1200 * kyHan);
            uint tong_tien = (uint)(soTien + tien_lai);
           ModelBankInterest ls= new ModelBankInterest(soTien.ToString("N0"), laiSuat.ToString("N0"), kyHan.ToString("N0"), tien_lai.ToString("N0"), tong_tien.ToString("N0"));
            return View(ls);
        }
    }
}
