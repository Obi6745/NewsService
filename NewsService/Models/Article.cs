using System; 

namespace NewsService.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime PublishedDate { get; set; }

        public int CategoryId { get; set; }


        public Category Category { get; set; }



    }
}