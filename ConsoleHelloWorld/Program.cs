namespace ConsoleHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int height = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.Write("Please input your name (ENG) : ");
            name = Console.ReadLine();
            //ffffffffff

            Console.WriteLine("Hello, Welcome "+name);

            Console.Write("Please fill you height(cm) : ");
            height = Convert.ToInt16(Console.ReadLine());
            int weight = height - 100;

            Console.WriteLine("You ideal weight is " + weight.ToString());


            Console.WriteLine();
            Console.WriteLine("Press any key to end program");
            Console.ReadKey();
        }
    }
}
