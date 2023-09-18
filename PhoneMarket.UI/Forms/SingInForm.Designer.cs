namespace PhoneMarket.UI.Forms
{
    partial class SingInForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitApplicatonLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SingUpLable = new System.Windows.Forms.Label();
            this.SingInButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.ExitApplicatonLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitApplicatonLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApplicatonLable.Location = new System.Drawing.Point(467, 0);
            this.ExitApplicatonLable.Name = "ExitApplicatonLable";
            this.ExitApplicatonLable.Size = new System.Drawing.Size(30, 29);
            this.ExitApplicatonLable.TabIndex = 1;
            this.ExitApplicatonLable.Text = "X";
            this.ExitApplicatonLable.Click += new System.EventHandler(this.ExitApplicatonLable_Click);
            this.ExitApplicatonLable.MouseEnter += new System.EventHandler(this.ExitApplicatonLable_MouseEnter);
            this.ExitApplicatonLable.MouseLeave += new System.EventHandler(this.ExitApplicatonLable_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneMarket.UI.Properties.Resources.picUser1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.SingUpLable);
            this.panel1.Controls.Add(this.SingInButton);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.LoginTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 553);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            // SingInButton
            // 
            this.SingInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingInButton.Location = new System.Drawing.Point(158, 396);
            this.SingInButton.Name = "SingInButton";
            this.SingInButton.Size = new System.Drawing.Size(180, 50);
            this.SingInButton.TabIndex = 3;
            this.SingInButton.Text = "Enter";
            this.SingInButton.UseVisualStyleBackColor = true;
            this.SingInButton.Click += new System.EventHandler(this.SingInButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(50, 309);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(400, 41);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.MouseEnter += new System.EventHandler(this.PasswordTextBox_MouseEnter);
            this.PasswordTextBox.MouseLeave += new System.EventHandler(this.PasswordTextBox_MouseLeave);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(50, 209);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(400, 50);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.MouseEnter += new System.EventHandler(this.LoginTextBox_MouseEnter);
            this.LoginTextBox.MouseLeave += new System.EventHandler(this.LoginTextBox_MouseLeave);
            // 
            // SingInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingInForm";
            this.Text = "SingInForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitApplicatonLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SingUpLable;
        private System.Windows.Forms.Button SingInButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
    }
}