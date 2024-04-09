
namespace IOnetApp
{
    partial class FormAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeviceIDText = new System.Windows.Forms.TextBox();
            this.UserIdText = new System.Windows.Forms.TextBox();
            this.DeviceNameText = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.AddNewWorkerTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RunCommand = new System.Windows.Forms.Button();
            this.Command = new System.Windows.Forms.Label();
            this.commandText = new System.Windows.Forms.RichTextBox();
            this.AddNewWorkerTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID";
            // 
            // DeviceIDText
            // 
            this.DeviceIDText.Location = new System.Drawing.Point(190, 118);
            this.DeviceIDText.Margin = new System.Windows.Forms.Padding(4);
            this.DeviceIDText.Name = "DeviceIDText";
            this.DeviceIDText.Size = new System.Drawing.Size(333, 22);
            this.DeviceIDText.TabIndex = 4;
            // 
            // UserIdText
            // 
            this.UserIdText.Location = new System.Drawing.Point(190, 32);
            this.UserIdText.Margin = new System.Windows.Forms.Padding(4);
            this.UserIdText.Name = "UserIdText";
            this.UserIdText.Size = new System.Drawing.Size(333, 22);
            this.UserIdText.TabIndex = 5;
            // 
            // DeviceNameText
            // 
            this.DeviceNameText.Location = new System.Drawing.Point(190, 74);
            this.DeviceNameText.Margin = new System.Windows.Forms.Padding(4);
            this.DeviceNameText.Name = "DeviceNameText";
            this.DeviceNameText.Size = new System.Drawing.Size(333, 22);
            this.DeviceNameText.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(190, 194);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 194);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewWorkerTab
            // 
            this.AddNewWorkerTab.Controls.Add(this.tabPage1);
            this.AddNewWorkerTab.Controls.Add(this.tabPage2);
            this.AddNewWorkerTab.Location = new System.Drawing.Point(2, 2);
            this.AddNewWorkerTab.Name = "AddNewWorkerTab";
            this.AddNewWorkerTab.SelectedIndex = 0;
            this.AddNewWorkerTab.Size = new System.Drawing.Size(702, 311);
            this.AddNewWorkerTab.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UserIdText);
            this.tabPage1.Controls.Add(this.DeviceIDText);
            this.tabPage1.Controls.Add(this.DeviceNameText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 282);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RunCommand);
            this.tabPage2.Controls.Add(this.Command);
            this.tabPage2.Controls.Add(this.commandText);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 282);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RunCommand
            // 
            this.RunCommand.Location = new System.Drawing.Point(273, 232);
            this.RunCommand.Name = "RunCommand";
            this.RunCommand.Size = new System.Drawing.Size(140, 26);
            this.RunCommand.TabIndex = 2;
            this.RunCommand.Text = "Run\r\n";
            this.RunCommand.UseVisualStyleBackColor = true;
            this.RunCommand.Click += new System.EventHandler(this.RunCommand_Click);
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(75, 11);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(286, 25);
            this.Command.TabIndex = 1;
            this.Command.Text = "Command:\r\n";
            // 
            // commandText
            // 
            this.commandText.Location = new System.Drawing.Point(75, 39);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(500, 178);
            this.commandText.TabIndex = 0;
            this.commandText.Text = "";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 315);
            this.Controls.Add(this.AddNewWorkerTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.AddNewWorkerTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox commandText;
        private System.Windows.Forms.TabControl AddNewWorkerTab;

        private System.Windows.Forms.Label Command;
        private System.Windows.Forms.Button RunCommand;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.TabControl tabControl1;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeviceIDText;
        private System.Windows.Forms.TextBox UserIdText;
        private System.Windows.Forms.TextBox DeviceNameText;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}