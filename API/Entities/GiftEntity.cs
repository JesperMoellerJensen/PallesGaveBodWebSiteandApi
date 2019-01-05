using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class GiftEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GiftNumber { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool BoyGift { get; set; }
        public bool GirlGift { get; set; }
    }
}
