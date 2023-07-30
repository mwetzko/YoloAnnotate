using System.Windows.Forms;

namespace YoloAnnotate
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
