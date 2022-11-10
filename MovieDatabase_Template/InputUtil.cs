using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase_Template
{
    internal class InputUtil
    {
        public static int SafeReadInt(int minValue, int maxValue, bool allowZero)
        {
            int inputValue = -1;
            bool validSelectionMade = false;
            while (!validSelectionMade)
            {
                string rawInputValue = Console.ReadLine();
                if (int.TryParse(rawInputValue, out _))
                {
                    inputValue = Convert.ToInt32(rawInputValue);
                    validSelectionMade = inputValue <= maxValue && inputValue >= minValue;
                    if (allowZero)
                    {
                        validSelectionMade = validSelectionMade || inputValue == 0;
                    }
                }
                if (!validSelectionMade)
                {
                    Console.WriteLine("Error: unknown option selected!");
                }
            }
            return inputValue;
        }
    }
}
