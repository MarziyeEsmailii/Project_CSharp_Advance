using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdvanceC_
{
    [Table("T_Teacher")]
    public class Teacher:UserInformation
    {
        [Required]
        [MaxLength(70)]
        public string Degree { get; set; }
        public string UniversityGraduated { get; set; }
        [Required]
        public DateTime GraduatedDate { get; set; }
        [Column("Study",TypeName ="nvarchar")]
        [MaxLength(70)]
        [Required]
        public string FieldOfStudy { get; set; }
        [Required]
        public int Rights { get; set; }
        public int teachingExperience { get; set; }


        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Teacher() { }
        public Teacher(string FirstName, string LastName, DateTime BirthDate, string PhoneNumber, string password, bool Gender, string NationalCode, string Email, string Address, DateTime RegisterDate, int UserRoleID, bool IsActive,string Degree,string UniversityGraduated,DateTime GraduatedDate,string FieldOfStudy,int Rights,int teachingExperience) :base(FirstName, LastName, BirthDate, PhoneNumber, password, Gender, NationalCode, Email, Address, RegisterDate, UserRoleID, IsActive)
        {
            this.Degree = Degree;
            this.GraduatedDate = GraduatedDate;
            this.FieldOfStudy = FieldOfStudy;
            this.Rights = Rights;
            this.teachingExperience = teachingExperience;
        }
    }
}
