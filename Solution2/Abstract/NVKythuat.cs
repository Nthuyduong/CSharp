using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
	public class NVKythuat : Nhanvien
	{
		public int ngaycong;
		public NVKythuat();
		{

		}

		public NVKythuat(String Hoten, double LuongCB, int ngaycong)
		:base(Hoten, LuongCB)
		{
			this.ngaycong = ngaycong;
		}

		public override void Nhap()
		{
			base:Nhap();
			Console.Write("Nhap so ngay cong:")
			ngaycong.int.Parse(Console.Readline());
		}

		public override void Hienthi()
		{
			base.Hienthi();
			Console.WriteLine("So ngay cong: {0}", ngaycong);
		}

		public override double Tinhluong()
		{
			return LuongCB + (ngaycong * 100000);
		}
	}
}

