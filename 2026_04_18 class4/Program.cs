namespace _2026_04_18_class4
{
    internal class Program
    {

        class Rectangle
        {
            
            public double q { get; set; }
            public double r { get; set; }

            public double GetArea()
            {
                return q * r;
            }
        }


            static void Main(string[] args)
            {
            Rectangle t = new Rectangle();
            t.q = 10;
            t.r = 100;
            Console.WriteLine("결과는 {0}", t.GetArea());


            }
        }
    }

