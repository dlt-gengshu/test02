namespace test01
{
    partial class Form1
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblboom = new Gizmox.WebGUI.Forms.Label();
            this.button1 = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // lblboom
            // 
            this.lblboom.AutoSize = true;
            this.lblboom.Location = new System.Drawing.Point(616, 132);
            this.lblboom.Name = "lblboom";
            this.lblboom.Size = new System.Drawing.Size(35, 13);
            this.lblboom.TabIndex = 0;
            this.lblboom.Text = "你看不见我";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "点击";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblboom);
            this.Size = new System.Drawing.Size(1077, 504);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblboom;
        private Gizmox.WebGUI.Forms.Button button1;
    }
}