﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Accounting.Data.Models.Logger;

namespace Accounting.Data.Models.Shared
{
    public class AccountCategory : EntryLog
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Category Code")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public int TypeId { get; set; }
        public AccountType Type { get; set; }
    }
}
