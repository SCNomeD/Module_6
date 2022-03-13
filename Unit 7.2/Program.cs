using System;

namespace Unit_7._2
{
    #region
    //Unit 7.2.1
    //class Car
    //{
    //    public int Mileage;

    //    public Car()
    //    {
    //        Mileage = 0;
    //    }

    //    public virtual void Move()
    //    {
    //        Console.WriteLine("Вызван метод Move класса Car");
    //        Mileage++;
    //    }
    //}

    //enum FuelType
    //{
    //    Gas = 0,
    //    Electricity
    //}

    //class HybridCar : Car
    //{
    //    public FuelType FuelType;

    //    public double Gas;

    //    public double Electricity;

    //    public HybridCar()
    //    {
    //        Electricity = 50;
    //        Gas = 50;
    //    }

    //    public override void Move()
    //    {
    //        base.Move();
    //        Console.WriteLine("Вызван метод Move класса HybridCar");

    //        switch (FuelType)
    //        {
    //            case FuelType.Gas:
    //                Gas -= 0.5;
    //                break;
    //            case FuelType.Electricity:
    //                Electricity -= 0.5;
    //                break;
    //        }
    //    }

    //    public void ChangeFuelType(FuelType type)
    //    {
    //        FuelType = type;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car car = new Car();
    //        HybridCar hybridCar = new HybridCar();

    //        car.Move();         // метод класса Car
    //        hybridCar.Move();       // метод класса HybridCar

    //        Console.ReadLine();

    //        ((Car)hybridCar).Move();// метод класса HybridCar

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region
    //Unit 7.2.2
    //class BaseClass
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Метод класса BaseClass");
    //    }
    //}
    //class DerivedClass : BaseClass
    //{
    //    public override void Display()
    //    {
    //        base.Display();
    //        Console.WriteLine("Метод класса DerivedClass");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DerivedClass obj = new DerivedClass();
    //        obj.Display();

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region
    //Unit 7.2.3
    //class Citizen
    //{
    //    public virtual double Age
    //    {
    //        get;
    //        set;
    //    }

    //    public void SayYourAge()
    //    {
    //        Console.WriteLine("Мне {0} лет", Age);
    //    }
    //}

    //class CivilServant : Citizen
    //{
    //    private double age;
    //    public override double Age
    //    {
    //        get
    //        {
    //            return age;
    //        }
    //        set
    //        {
    //            if (value < 18)
    //            {
    //                Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
    //            }
    //            else
    //            {
    //                age = value;
    //            }
    //        }
    //    }
    //}

    //class President : CivilServant
    //{
    //    private double age;
    //    public override double Age
    //    {
    //        get
    //        {
    //            return age;
    //        }
    //        set
    //        {
    //            if (value < 35)
    //            {
    //                Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
    //            }
    //            else
    //            {
    //                age = value;
    //            }
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region
    //Unit 7.2.4
    //class BaseClass
    //{
    //    public virtual int Counter
    //    {
    //        get;
    //        set;
    //    }
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Метод класса BaseClass");
    //    }
    //}
    //class DerivedClass : BaseClass
    //{
    //    private int counter;
    //    public override int Counter
    //    {
    //        get
    //        {
    //            return counter;
    //        }
    //        set
    //        {
    //            if (value >= 0)
    //            {
    //                counter = value;
    //            }
    //        }
    //    }
    //    public override void Display()
    //    {
    //        Console.WriteLine("Метод класса DerivedClass");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region
    //Unit 7.2.6
    //class A
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Вызван метод класса A");
    //    }
    //}
    //class B : A
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Вызван метод класса B");
    //    }
    //}
    //class C : B
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("Вызван метод класса C");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A a = new A();
    //        B b = new B();
    //        C c = new C();

    //        a.Display();    // метод класса A
    //        b.Display();    // метод класса B
    //        ((A)b).Display();  // метод класса B

