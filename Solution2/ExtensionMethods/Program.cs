using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ExtensionExample
    {
        public static string FirstLetrerLower(this string str)
        {
            if(str.Length>0)
            {
                char[] s = str.ToCharArray();
                s[0] = char.ToLower(s[0]);
                return new string(s);
            }
            return str;
        }
        //áp dụng extension menthods cho các lớp Generic
        public static List<T> RemoveDuplicate<T>(this List<T> list)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if(!result.Contains(item))
                    result.Add(item);
            }    
            return result;
        }    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "Viet Nam";
            Console.WriteLine(country.FirstLetrerLower());
            //sử dụng hàm bổ sung cho lớp List
            List<string> Students = new List<string>();
            Students.Add("Hoa");
            Students.Add("Hoat");
            Students.Add("Hoa");
            Students.Add("Tuan");
            Students.Add("Dat");
            Students.Add("Tuan");
            List<string> Students2 = Students.RemoveDuplicate();
            Console.WriteLine("List after Remove Duplicate");
            foreach(string student in Students2)
            {
                Console.WriteLine(student);
            }    
        }
    }
}
