using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Prefabs
    {

        public static StructurePrefab Dot = new StructurePrefab(1, 1)
        {
            name = "Dot",
            structure = new Point[]
            {
                new Point(0,0)
            }
            
        };

        //Still Lives

        public static StructurePrefab Block = new StructurePrefab(2, 2)
        {
            name = "Block",
            structure = new Point[]
            {
                new Point(0,0),
                new Point(1,0),
                new Point(0,1),
                new Point(1,1)
            }
        };

        public static StructurePrefab Beehive = new StructurePrefab(4, 3)
        {
            name = "Beehive",
            structure = new Point[]
            {
                new Point(1,0),
                new Point(2,0),
                new Point(0,1),
                new Point(3,1),
                new Point(1,2),
                new Point(2,2)
            }
        };

        public static StructurePrefab Loaf = new StructurePrefab(4, 4)
        {
            name = "Loaf",
            structure = new Point[]
            {
                new Point(1,0),
                new Point(2,0),
                new Point(0,1),
                new Point(3,1),
                new Point(1,2),
                new Point(3,2),
                new Point(2,3)
            }
        };

        public static StructurePrefab Boat = new StructurePrefab(3, 3)
        {
            name = "Boat",
            structure = new Point[]
            {
                new Point(0,0),
                new Point(1,0),
                new Point(0,1),
                new Point(2,1),
                new Point(1,2)
            }
        };

        public static StructurePrefab Ship = new StructurePrefab(3, 3)
        {
            name = "Ship",
            structure = new Point[]
            {
                new Point(0,0),
                new Point(1,0),
                new Point(0,1),
                new Point(2,1),
                new Point(1,2),
                new Point(2,2)
            }
        };

        public static StructurePrefab Fishook = new StructurePrefab(4, 4)
        {
            name = "Fish Hook",
            structure = new Point[]
            {
                new Point(0,0),
                new Point(1,0),
                new Point(0,1),
                new Point(2,1),
                new Point(2,2),
                new Point(2,3),
                new Point(3,3)
            }
        };

        public static StructurePrefab Integral = new StructurePrefab(5, 5)
        {
            name = "Integral",
            structure = new Point[]
            {
                new Point(3,0),
                new Point(4,0),
                new Point(2,1),
                new Point(4,1),
                new Point(2,2),
                new Point(0,3),
                new Point(2,3),
                new Point(0,4),
                new Point(1,4)
            }
        };

        //Oscillators

        public static StructurePrefab Blinker = new StructurePrefab(1, 3)
        {
            name = "Blinker",
            structure = new Point[]
            {
                new Point(0,0),
                new Point(0,1),
                new Point(0,2)
            }
        };

        public static StructurePrefab Toad = new StructurePrefab(4, 2)
        {
            name = "Toad",
            structure = new Point[]
            {
                new Point(1,0),
                new Point(2,0),
                new Point(3,0),
                new Point(0,1),
                new Point(1,1),
                new Point(2,1)
            }
        };

        public static StructurePrefab Beacon = new StructurePrefab(4, 4)
        {
            name = "Beacon",
            structure = new Point[]
            {
                new Point(0,0),
                new Point(1,0),
                new Point(0,1),
                new Point(1,1),
                new Point(2,2),
                new Point(3,2),
                new Point(2,3),
                new Point(3,3)
            }
        };

        public static StructurePrefab Glider = new StructurePrefab(3, 3)
        {
            name = "Glider",
            structure = new Point[]
            {
                new Point(2,0),
                new Point(2,1),
                new Point(2,2),
                new Point(1,2),
                new Point(0,1)
            }
        };

        public static StructurePrefab LWSS = new StructurePrefab(5, 4)
        {
            name = "Lightweight Space Ship",
            structure = new Point[]
            {
                new Point(1,0),
                new Point(2,0),
                new Point(3,0),
                new Point(4,0),
                new Point(0,1),
                new Point(4,1),
                new Point(4,2),
                new Point(0,3),
                new Point(3,3)
            }
        };

        public static StructurePrefab Clock = new StructurePrefab(12, 12)
        {
            name = "Clock",
            structure = new Point[]
            {
                new Point(6,0),
                new Point(7,0),
                new Point(6,1),
                new Point(7,1),
                new Point(4,3),
                new Point(5,3),
                new Point(6,3),
                new Point(7,3),
                new Point(0,4),
                new Point(1,4),
                new Point(0,5),
                new Point(1,5),
                new Point(3,4),
                new Point(3,5),
                new Point(3,6),
                new Point(3,7),
                new Point(8,4),
                new Point(8,5),
                new Point(8,6),
                new Point(8,7),
                new Point(6,5),
                new Point(6,6),
                new Point(5,7),
                new Point(10,6),
                new Point(10,7),
                new Point(11,6),
                new Point(11,7),
                new Point(4,8),
                new Point(5,8),
                new Point(6,8),
                new Point(7,8),
                new Point(4,10),
                new Point(5,10),
                new Point(4,11),
                new Point(5,11)
            }
        };

        public static StructurePrefab Cross = new StructurePrefab(8, 8)
        {
            name = "Cross",
            structure = new Point[]
            {
                new Point(2,0),
                new Point(3,0),
                new Point(4,0),
                new Point(5,0),
                new Point(2,1),
                new Point(5,1),
                new Point(0,2),
                new Point(1,2),
                new Point(2,2),
                new Point(5,2),
                new Point(6,2),
                new Point(7,2),
                new Point(0,3),
                new Point(7,3),
                new Point(0,4),
                new Point(7,4),
                new Point(0,5),
                new Point(1,5),
                new Point(2,5),
                new Point(5,5),
                new Point(6,5),
                new Point(7,5),
                new Point(2,6),
                new Point(5,6),
                new Point(2,7),
                new Point(3,7),
                new Point(4,7),
                new Point(5,7)
            }
        };

        public static StructurePrefab Fumarole = new StructurePrefab(8, 6)
        {
            name = "Fumarole",
            structure = new Point[]
            {
                new Point(3,0),
                new Point(4,0),
                new Point(1,1),
                new Point(2,1),
                new Point(5,1),
                new Point(6,1),
                new Point(1,2),
                new Point(6,2),
                new Point(2,3),
                new Point(5,3),
                new Point(0,4),
                new Point(2,4),
                new Point(5,4),
                new Point(7,4),
                new Point(0,5),
                new Point(1,5),
                new Point(6,5),
                new Point(7,5)
            }
        };

        public static StructurePrefab Galaxy = new StructurePrefab(9, 9)
        {
            name = "Galaxy",
            structure = new Point[]
            {
                new Point(0,0),
                new Point(1,0),
                new Point(3,0),
                new Point(4,0),
                new Point(5,0),
                new Point(6,0),
                new Point(7,0),
                new Point(8,0),
                new Point(0,1),
                new Point(1,1),
                new Point(3,1),
                new Point(4,1),
                new Point(5,1),
                new Point(6,1),
                new Point(7,1),
                new Point(8,1),
                new Point(0,2),
                new Point(1,2),
                new Point(0,3),
                new Point(1,3),
                new Point(7,3),
                new Point(8,3),
                new Point(0,4),
                new Point(1,4),
                new Point(7,4),
                new Point(8,4),
                new Point(0,5),
                new Point(1,5),
                new Point(7,5),
                new Point(8,5),
                new Point(7,6),
                new Point(8,6),
                new Point(0,7),
                new Point(1,7),
                new Point(2,7),
                new Point(3,7),
                new Point(4,7),
                new Point(5,7),
                new Point(7,7),
                new Point(8,7),
                new Point(0,8),
                new Point(1,8),
                new Point(2,8),
                new Point(3,8),
                new Point(4,8),
                new Point(5,8),
                new Point(7,8),
                new Point(8,8)
            }
        };

        public static StructurePrefab Pulsar = new StructurePrefab(13, 13)
        {
            name = "Pulsar",
            structure = new Point[]
            {
                new Point(2,0),
                new Point(3,0),
                new Point(4,0),
                new Point(8,0),
                new Point(9,0),
                new Point(10,0),
                new Point(0,2),
                new Point(5,2),
                new Point(7,2),
                new Point(12,2),
                new Point(0,3),
                new Point(5,3),
                new Point(7,3),
                new Point(12,3),
                new Point(0,4),
                new Point(5,4),
                new Point(7,4),
                new Point(12,4),
                new Point(2,5),
                new Point(3,5),
                new Point(4,5),
                new Point(8,5),
                new Point(9,5),
                new Point(10,5),
                new Point(2,7),
                new Point(3,7),
                new Point(4,7),
                new Point(8,7),
                new Point(9,7),
                new Point(10,7),
                new Point(0,8),
                new Point(5,8),
                new Point(7,8),
                new Point(12,8),
                new Point(0,9),
                new Point(5,9),
                new Point(7,9),
                new Point(12,9),
                new Point(0,10),
                new Point(5,10),
                new Point(7,10),
                new Point(12,10),
                new Point(2,12),
                new Point(3,12),
                new Point(4,12),
                new Point(8,12),
                new Point(9,12),
                new Point(10,12)
            }
        };

        public static StructurePrefab Pentadecathlon = new StructurePrefab(3, 10)
        {
            name = "Pentadecathlon",
            structure = new Point[]
            {
                new Point(1,0),
                new Point(1,1),
                new Point(0,2),
                new Point(2,2),
                new Point(1,3),
                new Point(1,4),
                new Point(1,5),
                new Point(1,6),
                new Point(0,7),
                new Point(2,7),
                new Point(1,8),
                new Point(1,9)
            }
        };

        public static StructurePrefab GliderGun = new StructurePrefab(36, 9)
        {
            name = "Glider Gun",
            structure = new Point[]
            {
                new Point(24,0),
                new Point(22,1),
                new Point(24,1),
                new Point(12,2),
                new Point(13,2),
                new Point(20,2),
                new Point(21,2),
                new Point(34,2),
                new Point(35,2),
                new Point(11,3),
                new Point(15,3),
                new Point(20,3),
                new Point(21,3),
                new Point(34,3),
                new Point(35,3),
                new Point(0,4),
                new Point(1,4),
                new Point(10,4),
                new Point(16,4),
                new Point(20,4),
                new Point(21,4),
                new Point(0,5),
                new Point(1,5),
                new Point(10,5),
                new Point(14,5),
                new Point(16,5),
                new Point(17,5),
                new Point(22,5),
                new Point(24,5),
                new Point(10,6),
                new Point(16,6),
                new Point(24,6),
                new Point(11,7),
                new Point(15,7),
                new Point(12,8),
                new Point(13,8)
            }
        };

        public static StructurePrefab[] prefabList = new StructurePrefab[]
        {Dot, Blinker, Block, Beehive, Loaf, Boat, Ship, Fishook, Integral,
         Toad, Beacon, Glider, LWSS, Clock, Cross, Fumarole, Galaxy, Pulsar, Pentadecathlon,
         GliderGun };

    }
}
