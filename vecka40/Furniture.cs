using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vecka40
{
    public abstract class Furniture
    {
        public bool Wood { get; set; }
        public bool Steel { get; set; }
        public bool Fabric { get; set; }
        public TypeOfFurniture TypeOfFurniture { get; set; }
        public string Name { get; set; } = "";

        public Furniture(string name, bool wood, bool steel, bool fabric, TypeOfFurniture typeOfFurniture)
        {
            Name = name;
            Wood = wood;
            Steel = steel;
            Fabric = fabric;
            TypeOfFurniture = typeOfFurniture;
        }
    }
}
