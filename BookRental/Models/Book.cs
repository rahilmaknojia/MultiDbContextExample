using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookRental.Models
{
    public class Book : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AutherId { get; set; }
        [ForeignKey("AutherId")]
        public virtual Author Author { get; set; }
    }
}
