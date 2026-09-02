using System.Windows.Forms;

namespace GameHub
{
    public partial class frmSnake : Form
    {
        public frmSnake()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

