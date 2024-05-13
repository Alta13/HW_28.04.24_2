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
    
    //Разработайте приложение, которое состоит из двух форм.Первая форма содержит TextBox доступный только для 
    //чтения и две кнопки «загрузить файл» и «редактировать». Кнопка «редактировать» изначально неактивна. 
    //При нажатии на первую кнопку, открывается диалог и пользователю предлагают выбрать текстовый файл.
    //Выбранный файл загружается в TextBox и кнопка «редактировать» становится активной.
    //При нажатии на вторую кнопку открывается вторая форма (не модально), которая содержит TextBox 
    //доступный для редактирования и две кнопки «Сохранить» и «Отменить». При нажатии на первую кнопку 
    //изменения отображаются в TextBox первой формы.
    public partial class Form1 : Form
    {
        public string TextBox_ReadFile
        {
            get { return tbxReadFile.Text; }
            set { tbxReadFile.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
            btnUpload.Click += FileUpload_Click;
            btnEdit.Click += FileEdit_Click;
            TextBox_ReadFile = "";
        }
        private void FileEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void FileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            file.FilterIndex = 2;
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(file.FileName, Encoding.Default);
                tbxReadFile.Clear();
                tbxReadFile.Text = reader.ReadToEnd();
                reader.Close();
                btnEdit.Enabled = true;
            }
        }

        private void textBoxReadFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
