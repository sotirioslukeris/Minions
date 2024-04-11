namespace Minions
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
            lblName = new Label();
            lblTowns = new Label();
            txtName = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            lblAge = new Label();
            btnAdd = new Button();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Italic);
            lblName.Location = new Point(35, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblTowns
            // 
            lblTowns.AutoSize = true;
            lblTowns.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Italic);
            lblTowns.Location = new Point(386, 25);
            lblTowns.Name = "lblTowns";
            lblTowns.Size = new Size(57, 28);
            lblTowns.TabIndex = 1;
            lblTowns.Text = "Town";
            // 
            // txtName
            // 
            txtName.Location = new Point(35, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(82, 23);
            txtName.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(373, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(82, 23);
            textBox2.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Italic);
            lblAge.Location = new Point(151, 25);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(42, 28);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(191, 157);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 72);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add new Minion";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(261, 71);
            txtId.Name = "txtId";
            txtId.Size = new Size(82, 23);
            txtId.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Italic);
            label1.Location = new Point(261, 25);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 7;
            label1.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 261);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(lblAge);
            Controls.Add(comboBox1);
            Controls.Add(txtName);
            Controls.Add(lblTowns);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTowns;
        private TextBox txtName;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label lblAge;
        private Button btnAdd;
        private TextBox txtId;
        private Label label1;
    }
}
