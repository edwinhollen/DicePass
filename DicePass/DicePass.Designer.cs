namespace DicePass
{
    partial class DicePass
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.num_words = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_showRolls = new System.Windows.Forms.CheckBox();
            this.rich_rolls = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_extraChar = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_words)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 214);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(356, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(158, 17);
            this.lbl_status.Text = "STATUS LABEL PLEASE IGNORE";
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output.Location = new System.Drawing.Point(3, 3);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(350, 20);
            this.txt_output.TabIndex = 1;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(275, 4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 2;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // num_words
            // 
            this.num_words.Location = new System.Drawing.Point(174, 4);
            this.num_words.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.num_words.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_words.Name = "num_words";
            this.num_words.Size = new System.Drawing.Size(52, 22);
            this.num_words.TabIndex = 3;
            this.num_words.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Words";
            // 
            // chk_showRolls
            // 
            this.chk_showRolls.AutoSize = true;
            this.chk_showRolls.Location = new System.Drawing.Point(9, 8);
            this.chk_showRolls.Name = "chk_showRolls";
            this.chk_showRolls.Size = new System.Drawing.Size(80, 17);
            this.chk_showRolls.TabIndex = 5;
            this.chk_showRolls.Text = "Show rolls";
            this.chk_showRolls.UseVisualStyleBackColor = true;
            this.chk_showRolls.CheckedChanged += new System.EventHandler(this.chk_showRolls_CheckedChanged);
            // 
            // rich_rolls
            // 
            this.rich_rolls.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_rolls.Location = new System.Drawing.Point(3, 108);
            this.rich_rolls.Name = "rich_rolls";
            this.rich_rolls.ReadOnly = true;
            this.rich_rolls.Size = new System.Drawing.Size(353, 97);
            this.rich_rolls.TabIndex = 6;
            this.rich_rolls.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.txt_output);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.rich_rolls);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 214);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_extraChar);
            this.panel1.Controls.Add(this.chk_showRolls);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.num_words);
            this.panel1.Controls.Add(this.btn_generate);
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 73);
            this.panel1.TabIndex = 8;
            // 
            // chk_extraChar
            // 
            this.chk_extraChar.AutoSize = true;
            this.chk_extraChar.Location = new System.Drawing.Point(9, 31);
            this.chk_extraChar.Name = "chk_extraChar";
            this.chk_extraChar.Size = new System.Drawing.Size(143, 17);
            this.chk_extraChar.TabIndex = 6;
            this.chk_extraChar.Text = "Extra security character";
            this.chk_extraChar.UseVisualStyleBackColor = true;
            // 
            // DicePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(356, 236);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DicePass";
            this.Text = "DicePass";
            this.Load += new System.EventHandler(this.DicePass_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_words)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.NumericUpDown num_words;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_showRolls;
        private System.Windows.Forms.RichTextBox rich_rolls;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_extraChar;
    }
}

