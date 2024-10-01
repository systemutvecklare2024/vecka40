using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vecka40
{
    public class Table : Furniture, IComparable
    {
        

        public double AreaOfTable { get; set; }

        public Table(double areaOfTable, string name, bool wood, bool steel, bool fabric, TypeOfFurniture typeOfFurniture) : base(name, wood, steel, fabric, typeOfFurniture)
        {
            AreaOfTable = areaOfTable;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            var table = obj as Table;

            if (table != null)
            {
                return AreaOfTable.CompareTo(table.AreaOfTable); // use builtin compareTo for double
            }
            else
            {
                throw new Exception("Object is not a table");
            }
        }

        public override string ToString()
        {
            return $"Bordet {Name} har ytan {AreaOfTable}";
        }
    }
}
