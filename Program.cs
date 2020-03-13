using System;

namespace Guessing_Game {
    class Program {
        static void Main(string[] args) {
            int low = 1;
            int high = 100;
            Random random = new Random();
            int number = random.Next(low, high);
            int guess = -1;
            int counter = 1;
            Console.WriteLine(number);

            while (guess != number) {
                Console.WriteLine("Enter your guess between " + low + " - " + high);

                // try catch to make sure its a number
                try {
                    guess = int.Parse(Console.ReadLine());
                } catch (FormatException) {
                    Console.WriteLine("Numbers only!");
                    continue;
                }

                // checking if guess is correct or outside the bounds
                // otherwise it will adjust the ranges
                if (guess == number) {
                    Console.WriteLine("Congrats! you guessed the right number in " + counter + " tries!");
                    break;
                } else if (guess > high || guess < low) {
                    Console.WriteLine("Make sure you use numbers inside the range!");
                } else {
                    if (guess > number) {
                        high = guess;
                    } else {
                        low = guess;
                    }
                }
                counter++;
            }
        }
    }
}
