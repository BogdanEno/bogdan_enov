using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private int[] searchList;
        private string searched;
        private int current = 0;
        private bool act = false;
        private void ArrInit()
        {
            act = true;
            int index = 0;
            int i = 0;
            while (richTextBox1.Text.IndexOf(searched, index) != -1)
            {
                index = richTextBox1.Text.IndexOf(searched, index);
                index += searched.Length;
                i++;
            }
            label1.Text = "Найдено: " + i.ToString();
            if (i == 0)
                act = false;
            else
            {
                index = 0;
                searchList = new int[i];
                for (int j = 0; j < searchList.Length; j++)
                {
                    index = richTextBox1.Text.IndexOf(searched, index);
                    searchList[j] = index;
                    index += searched.Length;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searched = textBox1.Text;
            ArrInit();
            Selecter();
        }

        private void Selecter()
        {
            if (act)
            {
                richTextBox1.SelectionStart = richTextBox1.Text.IndexOf(searched, searchList[current]);
                richTextBox1.SelectionLength = searched.Length;
                richTextBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (act)
            {
                if (current != 0)
                    current--;
                Selecter();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (act)
            {
                if (searchList.Length - 1 != current)
                    current++;
                Selecter();
            }
        }
    }
}
