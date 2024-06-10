using HW_ParallelSum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Classes
{
    public class MyInputDataConsole : IInputData
    {
        public void InitializeInputThreadsCount()
        {
            Console.Write("Задайте количество потоков - ");
        }
        public int InputThreadsCountWithCheck()
        {
            string input = Console.ReadLine();
            int number;
            bool isNaturalNumber = false;
            if (int.TryParse(input, out number))
            {
                if (number > 0)
                    isNaturalNumber = true;
            }
            while (!isNaturalNumber)
            {
                Console.Write("Неправильный ввод данный! Нужно ввести именно НАТУРАЛЬНОЕ ЧИСЛО! - ");
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number > 0)
                        isNaturalNumber = true;
                }
            }
            return number;
        }
    }
}
