namespace BusyBeezApplication
{
    partial class frmMainView
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
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 14);
            label1.TabIndex = 0;
            label1.Text = "Busy Beez";
            label1.Click += label1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(26, 259);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(227, 130);
            checkedListBox1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(26, 85);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(282, 110);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 3;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(282, 153);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 4;
            button2.Text = "Notification";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(282, 193);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 5;
            button3.Text = "Notes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(99, 404);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "input";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // frmMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(401, 615);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMainView";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
