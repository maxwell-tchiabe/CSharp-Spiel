using System;

namespace NumberGuesser
{
       // Main class
     class Progamm
     {
           // Main methode
         static void Main(string[] args){
            
            // var 
            string appName="NumberGuesser";
            string appNameVersion="2.0.0";
            string appAuthor="Maxwell Tchiabe";
            
            // test color
            Console.ForegroundColor = ConsoleColor.Green;

            // app info
            Console.WriteLine("{0}: Version{1}: By {2}", appName, appNameVersion,appAuthor);

            // reset text color

            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            //get users input
            string inputName= Console.ReadLine();

            Console.WriteLine("Hello{0},Let's play a game ..."inputName); 

             // init correct number
             int correctNumber= 7;

             // Init guess var
             int guess=0;

             Console.WriteLine("Guess a number beteen 1 and 10");

             //While guess is not correct
             while (guess!= correctNumber)
             {
                  // get user input
                 string input= Console.ReadLine();

                 // Make sure its a number
                 if (!int.TryParse(input,out guess))
                 {
                     PrintColorMessage(Console.Color.Red);

                     // keep going
                     continue;
                 }
                 
                 // cast to int and put in guess
                 guess = Int32.Parse(input);

                 // Match guess to correct number

                 if(guess!=correctNumber)
                 {
                     PrintColorMessage(ConsoleColor.Red,"Wrong number, please try again");
                 }

             }

             // change text color
             Console.ForegroundColor= ConsoleColor.Yellow;

             //Tell user its the right number
             Console.WriteLine("you are CORRECT!!!");

             // reset text color 
             Console.ResetColor();
             

         }
     }
}