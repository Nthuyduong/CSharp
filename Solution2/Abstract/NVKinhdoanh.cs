using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
	public class NVKinhdoanh : Nhavien
	{
		public double Doanhthu;

		public NVKinhdoanh()
		{

		}

		public NVKinhdoanh(String Hoten, double LuongCB, double Doanhthu)
            : base(string Hoten, double LuongCB)
        {
			this.Doanhthu = Doanhthu;
		}

		public override void Nhap()
		{
			base:Nhap();
			Console.WriteLine("Nhap so doanh thu:");
			Doanhthu = double.Prase(Console.ReadLine());
		}

		public override void Hienthi()
		{
			base:Hienthi();
			Console.WriteLine("So doanh thu: {0}", Doanhthu);
		}

		public override double Tinhluong()
		{
			return LuongCB + Doanhthu * 10 / 100;
		}
	}
}

