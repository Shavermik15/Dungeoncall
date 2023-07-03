using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncall
{
    public  class Entity
    {
        private string _name;
        public string Name { get { return _name; } }
        private int hp;
        public int HP
        {
            set
            {
                if (value < 0)
                {
                    hp = 0;
                }
            }
            get { return hp; }
        }
        private int armor;
        public int Armor { get { return armor; } set 
            { 
                if (value > 0) 
                    armor = value; 
                else  armor = 0; 
                if (value>1)
                {
                    armor = 1;
                }
            }
        }
        private int critrate;
        public int CritRate
        {
            get { return armor; }
            set
            {
                if (value > 0)
                    armor = value;
                else armor = 0;
                if (value > 1)
                {
                    armor = 1;
                }
            }
        }
        private int damage;
        public int Damage
        {
            set
            {
                if (value < 0)
                {
                    damage = 0;
                }
            }
            get { return damage; }
        }
        public Entity(string _name, int hp,int armor,int critrate,int damage) 
        { 
            this._name = _name;
            if (hp < 0)
            {
                this.hp = 1;
            }
            else
            {
                this.hp = hp;
            }
            if (armor < 0)
            {
                this.armor = 0;
            }
            else if (armor > 1)
            {
                this.armor = 1;
            }
            else { this.armor = armor; }
            if (critrate < 0)
            {
                this.critrate = 0;
            }
            else if (critrate > 1)
            {
                this.critrate = 1;
            }
            else { this.critrate = critrate; }
            if (damage < 0)
            {
                this.damage = 0;
            }
            else this.damage = damage;

        }


    }
}
