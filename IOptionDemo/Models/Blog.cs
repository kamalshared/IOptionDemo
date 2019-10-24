using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOptionDemo.Models;

namespace IOptionDemo.Models
{
    public class BlogPost
    {
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public bool Published { get; set; }

    }
}

namespace IOptionDemo
{
    class Blog
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public List<BlogPost> BlogPosts { get; internal set; }
    }
}