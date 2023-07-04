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
    public partial class Form3 : Form
    {
        Form2 OwnerForm;
        public Form3(Form2 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (OwnerForm.count == 3)
            {
                label1.Text = "Выбор события:";
                button1.Text = "Взять факел";
                button2.Text = "Пойти в левый проход";
                button3.Text = "Пойти в правый проход";
            }
            if (OwnerForm.count == 4)
            {
                label1.Text = "Вы спустились вниз по лестнице и попали в пустую комнату.\n Вся комната облеплена паутиной, которая замедляет ваши движения.\n На этот раз перед вами два тоннеля.";
                button3.Visible = false;
                button1.Text = "Войти в левый тоннель.";
                button2.Text = "Войти в правый тоннель.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OwnerForm.count == 3)
            {
                button1.Visible = false;
                StaticData.IsTorchStatus = true;
            }
            if (OwnerForm.count == 4)
            {
                button1.Text = "Осмотреть сундук";
                button2.Text = "Пройти мимо";
                OwnerForm.count++;
            }
            if (OwnerForm.count == 5)
            {
                if (StaticData.IsTorchStatus)
                {
                    MessageBox.Show(" Вы поджигаете паутину и она быстро сгорает. Когда вся паутина сгорела вы замечаете ловушку соединённую с сундуком, вы с легкостью обезвреживаете ловушку и открываете сундук. Внутри вы находите (Предмет). Затем вы проходите в комнату в центре которой горит костёр с вокнутым мечом. (Вы попадаете в безопасную команту)");
                }
                else
                {
                    MessageBox.Show("Вы пытаетесь открыть сундук но вам мешает паутина. Внезапно вы слышите щелчок и в вашу ногу попадает стрела. ");
                    MessageBox.Show("Стоило Вам закрыть глаза...Как... ");

                    StaticData.BattleStatus = false;
                    this.Close();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OwnerForm.count == 3)
            {
                if (button1.Visible)
                {
                    OwnerForm.pass2++;
                    this.Close();
                }
                else
                {
                    OwnerForm.pass2++;
                    OwnerForm.pass2++;
                    this.Close();
                }
            }
            if (OwnerForm.count == 4)
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OwnerForm.count == 3)
            {
                if (button1.Visible)
                {
                    OwnerForm.pass1++;
                    this.Close();
                }
                else
                {
                    OwnerForm.pass1++;
                    OwnerForm.pass1++;
                    this.Close();
                }
            }
        }
    }
}
