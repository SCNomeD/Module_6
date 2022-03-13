using System;

namespace Unit_7._6
{
    #region
    abstract class Engine { }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { }
    abstract class CarPart { }
    class Battery : CarPart { }
    class Differential : CarPart { }
    class Wheel : CarPart { }
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    #endregion
    #region
    //class Record<T1, T2>
    //{
    //    public T1 Id;
    //    public T2 Value;
    //    public DateTime Date;
    //}
    //class Obj
    //{
    //    public void Display<T>(T param)
    //    {
    //        Console.WriteLine(param.ToString());
    //    }
    //}
    #endregion
    #region
    //class Order<TDelivery, TStruct>
    //where TDelivery : Delivery
    //where TStruct : struct
    //{
    //    public TDelivery Delivery;
    //    public TStruct Struct;
    //    public static T Return<T>(int number) where T : new()
    //    {
    //        Console.WriteLine(number);

    //        return new T();
    //    }
    //    // ... Другие поля
    //}
    //abstract class Delivery
    //{
    //    public string Address;
    //}
    //class HomeDelivery : Delivery { /* ... */ }
    //class PickPointDelivery : Delivery { /* ... */ }
    //class ShopDelivery : Delivery { /* ... */ }
    #endregion
    class Program
    {
        #region
        //public static void Swap<T>(ref T x, ref T y)
        //{
        //    T t = x;
        //    x = y;
        //    y = t;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region
            //Obj obj = new Obj();
            //obj.Display<int>(345);
            ////obj.Display(345); // Из-за того что не жестко задан параметр можно использовать такую запись

            //int num1 = 4;
            //int num2 = 10;
            //Swap<int>(ref num1, ref num2);
            ////Swap(ref num1, ref num2); // Из-за того что не жестко задан параметр можно использовать такую запись

            //Console.WriteLine("{0} {1}", num1, num2);
            #endregion

            Console.ReadKey();
        }
    }
}
