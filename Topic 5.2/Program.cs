namespace Topic_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;
            int bet;
            int grade1;
            string dogName;
            int temp;
            int age;

            Console.WriteLine("What is you grade");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 50)
                Console.WriteLine("You passed!");
            else
                Console.WriteLine("Better luck next time");

            Console.WriteLine("How much do you want to bet?");
            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine("You bet " + bet.ToString("C"));
            }
            else
            {
                Console.WriteLine("That's not a valid number.");
                Console.WriteLine("Your bet will be set to the minimum of $1.00.");
                bet = 1;
            }

            Console.WriteLine("What was your grade");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade < 50)
            
                Console.WriteLine("That's an F!");

            
            else if (grade <= 65)
            
                Console.WriteLine("That's a D!");
            
            else if (grade <= 75)
            
                Console.WriteLine("That's a C!");
            
            else if (grade <= 85)
            
                Console.WriteLine("That's a B!");
            
            else if (grade > 85)
            
                Console.WriteLine("That's a A!");

            Console.WriteLine("Which name is a dog name?");
            Console.WriteLine("Dagger, Max, John, Dan");
            dogName = Console.ReadLine();
            if (dogName == "Dagger")
            {
                Console.WriteLine("That's not one!");
            }
            if (dogName == "Max")
            {
                Console.WriteLine("You got it!");
            }
            if (dogName == "John")
            {
                Console.WriteLine("That's not one!");
            }
            if (dogName == "Dan")
            {
                Console.WriteLine("That's not one!");
            }

            Console.WriteLine("What's the temprature of the water?");
            int.TryParse (Console.ReadLine(), out temp);
            if (temp < 0)
            
                Console.WriteLine("It's ice!");
            
            else if (temp <100)
            
                Console.WriteLine("It's water!");
            else if (temp > 100)

                Console.WriteLine("It's gas!");

            Console.WriteLine("How old are you?");
            int.TryParse(Console.ReadLine(), out age);
            if (age < 16)
            {
                Console.WriteLine("You can't drive");
            }
            else if (age <= 17)
            {
                Console.WriteLine("You can drive but not vote");
            }
            else if (age <= 24)
            {
                Console.WriteLine("You can vote but not rent a car");
            }
            else if (age >= 25)
            {
                Console.WriteLine("You can do pretty much anything");
            }
        }
    }
} 