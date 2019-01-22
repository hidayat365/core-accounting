using Accounting.Data.Models.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Data.Models.Shared
{
    public class Currency : EntryLog
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Currency Code")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Currency Name")]
        public string Name { get; set; }
    }
}
