namespace YoloAnnotate
{
	partial class ChooseExportForm
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
			tblItems = new System.Windows.Forms.TableLayoutPanel();
			cbExportFormat = new System.Windows.Forms.ComboBox();
			btnOK = new System.Windows.Forms.Button();
			cbUseAbsolute = new System.Windows.Forms.CheckBox();
			tblItems.SuspendLayout();
			SuspendLayout();
			// 
			// tblItems
			// 
			tblItems.ColumnCount = 1;
			tblItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			tblItems.Controls.Add(cbExportFormat, 0, 0);
			tblItems.Controls.Add(btnOK, 0, 2);
			tblItems.Controls.Add(cbUseAbsolute, 0, 1);
			tblItems.Dock = System.Windows.Forms.DockStyle.Fill;
			tblItems.Location = new System.Drawing.Point(0, 0);
			tblItems.Name = "tblItems";
			tblItems.RowCount = 3;
			tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tblItems.Size = new System.Drawing.Size(224, 121);
			tblItems.TabIndex = 2;
			// 
			// cbExportFormat
			// 
			cbExportFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
			cbExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbExportFormat.FormattingEnabled = true;
			cbExportFormat.Items.AddRange(new object[] { "YOLO Darknet", "YOLO Ultralytics" });
			cbExportFormat.Location = new System.Drawing.Point(17, 11);
			cbExportFormat.Name = "cbExportFormat";
			cbExportFormat.Size = new System.Drawing.Size(190, 23);
			cbExportFormat.TabIndex = 0;
			cbExportFormat.SelectedIndexChanged += cbExportFormat_SelectedIndexChanged;
			// 
			// btnOK
			// 
			btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
			btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			btnOK.Location = new System.Drawing.Point(74, 86);
			btnOK.Name = "btnOK";
			btnOK.Size = new System.Drawing.Size(75, 23);
			btnOK.TabIndex = 1;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			// 
			// cbUseAbsolute
			// 
			cbUseAbsolute.Anchor = System.Windows.Forms.AnchorStyles.None;
			cbUseAbsolute.AutoSize = true;
			cbUseAbsolute.Location = new System.Drawing.Point(49, 50);
			cbUseAbsolute.Name = "cbUseAbsolute";
			cbUseAbsolute.Size = new System.Drawing.Size(125, 19);
			cbUseAbsolute.TabIndex = 2;
			cbUseAbsolute.Text = "Use absolute paths";
			cbUseAbsolute.UseVisualStyleBackColor = true;
			// 
			// ChooseExportForm
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(224, 121);
			Controls.Add(tblItems);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ChooseExportForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Choose Export Format";
			tblItems.ResumeLayout(false);
			tblItems.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tblItems;
		private System.Windows.Forms.ComboBox cbExportFormat;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.CheckBox cbUseAbsolute;
	}
}