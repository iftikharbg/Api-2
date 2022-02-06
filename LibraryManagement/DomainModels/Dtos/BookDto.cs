using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Dtos
{
   public class BookDto
    {
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required, MaxLength(10)]
        public string Genre { get; set; }
        [Required, MaxLength(20)]
        public string Writer { get; set; }


    }
}
