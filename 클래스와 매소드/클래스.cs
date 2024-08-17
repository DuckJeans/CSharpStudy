using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using 김덕진.수업내용;

/*
 *  using : 이름 공간을 사용해라
 *  using 이름공간.이름공간;
 *  -> 네임 스페이스 옆에 붙이지 않아도 그 공간안에 있는 코드를 사용할 수 있다.
 */

namespace 김덕진
{
    namespace 수업내용
    {
        /*
         *  클래스
         *  사용자 정의 데이터 유형입니다. -> int, char, float, string
         *  클래스를 이용하여 객체를 생성하고 그 객체 내부에 있는 변수와 매소드를 이용하여 데이터에 접근하고 사용할 수 있는 집합체.
         */

        /*
         *  1. 클래스의 선언
         *  class 이름 {  }
         */

        class Monster
        {
            //공격한다 (행동)

            //체력
            //공격
            //공격력
            //방어력
        }

        /*
         *  2. 클래스의 사용
         */
    }
}

namespace 메이플스토리
{

    class Player
    {
        public int playerHP;
        public int playerAttackPower;

        
        public void Show()
        {
            Console.WriteLine($"플레이어의 체력 : {playerHP}");
            Console.WriteLine($"플레이어의 공격력 : {playerAttackPower}");
        }

        public void Attack(Slime slime)
        {
            slime.slimeHP = slime.slimeHP - playerAttackPower;
            
            Console.WriteLine($"플레이어가 {slime.Name}을 공격했습니다!");
            Console.WriteLine($"--------------결과----------------");
            Console.WriteLine($"플레이어의 공격력 : {playerAttackPower}으로 공격했습니다!");
        }
        public void Rest()
        {
            playerHP = playerHP + 10;

            Console.WriteLine($"플레이어가 휴식을 했습니다!");
            Console.WriteLine($"--------------결과----------------");
            Console.WriteLine($"플레이어의 체력을 회복했습니다!");
        }

        public void Run()
        {
            Console.WriteLine("--------------결과----------------");
            Console.WriteLine("플레이어는 도망칠 수 없습니다.");
            Console.WriteLine("전투를 계속 진행합니다.");
        }

        public void Potion(Player player)
        {
            Console.WriteLine("--------------결과----------------");
            Console.WriteLine("플레이어는 공격력 버프 포션을 먹었습니다.");
            Console.WriteLine("공격력이 10 증가하였습니다.");

            player.playerAttackPower = playerAttackPower + 10;
        }
    }
    class Slime
    {
        //슬라임의 체력 50. 실수형, 정수형

        /*
         *  접근지정자
         *  1.public  : 공공의, 외부에서 전부 사용할 수 있게 하라
         *  2.private : class 내부에서만 사용해라, 접근 지정자를 명시하지 않으면 자동으로 private 선언이 된다.
         */

        public int slimeHP;
        public int slimeAttackPower;
        public string Name;
        public float MoveSpeed;

        /*
         *  메소드 : 코드를 하나의 이름 아래 묶는 것입니다.
         *  묶인 코드를 이름을 불러주는 것만으로 실행할 수 있습니다.
         *  메소드를 호출하는 것을 Call method (메소드 호출)
         */

        /*
         *  (접근지정자) + (반환값) + (메소드의 이름) + () + {}
         *  public         void       Show()       {묶인 코드 내용들}
         *  
         *  접근지정자 : private, public => public 선언을 해주세요
         *  반환값이 없는 경우 : void
         *  반환값이 있는 경우 : Int(정수형), Float(실수형), String(문자열), Class이름(사용자 정의형) 반환하라..
         *  메소드의 이름 : Show();  1. Show(이름), 2. 소괄호 (), 3. ; => 3개의 기호가 합쳐져 Show메소드 안에 있는 코드를 호출한다.
         */

        int ReturnHP()
        {
            // 반환값이 있는 함수인 경우에는 return + 변수의 이름 + ; -> 해당하는 변수 값을 반환한다.
            return slimeHP;
        }

        string ReturnName()
        {
            return Name;
        }

        float ReturnMoveSpeed()
        {
            return MoveSpeed;
        }

        //슬라임이 공격하는 메소드를 만들어보세요
        public void BeAttacked(int damaged)
        {
            //플레이어의 체력 - 슬라임의 공격력
            slimeHP = slimeHP - damaged;
        }

        public void Attack(Player player)
        {
            player.playerHP = player.playerHP - slimeAttackPower;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}의 체력 : {slimeHP}");
            Console.WriteLine($"{Name}의 공격력 : {slimeAttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");
        }
    }

    class Skeleton
    {
        public int HP;
        public int AttackPower;
        public string Name;
        public float MoveSpeed;

        public void Show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");
        }
    }
}

namespace 클래스와_매소드
{
    internal class 클래스
    {
        
    }
}
