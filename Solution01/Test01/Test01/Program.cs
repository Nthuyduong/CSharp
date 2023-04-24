using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01;
class Program
{
    static void Main(string[] args)
    {
        //Them thu vien go tieng viet
        Console.InputEncoding = Encoding.UTF8;
        //Them thu vien hien thi tieng viet
        Console.OutputEncoding = Encoding.UTF8;

        //hien thi ra man hinh
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Lap trinh C#");

        //Khai bao bien kieu du lieu chuoi
        String hoten;
        //Hien thi moi nhap ho ten
        Console.WriteLine("Mời nhập họ tên:");
        //Nhap ho ten, tuong duong lenh hoten.NextLine()
        hoten = Console.ReadLine();
        //Hien thi ho ten
        Console.WriteLine("Ten toi la" + hoten);

        //Khai bao kieu du lieu dang int
        int tuoi;
        //Moi nhap tuoi
        Console.WriteLine("Moi nhap tuoi");
        //Input tuoi, chu y doi kieu du lieu tu chuoi sang so
        tuoi = Convert.ToInt32(Console.ReadLine());
        //cach 2
        tuoi = int.Parse(Console.ReadLine());
        Console.WriteLine("Nam nay toi: {0}", tuoi);
        //Console.WriteLine("Ban {0} nam nay {1}", hoten, tuoi);
        //Dung man hinh de doc dong duoc hien thi ra
        Console.ReadKey();
    }
}

