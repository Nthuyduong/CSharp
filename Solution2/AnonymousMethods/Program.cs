using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    internal class AnonymousMethods_KhongThamso
    {
        delegate void Display();
        delegate void DipplayWithParam(string msg, int n);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Display objDiplay = delegate ()
            {
                Console.WriteLine("Minh họa Anonymous Methods");
            };
            //gọi hàm trên
            objDiplay();
            //có thể bổ sung thêm các hàm anonymous cho objDisplay()
            objDiplay += delegate ()
            {
                Console.WriteLine("Thêm một Anonymous Methods khác");
            };
            objDiplay();
            //sử dụng delegate có tham số
            DipplayWithParam objDisplay2 = delegate (string msg, int n)
            {
                for(int i=1;i<=n;i++)
                    Console.WriteLine(i + "-" + msg);
            };
            objDisplay2("Demo anonymous methods có tham số", 3);
        }
    }
}
