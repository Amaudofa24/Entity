using Entity.Models;

namespace Entity
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EmployeesContext())
            {
                var Emp = new Employees () { firstName = "Bill" };
                ctx.Employees.Add(Emp);
                ctx.SaveChanges();
            }
            

            
        }
    }
}