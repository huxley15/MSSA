namespace Assignment5._4_Forms
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.dataGridLib = new System.Windows.Forms.DataGridView();
            this.groupBoxAddBooks = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imSadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLib)).BeginInit();
            this.groupBoxAddBooks.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridLib
            // 
            this.dataGridLib.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLib.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridLib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLib.Location = new System.Drawing.Point(12, 288);
            this.dataGridLib.Name = "dataGridLib";
            this.dataGridLib.RowHeadersWidth = 51;
            this.dataGridLib.RowTemplate.Height = 24;
            this.dataGridLib.Size = new System.Drawing.Size(776, 150);
            this.dataGridLib.TabIndex = 9;
            // 
            // groupBoxAddBooks
            // 
            this.groupBoxAddBooks.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddBooks.Controls.Add(this.btnSubmit);
            this.groupBoxAddBooks.Controls.Add(this.lblGenre);
            this.groupBoxAddBooks.Controls.Add(this.lblAuthor);
            this.groupBoxAddBooks.Controls.Add(this.lblTitle);
            this.groupBoxAddBooks.Controls.Add(this.comboGenre);
            this.groupBoxAddBooks.Controls.Add(this.txtAuthor);
            this.groupBoxAddBooks.Controls.Add(this.txtTitle);
            this.groupBoxAddBooks.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxAddBooks.Location = new System.Drawing.Point(0, 78);
            this.groupBoxAddBooks.Name = "groupBoxAddBooks";
            this.groupBoxAddBooks.Size = new System.Drawing.Size(527, 204);
            this.groupBoxAddBooks.TabIndex = 1;
            this.groupBoxAddBooks.TabStop = false;
            this.groupBoxAddBooks.Text = "Enter Book Info";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(191, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(318, 35);
            this.txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(191, 71);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(318, 35);
            this.txtAuthor.TabIndex = 3;
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(191, 125);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(318, 35);
            this.comboGenre.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(5, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Enter title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(7, 79);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(129, 27);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Enter author";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(5, 129);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(116, 27);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Select genre";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAdd.Font = new System.Drawing.Font("Viner Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(12, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSubmit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSubmit.Location = new System.Drawing.Point(167, 166);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 32);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Book";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.Font = new System.Drawing.Font("Viner Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Location = new System.Drawing.Point(223, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Book";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDisplay.Font = new System.Drawing.Font("Viner Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDisplay.Location = new System.Drawing.Point(431, 40);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(176, 32);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "Display Books";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
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
            // helpMeToolStripMenuItem
            // 
            this.helpMeToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.helpMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imSadToolStripMenuItem});
            this.helpMeToolStripMenuItem.Name = "helpMeToolStripMenuItem";
            this.helpMeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpMeToolStripMenuItem.Text = "Help";
            // 
            // imSadToolStripMenuItem
            // 
            this.imSadToolStripMenuItem.Name = "imSadToolStripMenuItem";
            this.imSadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imSadToolStripMenuItem.Text = "I\'m sad :(";
            this.imSadToolStripMenuItem.Click += new System.EventHandler(this.imSadToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxAddBooks);
            this.Controls.Add(this.dataGridLib);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLib)).EndInit();
            this.groupBoxAddBooks.ResumeLayout(false);
            this.groupBoxAddBooks.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLib;
        private System.Windows.Forms.GroupBox groupBoxAddBooks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imSadToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}