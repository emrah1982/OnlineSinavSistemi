using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineSinavModel
{
   public class Message:Base
    {
        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Gonderen { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Konu { get; set; }

        [Required]
        public string Aciklama { get; set; }

        public byte GonderiTipi { get; set; }//Email ,SMS, MMC vb

        

    }
}
