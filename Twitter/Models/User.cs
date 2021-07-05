using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Twitter.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}