using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class Form1 : Form
    {

       static double lengthOfShipsSuperStructure, widthOfShipsSuperStructure, heightOfShipsSuperStructure;
       static double lengthOfShip, widthOfShip, depthOfShip, displacementSalt, displacementFresh;
        static double blockCoefficent = .753, netRegistaredTonnes;
        public Form1()
        {
            InitializeComponent();
            DisplayOpeningScreen();
            DisplayClosingScreen();
        }


       
        /// <summary>
        /// txt Step 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\tWelcome to my Displacement and Net Registered Tons App.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to sail on.");
            Console.ReadKey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tThanks for using my Displacement and Net Registered Tons App.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayHeader("Ships Displacement and Net Registered Tonnage");

            Console.WriteLine("A Ship with your parameters in salt water");
            Console.WriteLine($"has a displacement of {displacementSalt} cubic feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A Ship with your parameters in Fresh water");
            Console.WriteLine($"has a displacement of {displacementFresh} cubic feet.");

            Console.WriteLine("A Ship with your parameters");
            Console.WriteLine($"has a Net Registered Ton of {netRegistaredTonnes} tons.");


            DisplayContinuePrompt();
        }

        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tThanks for using my Displacement and Net Registered Tons App.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double lengthOfShip, widthOfShip, depthOfShip;
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            string userResponse;
            double lengthOfShipsSuperStructure, widthOfShipsSuperStructure, heightOfShipsSuperStructure;



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

        private void button2_Click(object sender, EventArgs e)
        {        
            
            DisplayHeader("Processing Your Displacement an Net Registered Tonnage Parameters");
            displacementSalt = lengthOfShip * widthOfShip * depthOfShip * blockCoefficent / 0.9912;
            displacementFresh = lengthOfShip * widthOfShip * depthOfShip * blockCoefficent / 1.01952;

            netRegistaredTonnes = (((.506 * lengthOfShip * widthOfShip * depthOfShip) + (lengthOfShipsSuperStructure * widthOfShipsSuperStructure * heightOfShipsSuperStructure) / 100) * .9);

            Console.WriteLine("All Processed");
            DisplayContinuePrompt();
        }
    }
}
