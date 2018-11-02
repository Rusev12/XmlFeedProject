namespace Services
{
    using DisplayXml.Models;
    using Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using DisplayXml.Common;

    public class XmlParserService : IXmlParserService
    {
        private readonly string categoryName = "Friction";
        
        public ICollection<ArticleViewModel> GetLastTenArticles()
        {
            String URLString = "https://www.tungsten-network.com/rss-resource-library/";
            
            var doc = XDocument.Load(URLString);

            var articlesModel = doc.Root.Elements(GlobalConstants.Channel).Elements(GlobalConstants.Item).Where(b => (string)b.Element(GlobalConstants.Category) == categoryName)
                .Take(10)
                .Select(ar => new ArticleViewModel()
                {
                    Heading = ar.Element(GlobalConstants.Title).Value,
                    DateOfPublish = ar.Element(GlobalConstants.PubDate).Value,
                    ImageUrl = ar.Element(GlobalConstants.Enclosure).Attribute(GlobalConstants.Url).Value,
                    Categories = ar.Elements(GlobalConstants.Category).Select(cat => cat.Value).ToArray(),
                } ).ToArray();

            return articlesModel;
            
        }

       
    }
}
