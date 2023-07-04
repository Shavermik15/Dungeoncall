using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeoncall
{
    public partial class Form2 : Form
    {
        public int count = 0;
        public int pass2 = 0;
        public int pass1 = 0;
        public int countfloor2 = 0;
        int priority = 0;
        int chanceofmonsters;
        Random random = new Random();
        int chansmimics;
        int chancewithfire;
        Entity TheMainCharacter;
        Entity TheWandererSpider;
        Entity TheRat;
        Entity TheGiantScolopendra;
        public int countfloor21 =0;



        public Form2()
        {
            try
            {
                InitializeComponent();
                textBox1.Text = "Вы просыпаетесь от падающих вам на лицо капель воды. Вы не помните кто вы и где вы оказались.Вы лежите на голом полу, из одежды у вас порваная туника и штаны.";
                TheMainCharacter = new Entity("TheMainCharacter", 100, 10, 0, 15);
                TheWandererSpider = new Entity("TheWandererSpider", 30, 5, 50, 15);
                TheRat = new Entity("TheRat", 15, 0, 0, 15);
                TheGiantScolopendra = new Entity("TheGiantScolopendra", 50, 10, 0, 25);
                label5.Text = TheMainCharacter.HP.ToString();
                label6.Text = TheMainCharacter.Armor.ToString();
                label7.Text = TheMainCharacter.CritRate.ToString() + "%";
                label8.Text = TheMainCharacter.Damage.ToString(); ;


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Text = "На противоположной стороне комнаты вам в глаза вам бросается факел, который горит синим огнём, его света еле хватает чтобы осмотреться вокруг.";
                count++;
                switch (count)
                {
                    case 2:
                        textBox1.Text = "Вы лежите на голом полу, из одежды у вас порваная туника и штаны. Привыкнув к тьме вы замечаете по бокам от факела два прохода. Левый освёщен факелами и выглядит безопасно. Правый ведёт в непроглядную тьму.";
                        break;
                    case 3:
                        Form3 form3 = new Form3(this);
                        form3.ShowDialog();
                        count++;
                        break;
                   

                }
                switch (pass1)
                {
                    case 1:
                        chancewithfire = random.Next(3);
                        if (chancewithfire == 0 || chancewithfire == 1)
                        {
                            textBox1.Text = " Опираясь на стену вы продвигаетесь вперёд по тоннелю. Вы слышите странные приближающиеся звуки во тьме. Вы понимаете что кто-то хочет напасть на вас.";
                            priority++;
                            chanceofmonsters = random.Next(3);

                            switch (chanceofmonsters)
                            {
                                case 0:

                                    Form4 form4 = new Form4(this, TheMainCharacter, TheWandererSpider, priority, chanceofmonsters);

                                    form4.ShowDialog();
                                    
                                    if (StaticData.BattleStatus) {
                                        countfloor2++;
                                    label5.Text = StaticData.HP;
                                    label6.Text = StaticData.AR;
                                    label7.Text = StaticData.CR;
                                    label8.Text = StaticData.DM;
                                    label10.Text = StaticData.Name;
                                    }
                                    else this.Close();
                                    break;
                                case 1:

                                    Form4 form41 = new Form4(this, TheMainCharacter, TheGiantScolopendra, priority, chanceofmonsters);

                                    form41.ShowDialog();
                                    if (StaticData.BattleStatus)
                                    {
                                        countfloor2++;
                                        label5.Text = StaticData.HP;
                                        label6.Text = StaticData.AR;
                                        label7.Text = StaticData.CR;
                                        label8.Text = StaticData.DM;
                                        label10.Text = StaticData.Name;
                                    }
                                    else this.Close();
                                    break;
                                case 2:

                                    Form4 form42 = new Form4(this, TheMainCharacter, TheRat, priority, chanceofmonsters);

                                    form42.ShowDialog();
                                    if (StaticData.BattleStatus)
                                    {
                                        countfloor2++;
                                        label5.Text = StaticData.HP;
                                        label6.Text = StaticData.AR;
                                        label7.Text = StaticData.CR;
                                        label8.Text = StaticData.DM;
                                        label10.Text = StaticData.Name;
                                    }
                                    else this.Close();
                                    break;
                            }

                        }
                        else

                            textBox1.Text = "Опираясь на стену вы продвигаетесь вперёд по тоннелю. Вы очень долго продвигаетесь по тоннелю, внезапно пол под вами начинается осыпаться и вы падаете в неизвестность.";
                        break;
                    case 2:
                        textBox1.Text = "Вы продвигаетесь по тоннелю освещая перед собой путь. На самом краю видимой зоны вы замечаете небольшое движение и сразу готовитесь к бою. (Битва на равных)";
                    
                        chanceofmonsters = random.Next(3);

                        switch (chanceofmonsters)
                        {
                            case 0:

                                Form4 form4 = new Form4(this, TheMainCharacter, TheWandererSpider, priority, chanceofmonsters);

                                form4.ShowDialog();

                                if (StaticData.BattleStatus)
                                {
                                    countfloor2++;
                                    label5.Text = StaticData.HP;
                                    label6.Text = StaticData.AR;
                                    label7.Text = StaticData.CR;
                                    label8.Text = StaticData.DM;
                                    label10.Text = StaticData.Name;
                                }
                                else this.Close();
                                break;
                            case 1:

                                Form4 form41 = new Form4(this, TheMainCharacter, TheGiantScolopendra, priority, chanceofmonsters);

                                form41.ShowDialog();
                                if (StaticData.BattleStatus)
                                {
                                    countfloor2++;
                                    label5.Text = StaticData.HP;
                                    label6.Text = StaticData.AR;
                                    label7.Text = StaticData.CR;
                                    label8.Text = StaticData.DM;
                                    label10.Text = StaticData.Name;
                                }
                                else this.Close();
                                break;
                            case 2:

                                Form4 form42 = new Form4(this, TheMainCharacter, TheRat, priority, chanceofmonsters);

                                form42.ShowDialog();
                                if (StaticData.BattleStatus)
                                {
                                    countfloor2++;
                                    label5.Text = StaticData.HP;
                                    label6.Text = StaticData.AR;
                                    label7.Text = StaticData.CR;
                                    label8.Text = StaticData.DM;
                                    label10.Text = StaticData.Name;
                                }
                                else this.Close();
                                break;
                        }
                        break;
                }

                switch (pass2)
                {
                    case 1:
                        textBox1.Text = "Зайдя в проход вы видите очень длинный коридор который заканчивается поворотом налево. На протяжении всей стены расположены факела, которые полностью освещают путь. Пройдя до конца вы поворачиваете за угол и видите спуск вниз.";
                        countfloor2++;
                        break;
                    case 2:
                        textBox1.Text = "Зайдя в проход вы видите очень длинный коридор который заканчивается поворотом налево. На протяжении всей стены расположены такие же как и у вас факела, которые полностью освещают путь. Вы проходите до конца и попадаете в комнату с сундуком.";
                        chansmimics = random.Next(2);
                        switch (chansmimics)
                        {

                            case 0:
                                MessageBox.Show(" Вы подходите к сундуку и пробуете его открыть. Вы погибли! Это был мимик.");
                                this.Close();
                                

                                break;
                            case 1:
                                Protected leatherarmor = new Protected("Кожаная броня", 10, 10);
                                textBox1.Text = "Вы подходите к сундуку и пробуете его открыть. У вас получилось! Внутри вы находите кожаную броню";
                                countfloor2++;
                                label5.Text = (int.Parse(label5.Text) + leatherarmor.HP).ToString();
                                break;

                        }
                        break;
                }
                switch (countfloor2)
                {
                    case 1:
                        Form3 form3 = new Form3(this);
                        form3.ShowDialog();
                        if (!StaticData.BattleStatus)
                            this.Close();
                        break;
                    case 2:
                        
                        break; 
                }
                


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                throw;
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
