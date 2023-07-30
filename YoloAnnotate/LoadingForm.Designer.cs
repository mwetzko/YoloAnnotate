namespace YoloAnnotate
{
	partial class LoadingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pgrsBar = new System.Windows.Forms.ProgressBar();
			lbTitle = new System.Windows.Forms.Label();
			tblItems = new System.Windows.Forms.TableLayoutPanel();
			tblItems.SuspendLayout();
			SuspendLayout();
			// 
			// pgrsBar
			// 
			pgrsBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			pgrsBar.Location = new System.Drawing.Point(36, 53);
			pgrsBar.MarqueeAnimationSpeed = 33;
			pgrsBar.Name = "pgrsBar";
			pgrsBar.Size = new System.Drawing.Size(152, 23);
			pgrsBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			pgrsBar.TabIndex = 0;
			// 
			// lbTitle
			// 
			lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			lbTitle.AutoSize = true;
			lbTitle.Location = new System.Drawing.Point(82, 35);
			lbTitle.Name = "lbTitle";
			lbTitle.Size = new System.Drawing.Size(59, 15);
			lbTitle.TabIndex = 1;
			lbTitle.Text = "Loading...";
			// 
			// tblItems
			// 
			tblItems.ColumnCount = 1;
			tblItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tblItems.Controls.Add(lbTitle, 0, 0);
			tblItems.Controls.Add(pgrsBar, 0, 1);
			tblItems.Dock = System.Windows.Forms.DockStyle.Fill;
			tblItems.Location = new System.Drawing.Point(0, 0);
			tblItems.Name = "tblItems";
			tblItems.RowCount = 3;
			tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			tblItems.Size = new System.Drawing.Size(224, 121);
			tblItems.TabIndex = 2;
			// 
			// LoadingForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(224, 121);
			Controls.Add(tblItems);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "LoadingForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			tblItems.ResumeLayout(false);
			tblItems.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ProgressBar pgrsBar;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TableLayoutPanel tblItems;
	}
}