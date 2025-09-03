using EF02.Contexts;
using EF02.Entities;

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

            #region CROUD Operation
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

            #region Create - Insert
            // Create - Insert 

            var employee = new Employee()
            {
                Name = "Ahmed Ali",
                Salary = 12000,
                Address = "Cairo",
                Age = 25
            };

            //Console.WriteLine(context.Entry(employee).State); // Deatched
            //context.Add(employee);
            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State); // Added 

            //var result = context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State); // Unchanged

            //employee.Name = "Khaled";

            //Console.WriteLine(context.Entry(employee).State); // Modified

            //Console.WriteLine(result);

            //context.Employees.Add(employee);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State); 
            #endregion

            #region Read - Select 
            // Read - Select 

            //var result = context.Employees.Where(E => E.Id == 40).FirstOrDefault();
            //var result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //var result = context.Employees.ToList();

            //Console.WriteLine(context.Entry(result).State); // Unchanged

            //result.Name = "Ali";

            //Console.WriteLine(context.Entry(result).State); // Modified

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.WriteLine(result.Name);
            //Console.WriteLine(result.Id); 
            #endregion

            #region Update 

            // Update 

            //var result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(context.Entry(result).State);

            //result.Name = "Omar Ali";
            //Console.WriteLine(context.Entry(result).State);

            //context.Update(result);

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); 
            #endregion

            #region Delete

            //Delete 
            //var result = context.Employees.FirstOrDefault(E => E.Id == 30);

            //Console.WriteLine(context.Entry(result).State); //Unchanged

            //context.Employees.Remove(result);
            //Console.WriteLine(context.Entry(result).State); //Delete

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); //Detached 
            #endregion 
            #endregion

            //Employee employee = new Employee();


        }
    }
}
