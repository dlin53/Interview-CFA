using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAParserCodeEntities
{
    public interface IContent
    {
        int GargabeCharCount { get; }
        int Score(int outer);
    }
}
