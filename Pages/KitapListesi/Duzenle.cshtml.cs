using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kitaplisteleme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kitaplisteleme.Pages.KitapListesi
{
    public class DuzenleModel : PageModel
    {
        private KLDbContext _db;

        public DuzenleModel(KLDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Kitap Kitap { get; set; }

        public async Task OnGet(int id)
        {
            Kitap = await _db.Kitap.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var DbGelenKitap = await _db.Kitap.FindAsync(Kitap.Id);
                
                DbGelenKitap.KitapAd = Kitap.KitapAd;
                DbGelenKitap.Yazar = Kitap.Yazar;
                DbGelenKitap.ISBN = Kitap.ISBN;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index"); 


            }

            return RedirectToPage();
        }
    }
}
