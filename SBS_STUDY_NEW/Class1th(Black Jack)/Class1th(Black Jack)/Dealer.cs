using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1th_Black_Jack_
{
    public class Dealer : Player 
    {
        public Dealer(string name) : base(name)
        {

        }
        
        public bool ShouldDrawCard()
        {
            // 딜러의 점수가 16 미만이면 카드를 받는다
            return CalculateScore() < 17;
        }

        public void DealerTurn(Deck deck)
        {
            Console.WriteLine("\n딜러의 턴 :");

            while(CalculateScore() < 17)
            {
                Console.WriteLine("딜러가 카드를 받습니다.");
                ReceiveCard(deck.Draw());
                Console.WriteLine(this);
                ShowScore();
            }

            if(CalculateScore() > 21)
            {
                Console.WriteLine("딜러가 21을 초과하여 패배");
            }
        }

    }
}
