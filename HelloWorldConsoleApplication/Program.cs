using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI;

namespace HelloWorldConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Abstract Class Version (strategy pattern)--------");
            HelloWorldConsole conApp = new HelloWorldConsole();
            conApp.SetMessage("Hello World");
            conApp.ConsoleDisplay();

            HelloWorldDatabase dbApp = new HelloWorldDatabase();
            dbApp.SetMessage("Hello World");
            dbApp.ConsoleDisplay();


            Console.WriteLine("\n------- Interface Version (strategy pattern) --------");
            App newApp = new App();
            var appBehavior = ConfigurationManager.AppSettings["ProgramBehavior"];

            switch (appBehavior)
            {
                case "Console":
                    newApp.setBehavior(new ConsoleBehavior());
                    newApp.setMessage("Hello World");
                     newApp.WriteMessage();
                    break;
                case "Database":
                    newApp.setBehavior(new DatabaseBehavior());
                    newApp.setMessage("Hello World");
                    newApp.WriteMessage();
                    break;
                default:
                    newApp.setBehavior(new ConsoleBehavior());
                    newApp.setMessage("Hello World");
                    newApp.WriteMessage();
                    break;
            }

            Console.ReadKey();
        }
    }
}