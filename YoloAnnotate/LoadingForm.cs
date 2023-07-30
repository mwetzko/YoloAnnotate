using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoloAnnotate
{
	public partial class LoadingForm : Form
	{
		public class LoadingState
		{
			public bool Aborted { get; set; }
		}

		LoadingState mLoadingState;

		public LoadingForm()
		{
			InitializeComponent();

			this.Text = MainForm.FORM_NAME;

			mLoadingState = new LoadingState();
		}

		public string Title { get => lbTitle.Text; set => lbTitle.Text = value; }

		public Action<LoadingState> ProcessAction { get; set; }

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			Task.Run(() => ProcessAction(mLoadingState)).ContinueWith(AfterProcessAction);
		}

		void AfterProcessAction(Task task)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new Action<Task>(AfterProcessAction), task);
			}
			else
			{
				task.GetAwaiter().GetResult();

				DialogResult = DialogResult.OK;

				this.Close();
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);

			mLoadingState.Aborted = true;
		}
	}
}
