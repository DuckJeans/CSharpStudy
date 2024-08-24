using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    enum USERINPUT { GAMESTART = 1, GAMEEND, OPTION }
    //enum : 열거형.
    // 숫자 1이 무조건 A를 표현 할 거야. 약속.
    internal static class switch조건문
    {
        static USERINPUT userinput;
        public static void Show()
        {
            Console.WriteLine("switch조건문 강의");



            Console.WriteLine("1번 게임 시작 / 2번 게임 종료 / 3번 설정");
            //if = else if = else if = else if... 코드 내용을 파악하기 힘들었다.
            int userinput2 = int.Parse(Console.ReadLine());   // 1. 게임 시작 , 2. 게임 종료, 3. 설정


            switch (userinput2)
            {
                case 1:
                    Console.WriteLine("1번 게임 시작");
                    break;
                case 2:
                    Console.WriteLine("2번 게임 종료");
                    break;
                case 3:
                    Console.WriteLine("3번 설정");
                    break;
                default:
                    Console.WriteLine("잘못된 입력값입니다. 다시 입력해 주세요.");
                    break;
            }

            // if(userinput == 1)
            // switch문 사용시 주의 사항
            // break 사용법을 주의해야한다.

            //
        }
    }
}
