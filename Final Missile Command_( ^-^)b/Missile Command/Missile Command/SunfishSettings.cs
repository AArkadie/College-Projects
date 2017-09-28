using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class SunfishSettings : DefaultSettings
    {
        public SunfishSettings() : base()
        {
            name = "Baby Whale";
            normal = Missile_Command.Properties.Resources.sunfish;
            victory = Missile_Command.Properties.Resources.sunfishWin;
            lifeSize = 10;
        }

        public override string description()
        {
            return "Player gets bigger life, Enemy gets explosive shells.";
        }

        public override Shell enemyMissileType()
        {
            return base.enemyMissileType();//not yet implemented
        }
    }
}
