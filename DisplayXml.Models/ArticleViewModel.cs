namespace DisplayXml.Models
{
    using System.Collections.Generic;

    public class ArticleViewModel
    {
       
        public string Heading { get; set; }

        public string DateOfPublish { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<string> Categories { get; set; }

    }
}
