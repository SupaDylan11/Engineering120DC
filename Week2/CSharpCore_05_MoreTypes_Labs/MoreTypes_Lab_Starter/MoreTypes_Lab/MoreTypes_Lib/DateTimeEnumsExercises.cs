using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS,             //0
        CLUBS,                //1
        DIAMONDS,       //2
        SPADES              //3
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (birthDate > date)
                throw new ArgumentException("Error - birthDate is in the future");
            else if (birthDate.Month > date.Month)
                return date.Year - birthDate.Year - 1; // you do want to take a year away
            else
                return date.Year - birthDate.Year;
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            if (date.Month == 1)
                return "January";
            else if (date.Month == 2)
                return "February";
            else if (date.Month == 3)
                return "March";
            else if (date.Month == 4)
                return "April";
            else if (date.Month == 5)
                return "May";
            else if (date.Month == 6)
                return "June";
            else if (date.Month == 7)
                return "July";
            else if (date.Month == 8)
                return "August";
            else if (date.Month == 9)
                return "September";
            else if (date.Month == 10)
                return "October";
            else if (date.Month == 11)
                return "November";
            else
                return "December";
        }


        //        [TestCase(Suit.CLUBS, "And the seventh rule is if this is your first night at fight club, you have to fight.")]
        //        [TestCase(Suit.DIAMONDS, "Diamonds are a girls best friend")]
        //        [TestCase(Suit.HEARTS, "You've broken my heart")]
        //        [TestCase(Suit.SPADES, "Bucket and spade")]
        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            if (suit == Suit.HEARTS)
                return "You've broken my heart";
            else if (suit == Suit.CLUBS)
                return "And the seventh rule is if this is your first night at fight club, you have to fight.";
            else if (suit == Suit.DIAMONDS)
                return "Diamonds are a girls best friend";
            else
                return "Bucket and spade";
        }
    }
}
