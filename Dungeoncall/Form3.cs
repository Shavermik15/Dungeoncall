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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OwnerForm.count == 3)
            {
                button1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerForm.total++;
            this.Close();
        }
    }
}
