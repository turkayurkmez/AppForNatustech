using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfMVC.Models
{
    public class YanitModel
    {
        [Required(ErrorMessage ="Ad alanı, boş olamaz")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Eposta boş olamaz")]
        [EmailAddress(ErrorMessage = "Eposta formatı hatalı")]
        public string Eposta { get; set; }
        [Required(ErrorMessage = "Telefonunuzu girin")]
        public string Telefon { get; set; }

        public bool KatilimDurumu { get; set; }

    }
}
