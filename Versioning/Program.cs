using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versioning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This Question:
             * https://stackoverflow.com/questions/826777/how-to-have-an-auto-incrementing-version-number-visual-studio
             * 
             * Leads to this:
             * https://docs.microsoft.com/en-us/visualstudio/modeling/writing-a-t4-text-template?view=vs-2019
             * 
             * Interesting!
             * So this project is an example of automatic versioning.
             */
            System.Diagnostics.Debug.WriteLine("Version Testing.");
            Console.WriteLine("Version Testing.\n\r");

            System.Diagnostics.Debug.WriteLine("The version of the currently executing assembly is: {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            Console.WriteLine("The version of the currently executing assembly is: {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);

            Console.ReadKey();
        }
    }
}
