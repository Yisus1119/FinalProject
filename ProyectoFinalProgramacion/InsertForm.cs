using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacion
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            CRUD CR = new CRUD();
            CR.Show();
            this.Visible = false;
        }
    }
}
