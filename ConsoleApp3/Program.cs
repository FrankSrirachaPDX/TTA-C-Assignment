using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            string courseName;
            string boolHelp;
            string numHolder;
            string experience;
            string feedback;

            int pageNum = 0;
            int hoursStudy = 0;

            bool helpState = true;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            courseName= Console.ReadLine();
            Console.WriteLine("What page number?");
            numHolder= Console.ReadLine();
            pageNum = Convert.ToInt16(numHolder);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”");
            boolHelp= Console.ReadLine();
            helpState = Convert.ToBoolean(boolHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            experience= Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            feedback= Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            numHolder= Console.ReadLine();
            hoursStudy = Convert.ToInt16(numHolder);
            
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!") ;
            Console.ReadLine();

        }
    }
}
