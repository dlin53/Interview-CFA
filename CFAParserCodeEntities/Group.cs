using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAParserCodeEntities
{
    public class Group : IContent
    {
        private readonly IContent[] _content;

        public Group(IContent[] content)
        {
            _content = content;
        }

        public int GargabeCharCount => _content.Sum(c => c.GargabeCharCount);

        public int Score(int outer)
        {
            var thisLayer = outer + 1;
            var innerSum = _content.Sum(c => c.Score(thisLayer));
            return thisLayer + innerSum;
        }
    }
}
