namespace Stok_Takip___Masaustu_Uygulama
{
    partial class userScreen
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
            this.registerBtn = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userPasswordTXT = new System.Windows.Forms.Label();
            this.userNameTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.AutoSize = true;
            this.registerBtn.Location = new System.Drawing.Point(257, 282);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(52, 16);
            this.registerBtn.TabIndex = 11;
            this.registerBtn.TabStop = true;
            this.registerBtn.Text = "Kayıt Ol";
            this.registerBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerBtn_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(126, 228);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(111, 23);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Giriş Yap";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // userPasswordTXT
            // 
            this.userPasswordTXT.AutoSize = true;
            this.userPasswordTXT.Location = new System.Drawing.Point(61, 175);
            this.userPasswordTXT.Name = "userPasswordTXT";
            this.userPasswordTXT.Size = new System.Drawing.Size(96, 16);
            this.userPasswordTXT.TabIndex = 9;
            this.userPasswordTXT.Text = "Kullanıcı Şifresi";
            // 
            // userNameTXT
            // 
            this.userNameTXT.AutoSize = true;
            this.userNameTXT.Location = new System.Drawing.Point(61, 131);
            this.userNameTXT.Name = "userNameTXT";
            this.userNameTXT.Size = new System.Drawing.Size(79, 16);
            this.userNameTXT.TabIndex = 10;
            this.userNameTXT.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Girişi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 5;
            // 
            // userScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 373);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userPasswordTXT);
            this.Controls.Add(this.userNameTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "userScreen";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel registerBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userPasswordTXT;
        private System.Windows.Forms.Label userNameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}