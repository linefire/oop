using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.Text = Application.StartupPath + @"\beep23.mp3";
        }
        public List<Data> data = new List<Data>();
        public DataGridView dataGridView1;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)       
        {
            char number = e.KeyChar;
            e.Handled = !Char.IsDigit(number) && number != 8 && number != 44;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            data.Add(new Data(data.Count, Convert.ToInt32(textBox1.Text), textBox2.Text, dataGridView1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            data.Add(new Data(data.Count, Convert.ToInt32(textBox1.Text), textBox2.Text, dataGridView1));
            data[data.Count - 1].Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "mp3 Files|*.mp3";
            OFD.Title = "Choose mp3 file";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = OFD.FileName;
            }
        }
    }
}
