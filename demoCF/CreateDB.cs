using System.Data.Entity;

namespace demoCF
{
    public class CreateDB :
        CreateDatabaseIfNotExists<QLSV>
    {
       protected override void Seed(QLSV context)
        {
            context.LSHes.AddRange(new LSH[]
            {
                new LSH { ID_Lop = 1 , NameLop = "18T"},
                new LSH { ID_Lop = 2 , NameLop = "19T"},
                new LSH { ID_Lop = 3 , NameLop = "20T"},
            });

            context.SVs.AddRange(new SV[]
            {
                new SV{ MSSV = "100000001", NameSV = "SonTung", ID_Lop= 1 , DTB = 9.2 },
                new SV{ MSSV = "100000002", NameSV = "Jack100cu", ID_Lop= 2 , DTB = 9.3 },
                new SV{ MSSV = "100000003", NameSV = "Jack5trieu", ID_Lop= 1 , DTB = 9.4 },
                new SV{ MSSV = "100000004", NameSV = "SiTa", ID_Lop= 3 , DTB = 9.5 },
                new SV{ MSSV = "100000005", NameSV = "ROco", ID_Lop= 3 , DTB = 9.6 },
            });
        }
    }
}
