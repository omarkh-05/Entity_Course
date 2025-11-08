using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entity_Course;
using Entity_Course.Models;

namespace Entity_Course.AppDBContext1
{
    //      to get migration script (give us script to use it to make sql script) to script all migration write script-migration  to script specific migration write script-migration (before the specific one name) (the specific one name)
    // ex : script migration init_db Indexing_Student to get the Indexing_Student script
    public class AppDBContext : DbContext
    {

        // megration : امر بتعطيه للانتتي فريم وورك عشان يسوي جينيريت لفايل بكزن مسؤول عن كتابة السكريبت في الداتابيز عشان يصنع الجداول في الداتا بيز

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(Connection.ConnectionString);
        }

        // my models will moved to DB and created
        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<StudentBook> StagesBook { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        // The properties is The DataBase table name

        // after adding these dbsets we will create the migration file 

        // add-migration <migName(not database name)> (in this stage we still not adding the models to db)

        // to add models to db we should type ( update-database )

        // to remove mig we type ( remove-migration )


        // RollBack


        // We Should Get the name of migrationid and then we write ( update-migration <Mig ID> ) now all mig after that mig will retrive

        // Now It Depend on us if we want to delete the mig we remove-migration we remove it and if we want to update the models then added it back we type 


        //      this is called Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // من خلاله بنتحكم بشغلات بدل ما نعدلها في الميقريشن فايل

            // this code make all models Referential Actions On Delete = Restrict
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // if you need to make one model Referential Actions On Delete = Another thing you need to write 

            //modelBuilder.Entity<Student>().HasOne(e => e.grade).WithOne(s => s.student).OnDelete(DeleteBehavior.SetNull);


            // في حال بدي اعدل على موديل بدون ما تنضاف التعديلات على الداتا بيز بعد الميقريشن طبعا والابديت

            //modelBuilder.Entity<Attendance>().ToTable(" name in database ",a=>a.ExcludeFromMigrations());


            // Invoice هاض الكود عشان الفيلدز الي بنعمللهمش مايقريشن الي بكون فيهم جمع لاثنين فيلدز زي مودل ال
            modelBuilder.Entity<Invoice>().Property(n => n.qty).HasDefaultValue(1);
            modelBuilder.Entity<Invoice>().Property(n => n.CreatedDate).HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Invoice>().Property(n => n.CustomerDescription )
                .HasComputedColumnSql("[CustomerName] + ' ' + [CustomerTitle]");
            modelBuilder.Entity<Invoice>().Property(n => n.total)
               .HasComputedColumnSql("[price] * [qty]");


            // Sequence : هاي بتنحط كولوم في اكثر من تيبل وبكون عبارة عن اوتو انكريمينت فبصير كل ما ينضاف روو للتيبل الموجود في هاض الكولوم بروح بنزاد واحد وبكمل بالتيبل الثاني زي تيبل الكتب وتيبل اليونيفورم 
            modelBuilder.HasSequence<int>("DilevaryOrder").StartsAt(100).IncrementsBy(1);
            modelBuilder.Entity<Book>().Property(p => p.DilevaryOrder).HasDefaultValueSql("next value for DilevaryOrder");
            modelBuilder.Entity<Uniform>().Property(p => p.DilevaryOrder).HasDefaultValueSql("next value for DilevaryOrder");
        }
    }
}
