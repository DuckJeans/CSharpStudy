/*
 *  학습목표 : 반복문과 조건문을 사용해서 코드를 제어하는 방법을 이해한다.
 *  작성일   : 2024 - 08 - 24
 *  작성자   : 김덕진
 */

/*
 *  복습 겸 학습 개요
 *  네임 스페이스 + 클래스와 메소드
 */

/*
 *  범위지정
 *  
 *  범위의 시작 {
 *  
 *  } 범위의 끝
 */

/*
 *  목표 : 게임 시작 메뉴 만들기 (C# 언어로)
 *   - 게임시작 , 게임종료
 *   1. 두개의 선택 사항을 구분되서 코드를 제어하는 방법 (조건문) if조건문 , switch조건문
 *   2.시작하자 마자 프로그램이 종료되는 것을 방지하기 위함. 무한적으로 프로그램이 실행. (무한 반복) for반복문과 while반복문
 */

namespace 코드흐름제어
{
    internal class Program
    {
        static void Main(string[] args) //프로그램을 시작하는 메소드의 시작
        {
            Console.WriteLine("주말 C# 강의 3번째 클래스");
            Console.WriteLine("반복문과 조건문");

            Console.WriteLine("실행할 강의를 선택해 주세요.(1. if조건문 / 2. switch조건문 / 3. for 반복문 / 4. while 반복문 / 5. 메인 로비) : ");
            int userinput = int.Parse(Console.ReadLine());

            if (userinput == 1)
                if조건문.Show();
            else if (userinput == 2)
                switch조건문.Show();
            else if (userinput == 3)
                for반복문.Show();
            else if (userinput == 4)
                while반복문.Show();
            else if (userinput == 5)
                메인로비.ShowMenu();
            // switch문 강의 내용
            // for문 강의 내용
            // while문 강의 내용
            // 게임 메인 화면 구성
        } //프로그램이 종료된다
    }
}
