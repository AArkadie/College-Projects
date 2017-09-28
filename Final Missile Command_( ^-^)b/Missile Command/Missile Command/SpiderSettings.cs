using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class SpiderSettings : DefaultSettings
    {
        public SpiderSettings() : base()
        {
            name = "Spider Pun";
            normal = Missile_Command.Properties.Resources.spider;
            victory = Missile_Command.Properties.Resources.spiderWin;
            shellSize = 2;
        }

        public override string description()
        {
            return "Player gets sticky Life, Enemy gets smaller shells.";
        }

        public override void lifeCollisionStrategy()
        {
            base.lifeCollisionStrategy();//not yet implemented
        }
    }
}
