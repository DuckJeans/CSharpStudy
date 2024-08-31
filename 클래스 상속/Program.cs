namespace 클래스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 상속");

            Player player = new Player();
            player.HP = 100;
            player.AttackPower = 10;

            Slime slime = new Slime();
            slime.HP = 50;
            slime.AttackPower = 5;

            Bear bear = new Bear();
            bear.HP = 70;
            bear.AttackPower = 10;

            Skeleton skeleton = new Skeleton();
            skeleton.HP = 90;
            skeleton.AttackPower = 20;

            Zombie zombie = new Zombie();
            zombie.HP = 140;
            zombie.AttackPower = 5;

            Console.WriteLine("만나서 반갑습니다 플레이어님!");
            Console.WriteLine("어떤 종류의 몬스터와 싸우시겠습니까?");
            Console.WriteLine("1.슬라임 / 2.좀비 / 3.스켈레톤");
            int choose = int.Parse(Console.ReadLine());
            
            if (choose == 1)
            {
                Console.Clear();
                Console.WriteLine("슬라임을 선택하셨습니다.");
                Console.WriteLine($"플레이어의 체력 : {player.HP}");
                Console.WriteLine($"플레이어의 공격력 : {player.AttackPower}");
                Console.WriteLine($"슬라임의 체력 : {slime.HP}");
                Console.WriteLine($"슬라임의 공격력 : {slime.AttackPower}");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("플레이어는 1번과 2번으로 플레이 합니다.");

                while (slime.HP >= 0)
                {
                    if (slime.HP <= 0)
                    {
                        Console.WriteLine("게임에서 승리하였습니다! 게임을 종료합니다.");
                        break;
                    }
                    Console.WriteLine("1. 공격 / 2.휴식");

                    int act = int.Parse(Console.ReadLine());
                    if (act == 1)
                    {
                        Console.Clear();
                        player.Attack(slime);
                        player.BeAttacked(slime);
                    }
                    else if (act == 2)
                    {
                        Console.Clear();
                        player.rest();
                    }
                }
            }
            else if (choose == 2)
            {
                Console.Clear();
                Console.WriteLine("좀비을 선택하셨습니다.");
                Console.WriteLine($"플레이어의 체력 : {player.HP}");
                Console.WriteLine($"플레이어의 공격력 : {player.AttackPower}");
                Console.WriteLine($"좀비의 체력 : {zombie.HP}");
                Console.WriteLine($"좀비의 공격력 : {zombie.AttackPower}");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("플레이어는 1번과 2번으로 플레이 합니다.");

                while (zombie.HP >= 0)
                {
                    if (zombie.HP <= 0)
                    {
                        Console.WriteLine("게임에서 승리하였습니다! 게임을 종료합니다.");
                        break;
                    }
                    Console.WriteLine("1. 공격 / 2.휴식");

                    int act = int.Parse(Console.ReadLine());
                    if (act == 1)
                    {
                        Console.Clear();
                        player.Attack(zombie);
                        player.BeAttacked(zombie);
                    }
                    else if (act == 2)
                    {
                        Console.Clear();
                        player.rest();
                    }
                }
            }
            else if (choose == 3)
            {
                Console.Clear();
                Console.WriteLine("스켈레톤을 선택하셨습니다.");
                Console.WriteLine($"플레이어의 체력 : {player.HP}");
                Console.WriteLine($"플레이어의 공격력 : {player.AttackPower}");
                Console.WriteLine($"스켈레톤의 체력 : {skeleton.HP}");
                Console.WriteLine($"스켈레톤의 공격력 : {skeleton.AttackPower}");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("플레이어는 1번과 2번으로 플레이 합니다.");

                while (skeleton.HP >= 0)
                {
                    if (skeleton.HP <= 0)
                    {
                        Console.WriteLine("게임에서 승리하였습니다! 게임을 종료합니다.");
                        break;
                    }
                    Console.WriteLine("1. 공격 / 2.휴식");

                    int act = int.Parse(Console.ReadLine());
                    if (act == 1)
                    {
                        Console.Clear();
                        player.Attack(skeleton);
                        player.BeAttacked(skeleton);
                    }
                    else if (act == 2)
                    {
                        Console.Clear();
                        player.rest();
                    }
                }
            }
            else
            {
                Console.WriteLine("정확한 선택지가 아닙니다.");
            }
        }
    }
}
