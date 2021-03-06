using System.Web.Mvc;

namespace Municipality.Models
{
    public class Article
    {
        
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }


        [AllowHtml]
        public string Description { get; set; }
    }
}
