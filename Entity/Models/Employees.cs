using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<EmployeesDetails> EmployeesDetails { get; set; }
    }

   
    public class EmployeesDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ReferenceID { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int EmployeeID { get; set; }

        [ForeignKey("EmployeesID")]
        public Employees Employees { get; set; }
    }
}
