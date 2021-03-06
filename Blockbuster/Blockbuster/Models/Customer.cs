﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blockbuster.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter customer name")]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubscribedNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypesId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}