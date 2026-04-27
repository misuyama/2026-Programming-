namespace _2026_04_18_class3
{
    internal class Program
    {

        //class 생성자함수를 이용해서 rectangle 만들어보기 
        class Rectangle
        {
            private double a, b; //변수 생성
            public Rectangle(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public double GetArea() { return a + b; }
            public double Getx() { return a - b; }


            static void Main(string[] args)
            {
                //객체 생성 random r = new random
                Rectangle r = new Rectangle(10, 50);
                double x =r.GetArea();
                r.Getx();
                Console.WriteLine("합은" + r.GetArea() +"\n" + "빼기는" + r.Getx().ToString("0.0"));
            }
        }
    }
}
