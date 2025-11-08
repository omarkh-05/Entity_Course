using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.CRUD_OP
{
    internal class Delete
    {
        //      Method 1
        //using var db = new AppDBContext();

        //var departments = db.Departments.Find(1);

        //if (departments != null)
        //{
        //    db.Departments.Remove(departments);
        //    db.SaveChanges();
        //}


        //      Method 2
        //var departments = db.Departments.FirstOrDefault(s => s.DepartmentID == 1);
        //if (departments != null)
        //{
        //    db.Departments.Remove(departments);
        //    db.SaveChanges();
        //}
    }
}
