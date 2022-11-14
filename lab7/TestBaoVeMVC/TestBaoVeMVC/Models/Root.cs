using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBaoVeMVC.Models
{
    public class Root
    {
        [Key]
        public int RootID { get; set; }
        public int ArticleID { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string TextID { get; set; }
        [StringLength(500)]
        public string Head { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PublishTime { get; set; }
        public int HitCount { get; set; }
        public int CommentCount { get; set; }
        [StringLength(300)]
        public string URL { get; set; }
        public int ChannelID { get; set; }
        [StringLength(500)]
        public string HeadImageUrl { get; set; }
        public int ArticleType { get; set; }
        [StringLength(200)]
        public string ThumbImageUrl { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
    }
}
