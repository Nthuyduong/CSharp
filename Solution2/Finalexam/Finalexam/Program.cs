namespace Finalexam;
class Program
{
    public static int Menu()
    {
        int Select;
        Console.WriteLine("--------MENU--------");
        Console.WriteLine("1. Add product record");
        Console.WriteLine("2. Display product record");
        Console.WriteLine("3. Delecte produce by ID");

        int Number = int.Parse(Console.ReadLine());
        Select = Number;
        return Select;
    }
    static void Main(string[] args)
    {
        Productlist list = new Productlist();
        int Select;
        do
        {
            Select = Menu();
            switch (Select)
            {
                case 1:
                    Console.WriteLine("Add product record");
                    break;
                case 2:
                    Console.WriteLine("Display product record");
                    break;
                case 3:
                    Console.WriteLine("Delete product by ID");
                    break;
                default:
                    Console.WriteLine("Delete product by ID");
                    break;
            }
        }
        while (Select >= 1 && Select <= 4);
    }
}

