using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;




namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 _f1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _f1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Avtomobili". При необходимости она может быть перемещена или удалена.
            this.avtomobiliTableAdapter.Fill(this.kursDataSet.Avtomobili);





        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (MessageBox.Show("Удалить Автомобиль?", "Вы уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(row);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kursDataSet.Avtomobili.Rows.Add();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            avtomobiliTableAdapter.Update(this.kursDataSet);
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                string myPicturies = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Filter = "Image Files(*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png|All files (*.*)|*.*";
                ofd.FileName = "Image file name";
                ofd.Title = "Выберите фотографию...";
                ofd.AddExtension = true;
                ofd.FilterIndex = 0;
                ofd.Multiselect = false;
                ofd.ValidateNames = true;
                ofd.InitialDirectory = myPicturies;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox2.Image = Image.FromFile(ofd.FileName);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно!","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            avtomobiliTableAdapter.Update(this.kursDataSet);
        }
    }
}
         //   if (dataGridView1.SelectedRows.Count > 0)
           // {
             //   try
               // {
                 //   row.Foto = pictureBox2.Tag.ToString();
                //}
                //catch
                //{
                  //  MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            //}    
        
    
