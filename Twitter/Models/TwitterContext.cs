using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Twitter.Models
{
    public class TwitterContext : DbContext
    {
        public TwitterContext() : base("TwitterDb")
        { }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}