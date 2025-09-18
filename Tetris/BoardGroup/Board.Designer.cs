using CustomControls;

namespace Tetris.BoardGroup
{
    partial class Board
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
            tableLayoutPanel1 = new TableLayoutPanel();
            nextLabel = new Label();
            nextPanel = new DoubleBufferedPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            holdLabel = new Label();
            holdPanel = new DoubleBufferedPanel();
            scoreLabel = new Label();
            boardPanel = new DoubleBufferedPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(nextLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(nextPanel, 0, 1);
            tableLayoutPanel1.Location = new Point(37, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(70, 140);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // nextLabel
            // 
            nextLabel.AutoSize = true;
            nextLabel.Dock = DockStyle.Fill;
            nextLabel.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextLabel.Location = new Point(3, 0);
            nextLabel.Name = "nextLabel";
            nextLabel.Size = new Size(64, 70);
            nextLabel.TabIndex = 0;
            nextLabel.Text = "Next";
            nextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nextPanel
            // 
            nextPanel.Location = new Point(3, 73);
            nextPanel.Name = "nextPanel";
            nextPanel.Size = new Size(64, 64);
            nextPanel.TabIndex = 1;
            nextPanel.Paint += nextPanel_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(holdLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(holdPanel, 0, 1);
            tableLayoutPanel2.Location = new Point(37, 200);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(70, 140);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // holdLabel
            // 
            holdLabel.AutoSize = true;
            holdLabel.Dock = DockStyle.Fill;
            holdLabel.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            holdLabel.Location = new Point(3, 0);
            holdLabel.Name = "holdLabel";
            holdLabel.Size = new Size(64, 70);
            holdLabel.TabIndex = 0;
            holdLabel.Text = "Hold (Z)";
            holdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // holdPanel
            // 
            holdPanel.Location = new Point(3, 73);
            holdPanel.Name = "holdPanel";
            holdPanel.Size = new Size(64, 64);
            holdPanel.TabIndex = 1;
            holdPanel.Paint += holdPanel_Paint;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = SystemColors.Control;
            scoreLabel.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(395, 119);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(85, 26);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Score: 0";
            // 
            // boardPanel
            // 
            boardPanel.Location = new Point(157, 31);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(200, 400);
            boardPanel.TabIndex = 4;
            boardPanel.Paint += boardPanel_Paint;
            // 
            // TetrisBoard
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(boardPanel);
            Controls.Add(scoreLabel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "TetrisBoard";
            Size = new Size(511, 467);
            Load += TetrisBoard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TableLayoutPanel tableLayoutPanel1;
        protected Label nextLabel;
        protected TableLayoutPanel tableLayoutPanel2;
        protected Label holdLabel;
        protected Label scoreLabel;
        protected DoubleBufferedPanel nextPanel;
        protected DoubleBufferedPanel holdPanel;
        protected DoubleBufferedPanel boardPanel;
    }
}
