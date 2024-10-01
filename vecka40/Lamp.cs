using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vecka40
{
    public class Lamp : Furniture, IComparable
    {
        public double Current { get; set; }

        public Lamp(double current, string name, bool wood, bool steel, bool fabric, TypeOfFurniture typeOfFurniture) :
            base(name, wood, steel, fabric, typeOfFurniture)
        {
            Current = current;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            if (obj is Lamp lamp)
            {
                if (Current < lamp.Current) return -1;
                if (Current > lamp.Current) return 1;
                if (Current == lamp.Current) return 0;
            }

            throw new Exception("object must be a Lamp");
        }

        public override string ToString()
        {
            return $"Lampan {Name} drar {Current} amp";
        }
    }
}
