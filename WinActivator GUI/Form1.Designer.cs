namespace WinActivator_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Activate = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Activate
            // 
            Activate.BackColor = Color.BlueViolet;
            Activate.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
            Activate.FlatAppearance.BorderSize = 2;
            Activate.FlatStyle = FlatStyle.Flat;
            Activate.ForeColor = Color.FromArgb(255, 128, 255);
            Activate.Location = new Point(39, 176);
            Activate.Name = "Activate";
            Activate.Size = new Size(186, 50);
            Activate.TabIndex = 0;
            Activate.Text = "Activate Windows";
            Activate.UseVisualStyleBackColor = false;
            Activate.Click += Activate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 132);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = Activate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(264, 272);
            Controls.Add(pictureBox1);
            Controls.Add(Activate);
            Name = "Form1";
            ShowIcon = false;
            Text = "WinActivatorGUI";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Activate;
        private PictureBox pictureBox1;
    }
}
