using System;
using System.Diagnostics;
using System.Text;
using IOnetApp.Docker;

namespace IOnetApp
{
    partial class formMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UserID = new System.Windows.Forms.Label();
            this.DeviceId = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 604);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UserID);
            this.tabPage1.Controls.Add(this.DeviceId);
            this.tabPage1.Controls.Add(this.DeviceName);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(959, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Containers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(42, 71);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(51, 17);
            this.UserID.TabIndex = 4;
            this.UserID.Text = "UserID";
            // 
            // DeviceId
            // 
            this.DeviceId.AutoSize = true;
            this.DeviceId.Location = new System.Drawing.Point(42, 46);
            this.DeviceId.Name = "DeviceId";
            this.DeviceId.Size = new System.Drawing.Size(64, 17);
            this.DeviceId.TabIndex = 3;
            this.DeviceId.Text = "DeviceID";
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSize = true;
            this.DeviceName.Location = new System.Drawing.Point(42, 24);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(88, 17);
            this.DeviceName.TabIndex = 2;
            this.DeviceName.Text = "DeviceName";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(847, 71);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.ID, this.NameImage, this.ContainerName, this.CPUVersion });
            this.dataGridView1.Location = new System.Drawing.Point(19, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameImage
            // 
            this.NameImage.DataPropertyName = "Image";
            this.NameImage.FillWeight = 200F;
            this.NameImage.HeaderText = "Image Name";
            this.NameImage.MinimumWidth = 6;
            this.NameImage.Name = "NameImage";
            this.NameImage.ReadOnly = true;
            // 
            // ContainerName
            // 
            this.ContainerName.DataPropertyName = "ContainerName";
            this.ContainerName.HeaderText = "Container Name";
            this.ContainerName.MinimumWidth = 6;
            this.ContainerName.Name = "ContainerName";
            this.ContainerName.ReadOnly = true;
            // 
            // CPUVersion
            // 
            this.CPUVersion.DataPropertyName = "CPU";
            this.CPUVersion.HeaderText = "CPU";
            this.CPUVersion.MinimumWidth = 6;
            this.CPUVersion.Name = "CPUVersion";
            this.CPUVersion.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(959, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 604);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMain";
            this.Text = "IOApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label DeviceId;
        private System.Windows.Forms.Label UserID;

        private System.Windows.Forms.Label DeviceName;

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUVersion;
    }
}