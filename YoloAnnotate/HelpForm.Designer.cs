namespace YoloAnnotate
{
	partial class HelpForm
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
			tableLayout = new System.Windows.Forms.TableLayoutPanel();
			lbLmbDrag = new System.Windows.Forms.Label();
			lbLmbDragText = new System.Windows.Forms.Label();
			lbImageEditor = new System.Windows.Forms.Label();
			lbRmbDrag = new System.Windows.Forms.Label();
			lbRmbDragText = new System.Windows.Forms.Label();
			lbMwScroll = new System.Windows.Forms.Label();
			lbLmbDragEsc = new System.Windows.Forms.Label();
			lbLmbDragEscText = new System.Windows.Forms.Label();
			lbMmDel = new System.Windows.Forms.Label();
			lbMwText = new System.Windows.Forms.Label();
			lbMmDelText = new System.Windows.Forms.Label();
			lbMmCtrl = new System.Windows.Forms.Label();
			lbMmCtrlText = new System.Windows.Forms.Label();
			tableLayout.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayout
			// 
			tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			tableLayout.ColumnCount = 2;
			tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			tableLayout.Controls.Add(lbLmbDrag, 0, 1);
			tableLayout.Controls.Add(lbLmbDragText, 1, 1);
			tableLayout.Controls.Add(lbImageEditor, 0, 0);
			tableLayout.Controls.Add(lbRmbDrag, 0, 3);
			tableLayout.Controls.Add(lbRmbDragText, 1, 3);
			tableLayout.Controls.Add(lbMwScroll, 0, 4);
			tableLayout.Controls.Add(lbLmbDragEsc, 0, 2);
			tableLayout.Controls.Add(lbLmbDragEscText, 1, 2);
			tableLayout.Controls.Add(lbMmDel, 0, 5);
			tableLayout.Controls.Add(lbMwText, 1, 4);
			tableLayout.Controls.Add(lbMmDelText, 1, 5);
			tableLayout.Controls.Add(lbMmCtrl, 0, 6);
			tableLayout.Controls.Add(lbMmCtrlText, 1, 6);
			tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayout.Location = new System.Drawing.Point(0, 0);
			tableLayout.Name = "tableLayout";
			tableLayout.RowCount = 8;
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			tableLayout.Size = new System.Drawing.Size(444, 261);
			tableLayout.TabIndex = 0;
			// 
			// lbLmbDrag
			// 
			lbLmbDrag.AutoSize = true;
			lbLmbDrag.Location = new System.Drawing.Point(6, 32);
			lbLmbDrag.Margin = new System.Windows.Forms.Padding(5);
			lbLmbDrag.Name = "lbLmbDrag";
			lbLmbDrag.Size = new System.Drawing.Size(139, 15);
			lbLmbDrag.TabIndex = 2;
			lbLmbDrag.Text = "Left Mouse Down + Drag";
			// 
			// lbLmbDragText
			// 
			lbLmbDragText.AutoSize = true;
			lbLmbDragText.Location = new System.Drawing.Point(226, 32);
			lbLmbDragText.Margin = new System.Windows.Forms.Padding(5);
			lbLmbDragText.Name = "lbLmbDragText";
			lbLmbDragText.Size = new System.Drawing.Size(107, 15);
			lbLmbDragText.TabIndex = 3;
			lbLmbDragText.Text = "Create Image Mark";
			// 
			// lbImageEditor
			// 
			lbImageEditor.AutoSize = true;
			lbImageEditor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			lbImageEditor.Location = new System.Drawing.Point(6, 6);
			lbImageEditor.Margin = new System.Windows.Forms.Padding(5);
			lbImageEditor.Name = "lbImageEditor";
			lbImageEditor.Size = new System.Drawing.Size(78, 15);
			lbImageEditor.TabIndex = 1;
			lbImageEditor.Text = "Image Editor";
			// 
			// lbRmbDrag
			// 
			lbRmbDrag.AutoSize = true;
			lbRmbDrag.Location = new System.Drawing.Point(6, 84);
			lbRmbDrag.Margin = new System.Windows.Forms.Padding(5);
			lbRmbDrag.Name = "lbRmbDrag";
			lbRmbDrag.Size = new System.Drawing.Size(147, 15);
			lbRmbDrag.TabIndex = 6;
			lbRmbDrag.Text = "Right Mouse Down + Drag";
			// 
			// lbRmbDragText
			// 
			lbRmbDragText.AutoSize = true;
			lbRmbDragText.Location = new System.Drawing.Point(226, 84);
			lbRmbDragText.Margin = new System.Windows.Forms.Padding(5);
			lbRmbDragText.Name = "lbRmbDragText";
			lbRmbDragText.Size = new System.Drawing.Size(73, 15);
			lbRmbDragText.TabIndex = 7;
			lbRmbDragText.Text = "Move Image";
			// 
			// lbMwScroll
			// 
			lbMwScroll.AutoSize = true;
			lbMwScroll.Location = new System.Drawing.Point(6, 110);
			lbMwScroll.Margin = new System.Windows.Forms.Padding(5);
			lbMwScroll.Name = "lbMwScroll";
			lbMwScroll.Size = new System.Drawing.Size(79, 15);
			lbMwScroll.TabIndex = 8;
			lbMwScroll.Text = "Mouse Wheel";
			// 
			// lbLmbDragEsc
			// 
			lbLmbDragEsc.AutoSize = true;
			lbLmbDragEsc.Location = new System.Drawing.Point(6, 58);
			lbLmbDragEsc.Margin = new System.Windows.Forms.Padding(5);
			lbLmbDragEsc.Name = "lbLmbDragEsc";
			lbLmbDragEsc.Size = new System.Drawing.Size(24, 15);
			lbLmbDragEsc.TabIndex = 4;
			lbLmbDragEsc.Text = "Esc";
			// 
			// lbLmbDragEscText
			// 
			lbLmbDragEscText.AutoSize = true;
			lbLmbDragEscText.Location = new System.Drawing.Point(226, 58);
			lbLmbDragEscText.Margin = new System.Windows.Forms.Padding(5);
			lbLmbDragEscText.Name = "lbLmbDragEscText";
			lbLmbDragEscText.Size = new System.Drawing.Size(157, 15);
			lbLmbDragEscText.TabIndex = 5;
			lbLmbDragEscText.Text = "Cancel Image Mark Creation";
			// 
			// lbMmDel
			// 
			lbMmDel.AutoSize = true;
			lbMmDel.Location = new System.Drawing.Point(6, 136);
			lbMmDel.Margin = new System.Windows.Forms.Padding(5);
			lbMmDel.Name = "lbMmDel";
			lbMmDel.Size = new System.Drawing.Size(132, 15);
			lbMmDel.TabIndex = 10;
			lbMmDel.Text = "Mouse Over Mark + Del";
			// 
			// lbMwText
			// 
			lbMwText.AutoSize = true;
			lbMwText.Location = new System.Drawing.Point(226, 110);
			lbMwText.Margin = new System.Windows.Forms.Padding(5);
			lbMwText.Name = "lbMwText";
			lbMwText.Size = new System.Drawing.Size(111, 15);
			lbMwText.TabIndex = 9;
			lbMwText.Text = "Zoom Image in/out";
			// 
			// lbMmDelText
			// 
			lbMmDelText.AutoSize = true;
			lbMmDelText.Location = new System.Drawing.Point(226, 136);
			lbMmDelText.Margin = new System.Windows.Forms.Padding(5);
			lbMmDelText.Name = "lbMmDelText";
			lbMmDelText.Size = new System.Drawing.Size(70, 15);
			lbMmDelText.TabIndex = 11;
			lbMmDelText.Text = "Delete Mark";
			// 
			// lbMmCtrl
			// 
			lbMmCtrl.AutoSize = true;
			lbMmCtrl.Location = new System.Drawing.Point(6, 162);
			lbMmCtrl.Margin = new System.Windows.Forms.Padding(5);
			lbMmCtrl.Name = "lbMmCtrl";
			lbMmCtrl.Size = new System.Drawing.Size(209, 15);
			lbMmCtrl.TabIndex = 12;
			lbMmCtrl.Text = "[Hold] Ctrl + Mouse Over Mark Border";
			// 
			// lbMmCtrlText
			// 
			lbMmCtrlText.AutoSize = true;
			lbMmCtrlText.Location = new System.Drawing.Point(226, 162);
			lbMmCtrlText.Margin = new System.Windows.Forms.Padding(5);
			lbMmCtrlText.Name = "lbMmCtrlText";
			lbMmCtrlText.Size = new System.Drawing.Size(105, 15);
			lbMmCtrlText.TabIndex = 13;
			lbMmCtrlText.Text = "Resize Image Mark";
			// 
			// HelpForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(444, 261);
			Controls.Add(tableLayout);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			KeyPreview = true;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "HelpForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			tableLayout.ResumeLayout(false);
			tableLayout.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayout;
		private System.Windows.Forms.Label lbLmbDrag;
		private System.Windows.Forms.Label lbLmbDragText;
		private System.Windows.Forms.Label lbImageEditor;
		private System.Windows.Forms.Label lbRmbDrag;
		private System.Windows.Forms.Label lbRmbDragText;
		private System.Windows.Forms.Label lbMwScroll;
		private System.Windows.Forms.Label lbMwText;
		private System.Windows.Forms.Label lbMmDel;
		private System.Windows.Forms.Label lbMmDelText;
		private System.Windows.Forms.Label lbLmbDragEsc;
		private System.Windows.Forms.Label lbLmbDragEscText;
		private System.Windows.Forms.Label lbMmCtrl;
		private System.Windows.Forms.Label lbMmCtrlText;
	}
}