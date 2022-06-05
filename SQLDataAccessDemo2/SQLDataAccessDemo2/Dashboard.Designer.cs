
namespace SQLDataAccessDemo2
{
    partial class Dashboard
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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 31;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(32, 178);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(376, 159);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(206, 21);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(202, 38);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(39, 27);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(151, 32);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(138, 89);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(146, 54);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 544);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
    }
}

