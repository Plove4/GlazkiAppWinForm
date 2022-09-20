namespace GlazkiApp.Views.PartialView
{
    partial class AgentCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeNameLbl = new System.Windows.Forms.Label();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.priotityLbl = new System.Windows.Forms.Label();
            this.priotityValueLbl = new System.Windows.Forms.Label();
            this.presentLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeNameLbl
            // 
            this.TypeNameLbl.AutoSize = true;
            this.TypeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeNameLbl.Location = new System.Drawing.Point(288, 24);
            this.TypeNameLbl.Name = "TypeNameLbl";
            this.TypeNameLbl.Size = new System.Drawing.Size(384, 31);
            this.TypeNameLbl.TabIndex = 1;
            this.TypeNameLbl.Text = "Тип | Наименование агента";
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qtyLbl.Location = new System.Drawing.Point(288, 79);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(230, 31);
            this.qtyLbl.TabIndex = 3;
            this.qtyLbl.Text = "10 продаж за год";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.Location = new System.Drawing.Point(288, 125);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(223, 31);
            this.phoneLbl.TabIndex = 4;
            this.phoneLbl.Text = "+7 900 000 00 00";
            // 
            // priotityLbl
            // 
            this.priotityLbl.AutoSize = true;
            this.priotityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priotityLbl.Location = new System.Drawing.Point(288, 175);
            this.priotityLbl.Name = "priotityLbl";
            this.priotityLbl.Size = new System.Drawing.Size(226, 31);
            this.priotityLbl.TabIndex = 5;
            this.priotityLbl.Text = "Приоритетность:";
            // 
            // priotityValueLbl
            // 
            this.priotityValueLbl.AutoSize = true;
            this.priotityValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priotityValueLbl.Location = new System.Drawing.Point(509, 175);
            this.priotityValueLbl.Name = "priotityValueLbl";
            this.priotityValueLbl.Size = new System.Drawing.Size(44, 31);
            this.priotityValueLbl.TabIndex = 6;
            this.priotityValueLbl.Text = "32";
            // 
            // presentLbl
            // 
            this.presentLbl.AutoSize = true;
            this.presentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presentLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.presentLbl.Location = new System.Drawing.Point(1277, 24);
            this.presentLbl.Name = "presentLbl";
            this.presentLbl.Size = new System.Drawing.Size(71, 31);
            this.presentLbl.TabIndex = 7;
            this.presentLbl.Text = "10%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlazkiApp.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.presentLbl);
            this.Controls.Add(this.priotityValueLbl);
            this.Controls.Add(this.priotityLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.TypeNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(1383, 237);
            this.Load += new System.EventHandler(this.AgentCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TypeNameLbl;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.Label priotityLbl;
        private System.Windows.Forms.Label priotityValueLbl;
        private System.Windows.Forms.Label presentLbl;
        public System.Windows.Forms.Label phoneLbl;
    }
}
