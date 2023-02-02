using System;

namespace Class_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane boeing747 = new Airplane("Boeing 747", 100, 13000, 50);                      
            Airplane cornhusker = new Airplane("Кукурузник", 3, 400, 5);

            boeing747.Name = "Boeing 748";

            ShowAircraftInfo(boeing747);
            ShowAircraftInfo(cornhusker);
            cornhusker.Fly();
        }
        static void ShowAircraftInfo(Airplane airplane)
        {
            Console.WriteLine(
                "Название: " + airplane.Name + ",\n" +
                "Масса: " + airplane.Mass + ",\n" +
                "Мощность: " + airplane.Power + ",\n" +
                "Вместимость: " + airplane.Capacity + "\n"
                );
        }
    }
}
