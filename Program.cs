using System;
using System.Collections.Generic;

namespace ConsoleExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //1
            UpdateTheString("Happy Holidays!");


            //2
            var monthNumber  = 11;
            var monthName = DisplayMonthName(monthNumber);
            Console.WriteLine("Month " + monthNumber + ": " + monthName);

            //3
            var myText = "christmas";
            var reveredText = ReverseWord(myText);
            Console.WriteLine("My text: " + myText);
            Console.WriteLine("Reveres text: " + reveredText);


            //4
            Console.WriteLine("BMW:");
            IVehicle bmw = new BmwCar();
            bmw.Drive();
            bmw.Park();

            Console.WriteLine("AnyOtherCar:");
            IVehicle AnyOtherCar = new AnyOtherCar();
            AnyOtherCar.Drive();
            AnyOtherCar.Park();
        }


        public static void UpdateTheString(string text)
        {
            var firstChar = text[0];
            var newText =  firstChar + text + firstChar;
            Console.WriteLine(newText);
        }


        public static string DisplayMonthName(int month)
        {
            string monthName;
            switch (month)
            {
            case 1:
                monthName = "January" ;
                break;
            case 2:
                monthName = "February";
                break;
            case 3:
                monthName = "March";
                break;
            case 4:
                monthName = "April";
                break;
            case 5:
                monthName = "May";
                break;
            case 6:
                monthName = "June";
                break;
            case 7:
               monthName = "July";
                break;
            case 8:
                monthName = "August";
                break;
            case 9:
                monthName = "September";
                break;
            case 10:
                monthName = "October";
                break;
            case 11:
               monthName = "November";
                break;
            case 12:
                monthName = "December";
                break;
            default:
                monthName = "Not a valid month number";
                break;
            }
            return monthName;
        }


        public static string ReverseWord(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            
            var reverseText = new string(array);

            return reverseText;
        }

    }
}
