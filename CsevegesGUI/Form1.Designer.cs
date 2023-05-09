namespace CsevegesGUI
{
    partial class Form1
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
            cbKezd = new ComboBox();
            cbFoga = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tbCsev = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Kezdeményező";
            // 
            // cbKezd
            // 
            cbKezd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKezd.FormattingEnabled = true;
            cbKezd.Location = new Point(140, 24);
            cbKezd.Name = "cbKezd";
            cbKezd.Size = new Size(176, 23);
            cbKezd.TabIndex = 1;
            cbKezd.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // cbFoga
            // 
            cbFoga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoga.FormattingEnabled = true;
            cbFoga.Location = new Point(140, 57);
            cbFoga.Name = "cbFoga";
            cbFoga.Size = new Size(176, 23);
            cbFoga.TabIndex = 3;
            cbFoga.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 60);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Fogadó (partner)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 111);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Csevegések";
            // 
            // tbCsev
            // 
            tbCsev.Location = new Point(30, 129);
            tbCsev.Multiline = true;
            tbCsev.Name = "tbCsev";
            tbCsev.Size = new Size(286, 309);
            tbCsev.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 450);
            Controls.Add(tbCsev);
            Controls.Add(label3);
            Controls.Add(cbFoga);
            Controls.Add(label2);
            Controls.Add(cbKezd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Csevegés GUI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbKezd;
        private ComboBox cbFoga;
        private Label label2;
        private Label label3;
        private TextBox tbCsev;
    }
}