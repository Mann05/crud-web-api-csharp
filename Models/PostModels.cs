using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class PostModels
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostDescription { get; set; }
    }
    public class ResultSet {
        public int code { get; set; }
        public string message { get; set; }
    }
}