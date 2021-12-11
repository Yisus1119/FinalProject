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

        private void InsertarBtn_Click(object sender, System.EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.Show();
            this.Visible = false;
        }
    }
}
