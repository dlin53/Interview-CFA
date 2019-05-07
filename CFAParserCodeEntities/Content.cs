using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAParserCodeEntities
{
    public class Content
    {
        private readonly int gargabeCharCount;
        private readonly int score;

        public Content(int score, int gargabeCharCount)
        {
            this.score = score;
            this.gargabeCharCount = gargabeCharCount;
        }

        public int GargabeCharCount => this.gargabeCharCount;
        public int Score => this.score;
    }
}
