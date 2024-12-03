using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1th_Black_Jack_
{
    public class Game
    {
        private Deck deck;
        private Player player;
        private Dealer dealer;

        public Game(string playerName, string dealerName)
        {
            deck = new Deck();
            player = new Player(playerName);
            dealer = new Dealer(dealerName);
        }
        public void StartGame()
        {
            Console.WriteLine("게임을 시작합니다!");


            deck.Shuffle();

            DealInitialCards();

            PlayerTurn();

            if (player.CalculateScore() <= 21)
            {
                dealer.DealerTurn(deck);
            }

            ShowResult();
        }
        private void DealInitialCards()
        {
            player.ReceiveCard(deck.Draw());
            dealer.ReceiveCard(deck.Draw());
            player.ReceiveCard(deck.Draw());
            dealer.ReceiveCard(deck.Draw());

            Console.WriteLine(player);
            Console.WriteLine(dealer);
        }

        private void PlayerTurn()
        {
            Console.WriteLine("\n" + player.Name + "의 턴 : ");

            while (player.CalculateScore() < 21 && dealer.CalculateScore() < 21)
            {
                Console.WriteLine(player);
                Console.WriteLine("카드를 더 받으시겠습니까? (y/n)");

                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    player.ReceiveCard(deck.Draw());
                    Console.WriteLine(player);
                }
                else if (input == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }

            if (player.CalculateScore() < 21)
            {
                Console.WriteLine(player.Name + "가 21점을 초과하여 패배");
            }
        }

        private void ShowResult()
        {
            Console.WriteLine("\n 게임 종료");

            int playerScore = player.CalculateScore();
            int dealerScore = dealer.CalculateScore();

            Console.WriteLine(player);
            Console.WriteLine(dealer);

            if(playerScore > 21)
            {
                Console.WriteLine(player.Name + "가 21점을 초과하여 딜러 승리.");
            }
            else if(dealerScore > 21)
            {
                Console.WriteLine(dealer.Name + "가 21점을 초과하여" + player.Name + "승리");
            }
            else if(playerScore > dealerScore)
            {
                Console.WriteLine(player.Name + "승리");
            }
            else if(dealerScore > playerScore)
            {
                Console.WriteLine(dealer.Name + "승리");
            }
            else
            {
                Console.WriteLine("무승부");
            }
        }
    }
}
