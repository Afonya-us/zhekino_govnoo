using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Form1 _f1;
        public Form3(Form1 form1)
        {
            _f1 = form1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Gruppa". При необходимости она может быть перемещена или удалена.
            this.gruppaTableAdapter.Fill(this.kursDataSet.Gruppa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kursDataSet.Gruppa.Rows.Add();
        }
    }
}
