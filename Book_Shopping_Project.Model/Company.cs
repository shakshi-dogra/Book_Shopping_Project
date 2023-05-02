﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shopping_Project.Model
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display (Name ="Postal Code")]
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name ="Is Authorized Company")]
        public bool IsAuthorizedCompany { get; set; }
    }
}
