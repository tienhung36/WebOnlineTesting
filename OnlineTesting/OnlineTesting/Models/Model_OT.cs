using System;
using System.Data.Entity;
using System.Linq;

namespace OnlineTesting.Models
{
    public class Model_OT : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OnlineTesting.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model_OT()
            : base("name=ChuoiKN")
        {
            Database.SetInitializer<Model_OT>(new CreateDB());
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Test_History> Test_Histories { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Answer_In_Test> Answer_In_Tests { get; set; }
        public virtual DbSet<Question_In_Test> Question_In_Tests { get; set; }
        public virtual DbSet<Answer_In_Test_History> Answer_In_Test_Histories { get; set; }
        public virtual DbSet<Question_In_Test_History> Question_In_Test_Histories { get; set; }
        public virtual DbSet<admin> Admins { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}