namespace Classes_and_Structures
{
    public class PointC
    {
        private int x;
        private int y;
        public void SetX(int newValue)
        {
            if (newValue >= 0 && newValue <= WindowWidth) x = newValue;
            else WriteLine("Error Value : " + newValue );
        }
        public int GetX()
        {
            return x;
        }
        public void SetY(int newValue)
        {
            if (newValue >= 0 && newValue <= WindowHeight) y = newValue;
            else WriteLine("Error Value : " + newValue);
        }
        public int GetY()
        {
            return y;
        }
    }
}