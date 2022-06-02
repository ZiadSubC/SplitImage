namespace imageSplit.winForms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.pictureBox2 = new System.Windows.Forms.PictureBox();
    
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();

            this.SuspendLayout();
            
            // 
            // pictureBox2
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox2";
            this.pictureBox1.Size = new System.Drawing.Size(544, 391);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox2.Location = new System.Drawing.Point(444, 0);
            this.pictureBox2.Name = "pictureBox4";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(544, 392);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;

    }
}