using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Blockbuster.Models;

namespace Blockbuster.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter customer name")]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubscribedNewsLetter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
        
        public byte MembershipTypesId { get; set; }
        
        //[Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}