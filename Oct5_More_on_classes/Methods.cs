namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void move(int x, int y) { 
        this.X = x; 
        this.Y = y; 
        }

        public void move(Point newLocation)
        {
            if(newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            move(newLocation.X, newLocation.Y);
            //this.X = newLocation.X;  Not a good practice
            //this.Y = newLocation.Y; 
        }
    }
}