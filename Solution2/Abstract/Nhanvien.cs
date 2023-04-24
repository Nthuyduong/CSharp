using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract;
abstract class Nhanvien
{
    public String Hoten;
    public double LuongCB;

   public Nhanvien()
    {
   
    }

    public Nhanvien(String Hoten, double LuongCB)
    {
        this.Hoten = Hoten;
        this.LuongCB = LuongCB;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap ten nhan vien:");
        Hoten = Console.ReadLine();
        Console.Write("Nhap muc luong co ban cua nhan vien:");
        LuongCB = double.Parse(Console.ReadLine());
    }

    public virtual void Hienthi()
    {
        Console.WriteLine("Nhan vien: {0}, luong co ban: {1}", Hoten, LuongCB);
    }

    public abstract double Tinhluong();
}

