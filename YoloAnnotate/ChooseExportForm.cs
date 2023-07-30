using System.Windows.Forms;

namespace YoloAnnotate
{
	public partial class ChooseExportForm : Form
	{
		public ChooseExportForm()
		{
			InitializeComponent();

			cbExportFormat.SelectedIndex = 0;
		}

		public int SelectedIndex { get => cbExportFormat.SelectedIndex; set => cbExportFormat.SelectedIndex = value; }
		public bool UseAbsolutePaths => cbUseAbsolute.Checked;

		void cbExportFormat_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cbUseAbsolute.Visible = cbExportFormat.SelectedIndex == 0;
		}
	}
}
