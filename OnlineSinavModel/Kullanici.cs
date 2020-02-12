using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineSinavModel
{
    public class Kullanici : Base
    {
        #region Property
        [StringLength(50, ErrorMessage = "İsim alana en fazla 50 karakter olabilir.")]
        public string Ad { get; set; }

        [StringLength(50, ErrorMessage = "Soyad alana en fazla 50 karakter olabilir.")]
        public string Soyad { get; set; }

        [StringLength(11, ErrorMessage = "T.C Kimlik alana en fazla 11 karakter olabilir.")]
        public string TcNo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DogumTarihi { get; set; }

        [Display(Name = "Email adresi")]
        [Required(ErrorMessage = "E-posta adresi gerekli")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi")]
        public string Email { get; set; }

        public bool IsEmailActive { get; set; }

        public string FotoUrl { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime KayitTarihi { get; set; }

        [Required(ErrorMessage = "Sifre girilmesi zorunlu")]
        [StringLength(15, ErrorMessage = "5 ile 15 karakter arasında olmalıdır", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        public Guid ActivationCode { get; set; }

        [StringLength(100, ErrorMessage = "Sifre Yenileme İslemi Sırasında Aktivasyon Kodunuz olusmadi.Lütfen daha sonra tekrar deneyiniz.")]
        public string ResetPasswordCode { get; set; }
        #endregion

        #region navigation property

        public KullaniciDetay KullaniciDetaylari { get; set; }
        public virtual ICollection<KullaniciRol> KullaniciRoller { get; set; }
        public virtual ICollection<KullaniciSinav> KullaniciSinav { get; set; }
        public virtual ICollection<KullaniciKurs> KullaniciKurs { get; set; }
        public virtual ICollection<KursDers> KursDers { get; set; }
        public virtual ICollection<Yorum> Yorumlar { get; set; }
        public virtual ICollection<Sikayet> Sikayetler { get; set; }

        public ICollection<Sinav> SinavOgretmen { get; set; }
        public ICollection<Sinav> SinavKaydedenKullanici { get; set; }

        public virtual ICollection<ExceptionMessage> ExceptionMessage { get; set; } 
        #endregion

    }
}
