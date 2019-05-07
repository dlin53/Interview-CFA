using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFAParserCodeEntities;
namespace CFAParserCodeServices
{
    public interface IParsePosServices
    {
        ParsePosServicecs MoveRight();
        void SetInput(string input);
        bool EndOfStream { get; }
        char? Current { get; }
    }
}
