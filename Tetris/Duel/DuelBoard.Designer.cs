using Tetris.BoardGroup;

namespace Tetris.Duel
{
    partial class DuelBoard : Board
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel3 = new TableLayoutPanel();
            clearType = new Label();
            comboType = new Label();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // boardPanel
            // 
            boardPanel.Size = new Size(200, 500);
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(clearType, 0, 1);
            tableLayoutPanel3.Controls.Add(comboType, 0, 0);
            tableLayoutPanel3.Location = new Point(373, 256);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(117, 100);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // clearType
            // 
            clearType.AutoSize = true;
            clearType.Dock = DockStyle.Fill;
            clearType.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearType.Location = new Point(3, 50);
            clearType.Name = "clearType";
            clearType.Size = new Size(111, 50);
            clearType.TabIndex = 1;
            clearType.Text = "(Clear Type)";
            clearType.TextAlign = ContentAlignment.MiddleCenter;
            clearType.Visible = false;
            // 
            // comboType
            // 
            comboType.AutoSize = true;
            comboType.Dock = DockStyle.Fill;
            comboType.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboType.Location = new Point(3, 0);
            comboType.Name = "comboType";
            comboType.Size = new Size(111, 50);
            comboType.TabIndex = 0;
            comboType.Text = "Combo";
            comboType.TextAlign = ContentAlignment.MiddleCenter;
            comboType.Visible = false;
            // 
            // DuelBoard
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Name = "DuelBoard";
            Size = new Size(511, 686);
            Controls.SetChildIndex(scoreLabel, 0);
            Controls.SetChildIndex(boardPanel, 0);
            Controls.SetChildIndex(tableLayoutPanel3, 0);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Label comboType;
        private Label clearType;
    }
}
