namespace WindowsFormsApp3
{
    partial class pwgen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwgen));
            this.generateButton = new System.Windows.Forms.Button();
            this.numbersCheck = new System.Windows.Forms.CheckBox();
            this.specialsCheck = new System.Windows.Forms.CheckBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.lenBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pwListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.delSelectedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lenBar)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.generateButton.FlatAppearance.BorderSize = 2;
            this.generateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.generateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Black Ops One", 7.8F);
            this.generateButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.generateButton.Location = new System.Drawing.Point(142, 135);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(129, 38);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numbersCheck
            // 
            this.numbersCheck.AutoSize = true;
            this.numbersCheck.BackColor = System.Drawing.Color.Transparent;
            this.numbersCheck.Font = new System.Drawing.Font("Black Ops One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numbersCheck.ForeColor = System.Drawing.Color.BlueViolet;
            this.numbersCheck.Location = new System.Drawing.Point(12, 108);
            this.numbersCheck.Name = "numbersCheck";
            this.numbersCheck.Size = new System.Drawing.Size(99, 22);
            this.numbersCheck.TabIndex = 2;
            this.numbersCheck.Text = "Numbers";
            this.numbersCheck.UseVisualStyleBackColor = false;
            this.numbersCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // specialsCheck
            // 
            this.specialsCheck.AutoSize = true;
            this.specialsCheck.BackColor = System.Drawing.Color.Transparent;
            this.specialsCheck.Font = new System.Drawing.Font("Black Ops One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialsCheck.ForeColor = System.Drawing.Color.BlueViolet;
            this.specialsCheck.Location = new System.Drawing.Point(105, 108);
            this.specialsCheck.Name = "specialsCheck";
            this.specialsCheck.Size = new System.Drawing.Size(94, 22);
            this.specialsCheck.TabIndex = 3;
            this.specialsCheck.Text = "Specials";
            this.specialsCheck.UseVisualStyleBackColor = false;
            this.specialsCheck.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Aldrich", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.passBox.Location = new System.Drawing.Point(74, 43);
            this.passBox.Name = "passBox";
            this.passBox.ReadOnly = true;
            this.passBox.Size = new System.Drawing.Size(328, 19);
            this.passBox.TabIndex = 4;
            // 
            // lenBar
            // 
            this.lenBar.AutoSize = false;
            this.lenBar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lenBar.LargeChange = 10;
            this.lenBar.Location = new System.Drawing.Point(12, 68);
            this.lenBar.Maximum = 1000;
            this.lenBar.Minimum = 10;
            this.lenBar.Name = "lenBar";
            this.lenBar.Size = new System.Drawing.Size(393, 40);
            this.lenBar.TabIndex = 5;
            this.lenBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.lenBar.Value = 10;
            this.lenBar.Scroll += new System.EventHandler(this.lenBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aldrich", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(229, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // pwListBox
            // 
            this.pwListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pwListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.pwListBox.ForeColor = System.Drawing.Color.BlueViolet;
            this.pwListBox.FormattingEnabled = true;
            this.pwListBox.ItemHeight = 18;
            this.pwListBox.Location = new System.Drawing.Point(6, 179);
            this.pwListBox.Name = "pwListBox";
            this.pwListBox.Size = new System.Drawing.Size(399, 162);
            this.pwListBox.TabIndex = 7;
            this.pwListBox.Click += new System.EventHandler(this.pwListBox_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.deleteButton.FlatAppearance.BorderSize = 2;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Black Ops One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.deleteButton.Location = new System.Drawing.Point(277, 135);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(128, 38);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete All";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bungee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.saveButton.Location = new System.Drawing.Point(6, 347);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(399, 46);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Aldrich", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nameTextBox.Location = new System.Drawing.Point(74, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(328, 19);
            this.nameTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Aldrich", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.nameLabel.Location = new System.Drawing.Point(-1, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 21);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Aldrich", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.passLabel.Location = new System.Drawing.Point(-1, 43);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(62, 21);
            this.passLabel.TabIndex = 12;
            this.passLabel.Text = "Pass:";
            // 
            // delSelectedBtn
            // 
            this.delSelectedBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.delSelectedBtn.FlatAppearance.BorderSize = 2;
            this.delSelectedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.delSelectedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.delSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delSelectedBtn.Font = new System.Drawing.Font("Black Ops One", 7F);
            this.delSelectedBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.delSelectedBtn.Location = new System.Drawing.Point(6, 135);
            this.delSelectedBtn.Name = "delSelectedBtn";
            this.delSelectedBtn.Size = new System.Drawing.Size(130, 38);
            this.delSelectedBtn.TabIndex = 13;
            this.delSelectedBtn.Text = "Delete Selected";
            this.delSelectedBtn.UseVisualStyleBackColor = true;
            this.delSelectedBtn.Click += new System.EventHandler(this.delSelectedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(415, 395);
            this.Controls.Add(this.delSelectedBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.pwListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lenBar);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.specialsCheck);
            this.Controls.Add(this.numbersCheck);
            this.Controls.Add(this.generateButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Generator - El Dohanio";
            ((System.ComponentModel.ISupportInitialize)(this.lenBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox numbersCheck;
        private System.Windows.Forms.CheckBox specialsCheck;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TrackBar lenBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox pwListBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button delSelectedBtn;
    }
}

