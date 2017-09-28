using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class DogSettings : DefaultSettings
    {
        public DogSettings() : base()
        {
            name = "Rover Cleavland";
            normal = Missile_Command.Properties.Resources.dog;
            victory = Missile_Command.Properties.Resources.dogWin;
        }

        public override string description()
        {
            return "Player gets loyal cities, Enemy gets energetic shells.";
        }

        public override void cityDeathScoringStrategy()
        {
            base.cityDeathScoringStrategy();//not yet implemented
        }

        public override Shell enemyMissileType()
        {
            return base.enemyMissileType();//not yet implemented
        }
    }
}
