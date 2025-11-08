using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Models
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }

        public string MajorName { get; set; }

        public float AVG { get; set; }

        // بنحط اسم الجدول الي حيتاخد منه البرايمري كيي عشان يصير فورين كيي
        [ForeignKey("student")]
        public int StudentID { get; set; }
        public virtual Student student { get; set; }
    }
}
