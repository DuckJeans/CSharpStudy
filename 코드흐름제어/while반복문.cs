using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    static class while반복문
    {
        public static void Show()
        {
            Console.WriteLine("while 반복문");

            int number = 0;

            //while() 조건식이 false가 될 떄 까지 반복한다.
            while (number < 10)
            {
                Console.WriteLine(number);
                number = number + 1;  // number에 1을 더해서 다시 넣어준다.
            }
            number = 0;
            // while(ture) 무한 반복은 실행 후에 조건문으로 탈출하는 방법
            while (true)
            {
                Console.WriteLine(number);
                number = number + 1;
                if (number == 10)
                {
                    break;
                }
            }

            // while문 언제 사용하는가?
            // 얼마 만큼 반복해야 할지 잘 모르겠을 때 while 반복문을 쓰면 좋다.

            // 1 ~ 10까지의 숫자 중에서 짝수만 출력하는 코드를 작성해라. for반복문, while반복문
            int num2 = 0;
            while (num2 <= 10)
            {
                if (num2 % 2 == 0) // 짝수라면..
                {
                    Console.WriteLine("짝수 값 : " + num2);
                }

                num2 = num2 + 1;
                if (num2 == 10)
                {
                    break;
                }
            }
            // 1. 탈출해야 하는 조건
            // 2. 반복해서 실행해야 할 코드

            // 1부터 100사이의 3의 배수를 출력하는 코드를 작성 해 보세요.
            Console.WriteLine("반복문 예제 문제");
            Console.WriteLine("3의 배수를 출력하는 코드이다.");
            int num3 = 0;
            while(num3 <= 100)
            {
                num3 = num3 + 1;
                if (num3 % 3 == 0)
                {
                    Console.WriteLine(num3);
                }
                if (num3 == 100)
                {
                    break;
                }
            }
        }
    }
}