using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class DonkeySettings : DefaultSettings
    {
        public DonkeySettings() : base()
        {
            name = "Donkey Hote";
            normal = Missile_Command.Properties.Resources.donkey;
            victory = Missile_Command.Properties.Resources.donkeyWin;
            scoreDisrupt = 6;
        }

        public override string description()
        {
            return "Player gets social safety nets, Enemy gets to divide the vote.";
        }

        public override void cityDeathScoringStrategy()
        {
            base.cityDeathScoringStrategy();//not yet implemented
        }
    }
}
