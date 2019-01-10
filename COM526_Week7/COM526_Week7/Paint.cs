using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM526_Week7
{
    class Paint
    {
        private List<Wall> Walls = new List<Wall>();
        public double Price { get; set; }
        public double Area { get; set; }

        public void AddWall(Wall wall)
        {
            Walls.Add(wall);
        }

        public double Cost()
        {
            double sqm = 0;
            foreach (Wall item in Walls)
            {
                sqm += item.Height * item.Length;
            }

            double Litres = sqm / Area;
            double Total = Litres * Price;
            return Total;
        }
    }
}
