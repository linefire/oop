using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;


namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        public List<Data> data = new List<Data>();
        Random R = new Random();       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
         
            f2.data = data;
            f2.dataGridView1 = dataGridView1;
           
            f2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                data[row.Index].Start(); 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Data.doPlay = checkBox1.Checked; 
        }
    }

    public class Data
    {
        public static bool doPlay = true; 
        public Timer timer; 
        public int tick; 
        public int time; 
        public int index; 
        public string path; 
        
        public Data(int index, int time, string path, DataGridView dgv) 
        {
            tick = 0;
            this.time = time;
            this.path = path;
            dgv.Rows.Add(); 
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += (s, o) => 
            {
                tick++; 
                if (tick >= time) 
                {
                   
                    dgv[0, index].Value = tick / 60 + " m " + tick % 60 + " s"; 
                    dgv[1, index].Value = time / 60 + " m " + time % 60 + " s";
                    dgv[2, index].Value = path;
                    timer.Stop();
                    try
                    {
                        if (doPlay) 
                        {
                         
                            IWavePlayer waveOutDevice = new WaveOut();
                            AudioFileReader audioFileReader = new AudioFileReader(path);
                            waveOutDevice.Init(audioFileReader);
                            waveOutDevice.Play();
                        }

                    }
                    catch (Exception ex) 
                    {                        
                        MessageBox.Show("Файл пошкоджений або відсутній");
                    }
                    
                    MessageBox.Show("Timer №" + (index+1).ToString() + " is finished");
                }
                else 
                {
                    dgv[0, index].Value = tick / 60 + " m " + tick % 60 + " s";
                    dgv[1, index].Value = time / 60 + " m " + time % 60 + " s";
                    dgv[2, index].Value = path;
                }
            };
            
            dgv[0, index].Value = tick / 60 + " m " + tick % 60 + " s";
            dgv[1, index].Value = time / 60 + " m " + time % 60 + " s";
            dgv[2, index].Value = path;
        }



        public void Start()
        {
            tick = 0; 
            timer.Start(); 
        }
    }
}
