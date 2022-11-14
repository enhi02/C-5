using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bai1.Models
{
    [Table("Address", Schema = "Dbo")]
    public class Address
    {
        [Key]
        [ForeignKey("Client")]
        public  int Address_Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Home_addr { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string office_addr { get; set; }
        public Client Client { get; set; }
    }
}
