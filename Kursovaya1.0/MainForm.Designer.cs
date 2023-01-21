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
            this.SuspendLayout();
            // 
            // WhereLabel
            // 
            this.WhereLabel.AutoSize = true;
            this.WhereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhereLabel.Location = new System.Drawing.Point(12, 9);
            this.WhereLabel.Name = "WhereLabel";
            this.WhereLabel.Size = new System.Drawing.Size(151, 20);
            this.WhereLabel.TabIndex = 0;
            this.WhereLabel.Text = "Пункт назначения:";
            // 
            // ChooseWhereToGo
            // 
            this.ChooseWhereToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseWhereToGo.FormattingEnabled = true;
            this.ChooseWhereToGo.Location = new System.Drawing.Point(169, 8);
            this.ChooseWhereToGo.Name = "ChooseWhereToGo";
            this.ChooseWhereToGo.Size = new System.Drawing.Size(121, 26);
            this.ChooseWhereToGo.TabIndex = 1;
            this.ChooseWhereToGo.SelectedIndexChanged += new System.EventHandler(this.ChooseWhereToGo_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.ChooseWhereToGo);
            this.Controls.Add(this.WhereLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhereLabel;
        private System.Windows.Forms.ComboBox ChooseWhereToGo;
    }
}