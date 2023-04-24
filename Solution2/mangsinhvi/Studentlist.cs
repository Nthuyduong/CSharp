using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangsinhvi;
class Studentlist
{
    //Tao mang 10 sinh vien
    Student[] arr;
    int n;

    public Studentlist()
    {
        n=0;
        arr = new Student[10];
    }

    public void AddStudent()
    {
       
        //Nhap so luong sinh vien muon them ao mang
        do
        {
            Console.WriteLine("Nhap so luong sinh vien");
            n = int.Parse(Console.ReadLine());
        }
        while (1 > n || n > arr.Length);

        //Nhap n sinh vien bang vong lap for
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Student no {0}:", (i+1));
            arr[i] = new Student();
            arr[i].Input();
        }
    }

    //Hien thi danh sach sinh vien
    public void DisplayStudent()
    {
        if (n <= 0)
        {
            Console.WriteLine("Have no student on list");
        }
        else
        {
            Console.WriteLine("List students:");
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("Student no {0}:", i + 1);
                arr[i].Display();
            }
        }
        
    }

    //Sap xep danh sach sinh vien theo diem giam dan
    public  void ArrangeStudent()
    {
        Student temp;
        for (int i=0; i<n-1; i++)
        {
            for(int j=i+1; j<n; j++)
            {
                if (arr[i].mark < arr[j].mark)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    //Tim kiem ten sinh vien theo ho ten
    public void SearchStudent()
    {
        Console.WriteLine("Enter student's name want to search:");
        string key = Console.ReadLine();
        int dem = -1;
        for(int i = 0; i< n; i++)
        {   
            if (arr[i].name.CompareTo(key) == 0)
            {
                dem=i;
            }
            if (dem == -1)
            {
                Console.WriteLine("Không có sinh viên cần tìm");
            }
            else
            {
                Console.WriteLine("Thông tin sinh viên cần tìm là:");
                arr[dem].Display();
                Console.ReadKey();
            }
        }
    }
}

