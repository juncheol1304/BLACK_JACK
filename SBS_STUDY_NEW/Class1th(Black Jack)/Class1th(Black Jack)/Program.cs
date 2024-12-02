using System;
using System.Collections.Generic;

namespace Class1th_Black_Jack_
{
    internal class Program

    {       
        static void ShowStart() // 게임시작 화면 (완)
        {
            Console.WriteLine();
            Console.WriteLine("                             $$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("                             $ 블랙잭 게임을 시작합니다.$");
            Console.WriteLine("                             $$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine();
            Console.WriteLine("◎게임 규칙◎");
            Console.WriteLine();
            Console.WriteLine("- 숫자의 합이 21을 넘지않고 21에 가까운 플레이어가 승리합니다. ");
            Console.WriteLine("- A는 1 또는 11로 사용가능합니다.");
            Console.WriteLine("- J,Q,K 는 모두 10으로 통일합니다.");
            Console.WriteLine("- 각 플레이어는 시작시 두장의 패를 가지고 시작합니다.");
            Console.WriteLine("- 매 턴 마다 플레이어는 패를 받을지 STAY를 할지 결정합니다.");
            Console.WriteLine();
            Console.WriteLine("- 게임을 시작하려면 아무키나 눌러주세요.");
        }
        static void Main(string[] args)
        {
            ShowStart(); // 게임화면 출력(완)
            Card card;
        }
    }
}
