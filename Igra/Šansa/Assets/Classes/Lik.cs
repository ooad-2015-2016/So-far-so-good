using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class Lik
    {
        private  int lives;
        private  int health;
        private  float speed;
        private int poeni;

        public Lik(int lives, int hp, float spd)
        {
            this.lives = lives;
            this.health = hp;
            this.speed = spd;
            poeni = 0;
        }

        public int getLives()
        {
            return lives;
        }

        public bool umro()
        {
            lives--;
            if (lives == 0)
                return true;
            return false;
        }

        public int getHealth()
        {
            return health;
        }

        public void changeHealth(int hp)
        {
            health += hp;
        }

        public float getSpeed()
        {
            return speed;
        }

        public int getPoeni()
        {
            return poeni;
        }

        public void addPoints(int p)
        {
            poeni += p;
        }

        public void setHealth(int hp)
        {
            this.health = hp;
        }

    }
}
