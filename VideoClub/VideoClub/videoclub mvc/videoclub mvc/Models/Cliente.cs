using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace videoclub_mvc.Models
{
    public class Cliente
    {
        public int Id { get; set; } 
        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }
        public bool EstaSuscritoAlBoletinInformativo { get; set; }
        public virtual MembershipType MembershipType { get; set; }

        [Display(Name = "Tipo de Membresia")]
        public byte MembershipId { get; set; }
        [Display(Name = "Cumpleaños")]
        public DateTime? Cumpleaños { get; set; }
    }
}
