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
    public partial class Form6 : Form
    {
        Form1 _f1;
        public Form6(Form1 form1)
        {
            _f1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _f1.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Spisok_uchashihsa". При необходимости она может быть перемещена или удалена.
            this.spisok_uchashihsaTableAdapter.Fill(this.kursDataSet.Spisok_uchashihsa);

        }
    }
}
