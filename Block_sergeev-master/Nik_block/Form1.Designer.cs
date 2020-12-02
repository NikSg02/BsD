namespace Nik_block
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoginB = new System.Windows.Forms.TextBox();
            this.PasswordB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.Location = new System.Drawing.Point(320, 177);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(100, 20);
            this.LoginB.TabIndex = 0;
            // 
            // PasswordB
            // 
            this.PasswordB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordB.Location = new System.Drawing.Point(320, 225);
            this.PasswordB.Name = "PasswordB";
            this.PasswordB.PasswordChar = '*';
            this.PasswordB.ShortcutsEnabled = false;
            this.PasswordB.Size = new System.Drawing.Size(100, 20);
            this.PasswordB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeS
            // 
            this.TimeS.AutoSize = true;
            this.TimeS.Location = new System.Drawing.Point(332, 162);
            this.TimeS.Name = "TimeS";
            this.TimeS.Size = new System.Drawing.Size(0, 13);
            this.TimeS.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 443);
            this.Controls.Add(this.TimeS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordB);
            this.Controls.Add(this.LoginB);
            this.Name = "Form1";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginB;
        private System.Windows.Forms.TextBox PasswordB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TimeS;
        public System.Windows.Forms.Timer timer1;
    }
}

