namespace _2026_04_17_class
{

    class Rectangle
    {
        private int x, y;
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetArea()
        {
            return x * y;
        }

        public int GetSjfqdl()
        {
            return x + y;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 10);
            int q = r.GetArea();
            int w = r.GetSjfqdl();
            Console.WriteLine("넓이는" + r.GetArea());
            Console.WriteLine("합은" + r.GetSjfqdl());



            
        }
    }
}
