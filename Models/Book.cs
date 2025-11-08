using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<StudentBook> Students { get; set; }

        public int DilevaryOrder { get; set; }
    }
}
