using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bai3.Models
{
    public class PersonCompanies
    {
        [Key]
        [ForeignKey("People")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromYear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ToYear { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Position { get; set; }
        public int Company_Id { get; set; }
        public int Person_Id { get; set; }
        [ForeignKey("pp_ID")]
        public People peoples { get; set; }
        [ForeignKey("cm_ID")]
        public Companies Companies { get; set; }
    }
}
