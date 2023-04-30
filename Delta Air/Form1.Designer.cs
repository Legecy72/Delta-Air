namespace Delta_Air
{
    partial class Form1
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
            txtDate = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRe = new TextBox();
            txtName = new TextBox();
            txtNum = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Location = new Point(344, 194);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(182, 27);
            txtDate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(158, 24);
            label1.TabIndex = 1;
            label1.Text = "Ticket Number";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(571, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(508, 293);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(33, 553);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 86);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 142);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 5;
            label3.Text = "Region";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 197);
            label4.Name = "label4";
            label4.Size = new Size(57, 24);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // txtRe
            // 
            txtRe.Location = new Point(344, 139);
            txtRe.Name = "txtRe";
            txtRe.Size = new Size(182, 27);
            txtRe.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(344, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 27);
            txtName.TabIndex = 8;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(344, 24);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(182, 27);
            txtNum.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(162, 553);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(192, 192, 0);
            button3.Location = new Point(299, 553);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Upgrade";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(192, 0, 0);
            button4.Location = new Point(444, 553);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.toppng_com_delta_air_lines_logo_3597x786;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(687, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 154);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.united_states_mile_high_club_nyc_sun_flying;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1081, 604);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtNum);
            Controls.Add(txtName);
            Controls.Add(txtRe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtDate);
            Name = "Form1";
            Text = "Delta Air";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDate;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRe;
        private TextBox txtName;
        private TextBox txtNum;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
    }
}