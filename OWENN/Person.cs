namespace RoomAreaCalculator
{
    public class Person
    {
        public double CalculatePersonArea(int choice)
        {
            double personArea = 0;

            switch (choice)
            {
                case 1:
                    personArea = 1.00;
                    break;
                case 2:
                    personArea = 0.90;
                    break;
                case 3:
                    personArea = 0.75;
                    break;
                default:
                    break;
            }

            return personArea;
        }
    }
}
