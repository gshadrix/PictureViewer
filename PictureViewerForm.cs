using System;
using System.Windows.Forms;

namespace PictureViewer
{
    /// <summary>
    /// Stan Shadrix
    /// CS 6232 Homework 1
    /// Represents the main form of the Picture Viewer application.
    /// </summary>
    public partial class PictureViewerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureViewerForm"/> class.
        /// </summary>
        public PictureViewerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the PictureViewerForm.
        /// </summary>
        private void PictureViewerForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Show Picture button's Click event.
        /// </summary>
        private void ShowPictureButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (PictureOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageDisplayBox.Load(PictureOpenFileDialog.FileName);
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear Picture button. Clears the currently displayed picture.
        /// </summary>
        private void ClearPictureButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            ImageDisplayBox.Image = null;
        }

        /// <summary>
        /// Handles the Click event of the Set Background Color button. Opens a dialog to select a color.
        /// </summary>
        private void SetBackgroundColorButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (BackgroundColorDialog.ShowDialog() == DialogResult.OK)
                ImageDisplayBox.BackColor = BackgroundColorDialog.Color;
        }

        /// <summary>
        /// Handles the Click event of the Close Form button. Closes the form.
        /// </summary>
        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the Stretch Mode check box. Adjusts the size mode of the image.
        /// </summary>
        private void StretchModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (StretchModeCheckBox.Checked)
                ImageDisplayBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                ImageDisplayBox.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
