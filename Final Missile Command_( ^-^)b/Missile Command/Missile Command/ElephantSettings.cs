using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class ElephantSettings:DefaultSettings
    {
        public ElephantSettings() : base()
        {
            name = "Eli Phant";
            normal = Missile_Command.Properties.Resources.elephant;
            victory = Missile_Command.Properties.Resources.elephantWin;
            shellHealth = 2;
        }

        public override string description()
        {
            return "Player gets bigger life constructs, Enemy gets heartier missiles.";
        }

        public override StructurePrefab[] lifeTypes()
        {
            return Prefabs.bigStatics;
        }
    }
}
