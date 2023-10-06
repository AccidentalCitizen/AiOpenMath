namespace Visualizer
{
    partial class Main
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
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.AnglePictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayBox.Location = new System.Drawing.Point(0, 0);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(1779, 1119);
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.Click += new System.EventHandler(this.DisplayBox_Click);
            this.DisplayBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayBox_MouseClick);
            this.DisplayBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DisplayBox_MouseMove);
            this.DisplayBox.Resize += new System.EventHandler(this.DisplayBox_Resize);
            // 
            // AnglePictureBox
            // 
            this.AnglePictureBox.Location = new System.Drawing.Point(0, 0);
            this.AnglePictureBox.Name = "AnglePictureBox";
            this.AnglePictureBox.Size = new System.Drawing.Size(528, 434);
            this.AnglePictureBox.TabIndex = 1;
            this.AnglePictureBox.TabStop = false;
            this.AnglePictureBox.Click += new System.EventHandler(this.AnglePictureBox_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 518);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(528, 74);
            this.button2.TabIndex = 14;
            this.button2.Text = "StopAnimation";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(528, 74);
            this.button1.TabIndex = 13;
            this.button1.Text = "Animate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(789, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 38);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(1343, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(436, 38);
            this.textBox2.TabIndex = 16;
            this.textBox2.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 1119);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnglePictureBox);
            this.Controls.Add(this.DisplayBox);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.PictureBox AnglePictureBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

