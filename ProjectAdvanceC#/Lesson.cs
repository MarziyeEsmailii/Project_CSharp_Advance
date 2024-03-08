using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdvanceC_
{
    [Table("T_Lesson")]
    public class Lesson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public static int Code { get; set; }
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }
        [Required]
        public int LessonCode { get; set; }
        [Required]
        public int Unit { get; set; }
        [Column("Course type",TypeName ="nvarchar")]
        public string Status { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; }
        public int SemesterNumber { get; set; }


        public virtual ICollection<Teacher> teachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Lesson() { }
        public Lesson(string Name, int LessonCode,int Unit,string Status , DateTime RegisterDate,bool IsActive,int SemesterNumber)
        {
            Code++;
            ID = Code;
            this.Name = Name;
            this.LessonCode = LessonCode;
            this.Unit = Unit;
            this.Status=Status;
            this.RegisterDate = RegisterDate;
            this.IsActive = IsActive;
            this.SemesterNumber = SemesterNumber;
        }

    }
}
