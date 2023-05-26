namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var takeName = Console.ReadLine();
            Console.WriteLine("Hello" + takeName);
            Console.WriteLine("...............");
            Console.WriteLine("Please enter your password");
            var password = Console.ReadLine();
            Console.WriteLine("Welcome" + password);
            Console.ReadKey();

        }
    }
}