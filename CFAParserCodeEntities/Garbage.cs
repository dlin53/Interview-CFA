using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAParserCodeEntities
{
    public class Garbage : IContent
    {
        private readonly string _garbage;

        public Garbage(string garbage)
        {
            _garbage = garbage;
        }

        public int GargabeCharCount => _garbage.Length;

        public int Score(int outer)
        {
            return 0;
        }
    }
}
