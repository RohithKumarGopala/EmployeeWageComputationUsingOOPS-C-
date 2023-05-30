using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    
     public class Employee {
        public void EmpDailyWage()
        {
            //define constants
            int IS_FULL_TIME = 1;
            int Emp_Rate_Per_Hr = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            //random function is to create random numbers
            Random random = new Random();
            //
            int empCheck = random.Next(0, 2);
            //use if else statement to check if employee is present or absent

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}


