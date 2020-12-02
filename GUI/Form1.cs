using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Cipher;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            richTextBox1.Width = (this.Size.Width - 280) / 2+10;
            richTextBox2.Location = new Point(richTextBox1.Location.X + richTextBox1.Width+5,richTextBox2.Location.Y);
            richTextBox2.Width = (this.Size.Width - 280) / 2+10;
            richTextBox2.Height = this.Size.Height - 80;
            richTextBox1.Height = this.Size.Height - 80;
            button1.Location = new Point(button1.Location.X, this.Size.Height - 80);
            button2.Location = new Point(button2.Location.X, this.Size.Height - 80);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Width = (this.Size.Width - 280) / 2 + 10;
            richTextBox2.Location = new Point(richTextBox1.Location.X + richTextBox1.Width + 5, richTextBox2.Location.Y);
            richTextBox2.Width = (this.Size.Width - 280) / 2 + 10;
            richTextBox2.Height = this.Size.Height-80;
            richTextBox1.Height = this.Size.Height-80;
            button1.Location = new Point(button1.Location.X, this.Size.Height - 80);
            button2.Location = new Point(button2.Location.X, this.Size.Height - 80);
        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void загрузитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = null; ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(openFileDialog1.FileName)) 
                    {
                        sr = new StreamReader(openFileDialog1.FileName);
                        richTextBox1.Text=sr.ReadToEnd();
                        sr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Файл с данным именем не найден.");
                    }
                }
                   
                catch ( Exception ex)
                {
                    MessageBox.Show("Error: Нельзя счиать файл с диска" + ex.Message);
                    if (sr!=null)
                        sr.Close();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void cjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                        sw = new StreamWriter(saveFileDialog1.FileName);
                        sw.WriteLine(richTextBox2.Text);
                        sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Нельзя счиать файл с диска" + ex.Message);
                    if (sw != null)
                        sw.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="" || (textBox1.Text=="" && !radioButton3.Checked))
            {
                MessageBox.Show("Поля количество рабочих и ключ должны быть заполнены!");
            }
            else
            {
                int x;
                if (int.TryParse(textBox2.Text, out x))
                {
                    owner my_ciphers=new owner();
                    int n=3;
                    if (radioButton1.Checked)
                        n=1;
                    if (radioButton2.Checked)
                        n=2;
                    if (radioButton3.Checked)
                        n=3;
                    try
                    {
                        richTextBox2.Text = my_ciphers.encrypt(richTextBox1.Text, n, x, textBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Поле количество рабочих должно быть целым числом!");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || (textBox1.Text == "" && !radioButton3.Checked))
            {
                MessageBox.Show("Поля количество рабочих и ключ должны быть заполнены!");
            }
            else
            {
                int x;
                if (int.TryParse(textBox2.Text, out x))
                {
                    owner my_ciphers=new owner();
                    int n=3;
                    if (radioButton1.Checked)
                        n=1;
                    if (radioButton2.Checked)
                        n=2;
                    if (radioButton3.Checked)
                        n=3;
                    try
                    {
                        richTextBox2.Text = my_ciphers.decrypt(richTextBox1.Text, n, x, textBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Поле количество рабочих должно быть целым числом!");
                }
                
            }
        }
    }
}
