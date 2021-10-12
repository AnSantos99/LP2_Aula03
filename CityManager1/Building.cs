using System;

namespace CityManager1
{
    public class Building : IHasValue
    {
        private string buildingName;

        private float buildingArea;

        public float Value {get;}

        public Building(string buildingName, float value, float buildingArea)
        {
            this.buildingName = buildingName;
            this.buildingArea = buildingArea;
            value = Value;
        }

        

        public bool Equals (IHasValue other) 
        {
            if(other.Value == null) return false;
            return Value == other.Value;
        }


        public override string ToString()
        {
            return $"Name: {buildingName, -20 }\tValue: {Value, 8:f2}\tArea: {buildingArea, 8:f2} ";
        }
    }
}