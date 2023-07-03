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
    public partial class Form2 : Form
    {
        public int count = 0;
        public int total = 0;
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "Вы просыпаетесь от падающих вам на лицо капель воды. Вы не помните кто вы и где вы оказались.Вы лежите на голом полу, из одежды у вас порваная туника и штаны.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "На противоположной стороне комнаты вам в глаза вам бросается факел, который горит синим огнём, его света еле хватает чтобы осмотреться вокруг.";
            count++;
            switch (count) {
                case 2:
                    textBox1.Text = "Вы лежите на голом полу, из одежды у вас порваная туника и штаны. Привыкнув к тьме вы замечаете по бокам от факела два прохода. Левый освёщен факелами и выглядит безопасно. Правый ведёт в непроглядную тьму.";
                    break;
                case 3:
                    Form3 form3 = new Form3(this);
                    form3.ShowDialog();
                    break;


            }  
            switch (total)
            {
                case 1:
                    textBox1.Text = "Зайдя в проход вы видите очень длинный коридор который заканчивается поворотом налево. На протяжении всей стены расположены факела, которые полностью освещают путь. Пройдя до конца вы поворачиваете за угол и видите спуск вниз. (Переход на следующий этаж)";
                    break;
                case 2:
                    textBox1.Text = "2.1.  Зайдя в проход вы видите очень длинный коридор который заканчивается поворотом налево. На протяжении всей стены расположены такие же как и у вас факела, которые полностью освещают путь. Вы проходите до конца и попадаете в комнату с сундуком.";
                    break;
            }
        }
    }
}
