using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class1th_Black_Jack_
{
    public class Card
    {
        public string Rank { get; set; } // 카드 숫자

        public string Suit { get; set; } // 카드 문양

        public int Value
        {
            get
            {
                if (Rank == "A") // A 는 11로 설정
                    return 11;
                if (Rank == "K" || Rank == "Q" || Rank == "J") // 세개다 10으로 설정
                    return 10;
                if(int.TryParse(Rank, out int number))
                    return number;
                return 0;
            }
        }
        // 카드 문양 숫자 배열
        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }
        
        public override string ToString()
        {
            return Rank + " " + Suit;
        }

        internal static void Add(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
