using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogBackEndL.Models
{
    public class BlogitemModel
    {
        public int Id {get; set;}

        public int UserId {get; set;}

        public string? Publishername {get; set;}

        public string? Title {get; set;}

        public string? Tag {get; set;}

        public string? Date {get; set;}

        public string? Description {get; set;}

        public string? Image {get; set;}

        public string? Category {get; set;}

        public bool IsDelted {get; set;}

        public bool IsPublished {get; set;}

        public BlogitemModel () {}
    }
}