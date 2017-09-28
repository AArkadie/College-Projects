using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public interface CandidateTemplate
    {
        string candidateName();
        string description();
        int lifeSize();
        StructurePrefab[] lifeTypes();
        void lifeCollisionStrategy();
        float enemyMissileSpeed();
        float playerMissileSpeed();
        int enemyMissileSize();
        int enemyMissileLife();
        int enemyMissileWorth();
        int enemyMissileDelay();
        int enemyScoreDisrupt();
        int enemyShellEvadeChance();
        void cityDeathScoringStrategy();
        int cityEvadeChance();
        int cityBounceChance();
        bool winCondition();
        bool loseCondition();
        Shell enemyMissileType();
        Missile playerMissileType();
        Bitmap candidatePicture();
        Bitmap candidateWinPicture();
    }
}
