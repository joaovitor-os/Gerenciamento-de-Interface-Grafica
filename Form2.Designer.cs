using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_Interface_Grafica
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;
        public TableLayoutPanel TableLayoutPanel;
        private Label PrimaryLabel;
        private TextBox PrimaryTextBox;
        private Button Confirm;
        private ErrorProvider TextError;

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
            this.ClientSize = new Size(292, 266);
            this.Text = "TableLayout";
            this.BackColor = Color.Red;

            this.TableLayoutPanel = new TableLayoutPanel();
            this.TableLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.Dock = DockStyle.Fill;
            this.TableLayoutPanel.BackColor = Color.Green;
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            this.TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            this.PrimaryLabel = new Label();
            this.PrimaryLabel.Text = "Primeira Label";
            this.PrimaryLabel.ForeColor = Color.White;

            this.PrimaryTextBox = new TextBox();
            this.TextError = new ErrorProvider();
            this.TextError.SetIconAlignment(this.PrimaryTextBox, ErrorIconAlignment.MiddleRight);
            this.TextError.SetIconPadding(this.PrimaryTextBox, 2);
            this.TextError.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            this.Confirm = new Button();
            this.Confirm.Text = "Confirmar";
            this.Confirm.Click += new EventHandler(this.ConfirmClick);

            this.TableLayoutPanel.Controls.Add(this.PrimaryLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.PrimaryTextBox, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.Confirm, 2, 3);
            this.Controls.Add(TableLayoutPanel);
        }
        #endregion
    }
}