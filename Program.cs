
using LogicLibrary;
namespace FirstDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello, World!");
           Console.Write("Hello.....");
           Console.WriteLine();
           double ans = Math.Sqrt(100);
           Console.WriteLine(ans);
           Products obj = new Products();
           string s = obj.Greet();
           Console.WriteLine(s);
           Console.Read();

            

        }
    }

}