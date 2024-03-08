using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectAdvanceC_
{
    [Table("T_Emp")]
    public class Employee:UserInformation
    {
        public int Rights { get; set; }
        [Required]
        public string NameOfTheDepartment { get; set; }
        public int WorkingExperience { get; set; }
        public string Degree { get; set; }
        public Employee() { }
        public Employee(string FirstName, string LastName, DateTime BirthDate, string PhoneNumber, string password, bool Gender, string NationalCode, string Email, string Address, DateTime RegisterDate, int UserRoleID, bool IsActive, int Rights,string NameOfTheDepartment,int WorkingExperience,string Degree) : base(FirstName, LastName, BirthDate, PhoneNumber, password, Gender, NationalCode, Email, Address, RegisterDate, UserRoleID, IsActive)
        {
            this.Rights = Rights;
            this.NameOfTheDepartment = NameOfTheDepartment;
            this.WorkingExperience = WorkingExperience;
            this.Degree = Degree;
        }
    }
}
