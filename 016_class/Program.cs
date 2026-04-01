using System.Security.Cryptography.X509Certificates;

namespace _016_class //없어도 동작하지만, 헷갈리는 것을 방지하기 위해 필요하다. 
{
    //새로운 클래스를 만들려고하면 클래스 밖이나, 클래스 안이나 다른 파일에 만들어도 된다. 
    //다른 파일로 프로젝트를 만들면 파일 내에 클래스 여러개가 만들어진다. 이러면 더 편리하다.


    //3개의 함수를 포함하고 있는 클래스이다. 그 함수를 메소드라고 부르고, 변수를 필드라도 부른다. 

    internal class Program
    {
        class Date
        {
            //데이터(필드, 속성 = 다른 말로는 변수라고 한다.) 
            private int year, month, day; //public도 가능하지만, 이상한 값을 저장할 수 있으니 대부분은  private로 사용된다. 
            // 변수는 모두 private로 설정한다. 

            //동작(메소드 = 다른 말로는 함수라고 한다.) 세터(setter) , 게터 (getter)
            public void SetYear(int year) //public를 붙이지 않으면 사용할 수 없다. 공용화장실처럼 누구나 사용할 수 있다. 
            {

                //void 함수는 리턴값이 없는 함수이다. 
                //함수로하면 말도 안되는 값으로 설정되는 것을 방지한다. 
                // 
                this.year = year;
            }

            public int GetYear() { return this.year; } //this는 이 클래스 안에 있는 year을 의미한다. 가져오는 year이다. 
        }
     static void Main(string[] args)
        {
            Date birthday = new Date(); //객체 만드는 방법 Random r = new random();66666666

            birthday.SetYear(2006);
            //Console.WriteLine("나는 {0}년 생입니다.", birthday.year);
            Console.WriteLine("나는 {0}년 생입니다.", birthday.GetYear());


            //클래스 안에 있는 변수는 보호해야하기에 클래스 밖에서 만질 수 없다. 만진다면 위험하다. 
            //보호수준에서 제일 중요한 것은 클래스 밖에서 클래스 안을 마음대로 바꾸지 못한다. >> 잘못 될 수 있기 때문이다. 
            // 함수를 통해서만 고쳐라. 직접 건들기지 말고/ 함수를 쓰면 사용자의 의도를 반영할 수 있다.  
            //Class  바깥에서 객체의 필드를 함수를 통해서 한다. -> "캡슐화" 법칙이라고 한다. 이 캡슐화를 벗기려면 함수를 통해서만 사용한다.
        }
    }
}


//필드는 private로 만든다. 변수
//함수는 모두 Public이다. 동작
//필드에는 2개 이상의 함수가 필요하다. Setter, Getter가 필요한다. 변수를 읽는 
//값과 불러오는 값이 필요하다.
//생성자 함수 -> 객체가 생성될 때 자동으로 실행된다. 
//생성자 함수는 초기화할 때 유리하다. 
//생성자는 초기화할 때 쓰면 좋다. Setter를 쓸 필요가 없기 때문이다. 

