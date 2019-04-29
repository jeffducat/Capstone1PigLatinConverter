using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1PigLatinConverter
{
    class Methods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="option1"></param>
        /// <param name="option2"></param>
        /// <returns></returns>
        public static bool Continue(string message, string option1, string option2)
        {
            Console.Write(message);
            string response = Console.ReadLine();

            if (response == option1)
            {
                return true;
            }
            else if (response == option2)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Entry!");
                return Continue(message, option1, option2);
            }

        }
    }
}
