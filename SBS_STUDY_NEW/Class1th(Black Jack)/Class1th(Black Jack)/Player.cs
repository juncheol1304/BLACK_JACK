using Class1th_Black_Jack_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class1th_Black_Jack_
{
    public class Player 
    {
       
        public string Name {get; set;}
        
        protected List<Card> Hand {get; set;}
            
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
       
        public void ReceiveCard(Card card)
        {
            Hand.Add(card);
        }
        // 점수 계산.
        public int CalculateScore()
        {
            int score = 0;
            int aceCount = 0;

            // for문 돌리다가 막혀서 foreach라는 걸 찾음
            foreach (var card in Hand)
            { 
                if( card.Rank == "A")
                {
                    aceCount++;
                    score += 11;
                }
                else if( card.Rank == "K" || card.Rank == "Q" || card.Rank == "J" || card.Rank == "10")
                {
                    score += 10;
                }
                
                else
                {
                    score += int.Parse(card.Rank);
                }
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        // 플레이어 카드를 문자열로 반환
        public string ShowCards()
        {
            return string.Join(" ", Hand);
        }

        public void ShowScore()
        {
            Console.WriteLine(Name + "의 점수 : " + CalculateScore());
        }

        public override string ToString()
        {
            return Name + "의 카드 : " + ShowCards() + "(점수 : " + CalculateScore() + ")";
        }


    }
}
