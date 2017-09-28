using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class CatSettings : DefaultSettings
    {
        public CatSettings() : base()
        {
            name = "Kit T.";
            normal = Missile_Command.Properties.Resources.cat;
            victory = Missile_Command.Properties.Resources.catWin;
            cityEvade = 33;
            shellEvade = 50;
        }

        public override string description()
        {
            return "Player gets evasive cities, Enemy gets evasive shells.";
        }
    }
}
