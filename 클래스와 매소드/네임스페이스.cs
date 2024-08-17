/*
 *  학습 목표 : 이름공간(name space) 네임스페이스에 대한 이해
 *  작성일    : 2024 08 17
 *  작성자    : 김덕진
 */

/*
 *  이름 : 다른 이름을 가짐으로써 구분할 수 있다.
 *  만약에 같은 이름이 중복되면 어떻게 될까?
 *  -> 컴파일 에러가 발생한다. (실행이 안된다.)
 *  
 *  다른 비교할 기준이 있으면 두 대상을 구분할 수 있게 된다.
 *  같은 이름을 분류하는 이름 공간
 */

/*
 *  2. 네임 스페이스 선인 방법
 *  namespace 이름공간의 이름 {    } 범위를 표현해주는 기호
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부산
{
    class 밀면
    {
        public int count;
    }
}

namespace 서울
{
    class 밀면
    {
        public int count;
    }
}

namespace 봄봄카페
{
    class 커피
    {
        public string name;
    }
}

namespace 투썸플레이스
{
    class 커피
    {
        public string name;
    }
}



namespace 클래스와_매소드
{
    internal class 네임스페이스
    {
        public void Show()
        {

            Console.WriteLine("Hello World!");

            // 1. 같은 이름이 중복되면 안되는 예시
            int num = 10;
            int num2 = 20;

            부산.밀면 noodle = new 부산.밀면();
            noodle.count = 1;
            Console.WriteLine(noodle.count);
            서울.밀면 noodle2 = new 서울.밀면();
            noodle.count = 2;
            Console.WriteLine(noodle.count);



            봄봄카페.커피 coffee = new 봄봄카페.커피();
            coffee.name = "아메리카노";
            Console.WriteLine(coffee.name);
            투썸플레이스.커피 coffee2 = new 투썸플레이스.커피();
            coffee.name = "모카커피";
            Console.WriteLine(coffee.name);

        }
    }
}
