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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label titleLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAgentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboxTypeAgent = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChangeImageButn = new System.Windows.Forms.Button();
            this.CancleButn = new System.Windows.Forms.Button();
            this.SaveButn = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(35, 227);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Location = new System.Drawing.Point(35, 67);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(78, 13);
            directorNameLabel.TabIndex = 4;
            directorNameLabel.Text = "Director Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(35, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(35, 119);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(29, 13);
            iNNLabel.TabIndex = 8;
            iNNLabel.Text = "INN:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Location = new System.Drawing.Point(35, 145);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(31, 13);
            kPPLabel.TabIndex = 10;
            kPPLabel.Text = "KPP:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(35, 175);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Phone:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(35, 201);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(41, 13);
            priorityLabel.TabIndex = 16;
            priorityLabel.Text = "Priority:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(40, 41);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 18;
            titleLabel.Text = "Title:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(35, 250);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(59, 13);
            titleLabel1.TabIndex = 22;
            titleLabel1.Text = "AgenType:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComboxTypeAgent);
            this.panel1.Controls.Add(titleLabel1);
            this.panel1.Controls.Add(this.ChangeImageButn);
            this.panel1.Controls.Add(this.CancleButn);
            this.panel1.Controls.Add(this.SaveButn);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(directorNameLabel);
            this.panel1.Controls.Add(this.directorNameTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(iNNLabel);
            this.panel1.Controls.Add(this.iNNTextBox);
            this.panel1.Controls.Add(kPPLabel);
            this.panel1.Controls.Add(this.kPPTextBox);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(priorityLabel);
            this.panel1.Controls.Add(this.priorityTextBox);
            this.panel1.Controls.Add(titleLabel);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 354);
            this.panel1.TabIndex = 0;
            // 
            // ComboxTypeAgent
            // 
            this.ComboxTypeAgent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentTypeBindingSource, "Title", true));
            this.ComboxTypeAgent.DataSource = this.agentTypeBindingSource;
            this.ComboxTypeAgent.DisplayMember = "Title";
            this.ComboxTypeAgent.FormattingEnabled = true;
            this.ComboxTypeAgent.Location = new System.Drawing.Point(119, 250);
            this.ComboxTypeAgent.Name = "ComboxTypeAgent";
            this.ComboxTypeAgent.Size = new System.Drawing.Size(194, 21);
            this.ComboxTypeAgent.TabIndex = 23;
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(GlazkiApp.Models.AgentType);
            // 
            // ChangeImageButn
            // 
            this.ChangeImageButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeImageButn.Location = new System.Drawing.Point(377, 194);
            this.ChangeImageButn.Name = "ChangeImageButn";
            this.ChangeImageButn.Size = new System.Drawing.Size(122, 35);
            this.ChangeImageButn.TabIndex = 22;
            this.ChangeImageButn.Text = "Выбрать";
            this.ChangeImageButn.UseVisualStyleBackColor = true;
            // 
            // CancleButn
            // 
            this.CancleButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancleButn.Location = new System.Drawing.Point(303, 299);
            this.CancleButn.Name = "CancleButn";
            this.CancleButn.Size = new System.Drawing.Size(122, 35);
            this.CancleButn.TabIndex = 21;
            this.CancleButn.Text = "Отмена";
            this.CancleButn.UseVisualStyleBackColor = true;
            this.CancleButn.Click += new System.EventHandler(this.CancleButn_Click);
            // 
            // SaveButn
            // 
            this.SaveButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButn.Location = new System.Drawing.Point(119, 299);
            this.SaveButn.Name = "SaveButn";
            this.SaveButn.Size = new System.Drawing.Size(122, 35);
            this.SaveButn.TabIndex = 20;
            this.SaveButn.Text = "Изменить";
            this.SaveButn.UseVisualStyleBackColor = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(120, 224);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(194, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(GlazkiApp.Models.Agent);
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "DirectorName", true));
            this.directorNameTextBox.Location = new System.Drawing.Point(120, 64);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.directorNameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(194, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(120, 116);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(194, 20);
            this.iNNTextBox.TabIndex = 9;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(120, 142);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(194, 20);
            this.kPPTextBox.TabIndex = 11;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.agentBindingSource, "Logo", true));
            this.logoPictureBox.Image = global::GlazkiApp.Properties.Resources.picture;
            this.logoPictureBox.Location = new System.Drawing.Point(346, 55);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(177, 133);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(120, 172);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(194, 20);
            this.phoneTextBox.TabIndex = 15;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(120, 198);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(194, 20);
            this.priorityTextBox.TabIndex = 17;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(120, 38);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(194, 20);
            this.titleTextBox.TabIndex = 19;
            // 
            // EditAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 354);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAgentForm";
            this.Text = "EditAgentForm";
            this.Load += new System.EventHandler(this.EditAgentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button ChangeImageButn;
        private System.Windows.Forms.Button CancleButn;
        private System.Windows.Forms.Button SaveButn;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.ComboBox ComboxTypeAgent;
    }
}