namespace Assignment4._4._2
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
            this.grpCoff = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.comboTemp = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.drinkGrid = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCoff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCoff
            // 
            this.grpCoff.BackColor = System.Drawing.Color.Chocolate;
            this.grpCoff.Controls.Add(this.comboTemp);
            this.grpCoff.Controls.Add(this.comboSize);
            this.grpCoff.Controls.Add(this.comboType);
            this.grpCoff.Controls.Add(this.txtName);
            this.grpCoff.Controls.Add(this.lblTemp);
            this.grpCoff.Controls.Add(this.lblSize);
            this.grpCoff.Controls.Add(this.lblType);
            this.grpCoff.Controls.Add(this.lblName);
            this.grpCoff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpCoff.Location = new System.Drawing.Point(12, 132);
            this.grpCoff.Name = "grpCoff";
            this.grpCoff.Size = new System.Drawing.Size(657, 247);
            this.grpCoff.TabIndex = 1;
            this.grpCoff.TabStop = false;
            this.grpCoff.Text = "Enter order here";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(16, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(184, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter your name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblType.Location = new System.Drawing.Point(16, 74);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Select drink";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSize.Location = new System.Drawing.Point(16, 123);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(103, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Select size";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp.Location = new System.Drawing.Point(16, 175);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(169, 20);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Select temperature";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(226, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 26);
            this.txtName.TabIndex = 5;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(226, 71);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(364, 28);
            this.comboType.TabIndex = 6;
            // 
            // comboSize
            // 
            this.comboSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(226, 120);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(364, 28);
            this.comboSize.TabIndex = 7;
            // 
            // comboTemp
            // 
            this.comboTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTemp.FormattingEnabled = true;
            this.comboTemp.Location = new System.Drawing.Point(226, 172);
            this.comboTemp.Name = "comboTemp";
            this.comboTemp.Size = new System.Drawing.Size(364, 28);
            this.comboTemp.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Chocolate;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(12, 92);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(232, 34);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Chocolate;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(370, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Cancel Order";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // drinkGrid
            // 
            this.drinkGrid.BackgroundColor = System.Drawing.Color.Chocolate;
            this.drinkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinkGrid.Location = new System.Drawing.Point(12, 385);
            this.drinkGrid.Name = "drinkGrid";
            this.drinkGrid.RowHeadersWidth = 51;
            this.drinkGrid.RowTemplate.Height = 24;
            this.drinkGrid.Size = new System.Drawing.Size(913, 242);
            this.drinkGrid.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(249, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(605, 62);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Kyle\'s Koffee Shoppe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(797, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1170, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.drinkGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpCoff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCoff.ResumeLayout(false);
            this.grpCoff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCoff;
        private System.Windows.Forms.ComboBox comboTemp;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView drinkGrid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

