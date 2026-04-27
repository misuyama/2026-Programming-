namespace _2026_04_18_class2
{

    class Rectangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double GetArea() { 
            return a + b; 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle w = new Rectangle();
            w.a = 10;
            w.b = 20;
            Console.WriteLine("넓이는" + w.GetArea());
            
        }
    }
}
