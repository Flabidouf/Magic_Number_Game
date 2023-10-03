using System;

namespace magic_number
{
    class Program
    {
   
        static int AskNumber(int min, int max)
        {
            int user_nb = 0;

            while ((user_nb < min) || (user_nb > max))
            {
                Console.Write($"Choose a number between {min} and {max} \n");               
                string answer = Console.ReadLine();

                try  
                {
                    user_nb = int.Parse(answer);

                    if(user_nb < 0)
                    {
                        Console.WriteLine("Error, enter a positive number");
                        user_nb = 0; // To force reloop
                    }

                    else if ((user_nb < min) || (user_nb > max))
                    {
                        Console.WriteLine($"Error, enter a number between {min} and {max}");
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Error, you have to enter a valid number");
                }
                
            }

            return user_nb;
            
        }

        
        /*static void ShowNumber(int nb)
        {
            Console.WriteLine();
            Console.WriteLine($"Your number is {nb}");
        }*/

        static void Main(string[] args)
        {
            Random rand = new Random();
      
            const int MIN = 1;
            const int MAX = 10;

            int MAGIC_NUMBER = rand.Next(MIN, MAX + 1);

            int number = MAGIC_NUMBER+1;

            int nbLives = 4;
           

            while (nbLives > 0) {

                Console.WriteLine("You have " + nbLives + " lives left.");
                Console.WriteLine();
                number = AskNumber(MIN, MAX);
                
                    if (MAGIC_NUMBER > number)
                    {
                        Console.WriteLine("The number is higher my g");                  
                    }
                    else if (MAGIC_NUMBER < number)
                    {
                        Console.WriteLine("The number is lower my g");                    
                    }
                    else
                    {
                        Console.WriteLine("Dang dude ! You found the magic number ! \nYou be a calculator ?");
                        break;
                    }

                nbLives--;
            }

            if (nbLives == 0)          
            {
                Console.WriteLine("You lost my man, just try harder, you can do it. The correct number was : " + MAGIC_NUMBER);
            }
              
           
        }
    }
}

