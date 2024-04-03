using System;
using System.Diagnostics;
using System.Text;
using IOnetApp.Docker;

namespace IOnetApp
{
    partial class Form1
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            PrintDockerStat();
        }

        public void PrintDockerStat()
        {
            var containes = CommandLine.GetAllContainerId();
            foreach (var containerUID in containes)
            {
                string data = CommandLine.RunCommand("docker", $"stats --no-stream {containerUID}");
                Console.WriteLine($"{containerUID} data: " + data);
            }
        }

        #endregion
    }
}