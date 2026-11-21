using DamVanHieu_241230730_De2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DamVanHieu_241230730_De2.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly QltaiSanContext _context;
        public MenuViewComponent(QltaiSanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loaiTaiSan = _context.LoaiTaiSans.OrderBy(t => t.MaLoai).ToList();
            return View(loaiTaiSan);
        }
    }
}
