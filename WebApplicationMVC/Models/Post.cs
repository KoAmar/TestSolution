﻿using System;

namespace WebApplicationMVC.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string CreatorLogin { get; set; }
        public DateTime CreationDate { get; set; }
    }
}