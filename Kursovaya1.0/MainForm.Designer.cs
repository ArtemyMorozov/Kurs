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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WhereLabel = new System.Windows.Forms.Label();
            this.ChooseWhereToGo = new System.Windows.Forms.ComboBox();
            this.Closelabel = new System.Windows.Forms.Label();
            this.AnotherDateLable = new System.Windows.Forms.Label();
            this.TransferTextDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FreeSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketsAmmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.ComboBox();
            this.ClosestTime = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WhereLabel
            // 
            this.WhereLabel.AutoSize = true;
            this.WhereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhereLabel.Location = new System.Drawing.Point(16, 29);
            this.WhereLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WhereLabel.Name = "WhereLabel";
            this.WhereLabel.Size = new System.Drawing.Size(187, 25);
            this.WhereLabel.TabIndex = 0;
            this.WhereLabel.Text = "Пункт назначения:";
            // 
            // ChooseWhereToGo
            // 
            this.ChooseWhereToGo.DropDownHeight = 200;
            this.ChooseWhereToGo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseWhereToGo.FormattingEnabled = true;
            this.ChooseWhereToGo.IntegralHeight = false;
            this.ChooseWhereToGo.Location = new System.Drawing.Point(21, 58);
            this.ChooseWhereToGo.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseWhereToGo.MaxDropDownItems = 15;
            this.ChooseWhereToGo.Name = "ChooseWhereToGo";
            this.ChooseWhereToGo.Size = new System.Drawing.Size(251, 32);
            this.ChooseWhereToGo.TabIndex = 1;
            this.ChooseWhereToGo.SelectedIndexChanged += new System.EventHandler(this.ChooseWhereToGo_SelectedIndexChanged);
            this.ChooseWhereToGo.Enter += new System.EventHandler(this.ChooseWhereToGo_Enter);
            this.ChooseWhereToGo.Leave += new System.EventHandler(this.ChooseWhereToGo_Leave);
            // 
            // Closelabel
            // 
            this.Closelabel.AutoSize = true;
            this.Closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closelabel.Location = new System.Drawing.Point(698, 29);
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
            this.AnotherDateLable.Location = new System.Drawing.Point(357, 29);
            this.AnotherDateLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnotherDateLable.Name = "AnotherDateLable";
            this.AnotherDateLable.Size = new System.Drawing.Size(130, 25);
            this.AnotherDateLable.TabIndex = 4;
            this.AnotherDateLable.Text = "Выбор даты:";
            // 
            // TransferTextDate
            // 
            this.TransferTextDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.TransferTextDate.Location = new System.Drawing.Point(21, 186);
            this.TransferTextDate.Margin = new System.Windows.Forms.Padding(4);
            this.TransferTextDate.Multiline = true;
            this.TransferTextDate.Name = "TransferTextDate";
            this.TransferTextDate.Size = new System.Drawing.Size(251, 32);
            this.TransferTextDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пересадка:";
            // 
            // FreeSeats
            // 
            this.FreeSeats.Font = new System.Drawing.Font("Calibri", 12F);
            this.FreeSeats.Location = new System.Drawing.Point(362, 189);
            this.FreeSeats.Margin = new System.Windows.Forms.Padding(4);
            this.FreeSeats.Name = "FreeSeats";
            this.FreeSeats.Size = new System.Drawing.Size(251, 32);
            this.FreeSeats.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(357, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество свободных мест:";
            // 
            // TicketsAmmount
            // 
            this.TicketsAmmount.Font = new System.Drawing.Font("Calibri", 12F);
            this.TicketsAmmount.Location = new System.Drawing.Point(703, 189);
            this.TicketsAmmount.Margin = new System.Windows.Forms.Padding(4);
            this.TicketsAmmount.Name = "TicketsAmmount";
            this.TicketsAmmount.Size = new System.Drawing.Size(251, 32);
            this.TicketsAmmount.TabIndex = 14;
            this.TicketsAmmount.TextChanged += new System.EventHandler(this.TicketsAmmount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(698, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Нужно билетов:";
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Calibri", 12F);
            this.PriceText.Location = new System.Drawing.Point(21, 488);
            this.PriceText.Margin = new System.Windows.Forms.Padding(4);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(251, 32);
            this.PriceText.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 459);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Стоимость:";
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Buy.FlatAppearance.BorderSize = 0;
            this.Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buy.Location = new System.Drawing.Point(703, 464);
            this.Buy.Margin = new System.Windows.Forms.Padding(4);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(251, 54);
            this.Buy.TabIndex = 17;
            this.Buy.Text = "Оформить";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Calibri", 12F);
            this.date.FormattingEnabled = true;
            this.date.Location = new System.Drawing.Point(362, 58);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(251, 32);
            this.date.TabIndex = 18;
            this.date.SelectedIndexChanged += new System.EventHandler(this.date_SelectedIndexChanged);
            // 
            // ClosestTime
            // 
            this.ClosestTime.Font = new System.Drawing.Font("Calibri", 12F);
            this.ClosestTime.Location = new System.Drawing.Point(703, 58);
            this.ClosestTime.Margin = new System.Windows.Forms.Padding(4);
            this.ClosestTime.Multiline = true;
            this.ClosestTime.Name = "ClosestTime";
            this.ClosestTime.Size = new System.Drawing.Size(251, 32);
            this.ClosestTime.TabIndex = 19;
            this.ClosestTime.TextChanged += new System.EventHandler(this.ClosestTime_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(279, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 329);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(982, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClosestTime);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TicketsAmmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FreeSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransferTextDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnotherDateLable);
            this.Controls.Add(this.Closelabel);
            this.Controls.Add(this.ChooseWhereToGo);
            this.Controls.Add(this.WhereLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Касса аэрофлота";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox FreeSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TicketsAmmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.ComboBox date;
        private System.Windows.Forms.TextBox ClosestTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}