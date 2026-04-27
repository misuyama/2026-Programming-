using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __26_04_27_FireBase // 언더바 2개 확인!
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Form1.cs와 네임스페이스가 같아야 여기서 에러가 안 납니다.
            Application.Run(new Form1());
        }
    }
}