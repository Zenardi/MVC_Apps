using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blockbuster.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubscribedNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypesId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}