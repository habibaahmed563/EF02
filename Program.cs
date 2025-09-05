using EF02.Context;
using EF02.Entity;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            //Create - Insert 

            var student = new Student()
            {
                Id = 1,
                FName = "habiba",
                LName = "Ahmed",
                Address = "Cairo",
                Age = 20
            };
            context.Students.Add(student);
            var result = context.SaveChanges();
            Console.WriteLine(result);

            //Update 

            var student02 = context.Students.FirstOrDefault(s => s.Id == 1);
            student02.Address = "Alex";
            var res = context.SaveChanges();
            Console.WriteLine(res);

            var student03 = context.Students.FirstOrDefault(s => s.Id == 1);
            context.Students.Remove(student03);
            context.SaveChanges();
        }
    }
}