    //        c.Display();    // метод класса C
    //        ((A)c).Display();  // метод класса B
    //        ((B)c).Display();  // метод класса B
    //    }
    //}
    #endregion
    #region
    //Unit 7.2.7
    //class A
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("A");
    //    }
    //}
    //class B : A
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}
    //class C : A
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}
    //class D : B
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("D");
    //    }
    //}
    //class E : C
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("E");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A a = new A();
    //        B b = new B();
    //        C c = new C();
    //        D d = new D();
    //        E e = new E();

    //        a.Display();    // метод класса A
    //        b.Display();    // метод класса B
    //        c.Display();    // метод класса C
    //        d.Display();    // метод класса D
    //        e.Display();    // метод класса E
    //    }
    //}
    #endregion
    #region
    //Unit 7.2.7-->
    //class Vector
    //{
    //    public int X;
    //    public int Y;

    //    Vector Add(Vector second)
    //    {
    //        return new Vector
    //        {
    //            X = this.X + second.X,
    //            Y = this.Y + second.Y
    //        };
    //    }
    //    public static Vector operator + (Vector a, Vector b)
    //    {
    //        return new Vector
    //        {
    //            X = a.X + b.X,
    //            Y = a.Y + b.Y
    //        };
    //    }
    //    public static Vector operator + (Vector a)
    //    {
    //        return new Vector
    //        {
    //            X = a.X,
    //            Y = a.Y
    //        };
    //    }
    //    public static Vector operator + (Vector a, (int X, int Y) b)
    //    {
    //        return new Vector
    //        {
    //            X = a.X + b.X,
    //            Y = a.Y + b.Y
    //        };
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Vector a = new Vector { X = 3, Y = 5 };
    //        Vector b = new Vector { X = 7, Y = 13 };
    //        Vector c = a + b;
    //        Vector d = +a;
    //        Vector e = a + (10, -5);

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region
    //class Obj
    //{
    //    public int Value;

    //    public static Obj operator +(Obj a, Obj b)
    //    {
    //        return new Obj
    //        {
    //            Value = a.Value + b.Value
    //        };
    //    }
    //    public static Obj operator -(Obj a, Obj b)
    //    {
    //        return new Obj
    //        {
    //            Value = a.Value - b.Value
    //        };
    //    }
    //}
    #endregion
    #region
    //// Класс для объекта “Книга”
    //class Book
    //{
    //    public string Name;
    //    public string Author;
    //}

    //// Класс для объекта “Коллекция книг”
    //class BookCollection
    //{
    //    // Закрытое поле, хранящее книги в виде массива
    //    private Book[] collection;

    //    // Конструктор с добавлением массива книг
    //    public BookCollection(Book[] collection)
    //    {
    //        this.collection = collection;
    //    }

    //    // Индексатор по массиву
    //    public Book this[int index]
    //    {
    //        get
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                return collection[index];
    //            }
    //            else
    //            {
    //                return null;
    //            }
    //        }

    //        private set
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                collection[index] = value;
    //            }
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var array = new Book[]
    //        {
    //        new Book
    //        {
    //            Name = "Мастер и Маргарита",
    //            Author = "М.А. Булгаков"
    //        },
    //        new Book
    //        {
    //            Name = "Отцы и дети",
    //            Author = "И.С. Тургенев"
    //        },
    //        };

    //        BookCollection collection = new BookCollection(array);
    //        Book book = collection[1];

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region
    //class Book
    //{
    //    public string Name;
    //    public string Author;
    //}

    //class BookCollection
    //{
    //    private Book[] collection;

    //    public BookCollection(Book[] collection)
    //    {
    //        this.collection = collection;
    //    }

    //    // Индексатор по массиву
    //    public Book this[int index]
    //    {
    //        get
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                return collection[index];
    //            }
    //            else
    //            {
    //                return null;
    //            }
    //        }

    //        private set
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                collection[index] = value;
    //            }
    //        }
    //    }

    //    public Book this[string name]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < collection.Length; i++)
    //            {
    //                if (collection[i].Name == name)
    //                {
    //                    return collection[i];
    //                }
    //            }

    //            return null;
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        var array = new Book[] {
    //        new Book { Name = "Мастер и Маргарита", Author = "М.А. Булгаков" },
    //        new Book { Name = "Отцы и дети", Author = "И.С. Тургенев" },
    //    };
    //        BookCollection collection = new BookCollection(array);

    //        Console.ReadKey();

    //        Book book = collection[1];
    //        book = collection[-1];
    //        book = collection[4];

    //        Console.ReadKey();

    //        book = collection["Мастер и Маргарита"];

    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region
    //Unit 7.2.14
    class IndexingClass
    {
        private int[] array;
        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    #endregion
}