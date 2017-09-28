using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class DefaultSettings : CandidateTemplate
    {
        public string name;
        public float shellSpeed, missileSpeed;
        public int lifeSize, shellSize, shellHealth, shellWorth, scoreDisrupt,
                   shellEvade, cityEvade, cityBounce, shellDelay;
        public Bitmap normal, victory;

        public DefaultSettings()
        {
            name = "Joe Schmoe";
            lifeSize = 1;
            shellSpeed = 4.0F;
            missileSpeed = 30.0F;
            lifeSize = 20;
            shellSize = 5;
            shellHealth = 1;
            shellWorth = 10;
            shellDelay = 20;
            scoreDisrupt = 1;
            shellEvade = 0;
            cityEvade = 0;
            cityBounce = 0;
            normal = null; //just the candidate
            victory = null; //the candidate plus a USA striped top hat
        }

        public string candidateName()
        {
            return name;
        }

        public float enemyMissileSpeed()
        {
            return shellSpeed;
        }

        public float playerMissileSpeed()
        {
            return missileSpeed;
        }

        public int enemyMissileSize()
        {
            return shellSize;
        }

        public int enemyMissileLife()
        {
            return shellHealth;
        }

        public int enemyMissileWorth()
        {
            return shellWorth;
        }

        public int enemyScoreDisrupt()
        {
            return scoreDisrupt;
        }

        public int enemyShellEvadeChance()
        {
            return shellEvade;
        }

        public virtual void cityDeathScoringStrategy()
        {
            //ToDo: Handle city deaths here
        }

        public int cityEvadeChance()
        {
            return cityEvade;
        }

        public int cityBounceChance()
        {
            return cityBounce;
        }

        public virtual bool winCondition()
        {
            return Form1.score >= 1000;
        }

        public virtual bool loseCondition()
        {
            return Form1.numCities <= 0;
        }

        public virtual Shell enemyMissileType()
        {
            throw new NotImplementedException();//return new DefaultShell();
        }

        public virtual Missile playerMissileType()
        {
            throw new NotImplementedException();//return new DefaultMissile();
        }

        public Bitmap candidatePicture()
        {
            return normal;
        }

        public Bitmap candidateWinPicture()
        {
            return victory;
        }

        int CandidateTemplate.lifeSize()
        {
            return lifeSize;
        }

        public virtual StructurePrefab[] lifeTypes()
        {
            return Prefabs.statics;
        }

        public virtual string description()
        {
            return "No special powers for anyone.";
        }

        public virtual void lifeCollisionStrategy()
        {
            throw new NotImplementedException();
        }

        public int enemyMissileDelay()
        {
            return shellDelay;
        }
    }
}
