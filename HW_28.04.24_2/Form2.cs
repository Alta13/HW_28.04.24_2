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

namespace HW_28._04._24_2
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            tbxWriterFile.Text = form1.TextBox_ReadFile;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            form1.TextBox_ReadFile = tbxWriterFile.Text;
                      
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.Default);
                writer.Write(tbxWriterFile.Text);
                writer.Close();
            }
           
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
