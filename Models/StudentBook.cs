using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Models
{
    public class StudentBook
    {
        [Key]
        public int StudentBookID { get; set; }

        [ForeignKey("book")]
        public int BookID { get; set; }
        public virtual Book book { get; set; }

        [ForeignKey("student")]
        public int StudentID { get; set; }
        public virtual Student student { get; set; } 

        public DateTime ReseveDate { get; set; }
    }
}
