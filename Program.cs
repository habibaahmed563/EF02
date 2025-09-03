using EF02.Contexts;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Revision
            // EF Core : ORM in .net 
            // ORM 

            // 1.Mapping
            //   Code First [Generate Table Per Class]
            //   DB First [Generate Class Per Table]
            // 2. L2E [C# Code (LINQ) --> EF Core --> SQL DB]

            // 3. Ways Generate 
            // 1. TPC : Table Per Class
            // 2. TPH : Table Per Hierarichy
            // 2. TPCC : Table Per Concret Class 
            #endregion

            // CRoud Operation 
            // Create - Read - Update - Delete 


            //AppDbContext Context = new AppDbContext();

            //Context.Dispose();

            //try
            //{
            //    //Code
            //}
            //finally
            //{
            //    Context.Dispose();
            //}

            //using (AppDbContext context = new AppDbContext())
            //{
            //    //CRUD

            //}

            using AppDbContext context = new AppDbContext();

        }
    }
}
