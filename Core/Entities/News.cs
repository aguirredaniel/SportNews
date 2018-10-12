using System;

namespace Core.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public string UrlImage { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
    }
}