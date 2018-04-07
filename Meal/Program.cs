using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal;
            double total_meal;
            double p_p_m_c;
            double p_m_c;
            double total_bazar_cost;
            double p_p_b_c;
            double meal_cost;
            double extra;

            Console.WriteLine("Enter total Bazar Cost :");
            total_bazar_cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Total Meal : ");
            total_meal = Convert.ToDouble(Console.ReadLine());

                p_m_c = (total_bazar_cost/total_meal);
            Console.WriteLine("Enter Onc persons meal :");
            meal = Convert.ToDouble(Console.ReadLine());

            p_p_m_c = (meal * p_m_c);

            Console.WriteLine("Enter One persons Bazar Cost :");
            p_p_b_c = Convert.ToDouble(Console.ReadLine());

            meal_cost=(p_p_b_c-p_p_m_c);

            Console.WriteLine("Onc persons meal :"+meal);
            Console.WriteLine("Onc persons Bazar Cost :"+p_p_b_c);
            Console.WriteLine("Total Bazar Cost :"+total_bazar_cost);
            Console.WriteLine("Per Person meal Cost : "+p_m_c);
            Console.WriteLine("Onc persons meal Cost: "+p_p_m_c);
            if (meal_cost>=0)
            {
                Console.WriteLine("Get : "+meal_cost);
            }
            else
            {
                Console.WriteLine("Give : " + meal_cost);
            }

            Console.ReadKey();

        }
    }
}
