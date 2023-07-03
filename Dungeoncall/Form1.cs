namespace Dungeoncall
{
    public partial class Form1 : Form
    {   
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                throw;
            }
           
        }
    }
}