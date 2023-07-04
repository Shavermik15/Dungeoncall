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
{ //тут идёт бой и выпадение наград
    public partial class Form4 : Form
    {
        int bufdamage;
        int bufcritrate;
        Weapons oldonion = new Weapons("Старый лук", 50, 10);
        Weapons bronzesword = new Weapons("Бронзовый меч", 0, 15);
        
        Random rm = new Random();
        int rmm;
        Form2 form2;
        public Form4(Form2 form2,Entity TheMainCharacter, Entity Enemy, int priority,int rm)
        {
           
            InitializeComponent();
            this.form2 = form2;
            if (priority==1)
            {
                label9.Text = (TheMainCharacter.HP- Enemy.Damage).ToString();
                label10.Text = TheMainCharacter.Armor.ToString();
                label11.Text = TheMainCharacter.Damage.ToString();
                label12.Text = TheMainCharacter.CritRate.ToString() + "%";
                label13.Text = Enemy.HP.ToString();
                label14.Text = Enemy.Armor.ToString();
                label15.Text = Enemy.Damage.ToString();
                label16.Text = Enemy.CritRate.ToString()+"%";

            }
            else {
                label9.Text = (TheMainCharacter.HP).ToString();
                label10.Text = TheMainCharacter.Armor.ToString();
                label11.Text = TheMainCharacter.Damage.ToString();
                label12.Text = TheMainCharacter.CritRate.ToString() + "%";
                label13.Text = Enemy.HP.ToString();
                label14.Text = Enemy.Armor.ToString();
                label15.Text = Enemy.Damage.ToString();
                label16.Text = Enemy.CritRate.ToString() + "%";
            }
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(label13.Text) <= 0)
                {
                    rmm = rm.Next(2);
                    if (rmm == 0)
                    {
                        MessageBox.Show("Вы смогли выиграть этот бой и дойти до конца тоннеля. В конце вы нашли проход на следующий этаж и cтарый лук");
                       
                       
                        StaticData.HP = label9.Text;
                        StaticData.AR = label10.Text;
                        bufdamage = int.Parse(label11.Text) + oldonion.Damage;
                        bufcritrate = int.Parse(label12.Text.TrimEnd('%')) + oldonion.CritRate;
                        StaticData.CR = bufcritrate.ToString()+"%";
                        StaticData.DM =  bufdamage.ToString();
                        StaticData.Name=oldonion.Name;
                        StaticData.BattleStatus = true;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Вы смогли выиграть этот бой и дойти до конца тоннеля. В конце вы нашли проход на следующий этаж и бронзовый меч");
                        
                        StaticData.HP = label9.Text;
                        StaticData.AR = label10.Text;
                        StaticData.CR = label12.Text;
                        bufdamage = int.Parse(label11.Text) + bronzesword.Damage;
                        StaticData.DM = bufdamage.ToString();
                        StaticData.Name = bronzesword.Name;
                        StaticData.BattleStatus = true;

                        this.Close();

                    };

                }
                else
                {
                    if (int.Parse(label9.Text) <= 0) { MessageBox.Show("К сожалению этот бой был слишком тяжёлым для вас и вы погибли. Возможно повезёт в следующий раз. (Поражение)"); this.Close(); }
                    rmm = rm.Next(2);
                    if (rmm == 0)
                        label9.Text = (int.Parse(label9.Text) - 2 * int.Parse(label15.Text)).ToString();
                    else
                        label9.Text = (int.Parse(label9.Text) - int.Parse(label15.Text)).ToString();
                    label13.Text = (int.Parse(label13.Text) - int.Parse(label11.Text)).ToString();
                }
             
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            
        }
    }
}
