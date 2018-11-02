using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace DisplayXml.Tests
{
    [TestClass]
    public class XmlParserServicesTests
    {
        [TestMethod]
        public void GetLastTenArticles_ShouldReturnTenArticles()
        {
            //Arrange
            var service = new XmlParserService();
            //Act

            var articles = service.GetLastTenArticles();
            //Assert
            
            Assert.AreEqual(10, articles.Count);
        }
    }
}
