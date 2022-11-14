using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bai1.Models
{
    [Table("Client",Schema ="Dbo")]
    public class Client
    {
        [Key]
       
        public int Address_Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string PhoneNo { get; set; }
       public ICollection<Address> Address { get; set; }
    }
}
