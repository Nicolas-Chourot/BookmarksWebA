﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookmarksWebA.Models
{
    public class Bookmark
    {   // prop
        // ctor
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Url]
        public string Url { get; set; }

        public Bookmark()
        {

        }
    }
}
