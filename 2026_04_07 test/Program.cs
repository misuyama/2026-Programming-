namespace _2026_04_07_test
{


    class Circle
    {
        private double radius;
        private string color;

        public Circle (double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

      public double GetArea()
      {
          return 2 * 3.14 * radius;
      }
      
      public string Printinfo()
      {
          return color;
      }

        public void a()
        {
            Console.WriteLine($"면적은 {GetArea():F1}입니다.");
            Console.WriteLine("정보는" + Printinfo() + "입니다.");
        }


    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            Circle Hooing = new Circle(10, "빨간색");
           Console.WriteLine($"면적은 {Hooing.GetArea():F1}입니다.");
           Console.WriteLine("정보는" + Hooing.Printinfo() + "입니다.");
            Hooing.a();
        }
    }
}
