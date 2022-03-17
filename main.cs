using System;

namespace SampleApp
{


    public class Program
    {


        public static void Main(string[] args)
        {
            // What kind of sandwiches are being made
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            int numPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered:" +  861);

           // calculate the total number of slices of bread
            Console.WriteLine("number of bread slices needed");
            int numPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you Entered:" +  1722);

           // calculate the total loaves of bread
           Console.WriteLine("number of bread loaves");
            int numPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you Entered:" +  62);

            // calculate the total amount of tablespoons peanut butter
            Console.WriteLine("Enter 1 jar of peanut butter jar ");
            int numPeople = (Console.ReadLine());
            Console.WriteLine("you entered:" + 54);

          // calculate the total amount of teaspoons jelly
            Console.WriteLine("Enter 1 jar of jelly jar ");
            int numPeople = (Console.ReadLine());
            Console.WriteLine("you entered:" +  3444);

            // calculate the amount of peanut butter and jelly jars and loaves of bread
            int numOfPeople = Convert.ToInt32(Console.ReadLine());
            double breadConversion = numOfPeople * 2;
            double pbConversion = numOfPeople * 2;
            double jellyConversion = numOfPeople * 4;
            double loavesConversion = numOfPeople * 2;

            Console.WriteLine("You need: ");
            Console.WriteLine(breadConversion + " slices of bread");
            Console.WriteLine(pbConversion + "tablespoons of peanut butter");
            Console.WriteLine(jellyConversion + "teaspoons of jelly ");
            Console.WriteLine(loavesConversion + " Loaves of bread");
            
 
            while (true)
            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            string userChoice = Console.ReadLine();

            if (userChoice == "yes" || userChoice == "y");
            {
                "yes;"
            }
            else
            {
                "Goodbye;"
                       
