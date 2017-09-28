using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class FalconSettings : DefaultSettings
    {
        public FalconSettings() : base()
        {
            name = "Connor E. Door";
            normal = Missile_Command.Properties.Resources.falcon;
            victory = Missile_Command.Properties.Resources.falconWin;
        }

        public override string description()
        {
            return "Player gets tracking missiles, Enemy gets accelerating shells.";
        }

        public override Shell enemyMissileType()
        {
            return base.enemyMissileType();//not yet implemented
        }

        public override Missile playerMissileType()
        {
            return base.playerMissileType();//not yet implemented
        }
    }
}
