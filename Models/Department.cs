using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Models
{
    public class Department
    {

        // if we want to update on this table we need to put our updates then do add-migration <name> then update database

        [Key] // this attributes called data annotaion
        public int DepartmentID { get; set; }

        //[Required] this will make the field required even if theres a nullable sign
        [Required(ErrorMessage ="Name Cannot be empty"),MaxLength(20,ErrorMessage =("Name Cannot Be more than 20 char"))]
        public string Name { get; set; }

        // عملنا الerror message عشان لما يطلع ايرور ما يوقفلي البرنامج ويعمل كراش
        // لما تضيف الانوتيشن عادي بنقدر نسويها بدون ميجريشين في هاي الحالة بعدل على الفرونت ايند بس ما بغير الشكل في الداتا بيز الا اذا عملنا ميجريشن وابديت 

        public virtual Student student { get; set; }
    }
}
