namespace Class2th__Bit_
{
    internal class Program
    {        
        // Main 함수는 프로그램의 진입점 역할을 수행하는 함수입니다.
        static void Main(string[] args)
        {
            //'변수의 이름규칙' 실수로 지움 나중에 채워넣을것

            #region 상수
            // 프로그램이 실행되는 동안 더 이상 변경할 수 없는 메모리 공간입니다.

            // const int data = 10;

            // data = 20;

            // Console.WriteLine("상수 data의 값 : " + data);

            // 상수는 메모리 공간을 생성하는 동시에 초기화해야 하며, 한 번 저장된 값은 더 이상 변경할 수 없습니다.

            // 상수의 경우 메모리 공간을 가지고 있지 않은 상수를 리터럴 상수라고하며, 메모리 공간을 가지고 있는 상수를 심볼릭 상수라고 한다.
            // data<- 심볼릭 ,10<- 리터럴


            #endregion

            #region 산술 연산자
            //int data1 = 10;
            //int data2 = 15;
            //const int data3 = 25;

            //int result1 = data1 + data2;
            //int result2 = data1 - 25;
            //int result3 = 4 * data3;
            //int result4 = data2 / data3;
            //int result5 = data3 % 7;
            //
            //Console.WriteLine("result1 의 값 : " + result1);
            //Console.WriteLine("result2 의 값 : " + result2);
            //Console.WriteLine("result3 의 값 : " + result3);
            //Console.WriteLine("result4 의 값 : " + result4);
            //Console.WriteLine("result5 의 값 : " + result5);

            #endregion

            #region 비트
            // 데이터를 나타내는 최소의 단위이며, 0 또는 1의 조합으로 논리 계산을 수행하는 단위입니다.

            // 메모리는 비트 단위로, 데이터를 저장할 수 있으며, 1개의 비트에는 0 또는 1의 값만 저장할 수 있습니다.

            #region 10진수를 2진수로 변환하는 과정
            // 10진수를 1이될 때까지 계속 2로 나누어 준 다음 나눈 위치의 나머지 값을 아래에서 위로 순서대로 정렬합니다.
            // char alphabet = 23  23을 2진수로 => 0001 0111
            #endregion

            #region 2진수를 10진수로 변환하는 과정
            // 1 byte에 2진수로 저장된 값을 2의 제곱으로 나타내며, 각각의 비트에 1이 있다면 1과 2의 제곱의 위치를 계산한 다음
            // 각각의 비트를 모두 더하여 10진수로 나타냅니다. ex) 0000 1111 을 10진수로 나타내면 15이다.
            #endregion

            #endregion

            #region 비트 연산자
            // 비트 단위로 논리 연산을 수행하기 위해 사용하는 연산자입니다.

            // int a = 15; // 0000 1111
            // int b = 10; // 0000 1010
            // // AND 연산자 
            // // 두 개의 피연산자가 모두 1이면 1을 반환하는 연산자입니다.
            // Console.WriteLine("a 변수와 b 변수를 AND 연산한 결과 : " + (a & b));
            // 
            // // OR 연산자
            // // 두 개의 피 연산자 중에 하나라도 1이 있다면 1을 반환하는 연산자입니다.
            // Console.WriteLine("a 변수와 b 변수를 OR 연산한 결과 : " + (a | b));
            // 
            // // XOR 연산자
            // // 두 개의 피연산자가 서로 같으면 0을 반환하고, 서로 다르면 1을 반환하는 연산자입니다.
            // Console.WriteLine("a 변수와 b 변수를 XOR 연산한 결과 : " + (a ^ b));
            // 
            // // NOT 연산자
            // // 피연산자의 값을 반전시키는 연산자 입니다.
            // Console.WriteLine("a 변수를 NOT 연산한 결과 : " + ~a);
            // 
            // // 첫 번째 비트는 부호를 나타내며, 첫 번째 비트에 1이 있다면 값은 음수가 됩니다.

            #endregion

            #region 시프트 연산자
            // 0과 1로 이루어진 2진수를 왼쪽 또는 오른쪽으로 원하는 자리만큼 이동하는 연산자입니다.

            // int money = 10; // 0000 1010
            // 
            // Console.WriteLine("money 변수를 왼쪽으로 2번 shift 연산한 결과 : " + (money << 2));
            // 
            // Console.WriteLine("money 변수를 오른쪽으로 2번 shift 연산한 결과 : " + (money >> 2));

            #endregion


        }
    }
}
