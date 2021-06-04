
namespace SPI_Class
{
    partial class Frm_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.Btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.Btn_Close = new FontAwesome.Sharp.IconButton();
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.Panel_Right = new System.Windows.Forms.Panel();
            this.Btn_Staff = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Usertype = new System.Windows.Forms.ComboBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_UserID = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Panel_Title.SuspendLayout();
            this.Panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.Panel_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.Silver;
            this.Panel_Title.Controls.Add(this.iconButton5);
            this.Panel_Title.Controls.Add(this.Btn_Minimize);
            this.Panel_Title.Controls.Add(this.Btn_Close);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(600, 30);
            this.Panel_Title.TabIndex = 0;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton5.IconColor = System.Drawing.Color.Red;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.Location = new System.Drawing.Point(2, 0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(30, 30);
            this.iconButton5.TabIndex = 20;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Btn_Minimize.IconColor = System.Drawing.Color.Red;
            this.Btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Minimize.IconSize = 30;
            this.Btn_Minimize.Location = new System.Drawing.Point(531, 0);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.Btn_Minimize.TabIndex = 2;
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Btn_Close.IconColor = System.Drawing.Color.Red;
            this.Btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Close.IconSize = 30;
            this.Btn_Close.Location = new System.Drawing.Point(567, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Panel_Left
            // 
            this.Panel_Left.Controls.Add(this.Dgv_Data);
            this.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Left.Location = new System.Drawing.Point(0, 30);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(300, 470);
            this.Panel_Left.TabIndex = 1;
            // 
            // Dgv_Data
            // 
            this.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.ReadOnly = true;
            this.Dgv_Data.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("!Khmer OS Siemreap", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.Dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Data.Size = new System.Drawing.Size(294, 464);
            this.Dgv_Data.TabIndex = 0;
            this.Dgv_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Data_CellContentClick);
            // 
            // Panel_Right
            // 
            this.Panel_Right.Controls.Add(this.Btn_Staff);
            this.Panel_Right.Controls.Add(this.Btn_Delete);
            this.Panel_Right.Controls.Add(this.Btn_Edit);
            this.Panel_Right.Controls.Add(this.label4);
            this.Panel_Right.Controls.Add(this.iconButton4);
            this.Panel_Right.Controls.Add(this.panel4);
            this.Panel_Right.Controls.Add(this.Txt_Password);
            this.Panel_Right.Controls.Add(this.label3);
            this.Panel_Right.Controls.Add(this.label2);
            this.Panel_Right.Controls.Add(this.label1);
            this.Panel_Right.Controls.Add(this.Cmb_Usertype);
            this.Panel_Right.Controls.Add(this.iconButton3);
            this.Panel_Right.Controls.Add(this.panel3);
            this.Panel_Right.Controls.Add(this.iconButton2);
            this.Panel_Right.Controls.Add(this.panel2);
            this.Panel_Right.Controls.Add(this.Txt_Username);
            this.Panel_Right.Controls.Add(this.iconButton1);
            this.Panel_Right.Controls.Add(this.panel1);
            this.Panel_Right.Controls.Add(this.Txt_UserID);
            this.Panel_Right.Controls.Add(this.Btn_Save);
            this.Panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Right.Location = new System.Drawing.Point(300, 30);
            this.Panel_Right.Name = "Panel_Right";
            this.Panel_Right.Size = new System.Drawing.Size(300, 470);
            this.Panel_Right.TabIndex = 2;
            // 
            // Btn_Staff
            // 
            this.Btn_Staff.FlatAppearance.BorderSize = 0;
            this.Btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Staff.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Staff.Location = new System.Drawing.Point(222, 6);
            this.Btn_Staff.Name = "Btn_Staff";
            this.Btn_Staff.Size = new System.Drawing.Size(75, 33);
            this.Btn_Staff.TabIndex = 20;
            this.Btn_Staff.Text = "Staff";
            this.Btn_Staff.UseVisualStyleBackColor = true;
            this.Btn_Staff.Click += new System.EventHandler(this.Btn_Staff_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Delete.Location = new System.Drawing.Point(175, 412);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 33);
            this.Btn_Delete.TabIndex = 19;
            this.Btn_Delete.Text = "លុប";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.FlatAppearance.BorderSize = 0;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Edit.Location = new System.Drawing.Point(118, 412);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 33);
            this.Btn_Edit.TabIndex = 18;
            this.Btn_Edit.Text = "កែប្រែ";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "លេខសំងាត់ៈ";
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton4.IconColor = System.Drawing.Color.Red;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(6, 262);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(30, 30);
            this.iconButton4.TabIndex = 16;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(9, 292);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 3);
            this.panel4.TabIndex = 15;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.MistyRose;
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Password.Location = new System.Drawing.Point(37, 262);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(250, 26);
            this.Txt_Password.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "លេខកូដៈ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "លេខគណនីៈ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ប្រភេទគណនីៈ";
            // 
            // Cmb_Usertype
            // 
            this.Cmb_Usertype.BackColor = System.Drawing.Color.MistyRose;
            this.Cmb_Usertype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_Usertype.ForeColor = System.Drawing.Color.DimGray;
            this.Cmb_Usertype.FormattingEnabled = true;
            this.Cmb_Usertype.Location = new System.Drawing.Point(35, 358);
            this.Cmb_Usertype.Name = "Cmb_Usertype";
            this.Cmb_Usertype.Size = new System.Drawing.Size(252, 33);
            this.Cmb_Usertype.TabIndex = 10;
            this.Cmb_Usertype.Text = "   ";
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Red;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(4, 361);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(30, 30);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(7, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 3);
            this.panel3.TabIndex = 8;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.Red;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(6, 166);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(30, 30);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(9, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 3);
            this.panel2.TabIndex = 5;
            // 
            // Txt_Username
            // 
            this.Txt_Username.BackColor = System.Drawing.Color.MistyRose;
            this.Txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Username.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Username.Location = new System.Drawing.Point(37, 166);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(250, 26);
            this.Txt_Username.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(6, 76);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(9, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 3);
            this.panel1.TabIndex = 2;
            // 
            // Txt_UserID
            // 
            this.Txt_UserID.BackColor = System.Drawing.Color.MistyRose;
            this.Txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_UserID.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_UserID.Location = new System.Drawing.Point(37, 76);
            this.Txt_UserID.Name = "Txt_UserID";
            this.Txt_UserID.Size = new System.Drawing.Size(250, 26);
            this.Txt_UserID.TabIndex = 1;
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Save.Location = new System.Drawing.Point(37, 412);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 33);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "រក្សាទុក";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.Panel_Right);
            this.Controls.Add(this.Panel_Left);
            this.Controls.Add(this.Panel_Title);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_User";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.Panel_Right.ResumeLayout(false);
            this.Panel_Right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton Btn_Minimize;
        private FontAwesome.Sharp.IconButton Btn_Close;
        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.Panel Panel_Right;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Usertype;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Username;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_UserID;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Staff;
    }
}