namespace _019_04_08_Calculator
{
    class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("0으로 나누지 마세요.");
                return 0;
            }
            else
            {
                return a / b;
            }
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 6.3;
            double y = 9.2;

            double sum = Calculator.Add(x, y);
            double diff = Calculator.Subtract(x, y);
            double prod = Calculator.Multiply(x, y);
            double quot = Calculator.Divide(x, y);


            //{0:F2} 소수점 자리 쓰는 방법

            Console.WriteLine("덧셈 : {0:F2}",  sum);
            Console.WriteLine("뺄셈 :  {0:F2}" , diff);
            Console.WriteLine("곱셈 : {0:F2} " ,  prod);
            Console.WriteLine("나눗셈 : {0:F2}" , quot); 

            
           
        }
    }
}

