using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simonov_KR
{
    public partial class Form2 : Form
    {
        DataSet galaxy;
        DataSet star;
       
        MySqlDataAdapter adapter_galaxy;
        MySqlDataAdapter adapter_star;
      
        MySqlCommandBuilder commandBuilder;
        string connStr = "server=localhost;user=root;database=astronomy;password=13579qetup;";

        public Form2()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.LightGray);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Segoe UI", 14.0f, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGrid_galaxy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_star.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                string sql1 = "SELECT * FROM galaxy;";
                string sql2 = "SELECT * FROM star;";
                dataGrid_galaxy.AllowUserToAddRows = false;
                dataGrid_star.AllowUserToAddRows = false;
                adapter_galaxy = new MySqlDataAdapter(sql1, connection);
                galaxy = new DataSet();
                adapter_galaxy.Fill(galaxy);
                dataGrid_galaxy.DataSource = galaxy.Tables[0];


                adapter_star = new MySqlDataAdapter(sql2, connection);
                star = new DataSet();
                adapter_star.Fill(star);
                dataGrid_star.DataSource = star.Tables[0];

            }
        }

        //Добавить
        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds;
            int idx = tabControl1.SelectedIndex;
            if (idx == 0) ds = galaxy;
            else ds = star;
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
        }


        //удалить
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView grid;
            int idx = tabControl1.SelectedIndex;
            if (idx == 0) grid = dataGrid_galaxy;
            else grid = dataGrid_star;

            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                grid.Rows.Remove(row);
            }
        }


        //найти
        private void button3_Click(object sender, EventArgs e)
        {
            string find = textBox1.Text;
            DataGridView grid;
            int idx = tabControl1.SelectedIndex;
            if (idx == 0) grid = dataGrid_galaxy;
            else grid = dataGrid_star;

            grid.CurrentRow.Selected = false;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    string s = grid.Rows[i].Cells[j].Value.ToString();
                    if (s.Contains(find))
                    {
                        grid.Rows[i].Selected = true;
                    }
                }

            }
        }

        //сохранить
        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds;
            MySqlDataAdapter adapter;
            int idx = tabControl1.SelectedIndex;
            if (idx == 0)
            {
                adapter = adapter_galaxy;
                ds = galaxy;
            }
            else
            {
                adapter = adapter_star;
                ds = star;
            }

            using (MySqlConnection connect = new MySqlConnection(connStr))
            {
                connect.Open();
                commandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);
            }
        }
    }
}
