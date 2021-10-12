using System;

namespace GameInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IHasValue[] collectionOfUnits = new IHasValue[5];
            collectionOfUnits[0] = new MilitaryUnit(5, 100, 20);
            collectionOfUnits[0] = new MilitaryUnit(5, 105, 20);
            collectionOfUnits[1] = new SettlerUnit(5, 15);
            collectionOfUnits[2] = new Building("Library", 15.5f);

            IHasValue previous = null;

            foreach(IHasValue unit in collectionOfUnits)
            { 
                Console.WriteLine(unit.GetType().Name);
                Console.WriteLine(unit.Equals(previous));

                previous = unit;
            }

        }
    }
}
