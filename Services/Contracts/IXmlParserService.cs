namespace Services.Contracts
{
    using DisplayXml.Models;
    using System.Collections.Generic;

    public interface IXmlParserService
    {
        ICollection<ArticleViewModel> GetLastTenArticles();
    }
}
