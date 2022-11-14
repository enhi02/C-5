using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thi.Models
{
    public class Root
    {
        [Key]
        
        public int ArticleID { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string TextID { get; set; }
        [StringLength(200)]
        public string Head { get; set; }
        [StringLength(200)]
        public DateTime PublishTime { get; set; }
        public int HitCount { get; set; }
        public int CommentCount { get; set; }
        public string URL { get; set; }
        public int ChannelID { get; set; }
        public string HeadImageUrl { get; set; }
        public int ArticleType { get; set; }
        public string ThumbImageUrl { get; set; }
        public string Name { get; set; }
    }
}
