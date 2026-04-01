
class student
{
    private string name, major;
    private int age;
    public student(string name, int age, string major) //생성자
    {
        this.name = name;
        this.age = age;
        this.major = major;

    }

    public string Getname() { return name; }
    public int Getage() { return age; }  
    public string Getmajor() { return major; } 

    public void Displayinfo () //출력만하는 역할이다. 
    {
        Console.WriteLine("이름 : {0}\n나이 : {1}\n 전공 : {2} ", name, age, major);
        string s = string.Format("이름 : {0}\n나이 : {1}\n 전공 : {2} ", name, age, major);
        Console.WriteLine(s);
        
    }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
        student student = new student("김태우", 23, "의료it공학과");
        student.Displayinfo();
        }
    }

