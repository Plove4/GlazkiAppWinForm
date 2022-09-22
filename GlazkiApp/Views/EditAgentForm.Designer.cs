namespace GlazkiApp.Views
{
    partial class EditAgentForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAgentForm));
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaveButn = new System.Windows.Forms.Button();
            this.CancleButn = new System.Windows.Forms.Button();
            this.ChangeImageButn = new System.Windows.Forms.Button();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.agentTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            titleLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(23, 244);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 40;
            titleLabel.Text = "Title:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(23, 218);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(41, 13);
            priorityLabel.TabIndex = 38;
            priorityLabel.Text = "Priority:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(23, 192);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 36;
            phoneLabel.Text = "Phone:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Location = new System.Drawing.Point(23, 166);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(31, 13);
            kPPLabel.TabIndex = 34;
            kPPLabel.Text = "KPP:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(23, 140);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(29, 13);
            iNNLabel.TabIndex = 32;
            iNNLabel.Text = "INN:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 114);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 30;
            emailLabel.Text = "Email:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Location = new System.Drawing.Point(23, 88);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(78, 13);
            directorNameLabel.TabIndex = 28;
            directorNameLabel.Text = "Director Name:";
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Location = new System.Drawing.Point(23, 61);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(79, 13);
            agentTypeIDLabel.TabIndex = 26;
            agentTypeIDLabel.Text = "Agent Type ID:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(23, 35);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 24;
            addressLabel.Text = "Address:";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.AllowNew = true;
            this.agentBindingSource.DataSource = typeof(GlazkiApp.Models.Agent);
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(GlazkiApp.Models.AgentType);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 72);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 72);
            this.panel3.TabIndex = 43;
            // 
            // SaveButn
            // 
            this.SaveButn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.SaveButn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButn.ForeColor = System.Drawing.Color.White;
            this.SaveButn.Location = new System.Drawing.Point(122, 293);
            this.SaveButn.Name = "SaveButn";
            this.SaveButn.Size = new System.Drawing.Size(122, 35);
            this.SaveButn.TabIndex = 20;
            this.SaveButn.Text = "Сохранить";
            this.SaveButn.UseVisualStyleBackColor = false;
            this.SaveButn.Click += new System.EventHandler(this.SaveButn_Click);
            // 
            // CancleButn
            // 
            this.CancleButn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.CancleButn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancleButn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancleButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancleButn.ForeColor = System.Drawing.Color.White;
            this.CancleButn.Location = new System.Drawing.Point(306, 293);
            this.CancleButn.Name = "CancleButn";
            this.CancleButn.Size = new System.Drawing.Size(122, 35);
            this.CancleButn.TabIndex = 21;
            this.CancleButn.Text = "Отмена";
            this.CancleButn.UseVisualStyleBackColor = false;
            this.CancleButn.Click += new System.EventHandler(this.CancleButn_Click);
            // 
            // ChangeImageButn
            // 
            this.ChangeImageButn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.ChangeImageButn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeImageButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeImageButn.ForeColor = System.Drawing.Color.White;
            this.ChangeImageButn.Location = new System.Drawing.Point(378, 177);
            this.ChangeImageButn.Name = "ChangeImageButn";
            this.ChangeImageButn.Size = new System.Drawing.Size(122, 35);
            this.ChangeImageButn.TabIndex = 22;
            this.ChangeImageButn.Text = "Выбрать";
            this.ChangeImageButn.UseVisualStyleBackColor = false;
            this.ChangeImageButn.Click += new System.EventHandler(this.ChangeImageButn_Click);
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::GlazkiApp.Properties.Resources.picture;
            this.LogoPicBox.Location = new System.Drawing.Point(345, 39);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(175, 132);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicBox.TabIndex = 24;
            this.LogoPicBox.TabStop = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(108, 241);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(213, 20);
            this.titleTextBox.TabIndex = 41;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(108, 215);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(213, 20);
            this.priorityTextBox.TabIndex = 39;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(108, 189);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(213, 20);
            this.phoneTextBox.TabIndex = 37;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(108, 163);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(213, 20);
            this.kPPTextBox.TabIndex = 35;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(108, 137);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(213, 20);
            this.iNNTextBox.TabIndex = 33;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 111);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(213, 20);
            this.emailTextBox.TabIndex = 31;
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "DirectorName", true));
            this.directorNameTextBox.Location = new System.Drawing.Point(108, 85);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(213, 20);
            this.directorNameTextBox.TabIndex = 29;
            // 
            // agentTypeIDComboBox
            // 
            this.agentTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentBindingSource, "AgentTypeID", true));
            this.agentTypeIDComboBox.DataSource = this.agentTypeBindingSource;
            this.agentTypeIDComboBox.DisplayMember = "Title";
            this.agentTypeIDComboBox.FormattingEnabled = true;
            this.agentTypeIDComboBox.Location = new System.Drawing.Point(108, 58);
            this.agentTypeIDComboBox.Name = "agentTypeIDComboBox";
            this.agentTypeIDComboBox.Size = new System.Drawing.Size(213, 21);
            this.agentTypeIDComboBox.TabIndex = 27;
            this.agentTypeIDComboBox.ValueMember = "ID";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(108, 32);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(213, 20);
            this.addressTextBox.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 26);
            this.panel4.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(agentTypeIDLabel);
            this.panel1.Controls.Add(this.agentTypeIDComboBox);
            this.panel1.Controls.Add(directorNameLabel);
            this.panel1.Controls.Add(this.directorNameTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(iNNLabel);
            this.panel1.Controls.Add(this.iNNTextBox);
            this.panel1.Controls.Add(kPPLabel);
            this.panel1.Controls.Add(this.kPPTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(priorityLabel);
            this.panel1.Controls.Add(this.priorityTextBox);
            this.panel1.Controls.Add(titleLabel);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.LogoPicBox);
            this.panel1.Controls.Add(this.ChangeImageButn);
            this.panel1.Controls.Add(this.CancleButn);
            this.panel1.Controls.Add(this.SaveButn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 351);
            this.panel1.TabIndex = 0;
            // 
            // EditAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 351);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAgentForm";
            this.Text = "EditAgentForm";
            this.Load += new System.EventHandler(this.EditAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SaveButn;
        private System.Windows.Forms.Button CancleButn;
        private System.Windows.Forms.Button ChangeImageButn;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.ComboBox agentTypeIDComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}