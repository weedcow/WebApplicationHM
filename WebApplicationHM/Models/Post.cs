using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHM.Models
{
    public class Post
    {
        public Post()
        {

        }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}