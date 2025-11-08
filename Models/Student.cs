using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Models
{
    // indexing a column can make the search faster in table 
    [Index("Name","BirthDate")] // composite index can be on more than one column(field) بس ما بنحتاج نخلي الاسم انديكس
    [Index("MobileNumber",IsUnique = true)] // this make search fastest because we make it Unique
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual Grade grade { get; set; }

        [ForeignKey("department")]
        public int DepartmentID { get; set; }
        public virtual Department department { get; set; }

        public virtual ICollection<StudentBook> Books { get; set; }

        //[NotMapped] في حال بدي اربط الاثنين بس ما اخليه يضيفها على الداتا بيز بستخدم 
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
