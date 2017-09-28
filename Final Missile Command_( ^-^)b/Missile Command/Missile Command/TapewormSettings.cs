using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class TapewormSettings : DefaultSettings
    {
        public TapewormSettings() : base()
        {
            name = "Wiggles";
            normal = Missile_Command.Properties.Resources.tapeworm;
            victory = Missile_Command.Properties.Resources.tapewormWin;
            shellWorth = 20;
        }

        public override string description()
        {
            return "Player gets more score, Enemy gets leeching shells.";
        }

        public override Shell enemyMissileType()
        {
            return base.enemyMissileType();//not yet implemented
        }

        public override bool loseCondition()
        {
            return base.loseCondition();//not yet implemented
        }
    }
}
