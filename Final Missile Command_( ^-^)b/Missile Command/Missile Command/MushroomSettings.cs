using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class MushroomSettings : DefaultSettings
    {
        public MushroomSettings() : base()
        {
            name = "Charlie \"Fun\" Gusters";
            normal = Missile_Command.Properties.Resources.mushroom;
            victory = Missile_Command.Properties.Resources.mushroomWin;
        }

        public override string description()
        {
            return "Player gets reflective cities, Enemy gets bouncy shells.";
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
