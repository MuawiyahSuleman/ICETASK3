namespace ICETASK3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle("MyRectangle", 5, 3);
            rect.Display();

            Circle circle = new Circle("MyCircle", 4);
            circle.Display();
        }
    }
}
