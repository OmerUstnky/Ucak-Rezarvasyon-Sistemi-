using System.CodeDom.Compiler;

namespace Ucus_Rezarvasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yolcu Ad Soyad: " + textBox2.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text + " Rota :" +
                comboBox1.Text + " " + comboBox2.Text + " " + dateTimePicker1.Text + " " + maskedTextBox1.Text
                );
            MessageBox.Show("Yolcu kaydý yapýldý.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
