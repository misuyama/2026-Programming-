
   class Rectangle {
    private int width, height; //
    public Rectangle(int width, int height)
    {
        this.width = width; //this는 클래스의 변수라는 뜻을 가지고 있다. 
        this.height = height; //this는 클래스의 변수라는 뜻을 가지고 있다. 
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



class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 10); //메인 함수에서 생성한다. 
        double area = rect.GetArea();
        double peri = rect.GetPerimeter();

        Console.WriteLine("면적 : {0}\n둘레 : {1}\n",
            area, peri);


    }
}
    

