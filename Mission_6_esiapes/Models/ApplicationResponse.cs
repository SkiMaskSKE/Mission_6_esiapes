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
        
        //Build a foreign Key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]//character limit
        public string Notes { get; set; }
    }
}
