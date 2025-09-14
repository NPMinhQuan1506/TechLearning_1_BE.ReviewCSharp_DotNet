using BasicPractice.Monitor;
using System.Text;

namespace BasicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;  
            Console.InputEncoding = Encoding.UTF8;  
            MenuMonitor menu = new MenuMonitor();
            menu.show();
        }
    }
}
