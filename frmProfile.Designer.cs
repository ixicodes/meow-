

using System.Diagnostics;

namespace BusyBeezApplication
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class frmProfiles
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

        private Button GetButton1()
        {
            return button1;
        }

        private PictureBox GetPictureBox1()
        {
            return pictureBox1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button button1, PictureBox pictureBox1)
        {


        }

        private void NewMethod2()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;

        private string GetDebuggerDisplay() => ToString();
        private Button button1;
        private Button button2;
    }
    #endregion




}