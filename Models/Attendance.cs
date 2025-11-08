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
    // الكود الي تحت بخليني اغير اسم المودل في الداتا بيز على اساسه حتى لو في ال كونتيكست غير وبعدها بعمل ميقريشن
    [Table("StudentsAttendance" , Schema ="stdAtts")]
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }

        // هاي عشان اغير اسم الكولوم بعد المايقريشن
        [Column("TheName" , TypeName = "varchar(20)"),Comment("شرح عن التيبل")]
        public string AttendanceDay { get; set; }

        // ما بضيفها على الداتابيز
        [NotMapped]
        public DateTime AttendanceDate { get; set; }

        // في حال ما ربط الاتندانس في الطلاب وسويت ميقريشن ما حيضيف اشي الا اذا ضفته في الطلاب او في الكونتيكست فايل

        [ForeignKey("student")]
        public int StudentID { get; set; }

        public virtual Student student { get; set; }

    }
}
