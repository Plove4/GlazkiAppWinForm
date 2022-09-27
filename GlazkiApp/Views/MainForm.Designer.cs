namespace GlazkiApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Addbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.SortComboBox);
            this.panel1.Controls.Add(this.FiltrTypeComboBox);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 92);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1269, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "По возрастанию";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SortComboBox
            // 
            this.SortComboBox.BackColor = System.Drawing.Color.White;
            this.SortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Без сартировки",
            "Наименование",
            "Приоритет",
            "Скидка"});
            this.SortComboBox.Location = new System.Drawing.Point(1009, 22);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(254, 39);
            this.SortComboBox.TabIndex = 3;
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // FiltrTypeComboBox
            // 
            this.FiltrTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrTypeComboBox.FormattingEnabled = true;
            this.FiltrTypeComboBox.Location = new System.Drawing.Point(788, 22);
            this.FiltrTypeComboBox.Name = "FiltrTypeComboBox";
            this.FiltrTypeComboBox.Size = new System.Drawing.Size(200, 39);
            this.FiltrTypeComboBox.TabIndex = 2;
            this.FiltrTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrTypeComboBox_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.AccessibleName = "";
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchBox.Location = new System.Drawing.Point(123, 22);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(643, 45);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Text = "Введите текст";
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlazkiApp.Properties.Resources.Глазки_save;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1425, 73);
            this.panel2.TabIndex = 2;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.Addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(24, 16);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(182, 35);
            this.Addbtn.TabIndex = 22;
            this.Addbtn.Text = "Добавить";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1425, 498);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1425, 498);
            this.panel3.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1425, 663);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.ComboBox FiltrTypeComboBox;
        private System.Windows.Forms.Button Addbtn;
    }
}

