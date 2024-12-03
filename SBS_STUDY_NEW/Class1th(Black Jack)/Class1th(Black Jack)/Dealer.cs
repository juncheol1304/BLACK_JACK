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
        // 클래스들이 Internal로 되있어서 전부 에러뜸
        // Public 을 쓰면 되는걸 까먹고 있었음.

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
