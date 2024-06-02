using System;
using System.Data.Common;

namespace MyFristConsoleApp
{
    internal class Program
    {
        private static void OperatorExamples()
        {
            // 이 명령문은 변수를 선언하고 3을 할당합니다.
            int width = 3;

            // ++ 연산자는 변수의 값을 1만큼 증가시킵니다.
            width++;

            // 숫자를 할당할 수 있는 변수 2개를 선언하고
            // +, * 연산자를 사용해 수를 더하고 곱해봅니다.
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            // 다음 두 명령문은 string 변수 2개를 선언하고
            // + 연산자를 사용해 두 문자열을 연결합니다.
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            // 불리언 타입의 변수는 true 혹은 false 값을 가집니다.
            bool truethValue = true;
            Console.WriteLine(truethValue);

            while (area<50)
            {
                height++;
                area = width*height;
            }

            do
            {
                width--;
                area = width * height;
            } while (area>25);

        }

        static void Main(string[] args)
        {
            OperatorExamples();
        }


    }
}
