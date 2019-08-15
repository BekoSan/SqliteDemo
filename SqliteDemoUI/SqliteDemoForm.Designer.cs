namespace SqliteDemoUI
{
    partial class peopleForm
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
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refrechButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameValue
            // 
            this.firstNameValue.BackColor = System.Drawing.Color.White;
            this.firstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.firstNameValue.Location = new System.Drawing.Point(117, 144);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(223, 22);
            this.firstNameValue.TabIndex = 0;
            // 
            // lastNameValue
            // 
            this.lastNameValue.BackColor = System.Drawing.Color.White;
            this.lastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lastNameValue.Location = new System.Drawing.Point(117, 176);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(223, 22);
            this.lastNameValue.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.saveButton.Location = new System.Drawing.Point(108, 206);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 56);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // peopleListBox
            // 
            this.peopleListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(225)))));
            this.peopleListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(93)))));
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 16;
            this.peopleListBox.Location = new System.Drawing.Point(393, 144);
            this.peopleListBox.Margin = new System.Windows.Forms.Padding(4);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(241, 276);
            this.peopleListBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(93)))));
            this.firstNameLabel.Location = new System.Drawing.Point(15, 144);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(96, 17);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(93)))));
            this.lastNameLabel.Location = new System.Drawing.Point(13, 180);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 17);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(119, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "SQLITE DEMO";
            // 
            // refrechButton
            // 
            this.refrechButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.refrechButton.FlatAppearance.BorderSize = 0;
            this.refrechButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refrechButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.refrechButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.refrechButton.Location = new System.Drawing.Point(216, 206);
            this.refrechButton.Margin = new System.Windows.Forms.Padding(4);
            this.refrechButton.Name = "refrechButton";
            this.refrechButton.Size = new System.Drawing.Size(100, 56);
            this.refrechButton.TabIndex = 7;
            this.refrechButton.Text = "Refrech";
            this.refrechButton.UseVisualStyleBackColor = false;
            this.refrechButton.Click += new System.EventHandler(this.refrechButton_Click);
            // 
            // peopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(631, 421);
            this.Controls.Add(this.refrechButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.peopleListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "peopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sqlite Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refrechButton;
    }
}

