using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAParserCodeEntities
{
    public class Parameter
    {
        public Parameter(string v)
        {
            this.value = v;
        }

        public string value { get; set; }
    }
}
