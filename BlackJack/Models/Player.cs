using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        public string Name { get; set; }
        public int Cash { get; set; }
        public List<Card> Hand { get; set; }
        public int HandValue { get; set; }
    }
}
