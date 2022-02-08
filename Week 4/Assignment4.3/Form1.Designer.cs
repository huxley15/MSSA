namespace Assignment4._3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studGrid = new System.Windows.Forms.DataGridView();
            this.lblGrid = new System.Windows.Forms.Label();
            this.grpStud = new System.Windows.Forms.GroupBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).BeginInit();
            this.grpStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studGrid
            // 
            this.studGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.studGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrid.Location = new System.Drawing.Point(114, 92);
            this.studGrid.Name = "studGrid";
            this.studGrid.RowHeadersWidth = 51;
            this.studGrid.RowTemplate.Height = 24;
            this.studGrid.Size = new System.Drawing.Size(1146, 290);
            this.studGrid.TabIndex = 0;
            this.studGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellContentClick);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.BackColor = System.Drawing.Color.Salmon;
            this.lblGrid.Font = new System.Drawing.Font("Wide Latin", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrid.ForeColor = System.Drawing.Color.White;
            this.lblGrid.Location = new System.Drawing.Point(435, 22);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(528, 46);
            this.lblGrid.TabIndex = 1;
            this.lblGrid.Text = "2B || !2B Roster";
            // 
            // grpStud
            // 
            this.grpStud.BackColor = System.Drawing.Color.Transparent;
            this.grpStud.Controls.Add(this.txtSid);
            this.grpStud.Controls.Add(this.txtFname);
            this.grpStud.Controls.Add(this.txtLname);
            this.grpStud.Controls.Add(this.txtAddress);
            this.grpStud.Controls.Add(this.comboMonth);
            this.grpStud.Controls.Add(this.comboGrade);
            this.grpStud.Controls.Add(this.lblGrade);
            this.grpStud.Controls.Add(this.lblMonth);
            this.grpStud.Controls.Add(this.lblAddress);
            this.grpStud.Controls.Add(this.lblLname);
            this.grpStud.Controls.Add(this.lblFname);
            this.grpStud.Controls.Add(this.lblSid);
            this.grpStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpStud.Location = new System.Drawing.Point(262, 517);
            this.grpStud.Name = "grpStud";
            this.grpStud.Size = new System.Drawing.Size(594, 214);
            this.grpStud.TabIndex = 2;
            this.grpStud.TabStop = false;
            this.grpStud.Text = "Student Details";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.BackColor = System.Drawing.Color.Salmon;
            this.lblSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSid.ForeColor = System.Drawing.Color.White;
            this.lblSid.Location = new System.Drawing.Point(18, 34);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(123, 25);
            this.lblSid.TabIndex = 3;
            this.lblSid.Text = "Student ID";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.Salmon;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.White;
            this.lblFname.Location = new System.Drawing.Point(18, 63);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(128, 25);
            this.lblFname.TabIndex = 4;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.Salmon;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.White;
            this.lblLname.Location = new System.Drawing.Point(18, 94);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(125, 25);
            this.lblLname.TabIndex = 5;
            this.lblLname.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Salmon;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(18, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 25);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Salmon;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(18, 154);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(191, 25);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Admission Month";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Salmon;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.White;
            this.lblGrade.Location = new System.Drawing.Point(18, 184);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(75, 25);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade";
            // 
            // comboGrade
            // 
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboGrade.Location = new System.Drawing.Point(215, 182);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(310, 26);
            this.comboGrade.TabIndex = 3;
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboMonth.Location = new System.Drawing.Point(215, 152);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(310, 26);
            this.comboMonth.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(215, 121);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 24);
            this.txtAddress.TabIndex = 3;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(215, 92);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(310, 24);
            this.txtLname.TabIndex = 10;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(215, 61);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(310, 24);
            this.txtFname.TabIndex = 11;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(215, 32);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(310, 24);
            this.txtSid.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(342, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Salmon;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(691, 449);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(179, 40);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Remove Student";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(989, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 815);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpStud);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.studGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).EndInit();
            this.grpStud.ResumeLayout(false);
            this.grpStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studGrid;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.GroupBox grpStud;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

