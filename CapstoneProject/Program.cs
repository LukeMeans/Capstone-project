using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
// **************************************************
//
// Title: Displacement and Net Registered tonnage app
// Description: (Calculating displacment and NRT )
// Application Type: Console
// Author: (Edward Duwel)
// Dated Created: (11-30-17)
// Last Modified:(12-4-17)
//
// **************************************************
 * 
 *  Sea Water Displacement Formula:
   Displacement (Cubic Foot) = L x B x D x C / 0.9912
 *  Fresh Water Displacement Formula:
   Displacement (Cubic Foot) = L x B x D x C / 1.01952

   Variables
L stands for Length of the Ship
B stands for Breadth of the Ship
D stands for Depth or Drop of the Ship
C stands for Block Coefficient = .732
x = symbolizes as times or multiplied by
/ = symbolizes as divided by
35 = constant for body object found in Salt Water (tons)
36 = constant for body object found in Fresh Water (tons)
0.9912 = constant for body object found in Salt Water (measured capacity in cubic foot)
1.01952 = constant for body object found in Fresh Water (measured capacity in cubic foot)
*/


namespace CapstoneProject
{
    class Program
    {

  
        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMainMenu();
            DisplayClosingScreen();
        }
        /// <summary>
        /// display get hull parameters
        /// </summary>
        public static void DisplayGetHullParameters(out double lengthOfShip, out double widthOfShip, out double depthOfShip)
        {
            string userResponse;                  
            
            DisplayHeader("Ships Hull Parameters");

            Console.Write("What is the length of the ship in feet: ");

            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            while (!double.TryParse(userResponse, out lengthOfShip))
            {
                Console.WriteLine();
                Console.WriteLine("\tIt seems like you didnt enter a number.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();
                Console.Write("What is the length of the ship in feet: ");
                Console.WriteLine();
                Console.WriteLine();
                userResponse = Console.ReadLine();
                lengthOfShip = double.Parse(userResponse);
            }

            Console.Write("What is the width of the ship in feet: ");

            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            while (!double.TryParse(userResponse, out widthOfShip))
            {
                Console.WriteLine("\tIt seems like you didnt enter a number.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();
                Console.Write("What is the width of the ship in feet: ");
                Console.WriteLine();
                Console.WriteLine();
                userResponse = Console.ReadLine();
                widthOfShip = double.Parse(userResponse);
            }

            Console.Write("What is the draft of the ship in feet: ");

            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            while (!double.TryParse(userResponse, out depthOfShip))
            {
                Console.WriteLine("\tIt seems like you didnt enter a number.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();
                Console.Write("What is the draft of the ship in feet: ");
                Console.WriteLine();
                Console.WriteLine();
                userResponse = Console.ReadLine();
                depthOfShip = double.Parse(userResponse);
            }


        }
        /// <summary>
        /// display get superstructure parameters
        /// </summary>
        static void DisplayGetSuperStructureParameters(out double lengthOfShipsSuperStructure,out double widthOfShipsSuperStructure,out double heightOfShipsSuperStructure)
        {
            string userResponse;
          
            


            DisplayHeader("Ships Superstructure Parameters");

            Console.Write("What is the length of the Superstructure in feet: ");

            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            while (!double.TryParse(userResponse, out lengthOfShipsSuperStructure))
            {
                Console.WriteLine();
                Console.WriteLine("\tIt seems like you didnt enter a number.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();
                Console.Write("What is the length of the Superstructure in feet: ");
                Console.WriteLine();
                Console.WriteLine();
                userResponse = Console.ReadLine();
                lengthOfShipsSuperStructure = double.Parse(userResponse);
            }

            Console.Write("What is the width of the Superstructure in feet: ");

            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            while (!double.TryParse(userResponse, out widthOfShipsSuperStructure))
            {
                Console.WriteLine();
                Console.WriteLine("\tIt seems like you didnt enter a number.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();
                Console.Write("What is the width of the Superstructure in feet: ");
                Console.WriteLine();
                Console.WriteLine();
                userResponse = Console.ReadLine();
                widthOfShipsSuperStructure = double.Parse(userResponse);
            }

            Console.Write("What is the height of the Superstructure in feet: ");

            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            while (!double.TryParse(userResponse, out heightOfShipsSuperStructure))
            {
                Console.WriteLine();
                Console.WriteLine("\tIt seems like you didnt enter a number.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();
                Console.Write("What is the height of the Superstructure in feet: ");
                Console.WriteLine();
                Console.WriteLine();
                userResponse = Console.ReadLine();
                heightOfShipsSuperStructure = double.Parse(userResponse);
            }

        }
        /// <summary>
        /// Process Displacement Parameters
        /// </summary>
        static void ProcessDisplacementEquations(double lengthOfShip, double widthOfShip, double depthOfShip, out double displacementSalt, out double displacementFresh, double blockCoefficent)
        {           
                    

            // Sea Water Displacement Formula:
            // Displacement(Cubic Foot) = L x B x D x C / 0.9912
            DisplayHeader("Processing Your Displacement Parameters");
            displacementSalt = lengthOfShip * widthOfShip * depthOfShip * blockCoefficent / 0.9912;
            displacementFresh = lengthOfShip * widthOfShip * depthOfShip * blockCoefficent / 1.01952;

            Console.WriteLine("All Processed");
            DisplayContinuePrompt();

        }
        /// <summary>
        ///Process Net Registered Tons
        /// </summary>
        static void ProcesNetRegistaredTonnageParameters(out double netRegistaredTonnes,double widthOfShip,double lengthOfShipsSuperStructure, double depthOfShip,double widthOfShipsSuperStructure,double heightOfShipsSuperStructure,double lengthOfShip)
        {                       
            

            DisplayHeader("Processing Your Net Registered Tonnage Parameters");

            netRegistaredTonnes = (((.506 * lengthOfShip * widthOfShip * depthOfShip) + (lengthOfShipsSuperStructure * widthOfShipsSuperStructure * heightOfShipsSuperStructure) / 100) * .9);

            Console.WriteLine("All Processed");
            DisplayContinuePrompt();

        }
        /// <summary>
        /// Display Displacement
        /// </summary>
        static void DisplayDisplacement(double displacementFresh, double displacementSalt)
        {
           
           /* double displacementFresh;
            double displacementSalt;*/
            
            DisplayHeader("Ships Displacement");

            Console.WriteLine("A Ship with your parameters in salt water");
            Console.WriteLine($"has a displacement of {displacementSalt} cubic feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A Ship with your parameters in Fresh water");
            Console.WriteLine($"has a displacement of {displacementFresh} cubic feet.");

            DisplayContinuePrompt();
        }
        /// <summary>
        /// Display net registered tonnes
        /// </summary>
        static void DisplayNetRegisteredTonnes(double netRegistaredTonnes)
        {
            
           // double netRegistaredTonnes;

            DisplayHeader("Ships Net Registered Tons");

            Console.WriteLine("A Ship with your parameters");
            Console.WriteLine($"has a Net Registered Ton of {netRegistaredTonnes} tons.");
            

            DisplayContinuePrompt();

        }
        /// <summary>
        /// Display Main menu
        /// </summary>
        static void DisplayMainMenu()
        {
            
            string menuChoice;
            bool exiting = false;
             double lengthOfShipsSuperStructure = 0;
             double widthOfShipsSuperStructure = 0;
             double heightOfShipsSuperStructure = 0;
            double blockCoefficent = .753;
             double lengthOfShip= 0;
             double widthOfShip = 0;
             double depthOfShip = 0;            
             double displacementFresh = 0;
             double displacementSalt =0;
             double netRegistaredTonnes = 0;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Ships Hull Parameters");
                Console.WriteLine("\tB) Superstructure Parameters");
                Console.WriteLine("\tC) Process Displacement Parameters");
                Console.WriteLine("\tD) Process your parameters for Net Registered Tons");
                Console.WriteLine("\tE) Display Displacement  ");
                Console.WriteLine("\tF) Display Net Registared Tons ");
                Console.WriteLine("\tQ) Terminate and Quit");
                Console.Write("Enter Choice and Press Enter To Continue:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        DisplayGetHullParameters(out lengthOfShip, out widthOfShip, out depthOfShip);
                        break;

                    case "B":
                    case "b":
                        DisplayGetSuperStructureParameters(out lengthOfShipsSuperStructure, out widthOfShipsSuperStructure, out heightOfShipsSuperStructure);
                        break;

                    case "C":
                    case "c":
                        ProcessDisplacementEquations(lengthOfShip, widthOfShip, depthOfShip,out displacementSalt, out displacementFresh, blockCoefficent);
                        break;

                    case "D":
                    case "d":
                        ProcesNetRegistaredTonnageParameters(out netRegistaredTonnes, lengthOfShip, widthOfShip,  depthOfShip,  widthOfShipsSuperStructure,  heightOfShipsSuperStructure, lengthOfShipsSuperStructure);
                        break;

                    case "E":
                    case "e":
                        DisplayDisplacement(displacementFresh, displacementSalt);
                        break;

                    case "F":
                    case "f":
                        DisplayNetRegisteredTonnes(netRegistaredTonnes);
                        break;

                    case "Q":
                    case "q":
                        exiting = true;
                        break;

                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\tWelcome to my Displacement and Net Registered Tons App.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }
        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tThanks for using my Displacement and Net Registered Tons App.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to sail on.");
            Console.ReadKey();
        }
        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

    }
}
