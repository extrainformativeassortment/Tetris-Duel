namespace Tetris.BoardGroup
{
    partial class GameOverMenu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            finalScore = new Label();
            restart = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 129);
            label1.TabIndex = 0;
            label1.Text = "Game Over";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            // 
            // finalScore
            // 
            finalScore.AutoSize = true;
            finalScore.Dock = DockStyle.Fill;
            finalScore.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalScore.Location = new Point(3, 129);
            finalScore.Name = "finalScore";
            finalScore.Size = new Size(335, 65);
            finalScore.TabIndex = 1;
            finalScore.Text = "Score: 0";
            finalScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // restart
            // 
            restart.BackColor = Color.PaleVioletRed;
            restart.Dock = DockStyle.Fill;
            restart.FlatAppearance.BorderSize = 0;
            restart.FlatStyle = FlatStyle.Flat;
            restart.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            restart.Location = new Point(3, 197);
            restart.Name = "restart";
            restart.Size = new Size(335, 60);
            restart.TabIndex = 2;
            restart.Text = "Play Again";
            restart.UseVisualStyleBackColor = false;
            restart.Click += restart_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(restart, 0, 2);
            tableLayoutPanel1.Controls.Add(finalScore, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(118, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9975052F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0012512F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0012512F));
            tableLayoutPanel1.Size = new Size(341, 260);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0007477F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.998497F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0007477F));
            tableLayoutPanel2.Size = new Size(579, 444);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // GameOverMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "GameOverMenu";
            Size = new Size(579, 444);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label finalScore;
        private Button restart;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
