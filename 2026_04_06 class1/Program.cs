using System.Xml.Linq;

namespace _2026_04_06_class1
{

    class Student
    {
        private int age;
        private string major;
        private string name;
        public Student (string name, int age , string major)
        {
            this.age = age;
            this.major = major;
            this.name = name;

        }

        public string Getname()
        {
            return name;
        }

        public int Getage()
        {
            return age;

        }
        public string Getmajor()
        {
            return major;

        }

        public void Displayinfo ()
        {
           
            Console.WriteLine("이름 {0}, 나이 {1}, 전공 {2}", name, age, major);

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student it = new Student("김태우" , 23 ,"의료it");
            it.Displayinfo();
        }
    }
}
