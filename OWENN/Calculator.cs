namespace RoomAreaCalculator
{
    public class Calculator
    {
        public static double CalculateNumberOfPeople(double areaRoom, double personArea)
        {
            return System.Math.Floor(areaRoom / personArea);
        }
    }
}
