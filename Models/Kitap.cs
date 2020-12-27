using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kitaplisteleme.Models
{
    public class Kitap
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Kitap adı boş geçilemez")] 
        public string KitapAd { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
    }
}
