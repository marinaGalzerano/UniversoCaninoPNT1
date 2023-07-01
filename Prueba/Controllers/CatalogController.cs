using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba.Context;
using Prueba.Models;

namespace Prueba.Controllers
{
    public class CatalogController : Controller
    {
        private readonly UCaninoContext _context;

        public CatalogController(UCaninoContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Productos.ToListAsync());
        }

        public async Task<IActionResult> Product(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodcuto = await _context.Productos.FirstOrDefaultAsync(m => m.Id == id);
            if (prodcuto == null)
            {
                return NotFound();
            }

            return View(prodcuto);
        }

    }

}
