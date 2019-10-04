using System;

namespace Chapter7Exercise36
{
    class Program
    {
        static void Tower(int sz, short startPeg, short endPeg, short tempPeg)
        {
            //Prints direction from the starting peg to the ending peg if the size is 1
            if (sz == 1)
            {
                Console.WriteLine("{0} --> {1}", startPeg, endPeg);
            }

            //This calls Tower recursively until the sz argument is 1
            //Then prints the direction from starting peg to ending peg for the size that was passed in
            //Finally, it calls the Tower function recursively to take care of any disks on the temporary peg.
            else
            {
                Tower(sz - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine("{0} --> {1}", startPeg, endPeg);
                Tower(sz - 1, tempPeg, endPeg, startPeg);
            }
            
        }//end Tower
        static void Main(string[] args)
        {
            //Variable to hold the tower's size
            int size;

            //Asks user to enter the value for the size variable
            Console.Write("Enter the size of the tower: ");
            
            //Asks user for a valid value continuously while the entered value is not valid
            while(!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid number. Please try again.");
                Console.Write("Enter the size of the tower: ");
            }

            //Call to the Tower function
            Tower(size, 1, 3, 2);
        }//end Main
    }
}
