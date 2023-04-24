using System;
namespace Abstract
{
	public class Demo
	{
		public static void Main(string[] args)
		{
			//nhan vien ky thuat
			Nhanvien nv1 = new NVKythuat;
			nv1.Nhap();
			nv1.Hienthi();

			//nhan vien kinh doanh
            Nhanvien nv2 = new NVKinhdoanh;
			nv2.Nhap();
			nv2.Hienthi();
        }
	}
}

