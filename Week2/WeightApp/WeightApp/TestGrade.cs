using System;
namespace WeightApp
{
    public class TestGrade
    {
        public static string GetGrade(int mark)
        {
            return mark >= 65 ?
                (mark >= 85 ? "Distinction" : "Pass") :
                (mark <= 20 ? "Fail no retake" : "Fail with retake");
        }
    }
}