using DamVanHieu_241230730_De2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DamVanHieu_241230730_De2.ViewComponents
{
    public class KiemTraGiaViewComponent:ViewComponent
    {
        private readonly QltaiSanContext _context;
        public KiemTraGiaViewComponent(QltaiSanContext context) => _context = context;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var taiSan = await _context.TaiSans.Where(ts => ts.NguyenGia >= 20).ToListAsync();
            return View(taiSan);
        }
    }
}
