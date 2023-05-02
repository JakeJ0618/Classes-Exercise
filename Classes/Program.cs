using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           Car sedan = new Car();
            sedan.Make = "Chevy";
            sedan.Model = "Impala";
            sedan.Year = "1967";

            Console.WriteLine($"{sedan.Year} {sedan.Make} {sedan.Model}");

        }
      
        
    }
}
