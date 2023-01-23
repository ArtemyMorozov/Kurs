namespace Kursovaya1._0
{
    partial class MainForm
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
            this.WhereLabel = new System.Windows.Forms.Label();
            this.ChooseWhereToGo = new System.Windows.Forms.ComboBox();
            this.Closelabel = new System.Windows.Forms.Label();
            this.AnotherDateLable = new System.Windows.Forms.Label();
            this.TransferTextDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.ComboBox();
            this.ClosestTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WhereLabel
            // 
            this.WhereLabel.AutoSize = true;
            this.WhereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhereLabel.Location = new System.Drawing.Point(16, 11);
            this.WhereLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WhereLabel.Name = "WhereLabel";
            this.WhereLabel.Size = new System.Drawing.Size(187, 25);
            this.WhereLabel.TabIndex = 0;
            this.WhereLabel.Text = "Пункт назначения:";
            // 
            // ChooseWhereToGo
            // 
            this.ChooseWhereToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseWhereToGo.FormattingEnabled = true;
            this.ChooseWhereToGo.Location = new System.Drawing.Point(211, 9);
            this.ChooseWhereToGo.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseWhereToGo.Name = "ChooseWhereToGo";
            this.ChooseWhereToGo.Size = new System.Drawing.Size(160, 32);
            this.ChooseWhereToGo.TabIndex = 1;
            this.ChooseWhereToGo.SelectedIndexChanged += new System.EventHandler(this.ChooseWhereToGo_SelectedIndexChanged);
            // 
            // Closelabel
            // 
            this.Closelabel.AutoSize = true;
            this.Closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closelabel.Location = new System.Drawing.Point(509, 11);
            this.Closelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Closelabel.Name = "Closelabel";
            this.Closelabel.Size = new System.Drawing.Size(177, 25);
            this.Closelabel.TabIndex = 2;
            this.Closelabel.Text = "Ближайший рейс:";
            // 
            // AnotherDateLable
            // 
            this.AnotherDateLable.AutoSize = true;
            this.AnotherDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnotherDateLable.Location = new System.Drawing.Point(16, 113);
            this.AnotherDateLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnotherDateLable.Name = "AnotherDateLable";
            this.AnotherDateLable.Size = new System.Drawing.Size(130, 25);
            this.AnotherDateLable.TabIndex = 4;
            this.AnotherDateLable.Text = "Выбор даты:";
            // 
            // TransferTextDate
            // 
            this.TransferTextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferTextDate.Location = new System.Drawing.Point(154, 201);
            this.TransferTextDate.Margin = new System.Windows.Forms.Padding(4);
            this.TransferTextDate.Name = "TransferTextDate";
            this.TransferTextDate.Size = new System.Drawing.Size(246, 29);
            this.TransferTextDate.TabIndex = 10;
            this.TransferTextDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пересадка:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(332, 297);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 29);
            this.textBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество свободных мест:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(796, 294);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 29);
            this.textBox4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(616, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Нужно билетов:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(165, 412);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 29);
            this.textBox5.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Стоимость:";
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Location = new System.Drawing.Point(456, 482);
            this.log_in.Margin = new System.Windows.Forms.Padding(4);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(189, 54);
            this.log_in.TabIndex = 17;
            this.log_in.Text = "Оформить";
            this.log_in.UseVisualStyleBackColor = false;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.FormattingEnabled = true;
            this.date.Location = new System.Drawing.Point(154, 106);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(246, 32);
            this.date.TabIndex = 18;
            this.date.SelectedIndexChanged += new System.EventHandler(this.date_SelectedIndexChanged);
            // 
            // ClosestTime
            // 
            this.ClosestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClosestTime.Location = new System.Drawing.Point(728, 7);
            this.ClosestTime.Margin = new System.Windows.Forms.Padding(4);
            this.ClosestTime.Name = "ClosestTime";
            this.ClosestTime.Size = new System.Drawing.Size(334, 29);
            this.ClosestTime.TabIndex = 19;
            this.ClosestTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 567);
            this.Controls.Add(this.ClosestTime);
            this.Controls.Add(this.date);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransferTextDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnotherDateLable);
            this.Controls.Add(this.Closelabel);
            this.Controls.Add(this.ChooseWhereToGo);
            this.Controls.Add(this.WhereLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhereLabel;
        private System.Windows.Forms.ComboBox ChooseWhereToGo;
        private System.Windows.Forms.Label Closelabel;
        private System.Windows.Forms.Label AnotherDateLable;
        private System.Windows.Forms.TextBox TransferTextDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.ComboBox date;
        private System.Windows.Forms.TextBox ClosestTime;
    }
}