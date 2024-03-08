using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdvanceC_
{
    [Table("T_Roles")]
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public int ParentID { get; set; }
        public virtual ICollection<Role> ParentRoles { get;}

        public Role() { }
        public Role(string Name,string Title,int ParentID)
        {
            this.Name = Name;
            this.Title = Title;
            this.ParentID = ParentID;
        }
    }
}
