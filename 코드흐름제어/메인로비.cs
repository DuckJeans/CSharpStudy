using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using 게임중;

namespace 코드흐름제어
{

    static class 메인로비
    {

        public static void GameStart()
        {
            

            Console.WriteLine("게임을 시작했습니다.");

            while (true) 
            {
                int a = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("게임 실행 중");
                    Console.WriteLine("1. 메뉴를 엽니다.");
                }
                else if (a == 1)
                {
                    ShowMenu();
                }
            }
        }
        public static void ShowMenu()
        {
            
            Console.Clear();
            Console.WriteLine("----------------게임 메뉴 출력----------------");
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 게임 옵션");
            Console.WriteLine("3. 게임 크레딧");
            Console.WriteLine("4. 게임 종료");

            // 1. 강의를 학습하고, 스스로 이 코드를 직접 만들 수 있으면 성공적이다.

            while (true)
            {
                //유니티에서 게임을 시작해주는 클래스와 메소드가 미리 구현되어있다.
                Console.Write("입력을 기다리고 있습니다. : ");
                int userinput = int.Parse(Console.ReadLine());

                // 1. if 조건문, switch문

                if (userinput == 1)
                {
                    Console.WriteLine("게임을 실행 합니다.");
                    GameStart();
                    Player p1 = new Player();
                    p1.GameInformation(p1);
                }
                else if (userinput == 2)
                {
                    Console.WriteLine("게임 옵션을 들어갑니다.");
                }
                else if (userinput == 3)
                {
                    Console.WriteLine("게임 제작 : 김덕진");
                }
                else if (userinput == 4)
                {
                    Console.WriteLine("게임 종료.");
                    break;
                }
            }
        }
    }
}
namespace 게임중
{
    class Slime
    {
        public int slimeHP;
        public int slimeAttackPower;

        static public void slime(string[] args)
        {
            게임중.Slime slime = new 게임중.Slime();
            slime.slimeHP = 50;
            slime.slimeAttackPower = 5;
        }
    }
    class Player
    {
        public int userHP;
        public int userAttackPower;
        public void GameInformation(Player p1)
        {
            p1.userHP = 100;

            Console.WriteLine($"현재 플레이어의 체력 : {userHP}");
        }


        static public void user(string[] args)
        {
            게임중.Player p1 = new 게임중.Player();
            p1.userHP = 100;
            p1.userAttackPower = 10;
        }
    }
}