namespace AutoClicker
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
            button1 = new Button();
            button2 = new Button();
            comboBoxKey = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 148);
            button1.Name = "button1";
            button1.Size = new Size(221, 86);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(282, 148);
            button2.Name = "button2";
            button2.Size = new Size(221, 86);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBoxKey
            // 
            comboBoxKey.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKey.Font = new Font("Segoe UI", 16F);
            comboBoxKey.FormattingEnabled = true;
            comboBoxKey.Location = new Point(30, 64);
            comboBoxKey.Name = "comboBoxKey";
            comboBoxKey.Size = new Size(134, 45);
            comboBoxKey.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 23F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 52);
            label1.TabIndex = 3;
            label1.Text = "KEYBINDS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(282, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(515, 253);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBoxKey);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CAC";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBoxKey;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
