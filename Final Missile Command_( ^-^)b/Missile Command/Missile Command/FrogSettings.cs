using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class FrogSettings : DefaultSettings
    {
        public FrogSettings() : base()
        {
            name = "Anne P. Bian";
            normal = Missile_Command.Properties.Resources.frog;
            victory = Missile_Command.Properties.Resources.frogWin;
            missileSpeed = 50.0F;
            shellSpeed = 10.0F;
        }

        public override string description()
        {
            return "Player gets fast missiles, Enemy gets fast shells.";
        }
    }
}
