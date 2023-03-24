using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{

    class OptionException : Exception
    {
        public OptionException(String message) : base(message)
        {
            Console.WriteLine(message);
        }
    }

    class SlotMachine
    {
        int coins = 0;
        char op;

        public SlotMachine(int coins)
        {
            this.coins = coins;
        }

        public void play()
        {
            var jackpot = new Random(); // Bote aleatorio al que luego se le sumara las monedas introducidas
            
            do
            {
                try
                {
                    Console.Write("Slot machine!\nDo you want to play? (Y/N): ");
                    op = Convert.ToChar(Console.ReadLine()); // Opcion introducida por el usuario
                    if (!op.Equals('Y') && !op.Equals('y') && !op.Equals('N') && !op.Equals('n'))
                    {
                        throw new OptionException($"Error! Incorrect option: {op} ");
                    }
                    else
                    {
                        if (op.Equals('Y') || op.Equals('y'))
                        {
                            var boolrand1 = new Random();
                            var boolrand2 = new Random();
                            var boolrand3 = new Random();

                            if (boolrand1.NextDouble() > 0.5 && boolrand2.NextDouble() > 0.5 && boolrand2.NextDouble() > 0.5)
                            {
                                Console.WriteLine($"Congratulations!!!. You won {Convert.ToInt32(jackpot.Next(5, 500)) + coins} coins!!");
                            }
                            else
                            {
                                Console.WriteLine("Good luck next time!!");
                            }
                        }
                    }
                }
                catch (OptionException e)
                {
                    Console.WriteLine("Enter a previously mention option to be able to play");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter a previously mention option to be able to play");
                }
            } while (!op.Equals('N') && !op.Equals('n'));
            Console.WriteLine("Good bye!");
        }
    }
}
