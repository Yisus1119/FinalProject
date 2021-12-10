using System.Windows.Forms;

namespace ProyectoFinalProgramacion
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            statusBar.Panels[1].Text = System.DateTime.Now.ToString("F");
        }
    }
}
