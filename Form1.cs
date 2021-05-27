using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simonov_KR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            if (password == "1234")
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show(
                   "Пароль неверный. Попробуйте ввести снова.",
                   "Неверный пароль",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
            }

           
           
        }
    }
}
