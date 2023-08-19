using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = -5;
            int num2 = 10;
            // long으로 적었는데 오류가 나서 ulong으로 사용함. 큰 수를 사용할 때 사용하며 value 끝에 L을 붙여주어야 한다.
            ulong bigNum = 10000000000000000000L;
            short smallNum = 5000;
            byte byteNum = 250;
            bool logic1 = true;
            bool logic2 = false; 
            // 코드를 분기하고자 할 때(if) boolean 값을 많이 사용한다.
            string strsdf = "abc";
            // char은 ""이 아니라 ''으로 사용해야 한다.
            char str1 = 'b';
            // float 소수점을 사용할 때 사용하며, 값 끝에 F를 붙여주어야 한다.
            float fit = 0.5F;
            // 소수점에서 큰 숫자를 사용할 때는 double를 사용한다.
            double doublenum = 0.555555555555555D;
            // 반올림 되서 나온다.
            float doublenum2 = 0.555555555555555F;
            Console.WriteLine(num2);
            Console.WriteLine(num1);
            Console.WriteLine(bigNum);
            Console.WriteLine(smallNum);
            Console.WriteLine(byteNum);
            Console.WriteLine(logic1);
            Console.WriteLine(logic2);
            Console.WriteLine(strsdf);
            Console.WriteLine(str1);
            Console.WriteLine(fit);
            Console.WriteLine(doublenum);
            Console.WriteLine(doublenum2);

            int a = 5;
            int b = 6;
            b = a;
            // cw하면 자동생성됨!
            System.Console.WriteLine(a);
            // 형변환을 통해 문자 타입에 숫자 타입을 저장하는 방법
            string c = "";
            c = b.ToString();
            System.Console.WriteLine(c);
            // 형변환을 통해 숫자 타입에 문자로 된 숫자를 저장하는 방법
            int num = Int32.Parse(c);
            System.Console.WriteLine(num);
        }
    }
}   
// 주석 ctrl + k + c 키
// 주석 해제 ctrl + k + u 키
//