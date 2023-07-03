using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncall
{
    public abstract class Entity
    {
        private string _name;
        public string Name { get { return _name; } set { if (value != null) { _name = value; } else { _name = Name; } } }
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
        public Entity() { }


    }
}
