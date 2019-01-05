using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Gift
    {
        public int GiftNumber { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool BoyGift { get; set; }
        public bool GirlGift { get; set; }
    }
}
