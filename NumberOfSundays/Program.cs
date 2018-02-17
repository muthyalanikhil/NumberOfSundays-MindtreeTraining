using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberOfSundays
{
    class Program
    {
        public void logic()
        {
            try
            {
                int n = 0;
                Console.WriteLine("Enter start date in yyyy/mm/dd format: ");
                DateTime a = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter end date in yyyy/mm/dd format: ");
                DateTime b = Convert.ToDateTime(Console.ReadLine());

                while (a <= b)
                {
                    if (a.Day == 1)
                    {
                        if (a.DayOfWeek == DayOfWeek.Sunday)
                        {
                            a = a.AddMonths(1);
                            n++;
                        }
                        else
                        {
                            a = a.AddMonths(1);
                        }
                    }
                    else
                    {
                        a = a.AddDays(1);
                    }
                }

                Console.WriteLine("Total number of sundays falling on first of the months are: {0}", n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }
    }
}


 
