
namespace Rudolf_Bank
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
            this.Button_LogOn = new System.Windows.Forms.Button();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.LabeL_Login = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.GroupBox_Auth = new System.Windows.Forms.GroupBox();
            this.GroupBox_Auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_LogOn
            // 
            this.Button_LogOn.Location = new System.Drawing.Point(6, 112);
            this.Button_LogOn.Name = "Button_LogOn";
            this.Button_LogOn.Size = new System.Drawing.Size(412, 42);
            this.Button_LogOn.TabIndex = 0;
            this.Button_LogOn.Text = "Войти";
            this.Button_LogOn.UseVisualStyleBackColor = true;
            this.Button_LogOn.Click += new System.EventHandler(this.Button_LogOn_Click);
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(100, 32);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(318, 33);
            this.TextBox_Login.TabIndex = 1;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(100, 73);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(318, 33);
            this.TextBox_Password.TabIndex = 2;
            // 
            // LabeL_Login
            // 
            this.LabeL_Login.AutoSize = true;
            this.LabeL_Login.Location = new System.Drawing.Point(6, 35);
            this.LabeL_Login.Name = "LabeL_Login";
            this.LabeL_Login.Size = new System.Drawing.Size(75, 25);
            this.LabeL_Login.TabIndex = 4;
            this.LabeL_Login.Text = "Логин:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(6, 76);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(88, 25);
            this.Label_Password.TabIndex = 5;
            this.Label_Password.Text = "Пароль:";
            // 
            // GroupBox_Auth
            // 
            this.GroupBox_Auth.Controls.Add(this.LabeL_Login);
            this.GroupBox_Auth.Controls.Add(this.Label_Password);
            this.GroupBox_Auth.Controls.Add(this.Button_LogOn);
            this.GroupBox_Auth.Controls.Add(this.TextBox_Login);
            this.GroupBox_Auth.Controls.Add(this.TextBox_Password);
            this.GroupBox_Auth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBox_Auth.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Auth.Name = "GroupBox_Auth";
            this.GroupBox_Auth.Size = new System.Drawing.Size(424, 163);
            this.GroupBox_Auth.TabIndex = 6;
            this.GroupBox_Auth.TabStop = false;
            this.GroupBox_Auth.Text = "Авторизация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 186);
            this.Controls.Add(this.GroupBox_Auth);
            this.Name = "Form1";
            this.Text = "Банкомат";
            this.GroupBox_Auth.ResumeLayout(false);
            this.GroupBox_Auth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_LogOn;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label LabeL_Login;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.GroupBox GroupBox_Auth;
    }
}

