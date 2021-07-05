using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Twitter.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PhotoLink { get; set; }
        public string Tags { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}