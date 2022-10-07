using System.Drawing;

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
    }
    //6.6.1
    class TrafficLight
    {
        private void ChangeColor(string color)
        {

        }
        public string GetColor()
        {
            string color = "color";
            return color;
        }
    }
    //6.6.2
    class User
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if(value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее 3 символов длиинной");
                }
                else
                {
                    login = value;
                }
            }
        }
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if(!value.Contains('@'))
                {
                    Console.WriteLine("Неверный формат адреса электронной почты");
                }
                else
                {
                    email = value;
                }
                    
            }
        }
    }
    //Example private/public
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }

    class Car
    {
        private double Fuel;

        private int Mileage;

        private string color;

        private TurnDirection turn;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            color = "White";
        }

        private void Move()
        {
            // Move a kilometer
            Mileage++;
            Fuel -= 0.5;
        }

        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }

        public string GetColor()
        {
            return color;
        }

        public void ChangeColor(string newColor)
        {
            if (color != newColor)
                color = newColor;
        }

        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }

        public bool IsTurningRight()
        {
            return turn == TurnDirection.Right;
        }
    }
    //6.5.2
    /*
    class Triangle
    {
        public int a;
        public int b;
        public int c;
        public int h;

        public double Square()
        {
        }
        public double Perimeter()
        {

        }
    }
    class Circle
    {
        public double radius;
        public double Square()
        {
        }

        public double Length()
        {
        }
    }
    
    class Square
    {
        public int side;
        public double Square()
        {
        }
        public double Perimeter()
        {

        }
    }*/
    class Bus
    {
        //6.3.2
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
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