using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Twitter.Models
{
    public class EditPostModel
    {
        public string Description { get; set; }
        public string PhotoLink { get; set; }
        public string Tags { get; set; }
        public int Id { get; set; }
    }
}