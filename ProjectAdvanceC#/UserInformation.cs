using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdvanceC_
{
    public abstract class UserInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(25)]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(35)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(8)]
        public string password { get; set; }
        public bool Gender { get; set; }
        [Required]
        [MaxLength(11)]
        public string NationalCode { get; set; }
        public string CityOfBirth { get; set; }
        [Required]
        [Column("Email(Gmail)",TypeName ="varchar")]
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; }
        [Required]
        public int UserRoleID { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public UserInformation() { }
        public UserInformation(string FirstName, string LastName, DateTime BirthDate,string PhoneNumber,string password, bool Gender,string NationalCode,string Email,string Address,DateTime RegisterDate ,int UserRoleID, bool IsActive)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.password = password;
            this.Gender = Gender;
            this.NationalCode = NationalCode;
            this.CityOfBirth = CityOfBirth;
            this.Email = Email;
            this.Address = Address;
            this.RegisterDate = RegisterDate;
            this.UserRoleID = UserRoleID;
            this.IsActive = IsActive;
        }
    }
}
