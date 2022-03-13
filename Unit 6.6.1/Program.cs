//using System;

//namespace Unit_6._6._1
//{
//    enum TurnDirection
//    {
//        None = 0,
//        Left,
//        Right
//    }

//    class Car
//    {
//        private double Fuel;

//        private int Mileage;

//        private string color;

//        private TurnDirection turn;

//        public Car()
//        {
//            Fuel = 50;
//            Mileage = 0;
//            color = "White";
//        }

//        private void Move()
//        {
//            // Move a kilometer
//            Mileage++;
//            Fuel -= 0.5;
//        }

//        private void Turn(TurnDirection direction)
//        {
//            turn = direction;
//        }

//        public void FillTheCar()
//        {
//            Fuel = 50;
//        }

//        public string GetColor()
//        {
//            return color;
//        }

//        public void ChangeColor(string newColor)
//        {
//            if (color != newColor)
//                color = newColor;
//        }

//        public bool IsTurningLeft()
//        {
//            return turn == TurnDirection.Left;
//        }

//        public bool IsTurningRight()
//        {
//            return turn == TurnDirection.Right;
//        }
//    }
//    //Unit 6.6.1
//    class TrafficLight
//    {
//        private string color;
//        private void ChangeColor(string color)
//        {

//        }
//        public string GetColor()
//        {
//            return color;
//        }
//    }
//    //Свойства 
//    class User
//    {
//        private int age;
//        private string login, email;
//        public int Age
//        {
//            get
//            {
//                return age;
//            }

//            set
//            {
//                age = value;
//            }
//        }
//        public string Login
//        {
//            get
//            {
//                return login;
//            }
//            set
//            {
//                if (value.Length < 3)
//                {
//                    Console.WriteLine("Логин должен быть длиннее 3х символов");
//                }
//                else
//                {
//                    login = value;
//                }
//            }
//        }
//        public string Email
//        {
//            get
//            {
//                return email;
//            }
//            set
//            {
//                if (!value.Contains('@'))
//                {
//                    Console.WriteLine("Формат адреса электронной почты неверный");
//                }
//                else
//                {
//                    email = value;
//                }
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            User user = new User();

//            // Setter
//            user.Age = 23;

//            // Getter
//            Console.WriteLine(user.Age);

//            Console.ReadKey();
//        }
//    }
//    //Unit 6.6.5
//    class Triangle
//    {
//        private int a, b, c;

//        public int A
//        {
//            get { return a; }
//            set
//            {
//                if (value > 0 && b + c > value)
//                {
//                    a = value;
//                }
//            }
//        }
//        public int B
//        {
//            get { return b; }
//            set
//            {
//                if (value > 0 && a + c > value)
//                {
//                    b = value;
//                }
//            }
//        }
//        public int C
//        {
//            get { return c; }
//            set
//            {
//                if (value > 0 && a + b > value)
//                {
//                    c = value;
//                }
//            }
//        }
//    }
//}
