namespace exam2;
class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Lion(500, "Simba");
        animals[1] = new Tiger(600, "Shere Khan");

        foreach (Animal animal in animals)
        {
            animal.Show();
            Console.WriteLine();
        }
    }
}
