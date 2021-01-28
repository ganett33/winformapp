namespace Win5215Assign2
{
    partial class form
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
            this.lstbList = new System.Windows.Forms.ListBox();
            this.txtbCusNam = new System.Windows.Forms.TextBox();
            this.lbCustNam = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCustDetail = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbLNam = new System.Windows.Forms.TextBox();
            this.txtbFNam = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbLN = new System.Windows.Forms.Label();
            this.lbFN = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnListCust = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbList
            // 
            this.lstbList.FormattingEnabled = true;
            this.lstbList.Location = new System.Drawing.Point(41, 122);
            this.lstbList.Name = "lstbList";
            this.lstbList.Size = new System.Drawing.Size(305, 212);
            this.lstbList.TabIndex = 15;
            this.lstbList.SelectedIndexChanged += new System.EventHandler(this.lstbList_SelectedIndexChanged);
            // 
            // txtbCusNam
            // 
            this.txtbCusNam.BackColor = System.Drawing.Color.White;
            this.txtbCusNam.Location = new System.Drawing.Point(41, 85);
            this.txtbCusNam.Multiline = true;
            this.txtbCusNam.Name = "txtbCusNam";
            this.txtbCusNam.Size = new System.Drawing.Size(212, 30);
            this.txtbCusNam.TabIndex = 13;
            // 
            // lbCustNam
            // 
            this.lbCustNam.AutoSize = true;
            this.lbCustNam.BackColor = System.Drawing.Color.Transparent;
            this.lbCustNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCustNam.Location = new System.Drawing.Point(44, 57);
            this.lbCustNam.Name = "lbCustNam";
            this.lbCustNam.Size = new System.Drawing.Size(191, 20);
            this.lbCustNam.TabIndex = 0;
            this.lbCustNam.Text = "Enter Customer Name:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(749, 450);
            this.panel5.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lbCustDetail);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gbox);
            this.panel1.Controls.Add(this.btnClearList);
            this.panel1.Controls.Add(this.btnListCust);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lbCustNam);
            this.panel1.Controls.Add(this.txtbCusNam);
            this.panel1.Controls.Add(this.lstbList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 450);
            this.panel1.TabIndex = 15;
            // 
            // lbCustDetail
            // 
            this.lbCustDetail.AutoSize = true;
            this.lbCustDetail.BackColor = System.Drawing.Color.DarkGray;
            this.lbCustDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustDetail.Location = new System.Drawing.Point(532, 106);
            this.lbCustDetail.Name = "lbCustDetail";
            this.lbCustDetail.Size = new System.Drawing.Size(152, 20);
            this.lbCustDetail.TabIndex = 19;
            this.lbCustDetail.Text = "Customer Details:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Location = new System.Drawing.Point(147, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(455, 45);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Location = new System.Drawing.Point(293, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(145, 45);
            this.panel8.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(14, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 45);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(440, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 45);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(161, 405);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 45);
            this.panel4.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(147, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 45);
            this.panel2.TabIndex = 21;
            // 
            // gbox
            // 
            this.gbox.BackColor = System.Drawing.Color.Transparent;
            this.gbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbox.Controls.Add(this.btnDel);
            this.gbox.Controls.Add(this.btnClear);
            this.gbox.Controls.Add(this.btnADD);
            this.gbox.Controls.Add(this.btnUpdate);
            this.gbox.Controls.Add(this.txtbPhone);
            this.gbox.Controls.Add(this.txtbLNam);
            this.gbox.Controls.Add(this.txtbFNam);
            this.gbox.Controls.Add(this.lbPhone);
            this.gbox.Controls.Add(this.lbLN);
            this.gbox.Controls.Add(this.lbFN);
            this.gbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbox.Location = new System.Drawing.Point(372, 115);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(327, 265);
            this.gbox.TabIndex = 19;
            this.gbox.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDel.FlatAppearance.BorderSize = 4;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDel.Location = new System.Drawing.Point(27, 196);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(129, 30);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 4;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(183, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 30);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnADD
            // 
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnADD.FlatAppearance.BorderSize = 2;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnADD.Location = new System.Drawing.Point(183, 156);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(129, 30);
            this.btnADD.TabIndex = 22;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 4;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(27, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 30);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbPhone
            // 
            this.txtbPhone.Location = new System.Drawing.Point(128, 99);
            this.txtbPhone.Multiline = true;
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(184, 25);
            this.txtbPhone.TabIndex = 20;
            // 
            // txtbLNam
            // 
            this.txtbLNam.Location = new System.Drawing.Point(128, 67);
            this.txtbLNam.Multiline = true;
            this.txtbLNam.Name = "txtbLNam";
            this.txtbLNam.Size = new System.Drawing.Size(184, 25);
            this.txtbLNam.TabIndex = 19;
            // 
            // txtbFNam
            // 
            this.txtbFNam.Location = new System.Drawing.Point(128, 30);
            this.txtbFNam.Multiline = true;
            this.txtbFNam.Name = "txtbFNam";
            this.txtbFNam.Size = new System.Drawing.Size(184, 25);
            this.txtbFNam.TabIndex = 18;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(53, 99);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(63, 20);
            this.lbPhone.TabIndex = 22;
            this.lbPhone.Text = "Phone :";
            // 
            // lbLN
            // 
            this.lbLN.AutoSize = true;
            this.lbLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLN.Location = new System.Drawing.Point(22, 63);
            this.lbLN.Name = "lbLN";
            this.lbLN.Size = new System.Drawing.Size(90, 20);
            this.lbLN.TabIndex = 21;
            this.lbLN.Text = "LastName :";
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFN.Location = new System.Drawing.Point(22, 28);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(90, 20);
            this.lbFN.TabIndex = 20;
            this.lbFN.Text = "FirstName :";
            // 
            // btnClearList
            // 
            this.btnClearList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearList.FlatAppearance.BorderSize = 4;
            this.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearList.Location = new System.Drawing.Point(197, 350);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(150, 30);
            this.btnClearList.TabIndex = 17;
            this.btnClearList.Text = "CLEAR LIST";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnListCust
            // 
            this.btnListCust.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListCust.FlatAppearance.BorderSize = 4;
            this.btnListCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListCust.Location = new System.Drawing.Point(41, 350);
            this.btnListCust.Name = "btnListCust";
            this.btnListCust.Size = new System.Drawing.Size(150, 30);
            this.btnListCust.TabIndex = 16;
            this.btnListCust.Text = "LIST CUSTOMERS";
            this.btnListCust.UseVisualStyleBackColor = true;
            this.btnListCust.Click += new System.EventHandler(this.btnListCust_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 4;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(259, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.panel5);
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstbList;
        private System.Windows.Forms.TextBox txtbCusNam;
        private System.Windows.Forms.Label lbCustNam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnListCust;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbLNam;
        private System.Windows.Forms.TextBox txtbFNam;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbLN;
        private System.Windows.Forms.Label lbCustDetail;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}

