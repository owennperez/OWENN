using System;

namespace RoomAreaCalculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Hello Goodday, Welcome to Room Area Calculator");
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter room length (in meters): ");
                double lengthRoom = double.Parse(Console.ReadLine());

                Console.Write("Enter room width (in meters): ");
                double widthRoom = double.Parse(Console.ReadLine());

                int choice = 0;

                while (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Choose the average size of people with a small space:");
                    Console.WriteLine("1. Adult men (1.00 m)");
                    Console.WriteLine("2. Adult women (0.90 sq. m)");
                    Console.WriteLine("3. Children (0.75 sq. m)");
                    Console.Write("Enter your choice (1, 2, or 3): ");

                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        choice = 0;
                    }
                }

                Room room = new Room(lengthRoom, widthRoom);
                double areaRoom = room.CalculateArea();

                Person person = new Person();
                double personArea = person.CalculatePersonArea(choice);

                double numberPeople = Calculator.CalculateNumberOfPeople(areaRoom, personArea);

                Console.WriteLine($"Dear {name}, the room has an area of {areaRoom:F2} square meters.");
                Console.WriteLine($"An average of {numberPeople} people can fit in the room.");
                Console.WriteLine($"Thank you, {name}!");

                Console.Write("Do you want to enter another set of data? (Y/N) ");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("THANK YOU FOR USING THE AREA CALCULATOR!");

            int[] numberOfPeopleArray = { 5, 3, 7, 2, 4 };

            Console.WriteLine("\nNumber of people for each room:");
            for (int i = 0; i < numberOfPeopleArray.Length; i++)
            {
                Console.WriteLine($"Room {i + 1}: {numberOfPeopleArray[i]}");
            }
        }
    }
}
