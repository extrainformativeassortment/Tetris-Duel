namespace Tetris
{
    partial class MainMenu
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
            tetrisTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            exit = new Button();
            duoBattle = new Button();
            arcade = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tetrisTitle
            // 
            tetrisTitle.AutoSize = true;
            tetrisTitle.Dock = DockStyle.Fill;
            tetrisTitle.Font = new Font("Franklin Gothic Medium", 84F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tetrisTitle.ForeColor = Color.Red;
            tetrisTitle.Location = new Point(3, 0);
            tetrisTitle.Name = "tetrisTitle";
            tetrisTitle.Size = new Size(364, 177);
            tetrisTitle.TabIndex = 0;
            tetrisTitle.Text = "Tetris";
            tetrisTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(exit, 0, 2);
            tableLayoutPanel1.Controls.Add(duoBattle, 0, 1);
            tableLayoutPanel1.Controls.Add(arcade, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(364, 172);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // exit
            // 
            exit.BackColor = Color.PaleVioletRed;
            exit.Dock = DockStyle.Fill;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(3, 117);
            exit.Name = "exit";
            exit.Size = new Size(358, 52);
            exit.TabIndex = 2;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // duoBattle
            // 
            duoBattle.BackColor = Color.PaleVioletRed;
            duoBattle.Dock = DockStyle.Fill;
            duoBattle.FlatAppearance.BorderSize = 0;
            duoBattle.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            duoBattle.FlatStyle = FlatStyle.Flat;
            duoBattle.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duoBattle.Location = new Point(3, 60);
            duoBattle.Name = "duoBattle";
            duoBattle.Size = new Size(358, 51);
            duoBattle.TabIndex = 1;
            duoBattle.Text = "Duo Battle";
            duoBattle.UseVisualStyleBackColor = false;
            duoBattle.Click += duoBattle_Click;
            // 
            // arcade
            // 
            arcade.BackColor = Color.PaleVioletRed;
            arcade.Dock = DockStyle.Fill;
            arcade.FlatAppearance.BorderSize = 0;
            arcade.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            arcade.FlatStyle = FlatStyle.Flat;
            arcade.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            arcade.Location = new Point(3, 3);
            arcade.Name = "arcade";
            arcade.Size = new Size(358, 51);
            arcade.TabIndex = 0;
            arcade.Text = "Arcade";
            arcade.UseVisualStyleBackColor = false;
            arcade.Click += arcade_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(627, 452);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tetrisTitle, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(128, 48);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(370, 355);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainMenu";
            Size = new Size(627, 452);
            Load += MainMenu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label tetrisTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button arcade;
        private Button exit;
        private Button duoBattle;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
