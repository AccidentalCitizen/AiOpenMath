using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiOpenMath.Domain.Basic
{
    public class Pair<Key, Value>
    {
        public Pair(Key key, Value value)
        {
            GetKey = key;
            GetValue = value;
        }
        public Key GetKey { get; set; }
        public Value GetValue { get; set; }
    }
}
