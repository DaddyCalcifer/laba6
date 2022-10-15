using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        List<string> Objects = new List<string>();
        //
        void RefreshListBox()
        {
            int sel_ind = listBox1.SelectedIndex;
            listBox1.Items.Clear();
            foreach (string item in Objects)
            {
                listBox1.Items.Add(item);
            }
            if(Objects.Count > sel_ind)
                listBox1.SelectedIndex = sel_ind;
        }
        private void button1_Click(object sender, EventArgs e) //Добавление
        {
            if (textBox1.Text.Trim() != "")
            {
                if(listBox1.SelectedIndex >= 0)
                    Objects.Insert(listBox1.SelectedIndex, textBox1.Text);
                else Objects.Add(textBox1.Text);
                textBox1.Clear();
                RefreshListBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                Objects.RemoveAt(listBox1.SelectedIndex);
                RefreshListBox();
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = Objects.IndexOf(textBox2.Text);
            if (index > -1)
                listBox1.SelectedIndex = index;
            else MessageBox.Show("Ничего не найдено!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }
    }
}
