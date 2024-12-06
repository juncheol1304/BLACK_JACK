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

            PlayerAndDealerTurn();

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

        private void PlayerAndDealerTurn()
        {
            Console.WriteLine("\n플레이어와 딜러의 턴을 시작합니다!");


            while (player.CalculateScore() <= 21 && dealer.CalculateScore() <= 21)
            {
                // 플레이어 턴
                Console.WriteLine($"\n{player.Name}의 턴:");
                Console.WriteLine(player);
                Console.WriteLine("카드를 더 받으시겠습니까? (y/n)");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    player.ReceiveCard(deck.Draw());
                    Console.WriteLine(player);
                    if (player.CalculateScore() > 21)
                    {
                        Console.WriteLine($"{player.Name}가 21점을 초과하였습니다!");
                        break;
                    }
                }
                else if (input == "n")
                {
                    Console.WriteLine($"{player.Name}가 카드를 받는 것을 중단합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    continue;
                }

                // 딜러 턴 (자동 진행)
                Console.WriteLine($"\n{dealer.Name}의 턴:");
                if (dealer.ShouldDrawCard())
                {
                    dealer.ReceiveCard(deck.Draw());
                    Console.WriteLine(dealer);
                    if (dealer.CalculateScore() > 21)
                    {
                        Console.WriteLine($"{dealer.Name}가 21점을 초과하였습니다!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{dealer.Name}가 카드를 받는 것을 중단합니다.");
                    
                }
                
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
