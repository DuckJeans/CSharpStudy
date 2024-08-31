using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 클래스_상속
{
    internal class Player
    {
        public int HP;
        public int AttackPower;

        public void Attack(Monster monster)
        {
            monster.HP = monster.HP - AttackPower;
            Console.WriteLine("플레이어가 공격했습니다!");
            Console.WriteLine($"몬스터 현재 체력 : {monster.HP}");
            Console.WriteLine($"몬스터 데미지 : {monster.AttackPower}");
        }

        public void rest()
        {
            HP = HP + 10;
            Console.WriteLine("플레이어가 휴식하여 HP를 10만큼 회복하였습니다.");
            Console.WriteLine($"플레이어 현재 체력 : {HP}");
            Console.WriteLine($"플레이어 데미지 : {AttackPower}");
        }
        public void BeAttacked(Slime monster)
        {
            HP = HP - monster.AttackPower;
            Console.WriteLine("슬라임이 공격했습니다!");
            Console.WriteLine($"플레이어 체력 : {HP}");
            Console.WriteLine($"플레이어 데미지 : {AttackPower}");
        }

        public void BeAttacked(Zombie monster)
        {
            HP = HP - monster.AttackPower;
            Console.WriteLine("좀비가 공격했습니다!");
            Console.WriteLine($"플레이어 체력 : {HP}");
        }


        public void BeAttacked(Skeleton monster)
        {
            HP = HP - monster.AttackPower;
            Console.WriteLine("스켈레톤이 공격했습니다!");
            Console.WriteLine($"플레이어 체력 : {HP}");
        }
    }
}
