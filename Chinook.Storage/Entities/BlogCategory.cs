﻿using System.Collections.Generic;

namespace Chinook.Storage.Entities
{
    public class BlogCategory : BaseModel
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
