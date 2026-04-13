namespace _020_RectangleP
{

    class Rectangle
    {
        // int width, height; // 필드
        public int width { get; set; } // 속성(대문자) public
        public int height { get; set; }

        public int GetArea()
        {
            return width * height;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.width = 20;
            r.height = 30;
            r.GetArea();
            Console.WriteLine("면적 = " + r.GetArea());

        }
    }
}
