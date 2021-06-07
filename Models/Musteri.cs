using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace emlak.Models
{
    public class Musteri
    {
        [Required(ErrorMessage ="Lütfen ad alanını boş bırakmayınız!") ]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyad alanını boş bırakmayınız!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen adres alanını boş bırakmayınız!")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lütfen email alanını boş bırakmayınız!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefon alanını boş bırakmayınız!")]
        public int Telefon { get; set; }
        

    }
}
