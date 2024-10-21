namespace Battleships_multiplayer_client
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(873, 927);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(651, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(184, 280);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveCaption;
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(62, 65);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show enemies grid";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(299, 50);
            label1.TabIndex = 4;
            label1.Text = "Placement phase";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(651, 54);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 6;
            label2.Text = "Moves";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(651, 445);
            label3.Name = "label3";
            label3.Size = new Size(57, 30);
            label3.TabIndex = 7;
            label3.Text = "Fleet";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Minesweep (2 squares) ", "Frigate (3 squares) ", "Cruiser  (4 squares) ", "Battleship (5 squares)  " });
            listBox1.Location = new Point(651, 498);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(159, 109);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(651, 613);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(159, 96);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(358, 674);
            button1.Name = "button1";
            button1.Size = new Size(127, 35);
            button1.TabIndex = 10;
            button1.Text = "Ready";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 717);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private RichTextBox richTextBox2;
        private Button button1;
    }
}