using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class OctopusSettings : DefaultSettings
    {
        public OctopusSettings() : base()
        {
            name = "Seth Lopod";
            normal = Missile_Command.Properties.Resources.octopus;
            victory = Missile_Command.Properties.Resources.octopusWin;
            shellDelay = 10;
        }

        public override string description()
        {
            return "Player gets oscillators, Enemy gets to shoot faster.";
        }

        public override StructurePrefab[] lifeTypes()
        {
            return Prefabs.oscillators;
        }
    }
}
