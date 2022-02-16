namespace Assignment6._2
{
    partial class FormCarDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarDB));
            this.lblCarDB = new System.Windows.Forms.Label();
            this.menuStripCarDB = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.groupBoxCarInfo = new System.Windows.Forms.GroupBox();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnSubmitNew = new System.Windows.Forms.Button();
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStripCarDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.groupBoxCarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarDB
            // 
            this.lblCarDB.AutoSize = true;
            this.lblCarDB.BackColor = System.Drawing.Color.Transparent;
            this.lblCarDB.Font = new System.Drawing.Font("Engravers MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDB.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblCarDB.Location = new System.Drawing.Point(431, 38);
            this.lblCarDB.Name = "lblCarDB";
            this.lblCarDB.Size = new System.Drawing.Size(318, 51);
            this.lblCarDB.TabIndex = 0;
            this.lblCarDB.Text = "Welcome";
            // 
            // menuStripCarDB
            // 
            this.menuStripCarDB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCarDB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripCarDB.Location = new System.Drawing.Point(0, 0);
            this.menuStripCarDB.Name = "menuStripCarDB";
            this.menuStripCarDB.Size = new System.Drawing.Size(1239, 28);
            this.menuStripCarDB.TabIndex = 1;
            this.menuStripCarDB.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridCars
            // 
            this.dataGridCars.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(107, 101);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.RowHeadersWidth = 51;
            this.dataGridCars.RowTemplate.Height = 24;
            this.dataGridCars.Size = new System.Drawing.Size(1007, 204);
            this.dataGridCars.TabIndex = 2;
            // 
            // groupBoxCarInfo
            // 
            this.groupBoxCarInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCarInfo.Controls.Add(this.btnSubmitUpdate);
            this.groupBoxCarInfo.Controls.Add(this.btnSubmitNew);
            this.groupBoxCarInfo.Controls.Add(this.txtColor);
            this.groupBoxCarInfo.Controls.Add(this.txtPrice);
            this.groupBoxCarInfo.Controls.Add(this.txtYear);
            this.groupBoxCarInfo.Controls.Add(this.txtModel);
            this.groupBoxCarInfo.Controls.Add(this.txtMake);
            this.groupBoxCarInfo.Controls.Add(this.txtVIN);
            this.groupBoxCarInfo.Controls.Add(this.lblColor);
            this.groupBoxCarInfo.Controls.Add(this.lblPrice);
            this.groupBoxCarInfo.Controls.Add(this.lblYear);
            this.groupBoxCarInfo.Controls.Add(this.lblModel);
            this.groupBoxCarInfo.Controls.Add(this.lblMake);
            this.groupBoxCarInfo.Controls.Add(this.lblVIN);
            this.groupBoxCarInfo.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCarInfo.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBoxCarInfo.Location = new System.Drawing.Point(44, 345);
            this.groupBoxCarInfo.Name = "groupBoxCarInfo";
            this.groupBoxCarInfo.Size = new System.Drawing.Size(407, 376);
            this.groupBoxCarInfo.TabIndex = 3;
            this.groupBoxCarInfo.TabStop = false;
            this.groupBoxCarInfo.Text = "Car Info";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Engravers MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblVIN.Location = new System.Drawing.Point(16, 39);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(53, 20);
            this.lblVIN.TabIndex = 0;
            this.lblVIN.Text = "VIN";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Engravers MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblMake.Location = new System.Drawing.Point(16, 81);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(78, 20);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Engravers MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblModel.Location = new System.Drawing.Point(16, 125);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(94, 20);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Engravers MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblYear.Location = new System.Drawing.Point(16, 171);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(76, 20);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Engravers MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblPrice.Location = new System.Drawing.Point(16, 214);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Engravers MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblColor.Location = new System.Drawing.Point(16, 259);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(92, 20);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(137, 36);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(245, 25);
            this.txtVIN.TabIndex = 6;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(137, 78);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(245, 25);
            this.txtMake.TabIndex = 7;
            this.txtMake.Leave += new System.EventHandler(this.txtMake_Leave);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(137, 122);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(245, 25);
            this.txtModel.TabIndex = 8;
            this.txtModel.Leave += new System.EventHandler(this.txtModel_Leave);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(137, 168);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(245, 25);
            this.txtYear.TabIndex = 9;
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 211);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(245, 25);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(137, 256);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(245, 25);
            this.txtColor.TabIndex = 11;
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
            // 
            // btnSubmitNew
            // 
            this.btnSubmitNew.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNew.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSubmitNew.Location = new System.Drawing.Point(19, 311);
            this.btnSubmitNew.Name = "btnSubmitNew";
            this.btnSubmitNew.Size = new System.Drawing.Size(157, 44);
            this.btnSubmitNew.TabIndex = 12;
            this.btnSubmitNew.Text = "Submit New Car";
            this.btnSubmitNew.UseVisualStyleBackColor = false;
            this.btnSubmitNew.Click += new System.EventHandler(this.btnSubmitNew_Click);
            // 
            // btnSubmitUpdate
            // 
            this.btnSubmitUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitUpdate.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSubmitUpdate.Location = new System.Drawing.Point(204, 311);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(178, 44);
            this.btnSubmitUpdate.TabIndex = 13;
            this.btnSubmitUpdate.Text = "Submit Update";
            this.btnSubmitUpdate.UseVisualStyleBackColor = false;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnAdd.Location = new System.Drawing.Point(543, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 59);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add New Car";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnUpdate.Location = new System.Drawing.Point(543, 437);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 62);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update Car Info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnDelete.Location = new System.Drawing.Point(543, 536);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 60);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Car";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnRefresh.Location = new System.Drawing.Point(543, 635);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 65);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormCarDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1239, 749);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxCarInfo);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.lblCarDB);
            this.Controls.Add(this.menuStripCarDB);
            this.MainMenuStrip = this.menuStripCarDB;
            this.Name = "FormCarDB";
            this.Text = "Car Database";
            this.Load += new System.EventHandler(this.FormCarDB_Load);
            this.menuStripCarDB.ResumeLayout(false);
            this.menuStripCarDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.groupBoxCarInfo.ResumeLayout(false);
            this.groupBoxCarInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarDB;
        private System.Windows.Forms.MenuStrip menuStripCarDB;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.GroupBox groupBoxCarInfo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Button btnSubmitUpdate;
        private System.Windows.Forms.Button btnSubmitNew;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}