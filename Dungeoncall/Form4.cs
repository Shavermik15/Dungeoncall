using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeoncall
{
    public partial class Form4 : Form
    {
        Entity TheMainCharacter;
        Entity TheWandererSpider;
        Random rm = new Random();
        int rmm;
        public Form4(Entity TheMainCharacter, Entity TheWandererSpider, int priority)
        {
           
            InitializeComponent();
            if (priority==1)
            {
                label9.Text = (TheMainCharacter.HP- TheWandererSpider.Damage).ToString();
                label10.Text = TheMainCharacter.Armor.ToString();
                label11.Text = TheMainCharacter.Damage.ToString();
                label12.Text = TheMainCharacter.CritRate.ToString() + "%";
                label13.Text = TheWandererSpider.HP.ToString();
                label14.Text = TheWandererSpider.Armor.ToString();
                label15.Text = TheWandererSpider.Damage.ToString();
                label16.Text = TheWandererSpider.CritRate.ToString()+"%";

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (label13.Text == "0")
                {
                    MessageBox.Show("Вы смогли выиграть этот бой и дойти до конца тоннеля. В конце вы нашли проход на следующий этаж и (предмет)");
                }
                rm.Next(1);
                if (rmm==0)
                label9.Text = (int.Parse(label9.Text) - 2*int.Parse(label15.Text)).ToString();
                else
                    label9.Text = (int.Parse(label9.Text) -  int.Parse(label15.Text)).ToString();
                label13.Text = (int.Parse(label13.Text) - int.Parse(label11.Text)).ToString();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            
        }
    }
}
