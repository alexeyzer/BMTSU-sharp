using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Laboe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        List<string> list = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_File(object sender, EventArgs e)
        {


            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch(); t.Start();
                string text = File.ReadAllText(fd.FileName);

                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {

                    string str = strTemp.Trim();
                    if (!list.Contains(str)) list.Add(str);
                }
                t.Stop();
                this.textBox1.Text = t.Elapsed.ToString();
                this.textBox1.Text = list.Count.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }



        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1(object sender, EventArgs e)
        {

        }



        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_find(object sender, EventArgs e)
        {

        }

        private void Button_find_Click(object sender, EventArgs e)
        {
            string word = this.textBox2.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();
                Stopwatch t = new Stopwatch(); t.Start();
                foreach (string str in list) { if (str.ToUpper().Contains(wordUpper)) { tempList.Add(str); } }
                t.Stop();
                this.textBox3.Text = t.Elapsed.ToString();
                this.listBox1.BeginUpdate();
   
                this.listBox1.Items.Clear();
           
                foreach (string str in tempList)
                {
                    this.listBox1.Items.Add(str);
                }
                this.listBox1.EndUpdate();
            }
            else
            { MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска"); }

        }
    

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            // TextBox2 //word to find

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            //Texbox3
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
      



    }

