namespace GuidGenerator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guidTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnGenerate = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkboxUpperCase = new CheckBox();
            checkBoxHyphens = new CheckBox();
            checkBoxBraces = new CheckBox();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guidTextBox
            // 
            guidTextBox.Dock = DockStyle.Fill;
            guidTextBox.Font = new Font("Segoe UI", 18F);
            guidTextBox.Location = new Point(0, 0);
            guidTextBox.Name = "guidTextBox";
            guidTextBox.Size = new Size(545, 39);
            guidTextBox.TabIndex = 2;
            guidTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(229, 234, 254);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Resources.logo3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(545, 61);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 61);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(guidTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 57);
            panel2.TabIndex = 4;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerate.Location = new Point(187, 47);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(178, 86);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
            tableLayoutPanel1.Controls.Add(btnGenerate, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(labelStatus, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 118);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(545, 136);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkboxUpperCase);
            flowLayoutPanel1.Controls.Add(checkBoxHyphens);
            flowLayoutPanel1.Controls.Add(checkBoxBraces);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(178, 86);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // checkboxUpperCase
            // 
            checkboxUpperCase.AutoSize = true;
            checkboxUpperCase.Location = new Point(3, 3);
            checkboxUpperCase.Name = "checkboxUpperCase";
            checkboxUpperCase.Size = new Size(81, 19);
            checkboxUpperCase.TabIndex = 1;
            checkboxUpperCase.Text = "Uppercase";
            checkboxUpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxHyphens
            // 
            checkBoxHyphens.AutoSize = true;
            checkBoxHyphens.Checked = true;
            checkBoxHyphens.CheckState = CheckState.Checked;
            checkBoxHyphens.Location = new Point(3, 28);
            checkBoxHyphens.Name = "checkBoxHyphens";
            checkBoxHyphens.Size = new Size(73, 19);
            checkBoxHyphens.TabIndex = 2;
            checkBoxHyphens.Text = "Hyphens";
            checkBoxHyphens.UseVisualStyleBackColor = true;
            // 
            // checkBoxBraces
            // 
            checkBoxBraces.AutoSize = true;
            checkBoxBraces.Location = new Point(3, 53);
            checkBoxBraces.Name = "checkBoxBraces";
            checkBoxBraces.Size = new Size(60, 19);
            checkBoxBraces.TabIndex = 3;
            checkBoxBraces.Text = "Braces";
            checkBoxBraces.UseVisualStyleBackColor = true;
            checkBoxBraces.CheckStateChanged += checkBoxBraces_CheckStateChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = Color.DarkGreen;
            labelStatus.Location = new Point(371, 44);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(115, 15);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "Copied to clipboard!";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 254);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Guid Generator";
            FormClosing += Main_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox guidTextBox;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Button btnGenerate;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkboxUpperCase;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxHyphens;
        private CheckBox checkBoxBraces;
        private Label labelStatus;
    }
}
