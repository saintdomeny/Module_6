namespace Module_6
{
    class Rectangle
    {
        public int a;
        public int b;

        //Метод
        public int Square()
        {
            return a * b;
        }
        //Конструктор 1
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        //Конструктор 2
        public Rectangle(int side)
        {
            a = side;
            b = side;
        }
        //Конструктор 3
        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        class Pen
    {
        public string color;
        public int cost;

        //Конструктор 1
        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        //Конструктор 2
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}