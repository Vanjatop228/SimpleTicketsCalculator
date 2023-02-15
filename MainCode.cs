using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seats = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < seats.Length; i++)
                {
                    Console.WriteLine($"In {i + 1} free {seats[i]}");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Enter");
                Console.WriteLine("\n\n1 - 1\n\n2 - exit.\n\n");
                Console.Write("Enter a command: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSeat, userPlace;
                        Console.Write("In what seat you want to fly?");
                        userSeat = Convert.ToInt32(Console.ReadLine()); 
                        if (seats.Length <= userSeat || userSeat < 0)
                        {
                            Console.WriteLine("Error"); 

                            
                        }
                        Console.Write("How much seat you need?");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (seats[userSeat] < userPlace || userPlace < 0)
                        {
                           Console.WriteLine($"In sector " +
                               $"{userSeat} not enought seats Seats: {seats[userSeat]}");
                            break;
                        }
                        seats[userSeat] -= userPlace;
                        Console.WriteLine(seats[userSeat]);
                        break;

                    case 2:
                        isOpen = false;
                        Console.Clear();
                        break;
                }

                 
                Console.ReadKey();
                Console.Clear();
            }
        } 
    }
}
