using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Gerenciamento_de_Interface_Grafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Label PrimaryLabel;
        private Label SecondaryLabel;
        public FlowLayoutPanel FlowLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(292, 3266);
            this.Text = "FlowLayout";
            this.BackColor = Color.Yellow;

            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.BackColor = Color.Purple;
            this.FlowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            this.PrimaryLabel = new Label();
            this.PrimaryLabel.Text = "Primeira Label ";
            this.PrimaryLabel.ForeColor = Color.White;

            this.SecondaryLabel = new Label();
            this.SecondaryLabel.Text = "Segunda Label ";
            this.SecondaryLabel.ForeColor = Color.White;

            this.FlowLayoutPanel.Controls.Add(this.PrimaryLabel);
            this.FlowLayoutPanel.Controls.Add(this.SecondaryLabel);
            this.Controls.Add(FlowLayoutPanel);
        }
        #endregion
    }
}