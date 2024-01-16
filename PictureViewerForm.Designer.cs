namespace PictureViewer
{
    partial class PictureViewerForm
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImageDisplayBox = new System.Windows.Forms.PictureBox();
            this.StretchModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPictureButton = new System.Windows.Forms.Button();
            this.ClearPictureButton = new System.Windows.Forms.Button();
            this.SetBackgroundColorButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.PictureOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BackgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplayBox)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MainLayoutPanel.Controls.Add(this.ImageDisplayBox, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.StretchModeCheckBox, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.ButtonPanel, 1, 1);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(863, 548);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // ImageDisplayBox
            // 
            this.ImageDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainLayoutPanel.SetColumnSpan(this.ImageDisplayBox, 2);
            this.ImageDisplayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageDisplayBox.Location = new System.Drawing.Point(2, 2);
            this.ImageDisplayBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImageDisplayBox.Name = "ImageDisplayBox";
            this.ImageDisplayBox.Size = new System.Drawing.Size(859, 489);
            this.ImageDisplayBox.TabIndex = 0;
            this.ImageDisplayBox.TabStop = false;
            // 
            // StretchModeCheckBox
            // 
            this.StretchModeCheckBox.AutoSize = true;
            this.StretchModeCheckBox.Location = new System.Drawing.Point(2, 495);
            this.StretchModeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.StretchModeCheckBox.Name = "StretchModeCheckBox";
            this.StretchModeCheckBox.Size = new System.Drawing.Size(60, 17);
            this.StretchModeCheckBox.TabIndex = 1;
            this.StretchModeCheckBox.Text = "Stretch";
            this.StretchModeCheckBox.UseVisualStyleBackColor = true;
            this.StretchModeCheckBox.CheckedChanged += new System.EventHandler(this.StretchModeCheckBoxCheckedChanged);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ShowPictureButton);
            this.ButtonPanel.Controls.Add(this.ClearPictureButton);
            this.ButtonPanel.Controls.Add(this.SetBackgroundColorButton);
            this.ButtonPanel.Controls.Add(this.CloseFormButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonPanel.Location = new System.Drawing.Point(131, 495);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(730, 51);
            this.ButtonPanel.TabIndex = 2;
            // 
            // ShowPictureButton
            // 
            this.ShowPictureButton.AutoSize = true;
            this.ShowPictureButton.Location = new System.Drawing.Point(639, 2);
            this.ShowPictureButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPictureButton.Name = "ShowPictureButton";
            this.ShowPictureButton.Size = new System.Drawing.Size(89, 23);
            this.ShowPictureButton.TabIndex = 0;
            this.ShowPictureButton.Text = "Show a Picture";
            this.ShowPictureButton.UseVisualStyleBackColor = true;
            this.ShowPictureButton.Click += new System.EventHandler(this.ShowPictureButtonClick);
            // 
            // ClearPictureButton
            // 
            this.ClearPictureButton.AutoSize = true;
            this.ClearPictureButton.Location = new System.Drawing.Point(541, 2);
            this.ClearPictureButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearPictureButton.Name = "ClearPictureButton";
            this.ClearPictureButton.Size = new System.Drawing.Size(94, 23);
            this.ClearPictureButton.TabIndex = 1;
            this.ClearPictureButton.Text = "Clear the picture";
            this.ClearPictureButton.UseVisualStyleBackColor = true;
            this.ClearPictureButton.Click += new System.EventHandler(this.ClearPictureButtonClick);
            // 
            // SetBackgroundColorButton
            // 
            this.SetBackgroundColorButton.AutoSize = true;
            this.SetBackgroundColorButton.Location = new System.Drawing.Point(400, 2);
            this.SetBackgroundColorButton.Margin = new System.Windows.Forms.Padding(2);
            this.SetBackgroundColorButton.Name = "SetBackgroundColorButton";
            this.SetBackgroundColorButton.Size = new System.Drawing.Size(137, 23);
            this.SetBackgroundColorButton.TabIndex = 2;
            this.SetBackgroundColorButton.Text = "Set the background color";
            this.SetBackgroundColorButton.UseVisualStyleBackColor = true;
            this.SetBackgroundColorButton.Click += new System.EventHandler(this.SetBackgroundColorButtonClick);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.AutoSize = true;
            this.CloseFormButton.Location = new System.Drawing.Point(340, 2);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(56, 23);
            this.CloseFormButton.TabIndex = 3;
            this.CloseFormButton.Text = "Close";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButtonClick);
            // 
            // PictureOpenFileDialog
            // 
            this.PictureOpenFileDialog.FileName = "PictureOpenFileDialog";
            this.PictureOpenFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.PictureOpenFileDialog.Title = "Select a picture file";
            // 
            // PictureViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 548);
            this.Controls.Add(this.MainLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PictureViewerForm";
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.PictureViewerFormLoad);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplayBox)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.PictureBox ImageDisplayBox;
        private System.Windows.Forms.CheckBox StretchModeCheckBox;
        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button ShowPictureButton;
        private System.Windows.Forms.Button ClearPictureButton;
        private System.Windows.Forms.Button SetBackgroundColorButton;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.OpenFileDialog PictureOpenFileDialog;
        private System.Windows.Forms.ColorDialog BackgroundColorDialog;
    }
}

