namespace Kursovaya1._0
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
            this.log_in = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // log_in
            // 
            this.log_in.Location = new System.Drawing.Point(231, 259);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(144, 44);
            this.log_in.TabIndex = 0;
            this.log_in.Text = "Авторизоваться";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(231, 139);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(144, 29);
            this.loginField.TabIndex = 1;
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(231, 184);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(144, 26);
            this.passField.TabIndex = 2;
            this.passField.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.log_in);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
    }
}

