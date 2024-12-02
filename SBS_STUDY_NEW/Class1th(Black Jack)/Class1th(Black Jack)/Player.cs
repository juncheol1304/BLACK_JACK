using Class1th_Black_Jack_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1th_Black_Jack_
{
    internal class Player
    {
        public string Name {get; set;}
        public List<Card> Hand {get; set;}
        
        public int Score
        {
            get
            {
                int total = Hand.Sum<Card>
            }
        }
    }
}
