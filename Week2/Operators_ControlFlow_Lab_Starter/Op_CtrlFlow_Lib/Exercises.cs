using System.Collections.Generic;
using System;

namespace Op_CtrlFlow
{
    public class Exercises
    {

        /// <summary>
        /// this returns false if num 1 is equal to num 2,
        /// before determining if the modulo between
        /// these two numbers equals 0.
        ///
        /// Checks to see if num 1 is divisible by num 2
        /// but doesnt accept num 1 being equal to num 2bebeth
        ///
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the mean of the array nums
        public static double Average(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;

            double total = 0;
            foreach (int i in nums)
                total += i;
            return total / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5

        public static string TicketType(int age)
        {
            if (age < 5)
                return "Free";
            else if (age >= 5 && age <= 12)
                return "Child";
            else if (age >= 13 && age <= 17)
                return "Student";
            else if (age >= 60)
                return "OAP";
            else
                return "Standard";
        }

        public static string TicketTypeRefactored(int age)
        {
            return age >= 18 ?
                (age >= 60 ? "OAP" : "Standard") :
                (age <= 12 ? (age < 5 ? "Free" : "Child") : "Student");
        }

        public static string PracticeGrade(int mark)
        {
            return mark >= 60 ?
                (mark >= 75 ? "Pass with Distinction" : "Pass with Merit") :
                (mark < 40 ? "Fail" : "Pass");
        }

        public static string Grade(int mark)
        {
            if (mark >= 0)
            {
                if (mark >= 40)
                {
                    if (mark >= 60)
                    {
                        if (mark >= 75)
                        {
                            if (mark > 100)
                                return "ERROR, out of range";
                            return "Pass with Distinction";
                        }
                        return "Pass with Merit";
                    }
                    return "Pass";
                }
                return "Fail";
            }
            return "ERROR, out of range";
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int maxAttendees = 0;
            switch (covidLevel)
            {
                case 4:
                    maxAttendees = 20;
                    break;
                case 3:
                case 2:
                    maxAttendees = 50;
                    break;
                case 1:
                    maxAttendees = 100;
                    break;
                case 0:
                    maxAttendees = 200;
                    break;
            }
            return maxAttendees;
        }
    }
}
