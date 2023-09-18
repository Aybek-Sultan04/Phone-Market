namespace PhoneMarket.UI.Forms
{
    partial class SingUpForm
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
            this.SingInButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitApplicatonLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SingUpLable = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SingInButton
            // 
            this.SingInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingInButton.Location = new System.Drawing.Point(158, 396);
            this.SingInButton.Name = "SingInButton";
            this.SingInButton.Size = new System.Drawing.Size(180, 50);
            this.SingInButton.TabIndex = 3;
            this.SingInButton.Text = "Enter";
            this.SingInButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(219)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.ExitApplicatonLable);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(482, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 553);
            this.panel2.TabIndex = 3;
            // 
            // ExitApplicatonLable
            // 
            this.ExitApplicatonLable.AutoSize = true;
            this.ExitApplicatonLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApplicatonLable.Location = new System.Drawing.Point(470, 0);
            this.ExitApplicatonLable.Name = "ExitApplicatonLable";
            this.ExitApplicatonLable.Size = new System.Drawing.Size(30, 29);
            this.ExitApplicatonLable.TabIndex = 1;
            this.ExitApplicatonLable.Text = "X";
            this.ExitApplicatonLable.Click += new System.EventHandler(this.ExitApplicatonLable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.SingUpLable);
            this.panel1.Controls.Add(this.SingInButton);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.LoginTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 553);
            this.panel1.TabIndex = 2;
            // 
            // SingUpLable
            // 
            this.SingUpLable.AutoSize = true;
            this.SingUpLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingUpLable.Location = new System.Drawing.Point(3, 571);
            this.SingUpLable.Name = "SingUpLable";
            this.SingUpLable.Size = new System.Drawing.Size(68, 20);
            this.SingUpLable.TabIndex = 4;
            this.SingUpLable.Text = "Sing Up";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 309);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 50);
            this.textBox2.TabIndex = 2;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(50, 209);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(400, 50);
            this.LoginTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneMarket.UI.Properties.Resources.picUser1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SingUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SingUpForm";
            this.Text = "SingUpForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SingInButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitApplicatonLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SingUpLable;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox LoginTextBox;
    }
}