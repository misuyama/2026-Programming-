namespace _2026_04_05_class
{

    class Hooing
    {
        private int x, y;

        public Hooing (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Getsum ()
        { return x + y; }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hooing sum = new Hooing(5, 4);
            Console.WriteLine("합은 {0} 이다.", sum.Getsum());
        }
    }
}
