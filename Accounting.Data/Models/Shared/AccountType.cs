using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Accounting.Data.Models.Logger;

namespace Accounting.Data.Models.Shared
{
    public class AccountType : EntryLog
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Type Code")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Type Name")]
        public string Name { get; set; }
    }
}
