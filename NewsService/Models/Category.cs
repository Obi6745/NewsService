using System.Collections.Generic;

namespace NewsService.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // this would be the primary key 
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}