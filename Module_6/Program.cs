//using System;

//namespace Module_6
//{
//	class Human
//	{
//		// Поля класса
//		public string name;
//		public int age;

//		// Метод класса
//		public void Greetings()
//		{
//			Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
//		}

//		// Конструктор 1
//		public Human()
//		{
//			name = "Неизвестно";
//			age = 20;
//		}
//		// Конструктор 2
//		public Human(string n)
//		{
//			name = n;
//			age = 20;
//		}
//		// Конструктор 3
//		public Human(string n, int a)
//		{
//			name = n;
//			age = a;
//		}
//	}

//	struct Animal
//	{
//		// Поля структуры
//		public string type;
//		public string name;
//		public int age;

//		// Метод структуры
//		public void Info()
//		{
//			Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
//		}
//	}
//	class Pen
//	{
//		// Поля класса
//		public string color;
//		public int cost;

//		// Конструктор 1
//		public Pen()
//		{
//			color = "Черный";
//			cost = 100;
//		}

//		// Конструктор 2
//		public Pen(string penColor, int penCost)
//		{
//			color = penColor;
//			cost = penCost;
//		}
//	}
//	class Rectangle
//	{
//		// Поля класса
//		public int a;
//		public int b;

//		// Метод структуры
//		public int Square()
//		{
//			Console.WriteLine("Сторона a = {0}\nСторона b = {1}\nПлощадь = {2}", a, b, a * b);

//			return a * b;
//		}

//		// Конструктор 1
//		public Rectangle()
//		{
//			a = 6;
//			b = 4;
//		}

//		// Конструктор 2
//		public Rectangle(int side)
//		{
//			a = side;
//			b = side;
//		}

//		// Конструктор 3
//		public Rectangle(int first, int second)
//		{
//			a = first;
//			b = second;
//		}
//	}

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			//Human human = new Human();
//			//human.Greetings();

//			//human = new Human("Дмитрий");
//			//human.Greetings();

//			//human = new Human("Дмитрий", 23);
//			//human.Greetings();

//			//Инициализатор
//			Human human = new Human { name = "Дмитрий", age = 23 };
//			human.Greetings();

//			Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
//			animal.Info();

//			Rectangle rectangle = new Rectangle();
//			rectangle.Square();

//			rectangle = new Rectangle { a = 5, b = 5 };
//			rectangle.Square();

//			rectangle = new Rectangle { a = 7, b = 8 };
//			rectangle.Square();

//			Console.ReadKey();
//		}
//	}
//}
