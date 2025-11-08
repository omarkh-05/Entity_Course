using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Transaction
{
    internal class Transaction
    {
        //              Transaction 1 هاي اذا فشل جزء من العملية يلغي العملية كلها rollback all
        //var transaction = db.Database.BeginTransaction();

        //try
        //{
        //    db.Departments.Add(new Department { Name="Marketing"});
        //    db.Departments.Add(new Department { Name="HR"});

        //    transaction.Commit();
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    transaction.Rollback();
        //}



        //              Transaction 2 هاي اذا فشل جزء ما يلغي كل العملية برجع لنقطة انا محددها وبنفذها
        //var transaction = db.Database.BeginTransaction();

        //try
        //{
        //    db.Departments.Add(new Department { Name = "Marketing" });
        //    db.Departments.Add(new Department { Name = "HR" });

        //    transaction.CreateSavepoint("Data_OK");

        //    db.Departments.Add(new Department { Name = "Nigga" });
        //    db.Departments.Add(new Department { Name = "Blue" });


        //    transaction.Commit();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    // عشان ما يعطيني اكسيبشن ويسوي كراش
        //    try
        //    {
        //        transaction.RollbackToSavepoint("Data_OK");
        //        transaction.Commit();
        //    }
        //    catch (Exception ex2)
        //    {
        //        Console.WriteLine(ex2.Message);
        //        transaction.Rollback();
        //    }
        //}
    }
}
