using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class CactusSettings : DefaultSettings
    {
        public CactusSettings() : base()
        {
            name = "Peyton Yote";
            normal = Missile_Command.Properties.Resources.cactus;
            victory = Missile_Command.Properties.Resources.cactusWin;
        }

        public override string description()
        {
            return "Player gets hearty cities, Enemy gets cluster bombs.";
        }

        public override Shell enemyMissileType()
        {
            return base.enemyMissileType();//not yet implemented
        }

        public override void cityDeathScoringStrategy()
        {
            base.cityDeathScoringStrategy();//not yet implemented
        }
    }
}
