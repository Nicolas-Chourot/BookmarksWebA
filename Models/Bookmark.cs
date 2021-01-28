using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookmarksWebA.Models
{
    public class Bookmark
    {   // prop
        // ctor
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public Bookmark()
        {

        }
    }
}
