using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Models
{
    public class Account : EntryLog
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Account Code")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Account Name")]
        public string Name { get; set; }

        [Required]
        public Boolean Active { get; set; }

        [Required]
        public Boolean Checking { get; set; }

        [MaxLength(100)]
        public string BankName { get; set; }

        [MaxLength(200)]
        public string BankAddress { get; set; }

        [MaxLength(100)]
        public string BankAccountNumber { get; set; }

        [MaxLength(100)]
        public string BankAccountHolder { get; set; }

        [Required]
        [Display(Name = "Account Category")]
        public int CategoryId { get; set; }
        public AccountCategory Category { get; set; }

        [Display(Name = "Parent Account")]
        public int? ParentId { get; set; }
        public Account Parent { get; set; }
    }
}
