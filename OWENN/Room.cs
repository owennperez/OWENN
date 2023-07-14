namespace RoomAreaCalculator
{
    public class Room
    {
        private double length;
        private double width;

        public Room(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }
    }
}
