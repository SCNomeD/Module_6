using System;

namespace Unit_7._1
{
    //    class Car
    //    {
    //        public double Fuel;

    //        public int Mileage;

    //        public Car()
    //        {
    //            Fuel = 50;
    //            Mileage = 0;
    //        }

    //        public void Move()
    //        {
    //             Move a kilometer
    //            Mileage++;
    //            Fuel -= 0.5;
    //        }

    //        public void FillTheCar()
    //        {
    //            Fuel = 50;
    //        }
    //    }

    //    enum FuelType
    //    {
    //        Gas = 0,
    //        Electricity
    //    }

    //    class HybridCar : Car
    //    {
    //        public FuelType FuelType;

    //        public void ChangeFuelType(FuelType type)
    //        {
    //            FuelType = type;
    //        }
    //    }
    //    class Employee
    //    {
    //        public string Name;
    //        public int Age;
    //        public int Salary;
    //    }
    //    class ProjectManager : Employee
    //    {
    //        public string ProjectName;
    //    }
    //    class Developer : Employee
    //    {
    //        private string ProgrammingLanguage;
    //    }
    //    class Food
    //    {

    //    }
    //    class Fruit : Food
    //    {

    //    }
    //    class Vegeteble : Food
    //    {

    //    }
    //    class Apple : Fruit
    //    {

    //    }
    //    class Banana : Fruit
    //    {

    //    }
    //    class Pear : Fruit
    //    {

    //    }
    //    class Potato : Vegeteble
    //    {

    //    }
    //    class Carrot : Vegeteble
    //    {

    //    }
    //}
    //class Obj
    //{
    //    private string name;
    //    private string owner;
    //    private int length;
    //    private int count;

    //    public Obj(string name, string ownerName, int objLength, int count)
    //    {
    //        this.name = name;
    //        owner = ownerName;
    //        length = objLength;
    //        this.count = count;
    //    }
    //class SmartHelper
    //{
    //    private string name;

    //    public SmartHelper(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void Greetings(string name)
    //    {
    //        Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SmartHelper helper = new SmartHelper("Олег");
    //        helper.Greetings("Грег");

    //        Console.ReadKey();
    //    }

    //}
    //class BaseClass
    //{
    //    protected string Name;

    //    public BaseClass(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //class DerivedClass : BaseClass
    //{
    //    public string Description;
    //    public int Counter;
    //    public DerivedClass(string name, string description) : base(name)
    //    {
    //        Description = description;
    //    }
    //    public DerivedClass(string name, string description, int counter) : base(name)
    //    {
    //        Description = description;
    //        Counter = counter;
    //    }
        //Альтернатива второму
        //public DerivedClass(string name, string description, int counter) : this(name, description)
        //{
        //    Counter = counter;
        //}
    //}
    class Creature { }
    class Animal : Creature { }
    class Human : Creature { }
    class HomoSapiens : Human { }
    class Program
    {
        static void Main(string[] args)
        {
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondCreature = new Animal();
            Animal animal = (Animal)secondCreature;
        }
    }
}