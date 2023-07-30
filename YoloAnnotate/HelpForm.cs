using System.Windows.Forms;

namespace YoloAnnotate
{
	public partial class HelpForm : Form
	{
		public HelpForm()
		{
			InitializeComponent();

			this.Text = MainForm.FORM_NAME + " Help";
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
