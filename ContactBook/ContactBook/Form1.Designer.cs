namespace ContactBook
{
    partial class ContactsBook
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactBook.Properties.Resources.contact_book_color_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(692, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(96, 34);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(692, 52);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(96, 34);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(692, 92);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 34);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(692, 132);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 34);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(332, 20);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(354, 20);
            this.firstNameTextbox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(226, 20);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 20);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(332, 60);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(354, 20);
            this.lastNameTextbox.TabIndex = 7;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(332, 100);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(354, 20);
            this.phoneNumberTextbox.TabIndex = 8;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(332, 140);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(354, 20);
            this.emailTextbox.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(226, 60);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 20);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(226, 100);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberLabel.TabIndex = 11;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(226, 140);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 20);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // contactsDataGrid
            // 
            this.contactsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGrid.Location = new System.Drawing.Point(229, 182);
            this.contactsDataGrid.Name = "contactsDataGrid";
            this.contactsDataGrid.Size = new System.Drawing.Size(559, 256);
            this.contactsDataGrid.TabIndex = 13;
            this.contactsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactDataGrid_CellDoubleClick);
            // 
            // ContactsBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactsDataGrid);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ContactsBook";
            this.Text = "Contacts Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.DataGridView contactsDataGrid;
    }
}

