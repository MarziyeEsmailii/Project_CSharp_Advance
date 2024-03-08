using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectAdvanceC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\tWait for create DataBase:");
            UniversityDBContext universityDB = new UniversityDBContext("DB_UNI");
            universityDB.Database.CreateIfNotExists();
            Console.WriteLine("\n\tFinish");
            Console.ReadKey();
        }
    }
}
