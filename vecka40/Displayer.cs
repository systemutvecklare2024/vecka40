using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vecka40
{
    internal class Displayer
    {
        public List<Table>? Tables { get; private set; }
        public List<Lamp>? Lamps { get; private set; }
        public Displayer()
        {
            PopulateTables();
            PopulateLamps();
        }

        public void DisplayTables()
        {
            if (Tables == null)
                return;

            Tables.Sort();
            foreach (Table table in Tables)
            {
                Console.WriteLine(table);
            }
        }

        public void DisplayLamps()
        {
            if (Lamps == null)
                return;

            Lamps.Sort();
            foreach (var lamp in Lamps)
            {
                Console.WriteLine(lamp);
            }
        }
        
        private void PopulateTables()
        {
            Tables = new List<Table>
            {
                new Table(12, "Kitchen", true, false, false, TypeOfFurniture.Bord),
                new Table(5, "Garden", false, true, false, TypeOfFurniture.Bord),
                new Table(10, "Desk", true, false, false, TypeOfFurniture.Skrivbord),
                new Table(15, "Flimsy", false, false, true, TypeOfFurniture.Bord),
                new Table(2, "Study", true, false, false, TypeOfFurniture.Bord),
                new Table(20, "Livingroom", true, false, false, TypeOfFurniture.Bord),
                new Table(3, "Bedroom", false, true, true, TypeOfFurniture.Bord),
                new Table(3, "Bedroom2", false, false, false, TypeOfFurniture.Bord),
            };
        }

        private void PopulateLamps()
        {
            Lamps = new List<Lamp>()
            {
                new Lamp(5, "Fancy", false, true, false, TypeOfFurniture.Taklampa),
                new Lamp(10, "Shiny", true, true, true, TypeOfFurniture.Taklampa),
                new Lamp(1, "Dim", true, false, true, TypeOfFurniture.Bordslampa),
                new Lamp(25, "Bright", false, true, false, TypeOfFurniture.Taklampa),
                new Lamp(6, "Desk", false, true, false, TypeOfFurniture.Bordslampa),
                new Lamp(3, "Buffet", false, true, true, TypeOfFurniture.Bordslampa),
                new Lamp(7, "Torchiere", false, true, true, TypeOfFurniture.Bordslampa),
                new Lamp(2, "Bed", false, true, true, TypeOfFurniture.Bordslampa),
            };
        }
    }
}
