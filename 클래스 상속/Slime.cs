using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{

    internal class Monster 
    {
        public int HP;
        public int AttackPower;

        public virtual void Attack(Player player)
        {
            player.HP = player.HP - AttackPower;
            Console.WriteLine("몬스터가 플레이어를 공격함");
        }

        public virtual void BeAttacked(Player player)
        {
            HP = HP - player.AttackPower;
            Console.WriteLine("플레이어가 몬스터를 공격함");
        }
    }

    internal class Slime : Monster
    {
        //public void Attack(Player player)
        //{
        //    Console.WriteLine("새로운 공격 : 슬라임");
        //}
        //
        //public void Attack(Player player)
        //{
        //    base.Attack(player);
        //    Console.WriteLine("슬라임의 공격");
        //}

        public override void Attack(Player player)
        {
            Console.WriteLine("슬라임의 공격");
        }
        public override void BeAttacked(Player player) 
        {
            base.BeAttacked(player);
            Console.WriteLine("슬라임이 플레이어에게 공격 당함");
        }
    }

    internal class Bear : Monster
    {
        public override void Attack(Player player)
        {
            Console.WriteLine("곰이 공격");
        }
        public override void BeAttacked(Player player)
        {
            base.BeAttacked(player);
            Console.WriteLine("곰이 플레이어에게 공격 당함");
        }
    }

    internal class Skeleton : Monster
    {

    }
    internal class Zombie : Monster
    {

    }
}
