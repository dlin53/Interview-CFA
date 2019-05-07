using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFAParserCodeEntities;
namespace CFAParserCodeServices
{
    public interface IParseService
    {
        void SetInput(string input);
        Group ParseGroup();
        IContent[] ParseContents();
        IContent ParseContent();
        Garbage ParseGarbage();
    }
}
