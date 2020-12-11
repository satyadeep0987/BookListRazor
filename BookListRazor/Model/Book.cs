using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Auther { get; set; }

    }
}