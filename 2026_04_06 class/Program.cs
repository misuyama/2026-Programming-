namespace _2026_04_06_class
{

    class Rectangle
    {
        private int width, height;  //변수를 만들어줍니다. 항상 변수는 private로 해줍니다.
        public Rectangle (int width, int height) //퍼블릭을 만들어줍니다.
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 50);
            Console.WriteLine("길이는 : {0}", r.GetArea());
            Console.WriteLine("넓이는 : {0}",r.GetPerimeter());
        }
    }
}
