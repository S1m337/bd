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
    public partial class Form3 : Form
    {
        DataSet color;
        DataSet light;
        DataSet spec;

        MySqlDataAdapter adapter_color;
        MySqlDataAdapter adapter_light;
        MySqlDataAdapter adapter_spec;

        MySqlCommandBuilder commandBuilder;
        string connStr = "server=localhost;user=root;;database=astronomy;password=13579qetup;";
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                string sql1 = "SELECT * FROM color;";
                string sql2 = "SELECT * FROM spectrum;";
                string sql3 = "SELECT * FROM light;";

                adapter_color = new MySqlDataAdapter(sql1, connection);
                color = new DataSet();
                adapter_color.Fill(color);
                dataGridView1.DataSource = color.Tables[0];


                adapter_spec = new MySqlDataAdapter(sql2, connection);
                spec = new DataSet();
                adapter_spec.Fill(spec);
                dataGridView2.DataSource = spec.Tables[0];

                adapter_light = new MySqlDataAdapter(sql3, connection);
                light = new DataSet();
                adapter_light.Fill(light);
                dataGridView3.DataSource = light.Tables[0];

            }

        }
    }
}
