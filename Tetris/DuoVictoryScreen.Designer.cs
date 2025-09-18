namespace Tetris
{
    partial class DuoVictoryScreen
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            winner = new Label();
            restart = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel2.Size = new Size(590, 423);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(winner, 0, 0);
            tableLayoutPanel1.Controls.Add(restart, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(121, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9975052F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0012512F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0012512F));
            tableLayoutPanel1.Size = new Size(348, 247);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // winner
            // 
            winner.AutoSize = true;
            winner.Dock = DockStyle.Fill;
            winner.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winner.Location = new Point(3, 0);
            winner.Name = "winner";
            tableLayoutPanel1.SetRowSpan(winner, 2);
            winner.Size = new Size(342, 184);
            winner.TabIndex = 0;
            winner.Text = "Player _ won!";
            winner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // restart
            // 
            restart.BackColor = Color.PaleVioletRed;
            restart.Dock = DockStyle.Fill;
            restart.FlatAppearance.BorderSize = 0;
            restart.FlatStyle = FlatStyle.Flat;
            restart.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            restart.Location = new Point(3, 187);
            restart.Name = "restart";
            restart.Size = new Size(342, 57);
            restart.TabIndex = 2;
            restart.Text = "Play Again";
            restart.UseVisualStyleBackColor = false;
            restart.Click += restart_Click;
            // 
            // DuoVictoryScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "DuoVictoryScreen";
            Size = new Size(590, 423);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label winner;
        private Button restart;
    }
}
