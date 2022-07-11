
namespace Rudolf_Bank.Bank_Forms
{
    partial class Bank_Interface
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
            this.TextBox_Welcome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_Deposite_Count = new System.Windows.Forms.Label();
            this.TextBox_Deposite_Count = new System.Windows.Forms.TextBox();
            this.Label_Deposite_Nominal = new System.Windows.Forms.Label();
            this.TextBox_Balance = new System.Windows.Forms.TextBox();
            this.Button_Balance = new System.Windows.Forms.Button();
            this.Button_Deposite_Accept = new System.Windows.Forms.Button();
            this.Button_Deposite = new System.Windows.Forms.Button();
            this.TextBox_Deposite_Nominal = new System.Windows.Forms.TextBox();
            this.Button_Take_Accept = new System.Windows.Forms.Button();
            this.Button_Take = new System.Windows.Forms.Button();
            this.TextBox_Take = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Welcome
            // 
            this.TextBox_Welcome.Location = new System.Drawing.Point(12, 12);
            this.TextBox_Welcome.Name = "TextBox_Welcome";
            this.TextBox_Welcome.ReadOnly = true;
            this.TextBox_Welcome.Size = new System.Drawing.Size(776, 23);
            this.TextBox_Welcome.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_Deposite_Count);
            this.groupBox1.Controls.Add(this.TextBox_Deposite_Count);
            this.groupBox1.Controls.Add(this.Label_Deposite_Nominal);
            this.groupBox1.Controls.Add(this.TextBox_Balance);
            this.groupBox1.Controls.Add(this.Button_Balance);
            this.groupBox1.Controls.Add(this.Button_Deposite_Accept);
            this.groupBox1.Controls.Add(this.Button_Deposite);
            this.groupBox1.Controls.Add(this.TextBox_Deposite_Nominal);
            this.groupBox1.Controls.Add(this.Button_Take_Accept);
            this.groupBox1.Controls.Add(this.Button_Take);
            this.groupBox1.Controls.Add(this.TextBox_Take);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции";
            // 
            // Label_Deposite_Count
            // 
            this.Label_Deposite_Count.AutoSize = true;
            this.Label_Deposite_Count.Location = new System.Drawing.Point(173, 68);
            this.Label_Deposite_Count.Name = "Label_Deposite_Count";
            this.Label_Deposite_Count.Size = new System.Drawing.Size(72, 15);
            this.Label_Deposite_Count.TabIndex = 3;
            this.Label_Deposite_Count.Text = "Количество";
            this.Label_Deposite_Count.Visible = false;
            // 
            // TextBox_Deposite_Count
            // 
            this.TextBox_Deposite_Count.Location = new System.Drawing.Point(184, 95);
            this.TextBox_Deposite_Count.Name = "TextBox_Deposite_Count";
            this.TextBox_Deposite_Count.Size = new System.Drawing.Size(41, 23);
            this.TextBox_Deposite_Count.TabIndex = 8;
            this.TextBox_Deposite_Count.Visible = false;
            // 
            // Label_Deposite_Nominal
            // 
            this.Label_Deposite_Nominal.AutoSize = true;
            this.Label_Deposite_Nominal.Location = new System.Drawing.Point(96, 68);
            this.Label_Deposite_Nominal.Name = "Label_Deposite_Nominal";
            this.Label_Deposite_Nominal.Size = new System.Drawing.Size(59, 15);
            this.Label_Deposite_Nominal.TabIndex = 2;
            this.Label_Deposite_Nominal.Text = "Номинал";
            this.Label_Deposite_Nominal.Visible = false;
            // 
            // TextBox_Balance
            // 
            this.TextBox_Balance.Location = new System.Drawing.Point(125, 133);
            this.TextBox_Balance.Name = "TextBox_Balance";
            this.TextBox_Balance.ReadOnly = true;
            this.TextBox_Balance.Size = new System.Drawing.Size(100, 23);
            this.TextBox_Balance.TabIndex = 7;
            this.TextBox_Balance.Visible = false;
            // 
            // Button_Balance
            // 
            this.Button_Balance.Location = new System.Drawing.Point(6, 133);
            this.Button_Balance.Name = "Button_Balance";
            this.Button_Balance.Size = new System.Drawing.Size(75, 23);
            this.Button_Balance.TabIndex = 6;
            this.Button_Balance.Text = "Баланс";
            this.Button_Balance.UseVisualStyleBackColor = true;
            this.Button_Balance.Click += new System.EventHandler(this.Button_Balance_Click);
            // 
            // Button_Deposite_Accept
            // 
            this.Button_Deposite_Accept.Location = new System.Drawing.Point(254, 95);
            this.Button_Deposite_Accept.Name = "Button_Deposite_Accept";
            this.Button_Deposite_Accept.Size = new System.Drawing.Size(91, 23);
            this.Button_Deposite_Accept.TabIndex = 5;
            this.Button_Deposite_Accept.Text = "Подтвердить";
            this.Button_Deposite_Accept.UseVisualStyleBackColor = true;
            this.Button_Deposite_Accept.Visible = false;
            this.Button_Deposite_Accept.Click += new System.EventHandler(this.Button_Deposite_Accept_Click);
            // 
            // Button_Deposite
            // 
            this.Button_Deposite.Location = new System.Drawing.Point(6, 94);
            this.Button_Deposite.Name = "Button_Deposite";
            this.Button_Deposite.Size = new System.Drawing.Size(75, 23);
            this.Button_Deposite.TabIndex = 4;
            this.Button_Deposite.Text = "Внести";
            this.Button_Deposite.UseVisualStyleBackColor = true;
            this.Button_Deposite.Click += new System.EventHandler(this.Button_Deposite_Click);
            // 
            // TextBox_Deposite_Nominal
            // 
            this.TextBox_Deposite_Nominal.Location = new System.Drawing.Point(125, 95);
            this.TextBox_Deposite_Nominal.Name = "TextBox_Deposite_Nominal";
            this.TextBox_Deposite_Nominal.Size = new System.Drawing.Size(41, 23);
            this.TextBox_Deposite_Nominal.TabIndex = 3;
            this.TextBox_Deposite_Nominal.Visible = false;
            // 
            // Button_Take_Accept
            // 
            this.Button_Take_Accept.Location = new System.Drawing.Point(254, 23);
            this.Button_Take_Accept.Name = "Button_Take_Accept";
            this.Button_Take_Accept.Size = new System.Drawing.Size(91, 23);
            this.Button_Take_Accept.TabIndex = 2;
            this.Button_Take_Accept.Text = "Подтвердить";
            this.Button_Take_Accept.UseVisualStyleBackColor = true;
            this.Button_Take_Accept.Visible = false;
            this.Button_Take_Accept.Click += new System.EventHandler(this.Button_Take_Accept_Click);
            // 
            // Button_Take
            // 
            this.Button_Take.Location = new System.Drawing.Point(6, 22);
            this.Button_Take.Name = "Button_Take";
            this.Button_Take.Size = new System.Drawing.Size(75, 23);
            this.Button_Take.TabIndex = 1;
            this.Button_Take.Text = "Снять";
            this.Button_Take.UseVisualStyleBackColor = true;
            this.Button_Take.Click += new System.EventHandler(this.Button_Take_Click);
            // 
            // TextBox_Take
            // 
            this.TextBox_Take.Location = new System.Drawing.Point(125, 23);
            this.TextBox_Take.Name = "TextBox_Take";
            this.TextBox_Take.Size = new System.Drawing.Size(100, 23);
            this.TextBox_Take.TabIndex = 0;
            this.TextBox_Take.Visible = false;
            this.TextBox_Take.TextChanged += new System.EventHandler(this.TextBox_Take_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 292);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 0;
            // 
            // Bank_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBox_Welcome);
            this.Name = "Bank_Interface";
            this.Text = "Bank_Interface";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Welcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Balance;
        private System.Windows.Forms.Button Button_Deposite_Accept;
        private System.Windows.Forms.Button Button_Deposite;
        private System.Windows.Forms.TextBox TextBox_Deposite_Nominal;
        private System.Windows.Forms.Button Button_Take_Accept;
        private System.Windows.Forms.Button Button_Take;
        private System.Windows.Forms.TextBox TextBox_Take;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TextBox_Balance;
        private System.Windows.Forms.TextBox TextBox_Deposite_Count;
        private System.Windows.Forms.Label Label_Deposite_Nominal;
        private System.Windows.Forms.Label Label_Deposite_Count;
    }
}