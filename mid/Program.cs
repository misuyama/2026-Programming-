namespace mid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //정수 10개 배열
            // 랜덤 숫자 저장
            // 최대, 최소 평균 계산 

            int[] a = new int[10];
            Random r = new Random();

            for (int i = 0; i < 10; i++)
                a[i] = r.Next(100);

            int min = a[0];
            int max = a[0];
            int sum = 0;

            foreach (var i in a)
            {
                if (i < min)
                    min = i;
                else if (i > max)
                    max = i;
                sum += i;
            }
            Console.WriteLine("최소{0}. 최대 {1} , 평균 {2}", min, max, sum / 10.0);
        }
    }
    }

