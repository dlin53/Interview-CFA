using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFAParserCodeEntities;


namespace CFAParserCodeServices
{
    public class ParsePosServicecs : IParsePosServices
    {
        private string _input;
        public void SetInput(string input) { this._input = input; }
        private int _index = 0;
        public void SetIndex(int index)
        {
            this._index = index;
            if (_index < 0)
                _index = 0;
            if (_index >= _input.Length)
                _index = _input.Length;
        }

        public ParsePosServicecs()
        { }

        public ParsePosServicecs MoveRight()
        {
            ParsePosServicecs temp = new ParsePosServicecs();
            temp.SetInput(_input);
            temp.SetIndex(_index + 1);
            return temp;
        }

        public bool EndOfStream => _index >= _input.Length;

        public char? Current => !EndOfStream ? _input[_index] : (char?)null;
    }
}
