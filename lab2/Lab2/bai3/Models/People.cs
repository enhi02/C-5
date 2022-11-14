using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bai3.Models
{
    public class People
    {
        [ Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int FirstName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int lastName { get; set; }
        public ICollection<PersonCompanies> PersonCompaniess { get; set; }
    }
}
