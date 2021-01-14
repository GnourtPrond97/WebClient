using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClientX.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Images { get; set; }
        public string Content { get; set; }

        public Article()
        {
        }
    }
}