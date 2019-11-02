using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\user\Desktop\COOMP TROUBLESHOOTING\studypool\Python LAB\Sudoku\config.txt");
            List<int> list = new List<int>();
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                
                
                counter++;
            }
                int[] arr = { 2 ,1 ,0, 3, 0, 0, 2, 0, 0, 0, 1, 0, 0, 4, 0, 0, };
                
                
            listBox1.Items.Add(arr[0]);
            listBox2.Items.Add(arr[1]);
            //listBox3.Items.Add(arr[2]);
            listBox4.Items.Add(arr[3]);
            //listBox5.Items.Add(arr[4]);
            //listBox6.Items.Add(arr[5]);
            listBox7.Items.Add(arr[6]);
            //listBox8.Items.Add(arr[7]);
            //listBox9.Items.Add(arr[8]);
            //listBox10.Items.Add(arr[9]);
            //listBox11.Items.Add(arr[10]);
            listBox12.Items.Add(arr[11]);
            //listBox13.Items.Add(arr[12]);
            //listBox14.Items.Add(arr[13]);
            listBox15.Items.Add(arr[14]);
            //listBox16.Items.Add(arr[15]);
            //listBox17.Items.Add(arr[16]);
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
