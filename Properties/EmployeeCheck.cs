﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewagecomput288
{ 
        public class EmployeeCheck
        {
            public static void attendence(int EmpRate)
            {
                int FullTime = 1;
                int PartTime = 2;
                int EHours = 0;
                int EWage = 0;
                //int EmpRate = 20;
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                if (Empcheck == FullTime)
                {
                    Console.WriteLine("the Employee is present");
                    EHours = 8;

                }
                else if (Empcheck == PartTime)
                {
                    Console.WriteLine("Emp is part time present ");
                    EHours = 4;
                }
                else
                {
                    Console.WriteLine("Employee is absent");
                    EHours = 0;
                }
                EWage = EHours * EmpRate;
                Console.WriteLine("Emp Wages is " + EWage);


            }
        }
    }


