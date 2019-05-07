using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CFAParserCodeServices;
using CFAParserCodeEntities;

namespace CFAParserCode.Tests
{
    public class ContentTest : IContent
    {
       public int GargabeCharCount => 4;

        public int Score(int outer)
        {
            return 1;
        }
    }
    /// <summary>
    /// Summary description for ParserUnitTest
    /// </summary>
    [TestClass]
    public class ParserUnitTest
    {
        private Mock<IParseService> _mockParseService;
        IParseService parseService;
        [TestMethod]
        public void CheckValidGroupsForTheGivenInput()
        {
            var garbageCount = parseService.ParseGroup().GargabeCharCount;
            var score = parseService.ParseGroup().Score(1);
            Assert.AreEqual(4, garbageCount);
            Assert.AreEqual(3, score);
        }

        [TestInitialize]
        public void Initialize()
        {
            _mockParseService = new Mock<IParseService>();

            parseService = _mockParseService.Object;

            var contents = new IContent[1];
            contents[0] = new ContentTest();
            Group group = new Group(contents);

            _mockParseService.Setup(s => s.ParseGroup()).Returns(group);
        }
    }
}
