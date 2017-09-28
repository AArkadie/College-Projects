using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class BacteriaSettings : DefaultSettings
    {
        public BacteriaSettings() : base()
        {
            name = "U. Kerry Oat";
            normal = Missile_Command.Properties.Resources.bacteria;
            victory = Missile_Command.Properties.Resources.bacteriaWin;
        }

        public override string description()
        {
            return "Player gets spaceships, Enemy gets to spawn life too.";
        }

        public override StructurePrefab[] lifeTypes()
        {
            return Prefabs.spaceships;
        }

        public override Shell enemyMissileType()
        {
            return base.enemyMissileType();//not yet implemented
        }
    }
}
