using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdvanceC_
{
    public class Student:UserInformation
    {
        [Required]
        public float Avg { get; set; }
        [Required]
        [MaxLength(70)]
        public string FieldOfStudy { get; set; }
        [MaxLength(14)]
        [Column("StudentCode",TypeName ="varchar")]
        public string StuCode { get; set; }
        [Required]
        [MaxLength(70)]
        public string Diploma { get; set;}


        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual Teacher Teacher { get; set; }

        public Student() { }
        public Student(string FirstName, string LastName, DateTime BirthDate, string PhoneNumber, string password, bool Gender, string NationalCode, string Email, string Address, DateTime RegisterDate, int UserRoleID, bool IsActive, float Avg,string FieldOfStudy,string StuCode, string Diploma) :base(FirstName,LastName,BirthDate,PhoneNumber, password, Gender, NationalCode, Email, Address, RegisterDate, UserRoleID, IsActive)
        {
            this.Avg = Avg;
            this.StuCode = StuCode;
            this.FieldOfStudy = FieldOfStudy;
            this.Diploma = Diploma;
        }

    }
}
