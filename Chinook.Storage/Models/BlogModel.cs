﻿namespace Chinook.Storage.Models
{
    public class BlogModel
    {
        public int Id { get; set; }

        public int BlogCategoryId { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string ShortDefinition { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int Sequence { get; set; }

        public bool Published { get; set; }

        public bool IsActive { get; set; }
    }

    public class BlogFilterModel : FilterModel
    {
        public int? BlogCategoryId { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }
        public bool? IsActive { get; set; }

    }
}
