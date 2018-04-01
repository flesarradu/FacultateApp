using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultateApp
{
    public partial class Chestionar : Form
    {
        List<Question> Questions = new List<Question>();
        public Chestionar()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            using (var db = new DatabaseEntity())
            {
                foreach(var x in db.Questions)
                {
                    Questions.Add(x);
                }
            }
            label1.Text = Questions[0].Text;
            label2.Text = Questions[1].Text;
            label3.Text = Questions[2].Text;
            label4.Text = Questions[3].Text;
            label5.Text = Questions[4].Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
