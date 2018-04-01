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
    public partial class MeniuStudent : Form
    {
        public MeniuStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chestionar form = new Chestionar();
            
            form.Closed += (s, args) => Close();
            form.Show();
            Hide();
        }
    }
}
