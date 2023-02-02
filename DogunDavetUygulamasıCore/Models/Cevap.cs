using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogunDavetUygulamasıCore.Models
{
    public class Cevap
    {
        //burda bazı validasyon kontrolerini sağlayacaz 
        [Required(ErrorMessage ="Lütfen ad alanını boş bırakmayınız")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Lütfen Soyad alanını boş bırakmayınız")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Lütfen E Mail alanını boş bırakmayınız")]
        [EmailAddress]// burda uygun formata E mail adresi girilmiş mi bunu kontrol eder
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon alanını boş bırakmayınız")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Lütfen bir seçim yapınız")]
        public bool DuguneGelecekmi { get; set; }
    }
}
