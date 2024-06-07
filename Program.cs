namespace Assignment5._2._2
{
    internal class Program
    {
                                                                                // Main method, the entry point of the program
        static void Main()
        {                                                                     // Display a description of the program   
            Console.Write("How many numbers to print: ");
            int numtoPrint = Convert.ToInt32(Console.ReadLine());                                   // Read the user input for the count of numbers
                                                                               // Call the recursive method to print the first 'ctr' natural numbers starting from 1
            printNatural(1, numtoPrint);
            
        }
        //start at 1 ten numbers to print
                                                                             
        static int printNatural(int startingValue, int numtoPrint)
        {                                                                                     
            if (numtoPrint < 1)
            {
                return startingValue;
            }                                                                  
            Console.Write($" {startingValue} ");                              
            numtoPrint--;                                                          
            return printNatural(startingValue + 1, numtoPrint);
        }

        
    }
}
