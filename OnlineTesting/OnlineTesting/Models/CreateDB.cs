using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    public class CreateDB :
        //CreateDatabaseIfNotExists<QLSV>
        //DropCreateDatabaseIfModelChanges<QLSV>
        DropCreateDatabaseAlways<Model_OT>
    {
        protected override void Seed(Model_OT context)
        {
            
        }
    }
}