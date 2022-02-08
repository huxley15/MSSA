namespace Assignment5._1
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textEmpAge = new System.Windows.Forms.TextBox();
            this.textFName = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.textLName = new System.Windows.Forms.TextBox();
            this.groupAddEmp = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonSubmitEmp = new System.Windows.Forms.Button();
            this.labelDept = new System.Windows.Forms.Label();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.buttonAddEmp = new System.Windows.Forms.Button();
            this.buttonDeleteEmp = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupAddEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textEmpAge
            // 
            this.textEmpAge.Location = new System.Drawing.Point(312, 92);
            this.textEmpAge.Name = "textEmpAge";
            this.textEmpAge.Size = new System.Drawing.Size(100, 22);
            this.textEmpAge.TabIndex = 1;
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(23, 145);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(262, 22);
            this.textFName.TabIndex = 2;
            this.textFName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(20, 73);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(113, 16);
            this.labelDOB.TabIndex = 3;
            this.labelDOB.Text = "Enter date of birth:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(20, 126);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(101, 16);
            this.labelFName.TabIndex = 4;
            this.labelFName.Text = "Enter first name:";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(20, 183);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(102, 16);
            this.labelLName.TabIndex = 5;
            this.labelLName.Text = "Enter last name:";
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(23, 202);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(262, 22);
            this.textLName.TabIndex = 6;
            this.textLName.TextChanged += new System.EventHandler(this.textLName_TextChanged);
            // 
            // groupAddEmp
            // 
            this.groupAddEmp.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupAddEmp.Controls.Add(this.labelID);
            this.groupAddEmp.Controls.Add(this.textID);
            this.groupAddEmp.Controls.Add(this.buttonSubmitEmp);
            this.groupAddEmp.Controls.Add(this.labelDept);
            this.groupAddEmp.Controls.Add(this.comboDept);
            this.groupAddEmp.Controls.Add(this.labelDOB);
            this.groupAddEmp.Controls.Add(this.textLName);
            this.groupAddEmp.Controls.Add(this.dateTimePicker1);
            this.groupAddEmp.Controls.Add(this.labelLName);
            this.groupAddEmp.Controls.Add(this.textEmpAge);
            this.groupAddEmp.Controls.Add(this.textFName);
            this.groupAddEmp.Controls.Add(this.labelFName);
            this.groupAddEmp.Location = new System.Drawing.Point(12, 70);
            this.groupAddEmp.Name = "groupAddEmp";
            this.groupAddEmp.Size = new System.Drawing.Size(568, 360);
            this.groupAddEmp.TabIndex = 7;
            this.groupAddEmp.TabStop = false;
            this.groupAddEmp.Text = "Enter new employee informaton";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(20, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(118, 16);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "Enter employee ID";
            this.labelID.Visible = false;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(23, 39);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(262, 22);
            this.textID.TabIndex = 10;
            this.textID.Visible = false;
            // 
            // buttonSubmitEmp
            // 
            this.buttonSubmitEmp.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSubmitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitEmp.Location = new System.Drawing.Point(23, 300);
            this.buttonSubmitEmp.Name = "buttonSubmitEmp";
            this.buttonSubmitEmp.Size = new System.Drawing.Size(262, 23);
            this.buttonSubmitEmp.TabIndex = 9;
            this.buttonSubmitEmp.Text = "Submit new employee info";
            this.buttonSubmitEmp.UseVisualStyleBackColor = false;
            this.buttonSubmitEmp.Click += new System.EventHandler(this.buttonSubmitEmp_Click);
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(20, 236);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(116, 16);
            this.labelDept.TabIndex = 8;
            this.labelDept.Text = "Select department";
            this.labelDept.Click += new System.EventHandler(this.labelDept_Click);
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(23, 255);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(262, 24);
            this.comboDept.TabIndex = 7;
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.Location = new System.Drawing.Point(12, 449);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.RowHeadersWidth = 51;
            this.dataGridEmp.RowTemplate.Height = 24;
            this.dataGridEmp.Size = new System.Drawing.Size(1070, 284);
            this.dataGridEmp.TabIndex = 8;
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmp.Location = new System.Drawing.Point(12, 32);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(271, 32);
            this.buttonAddEmp.TabIndex = 9;
            this.buttonAddEmp.Text = "Add new employee";
            this.buttonAddEmp.UseVisualStyleBackColor = false;
            this.buttonAddEmp.Click += new System.EventHandler(this.buttonAddEmp_Click);
            // 
            // buttonDeleteEmp
            // 
            this.buttonDeleteEmp.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteEmp.Location = new System.Drawing.Point(310, 32);
            this.buttonDeleteEmp.Name = "buttonDeleteEmp";
            this.buttonDeleteEmp.Size = new System.Drawing.Size(270, 32);
            this.buttonDeleteEmp.TabIndex = 10;
            this.buttonDeleteEmp.Text = "Delete selected employee";
            this.buttonDeleteEmp.UseVisualStyleBackColor = false;
            this.buttonDeleteEmp.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(776, 396);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(254, 34);
            this.buttonReturn.TabIndex = 11;
            this.buttonReturn.Text = "Return to main menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1198, 745);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonDeleteEmp);
            this.Controls.Add(this.buttonAddEmp);
            this.Controls.Add(this.dataGridEmp);
            this.Controls.Add(this.groupAddEmp);
            this.Name = "FormEmployee";
            this.Text = "Employee System";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.groupAddEmp.ResumeLayout(false);
            this.groupAddEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textEmpAge;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.GroupBox groupAddEmp;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Button buttonSubmitEmp;
        private System.Windows.Forms.DataGridView dataGridEmp;
        private System.Windows.Forms.Button buttonAddEmp;
        private System.Windows.Forms.Button buttonDeleteEmp;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonReturn;
    }
}

