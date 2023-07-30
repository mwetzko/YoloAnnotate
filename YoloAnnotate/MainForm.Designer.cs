using System.Windows.Forms;

namespace YoloAnnotate
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pnlControls = new Panel();
			flowProject = new FlowLayoutPanel();
			lbProjectName = new Label();
			btnSave = new Button();
			btnClose = new Button();
			pnlDiffer = new Panel();
			btnProjectOpen = new Button();
			btnProjectCreate = new Button();
			pnlProjectLabel = new Panel();
			lbProject = new Label();
			pnlClasses = new Panel();
			pnlClassesScroll = new Panel();
			pnlClassesList = new Panel();
			pnlClassNamePadding = new Panel();
			txtNewClass = new TextBox();
			lbClasses = new Label();
			pnlImages = new Panel();
			pnlImagesScroll = new Panel();
			pnlImagesList = new Panel();
			pnlImagesAdd = new Panel();
			tblAddImage = new TableLayoutPanel();
			btnImageFromClipboard = new Button();
			btnImageFromFile = new Button();
			lbImages = new Label();
			imageEditor = new ImageEditor();
			pnlControls.SuspendLayout();
			flowProject.SuspendLayout();
			pnlProjectLabel.SuspendLayout();
			pnlClasses.SuspendLayout();
			pnlClassesScroll.SuspendLayout();
			pnlClassNamePadding.SuspendLayout();
			pnlImages.SuspendLayout();
			pnlImagesScroll.SuspendLayout();
			pnlImagesAdd.SuspendLayout();
			tblAddImage.SuspendLayout();
			SuspendLayout();
			// 
			// pnlControls
			// 
			pnlControls.BackColor = System.Drawing.Color.LightGray;
			pnlControls.Controls.Add(flowProject);
			pnlControls.Controls.Add(pnlProjectLabel);
			pnlControls.Dock = DockStyle.Top;
			pnlControls.Location = new System.Drawing.Point(0, 0);
			pnlControls.Name = "pnlControls";
			pnlControls.Size = new System.Drawing.Size(1104, 58);
			pnlControls.TabIndex = 0;
			// 
			// flowProject
			// 
			flowProject.AutoSize = true;
			flowProject.Controls.Add(lbProjectName);
			flowProject.Controls.Add(btnSave);
			flowProject.Controls.Add(btnClose);
			flowProject.Controls.Add(pnlDiffer);
			flowProject.Controls.Add(btnProjectOpen);
			flowProject.Controls.Add(btnProjectCreate);
			flowProject.Dock = DockStyle.Top;
			flowProject.Location = new System.Drawing.Point(56, 0);
			flowProject.Name = "flowProject";
			flowProject.Padding = new Padding(5);
			flowProject.Size = new System.Drawing.Size(1048, 35);
			flowProject.TabIndex = 1;
			// 
			// lbProjectName
			// 
			lbProjectName.AutoSize = true;
			lbProjectName.Location = new System.Drawing.Point(10, 10);
			lbProjectName.Margin = new Padding(5);
			lbProjectName.Name = "lbProjectName";
			lbProjectName.Size = new System.Drawing.Size(23, 15);
			lbProjectName.TabIndex = 0;
			lbProjectName.Text = "<>";
			// 
			// btnSave
			// 
			btnSave.Location = new System.Drawing.Point(43, 6);
			btnSave.Margin = new Padding(5, 1, 5, 1);
			btnSave.Name = "btnSave";
			btnSave.Size = new System.Drawing.Size(75, 23);
			btnSave.TabIndex = 2;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new System.Drawing.Point(128, 6);
			btnClose.Margin = new Padding(5, 1, 5, 1);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(75, 23);
			btnClose.TabIndex = 3;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// pnlDiffer
			// 
			pnlDiffer.BackColor = System.Drawing.Color.Gray;
			pnlDiffer.Location = new System.Drawing.Point(213, 6);
			pnlDiffer.Margin = new Padding(5, 1, 5, 1);
			pnlDiffer.Name = "pnlDiffer";
			pnlDiffer.Size = new System.Drawing.Size(1, 23);
			pnlDiffer.TabIndex = 4;
			// 
			// btnProjectOpen
			// 
			btnProjectOpen.Location = new System.Drawing.Point(224, 6);
			btnProjectOpen.Margin = new Padding(5, 1, 5, 1);
			btnProjectOpen.Name = "btnProjectOpen";
			btnProjectOpen.Size = new System.Drawing.Size(75, 23);
			btnProjectOpen.TabIndex = 5;
			btnProjectOpen.Text = "Open";
			btnProjectOpen.UseVisualStyleBackColor = true;
			btnProjectOpen.Click += btnProjectOpen_Click;
			// 
			// btnProjectCreate
			// 
			btnProjectCreate.Location = new System.Drawing.Point(309, 6);
			btnProjectCreate.Margin = new Padding(5, 1, 5, 1);
			btnProjectCreate.Name = "btnProjectCreate";
			btnProjectCreate.Size = new System.Drawing.Size(75, 23);
			btnProjectCreate.TabIndex = 6;
			btnProjectCreate.Text = "Create";
			btnProjectCreate.UseVisualStyleBackColor = true;
			btnProjectCreate.Click += btnProjectCreate_Click;
			// 
			// pnlProjectLabel
			// 
			pnlProjectLabel.AutoSize = true;
			pnlProjectLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnlProjectLabel.Controls.Add(lbProject);
			pnlProjectLabel.Dock = DockStyle.Left;
			pnlProjectLabel.Location = new System.Drawing.Point(0, 0);
			pnlProjectLabel.Name = "pnlProjectLabel";
			pnlProjectLabel.Size = new System.Drawing.Size(56, 58);
			pnlProjectLabel.TabIndex = 0;
			// 
			// lbProject
			// 
			lbProject.AutoSize = true;
			lbProject.Location = new System.Drawing.Point(9, 10);
			lbProject.Margin = new Padding(10, 10, 0, 10);
			lbProject.Name = "lbProject";
			lbProject.Size = new System.Drawing.Size(47, 15);
			lbProject.TabIndex = 0;
			lbProject.Text = "Project:";
			// 
			// pnlClasses
			// 
			pnlClasses.BackColor = System.Drawing.Color.LightGray;
			pnlClasses.Controls.Add(pnlClassesScroll);
			pnlClasses.Controls.Add(pnlClassNamePadding);
			pnlClasses.Controls.Add(lbClasses);
			pnlClasses.Dock = DockStyle.Right;
			pnlClasses.Location = new System.Drawing.Point(904, 58);
			pnlClasses.Name = "pnlClasses";
			pnlClasses.Padding = new Padding(1, 0, 1, 0);
			pnlClasses.Size = new System.Drawing.Size(200, 583);
			pnlClasses.TabIndex = 1;
			// 
			// pnlClassesScroll
			// 
			pnlClassesScroll.AutoScroll = true;
			pnlClassesScroll.Controls.Add(pnlClassesList);
			pnlClassesScroll.Dock = DockStyle.Fill;
			pnlClassesScroll.Location = new System.Drawing.Point(1, 58);
			pnlClassesScroll.Name = "pnlClassesScroll";
			pnlClassesScroll.Size = new System.Drawing.Size(198, 525);
			pnlClassesScroll.TabIndex = 6;
			// 
			// pnlClassesList
			// 
			pnlClassesList.Dock = DockStyle.Top;
			pnlClassesList.Location = new System.Drawing.Point(0, 0);
			pnlClassesList.Name = "pnlClassesList";
			pnlClassesList.Size = new System.Drawing.Size(198, 388);
			pnlClassesList.TabIndex = 4;
			pnlClassesList.ControlAdded += ClassesListControlsChanged;
			pnlClassesList.ControlRemoved += ClassesListControlsChanged;
			// 
			// pnlClassNamePadding
			// 
			pnlClassNamePadding.AutoSize = true;
			pnlClassNamePadding.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnlClassNamePadding.Controls.Add(txtNewClass);
			pnlClassNamePadding.Dock = DockStyle.Top;
			pnlClassNamePadding.Location = new System.Drawing.Point(1, 28);
			pnlClassNamePadding.Name = "pnlClassNamePadding";
			pnlClassNamePadding.Padding = new Padding(3, 3, 3, 4);
			pnlClassNamePadding.Size = new System.Drawing.Size(198, 30);
			pnlClassNamePadding.TabIndex = 5;
			pnlClassNamePadding.Paint += PaintBottomLine;
			// 
			// txtNewClass
			// 
			txtNewClass.Dock = DockStyle.Top;
			txtNewClass.Location = new System.Drawing.Point(3, 3);
			txtNewClass.Name = "txtNewClass";
			txtNewClass.Size = new System.Drawing.Size(192, 23);
			txtNewClass.TabIndex = 3;
			txtNewClass.KeyDown += txtNewClass_KeyDown;
			// 
			// lbClasses
			// 
			lbClasses.Dock = DockStyle.Top;
			lbClasses.Location = new System.Drawing.Point(1, 0);
			lbClasses.Name = "lbClasses";
			lbClasses.Size = new System.Drawing.Size(198, 28);
			lbClasses.TabIndex = 2;
			lbClasses.Text = "Classes";
			lbClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			lbClasses.Paint += PaintBottomLine;
			// 
			// pnlImages
			// 
			pnlImages.BackColor = System.Drawing.Color.Gainsboro;
			pnlImages.Controls.Add(pnlImagesScroll);
			pnlImages.Controls.Add(pnlImagesAdd);
			pnlImages.Controls.Add(lbImages);
			pnlImages.Dock = DockStyle.Right;
			pnlImages.Location = new System.Drawing.Point(704, 58);
			pnlImages.Name = "pnlImages";
			pnlImages.Padding = new Padding(1, 0, 1, 0);
			pnlImages.Size = new System.Drawing.Size(200, 583);
			pnlImages.TabIndex = 2;
			// 
			// pnlImagesScroll
			// 
			pnlImagesScroll.AutoScroll = true;
			pnlImagesScroll.Controls.Add(pnlImagesList);
			pnlImagesScroll.Dock = DockStyle.Fill;
			pnlImagesScroll.Location = new System.Drawing.Point(1, 58);
			pnlImagesScroll.Name = "pnlImagesScroll";
			pnlImagesScroll.Size = new System.Drawing.Size(198, 525);
			pnlImagesScroll.TabIndex = 6;
			// 
			// pnlImagesList
			// 
			pnlImagesList.Dock = DockStyle.Top;
			pnlImagesList.Location = new System.Drawing.Point(0, 0);
			pnlImagesList.Name = "pnlImagesList";
			pnlImagesList.Size = new System.Drawing.Size(198, 388);
			pnlImagesList.TabIndex = 4;
			pnlImagesList.ControlAdded += ImageListControlsChanged;
			pnlImagesList.ControlRemoved += ImageListControlsChanged;
			// 
			// pnlImagesAdd
			// 
			pnlImagesAdd.AutoSize = true;
			pnlImagesAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnlImagesAdd.Controls.Add(tblAddImage);
			pnlImagesAdd.Dock = DockStyle.Top;
			pnlImagesAdd.Location = new System.Drawing.Point(1, 28);
			pnlImagesAdd.Name = "pnlImagesAdd";
			pnlImagesAdd.Padding = new Padding(0, 0, 0, 1);
			pnlImagesAdd.Size = new System.Drawing.Size(198, 30);
			pnlImagesAdd.TabIndex = 5;
			pnlImagesAdd.Paint += PaintBottomLine;
			// 
			// tblAddImage
			// 
			tblAddImage.AutoSize = true;
			tblAddImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tblAddImage.ColumnCount = 2;
			tblAddImage.ColumnStyles.Add(new ColumnStyle());
			tblAddImage.ColumnStyles.Add(new ColumnStyle());
			tblAddImage.Controls.Add(btnImageFromClipboard, 1, 0);
			tblAddImage.Controls.Add(btnImageFromFile, 0, 0);
			tblAddImage.Dock = DockStyle.Top;
			tblAddImage.Location = new System.Drawing.Point(0, 0);
			tblAddImage.Margin = new Padding(0);
			tblAddImage.Name = "tblAddImage";
			tblAddImage.RowCount = 1;
			tblAddImage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblAddImage.Size = new System.Drawing.Size(198, 29);
			tblAddImage.TabIndex = 0;
			// 
			// btnImageFromClipboard
			// 
			btnImageFromClipboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnImageFromClipboard.Location = new System.Drawing.Point(84, 3);
			btnImageFromClipboard.Name = "btnImageFromClipboard";
			btnImageFromClipboard.Size = new System.Drawing.Size(111, 23);
			btnImageFromClipboard.TabIndex = 1;
			btnImageFromClipboard.Text = "From Clipboard";
			btnImageFromClipboard.UseVisualStyleBackColor = true;
			btnImageFromClipboard.Click += btnImageFromClipboard_Click;
			// 
			// btnImageFromFile
			// 
			btnImageFromFile.Location = new System.Drawing.Point(3, 3);
			btnImageFromFile.Name = "btnImageFromFile";
			btnImageFromFile.Size = new System.Drawing.Size(75, 23);
			btnImageFromFile.TabIndex = 0;
			btnImageFromFile.Text = "From File";
			btnImageFromFile.UseVisualStyleBackColor = true;
			btnImageFromFile.Click += btnImageFromFile_Click;
			// 
			// lbImages
			// 
			lbImages.Dock = DockStyle.Top;
			lbImages.Location = new System.Drawing.Point(1, 0);
			lbImages.Name = "lbImages";
			lbImages.Size = new System.Drawing.Size(198, 28);
			lbImages.TabIndex = 3;
			lbImages.Text = "Images";
			lbImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			lbImages.Paint += PaintBottomLine;
			// 
			// imageEditor
			// 
			imageEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			imageEditor.ImageControl = null;
			imageEditor.Location = new System.Drawing.Point(0, 58);
			imageEditor.Name = "imageEditor";
			imageEditor.Size = new System.Drawing.Size(704, 583);
			imageEditor.TabIndex = 3;
			imageEditor.GetImageClassName += imageEditor_GetImageClassName;
			imageEditor.DeleteMarks += imageEditor_DeleteMarks;
			imageEditor.ResizeMarks += imageEditor_ResizeMarks;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1104, 641);
			Controls.Add(this.imageEditor);
			Controls.Add(pnlImages);
			Controls.Add(pnlClasses);
			Controls.Add(pnlControls);
			DoubleBuffered = true;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "YoloAnnotate";
			pnlControls.ResumeLayout(false);
			pnlControls.PerformLayout();
			flowProject.ResumeLayout(false);
			flowProject.PerformLayout();
			pnlProjectLabel.ResumeLayout(false);
			pnlProjectLabel.PerformLayout();
			pnlClasses.ResumeLayout(false);
			pnlClasses.PerformLayout();
			pnlClassesScroll.ResumeLayout(false);
			pnlClassNamePadding.ResumeLayout(false);
			pnlClassNamePadding.PerformLayout();
			pnlImages.ResumeLayout(false);
			pnlImages.PerformLayout();
			pnlImagesScroll.ResumeLayout(false);
			pnlImagesAdd.ResumeLayout(false);
			pnlImagesAdd.PerformLayout();
			tblAddImage.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlControls;
		private Panel pnlProjectLabel;
		private Label lbProject;
		private FlowLayoutPanel flowProject;
		private Label lbProjectName;
		private Button btnProjectOpen;
		private Button btnProjectCreate;
		private Button btnSave;
		private Panel pnlDiffer;
		private Button btnClose;
		private Panel pnlClasses;
		private Panel pnlImages;
		private Label lbClasses;
		private Label lbImages;
		private TextBox txtNewClass;
		private Panel pnlImagesList;
		private Panel pnlClassesList;
		private Panel pnlClassNamePadding;
		private Panel pnlClassesScroll;
		private Panel pnlImagesScroll;
		private Panel pnlImagesAdd;
		private Button btnImageFromFile;
		private Button btnImageFromClipboard;
		private TableLayoutPanel tblAddImage;
		private ImageEditor imageEditor;
	}
}