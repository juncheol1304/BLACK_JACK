using Class1th_Black_Jack_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1th_Black_Jack_
{
    public class Deck
    {
        public List<Card> Cards { get; private set; } // 덱에 있는 카드 리스트

        private static readonly string[] Ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private static readonly string[] Suits = { "♠", "♣","◆", "♥" };
        private static Random rand = new Random();
        public Deck()
        {
            Cards = new List<Card>();
            InitializeDeck();
        }

        // 덱을 초기화하여 52장의 카드를 생성 (for문 사용)
        private void InitializeDeck()
        {
            for (int i = 0; i < Suits.Length; i++) // Suits 배열의 길이만큼 반복
            {
                for (int j = 0; j < Ranks.Length; j++) // Ranks 배열의 길이만큼 반복
                {
                    Cards.Add(new Card(Ranks[j], Suits[i])); // 카드 생성 후 덱에 추가
                }
            }
        }

        // 덱을 셔플하는 메서드
        
        public void Shuffle()
        {
            Random rand = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        // 덱에서 한 장의 카드를 뽑는 메서드
        public Card Draw()
        {
            Card drawnCard = Cards[0]; // 덱에서 첫 번째 카드 뽑기
            Cards.RemoveAt(0); // 첫 번째 카드 제거
            return drawnCard; // 뽑은 카드 반환
        }

        // 덱에 남아 있는 카드 수 반환
        public int CardsLeft()
        {
            return Cards.Count;
        }

        // 덱에 있는 카드들 전체를 문자열로 반환
        public override string ToString()
        {
            return string.Join(", ", Cards);
        }
    }
}
