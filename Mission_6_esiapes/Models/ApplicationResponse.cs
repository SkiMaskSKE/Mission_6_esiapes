using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_esiapes.Models
{
    public class ApplicationResponse
    {//Creating variables as well as establishing primary key
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Category { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]//character limit
        public string Notes { get; set; }
    }
}
