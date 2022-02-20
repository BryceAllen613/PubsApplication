namespace PubsApplication
{
    partial class pubsAppForm
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
            this.authorListBox = new System.Windows.Forms.ListBox();
            this.selectedAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newAddressText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.viewBooksButton = new System.Windows.Forms.Button();
            this.updateAddressButton = new System.Windows.Forms.Button();
            this.newCityText = new System.Windows.Forms.TextBox();
            this.newStateText = new System.Windows.Forms.TextBox();
            this.newZIPText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorListBox
            // 
            this.authorListBox.FormattingEnabled = true;
            this.authorListBox.Location = new System.Drawing.Point(43, 37);
            this.authorListBox.Name = "authorListBox";
            this.authorListBox.ScrollAlwaysVisible = true;
            this.authorListBox.Size = new System.Drawing.Size(326, 316);
            this.authorListBox.TabIndex = 0;
            this.authorListBox.SelectedIndexChanged += new System.EventHandler(this.authorListBox_SelectedIndexChanged);
            // 
            // selectedAuthor
            // 
            this.selectedAuthor.Location = new System.Drawing.Point(375, 52);
            this.selectedAuthor.Multiline = true;
            this.selectedAuthor.Name = "selectedAuthor";
            this.selectedAuthor.ReadOnly = true;
            this.selectedAuthor.Size = new System.Drawing.Size(160, 20);
            this.selectedAuthor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Author:";
            // 
            // newAddressText
            // 
            this.newAddressText.Location = new System.Drawing.Point(376, 120);
            this.newAddressText.Name = "newAddressText";
            this.newAddressText.Size = new System.Drawing.Size(163, 20);
            this.newAddressText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Address:";
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(375, 330);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(104, 23);
            this.viewAllButton.TabIndex = 8;
            this.viewAllButton.Text = "View All Authors";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // viewBooksButton
            // 
            this.viewBooksButton.Location = new System.Drawing.Point(375, 78);
            this.viewBooksButton.Name = "viewBooksButton";
            this.viewBooksButton.Size = new System.Drawing.Size(104, 23);
            this.viewBooksButton.TabIndex = 2;
            this.viewBooksButton.Text = "View Books";
            this.viewBooksButton.UseVisualStyleBackColor = true;
            this.viewBooksButton.Click += new System.EventHandler(this.viewBooksButton_Click);
            // 
            // updateAddressButton
            // 
            this.updateAddressButton.Location = new System.Drawing.Point(375, 289);
            this.updateAddressButton.Name = "updateAddressButton";
            this.updateAddressButton.Size = new System.Drawing.Size(104, 23);
            this.updateAddressButton.TabIndex = 7;
            this.updateAddressButton.Text = "Update Address";
            this.updateAddressButton.UseVisualStyleBackColor = true;
            this.updateAddressButton.Click += new System.EventHandler(this.updateAddressButton_Click);
            // 
            // newCityText
            // 
            this.newCityText.Location = new System.Drawing.Point(375, 160);
            this.newCityText.Name = "newCityText";
            this.newCityText.Size = new System.Drawing.Size(100, 20);
            this.newCityText.TabIndex = 4;
            // 
            // newStateText
            // 
            this.newStateText.Location = new System.Drawing.Point(375, 201);
            this.newStateText.Name = "newStateText";
            this.newStateText.Size = new System.Drawing.Size(100, 20);
            this.newStateText.TabIndex = 5;
            // 
            // newZIPText
            // 
            this.newZIPText.Location = new System.Drawing.Point(375, 244);
            this.newZIPText.Name = "newZIPText";
            this.newZIPText.Size = new System.Drawing.Size(100, 20);
            this.newZIPText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "New City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "New State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "New ZIP";
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.Location = new System.Drawing.Point(40, 21);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(43, 13);
            this.listBoxLabel.TabIndex = 14;
            this.listBoxLabel.Text = "Authors";
            // 
            // pubsAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 392);
            this.Controls.Add(this.listBoxLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newZIPText);
            this.Controls.Add(this.newStateText);
            this.Controls.Add(this.newCityText);
            this.Controls.Add(this.updateAddressButton);
            this.Controls.Add(this.viewBooksButton);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newAddressText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedAuthor);
            this.Controls.Add(this.authorListBox);
            this.Name = "pubsAppForm";
            this.Text = "Pubs Authors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox authorListBox;
        private System.Windows.Forms.TextBox selectedAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newAddressText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Button viewBooksButton;
        private System.Windows.Forms.Button updateAddressButton;
        private System.Windows.Forms.TextBox newCityText;
        private System.Windows.Forms.TextBox newStateText;
        private System.Windows.Forms.TextBox newZIPText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label listBoxLabel;
    }
}

