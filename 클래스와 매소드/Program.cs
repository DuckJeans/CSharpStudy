using System.Drawing;
using 메이플스토리;

namespace 클래스와_매소드
{
    internal class Program
    {
        static void Playerturn(Player player, Slime slime)
        {
            Console.WriteLine("1. 공격한다.");
            Console.WriteLine("2. 휴식한다.");
            Console.WriteLine("3. 도망친다.");
            Console.WriteLine("4. 공격력 증가 아이템을 먹는다.");

            Console.WriteLine("유저의 행동을 입력해주세요");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                player.Attack(slime);

            }
            else if (userInput == 2)
            {
                player.Rest();
            }
            else if (userInput == 3) 
            {
                player.Run();
            }
            else if (userInput == 4)
            {
                player.Potion(player);
            }
        }

        static void Main(string[] args)
        {
            네임스페이스 coffee = new 네임스페이스();
            coffee.Show();

            /*
             *  클래스 사용 방법
             *  (이름공간.Slime) (클래스의 이름 변수) = new 메이플스토리.Slime();
             *  
             */

            메이플스토리.Slime slime = new 메이플스토리.Slime();
            slime.Name = "슬라임";
            slime.slimeHP = 40;
            slime.MoveSpeed = 2;
            slime.slimeAttackPower = 5;
            slime.Show();

            메이플스토리.Skeleton skeleton = new 메이플스토리.Skeleton();
            skeleton.Name = "스켈레톤";
            skeleton.HP = 80;
            skeleton.MoveSpeed = 1;
            skeleton.AttackPower = 10;
            skeleton.Show();
            

            메이플스토리.Player player = new 메이플스토리.Player();
            player.playerHP = 100;
            player.playerAttackPower = 10;
            
            
            //slime.Attack(player);                             // Attack() 매소드는 인자로 Player 객체를 받는다. player
            //slime.BeAttacked(player.playerAttackPower);       // BeAttacked() 메소드는 인자로 int 데이터를 받는다. (int)player.AttackPower
            //slime.Show();

            //player.Show()
            while(true) //무한 반복문
            {
                Playerturn(player, slime); //함수로 코드를 정리해서, 코드의 쓰임새를 쉽게 정리할 수 있다.

                slime.Attack(player);
                player.Show();
                slime.Show();
                //Enemyturn(player, slime); //적이 플레이어를 대상으로 하는 행동 AI

                if(slime.slimeHP <= 0)
                {
                    Console.WriteLine("슬라임을 처치했습니다. 게임에서 승리하였습니다!");
                    break;
                }

                if (player.playerHP <= 0)
                {
                    Console.WriteLine("슬라임에게 패배하였습니다. 게임에서 패배하였습니다..");
                    break;
                }

                if(slime.slimeHP <= 20)
                {
                    Console.WriteLine("주의하세요! 슬라임이 화났습니다!");
                    Console.WriteLine("슬라임의 공격력이 5씩 증가합니다!");

                    slime.slimeAttackPower = slime.slimeAttackPower + 5;
                }
            }
        }
    }
}
