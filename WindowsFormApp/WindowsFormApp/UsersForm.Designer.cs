namespace WindowsFormApp
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.richTextBoxAddInfo = new System.Windows.Forms.RichTextBox();
            this.listBoxRegisteredUsers = new System.Windows.Forms.ListBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonExportUsers = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddInfo = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.groupBoxUserDatabase = new System.Windows.Forms.GroupBox();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxUserDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 36);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(124, 71);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(248, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(124, 105);
            this.dateTimePickerBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerBirthDate.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(124, 137);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(247, 22);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(124, 169);
            this.textBoxPostalCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(248, 22);
            this.textBoxPostalCode.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(124, 201);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 22);
            this.textBoxEmail.TabIndex = 5;
            // 
            // richTextBoxAddInfo
            // 
            this.richTextBoxAddInfo.Location = new System.Drawing.Point(13, 267);
            this.richTextBoxAddInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxAddInfo.Name = "richTextBoxAddInfo";
            this.richTextBoxAddInfo.Size = new System.Drawing.Size(357, 93);
            this.richTextBoxAddInfo.TabIndex = 6;
            this.richTextBoxAddInfo.Text = "";
            // 
            // listBoxRegisteredUsers
            // 
            this.listBoxRegisteredUsers.FormattingEnabled = true;
            this.listBoxRegisteredUsers.ItemHeight = 16;
            this.listBoxRegisteredUsers.Location = new System.Drawing.Point(11, 23);
            this.listBoxRegisteredUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxRegisteredUsers.Name = "listBoxRegisteredUsers";
            this.listBoxRegisteredUsers.Size = new System.Drawing.Size(359, 356);
            this.listBoxRegisteredUsers.TabIndex = 7;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(13, 368);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(359, 28);
            this.buttonAddUser.TabIndex = 8;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonExportUsers
            // 
            this.buttonExportUsers.Location = new System.Drawing.Point(12, 393);
            this.buttonExportUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExportUsers.Name = "buttonExportUsers";
            this.buttonExportUsers.Size = new System.Drawing.Size(359, 28);
            this.buttonExportUsers.TabIndex = 9;
            this.buttonExportUsers.Text = "Export users to file";
            this.buttonExportUsers.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(9, 71);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(65, 17);
            this.labelSurname.TabIndex = 11;
            this.labelSurname.Text = "Surname";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(9, 105);
            this.labelBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(87, 17);
            this.labelBirthDate.TabIndex = 12;
            this.labelBirthDate.Text = "Date of Birth";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(9, 137);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Address";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(5, 169);
            this.labelPostalCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(82, 17);
            this.labelPostalCode.TabIndex = 14;
            this.labelPostalCode.Text = "Postal code";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(9, 201);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // labelAddInfo
            // 
            this.labelAddInfo.AutoSize = true;
            this.labelAddInfo.Location = new System.Drawing.Point(9, 233);
            this.labelAddInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddInfo.Name = "labelAddInfo";
            this.labelAddInfo.Size = new System.Drawing.Size(97, 17);
            this.labelAddInfo.TabIndex = 16;
            this.labelAddInfo.Text = "Additional info";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.labelName);
            this.groupBoxUser.Controls.Add(this.labelAddInfo);
            this.groupBoxUser.Controls.Add(this.buttonAddUser);
            this.groupBoxUser.Controls.Add(this.textBoxName);
            this.groupBoxUser.Controls.Add(this.labelEmail);
            this.groupBoxUser.Controls.Add(this.textBoxSurname);
            this.groupBoxUser.Controls.Add(this.labelPostalCode);
            this.groupBoxUser.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxUser.Controls.Add(this.labelAddress);
            this.groupBoxUser.Controls.Add(this.textBoxAddress);
            this.groupBoxUser.Controls.Add(this.labelBirthDate);
            this.groupBoxUser.Controls.Add(this.textBoxPostalCode);
            this.groupBoxUser.Controls.Add(this.labelSurname);
            this.groupBoxUser.Controls.Add(this.textBoxEmail);
            this.groupBoxUser.Controls.Add(this.richTextBoxAddInfo);
            this.groupBoxUser.Location = new System.Drawing.Point(16, 15);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUser.Size = new System.Drawing.Size(384, 409);
            this.groupBoxUser.TabIndex = 17;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // groupBoxUserDatabase
            // 
            this.groupBoxUserDatabase.Controls.Add(this.listBoxRegisteredUsers);
            this.groupBoxUserDatabase.Controls.Add(this.buttonExportUsers);
            this.groupBoxUserDatabase.Location = new System.Drawing.Point(17, 432);
            this.groupBoxUserDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserDatabase.Name = "groupBoxUserDatabase";
            this.groupBoxUserDatabase.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserDatabase.Size = new System.Drawing.Size(383, 428);
            this.groupBoxUserDatabase.TabIndex = 18;
            this.groupBoxUserDatabase.TabStop = false;
            this.groupBoxUserDatabase.Text = "User Database";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 875);
            this.Controls.Add(this.groupBoxUserDatabase);
            this.Controls.Add(this.groupBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersForm";
            this.Text = "User management";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxUserDatabase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.RichTextBox richTextBoxAddInfo;
        private System.Windows.Forms.ListBox listBoxRegisteredUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonExportUsers;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddInfo;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxUserDatabase;
    }
}

