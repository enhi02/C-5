using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonAn.Models
{
    [Table("Roles")]
    public class RoleModel
    {
        [Key]
        //[ForeignKey("UserModel")]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        //public ICollection<UserModel> userModels { get; set; }

    }
}
