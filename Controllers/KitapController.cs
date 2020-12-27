using Kitaplisteleme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Kitaplisteleme.Controllers
{
    
    public class KitapController : Controller
    {
        private readonly KLDbContext _db;

        public KitapController(KLDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new {data = await _db.Kitap.ToListAsync() });
        }
    }
}
