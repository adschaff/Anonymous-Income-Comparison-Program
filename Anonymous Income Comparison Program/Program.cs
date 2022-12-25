using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Title Program

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate:"); //Write the two lines for person 1 and their hourly rate
            double p1HourRate = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Hours worked per week:"); //ask for the input of their hours worked per week
            double p1WorkWeek = Convert.ToDouble(Console.ReadLine());

            //following block is the same as block 1 for person 2 
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate:"); 
            double p2HourRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            double p2WorkWeek = Convert.ToDouble(Console.ReadLine());

            //lines 29 through 35 create the total salaries against 52 weeks so that they can be compared
            Console.WriteLine("Annual salary of Person 1:");
            double p1Salary = (p1HourRate * p1WorkWeek) * 52;
            Console.WriteLine(p1Salary);

            Console.WriteLine("Annual salary of Person 2:");
            double p2Salary = (p2HourRate * p2WorkWeek) * 52;
            Console.WriteLine(p2Salary);

            //Line 36 through 41 coompares the two salaries and outputs true if person 1 makes more than person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool p1MoreThanP2 = p1Salary > p2Salary;
            Console.WriteLine(p1MoreThanP2);
            Console.ReadLine();
        }
    }
}