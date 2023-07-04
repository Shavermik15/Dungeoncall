using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncall
{
    public abstract class item
    {
        protected string name;
        public string Name { get { return name; } }

    }
    public class Weapons : item
    {
 

        private int damage;
        public int Damage { get { return damage; }  }
        private int critrate;
        public int CritRate { get { return critrate; }  }
        public Weapons(string name, int critratem, int damage)
        {
            this.name = name;
            this.damage = damage;
            this.critrate = critratem;
        }
    }
    public class Protected : item
    {
        
        private int hp;
        public int HP { get { return hp; } }
        public int armor;
        public int Armor { get { return armor; } }
        public Protected(string name, int hp, int armor)
        {
            this.name = name;
            this.hp = hp;
            this.armor = armor;
        }
    }
}
