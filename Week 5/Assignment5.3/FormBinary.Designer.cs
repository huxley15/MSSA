namespace Assignment5._3
{
    partial class FormPuppy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPuppy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboBreed = new System.Windows.Forms.ComboBox();
            this.comboToy = new System.Windows.Forms.ComboBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labelBreed = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelToy = new System.Windows.Forms.Label();
            this.buttonBinSer = new System.Windows.Forms.Button();
            this.buttonBinDes = new System.Windows.Forms.Button();
            this.buttonXMLSer = new System.Windows.Forms.Button();
            this.buttonXMLDes = new System.Windows.Forms.Button();
            this.buttonJSONSer = new System.Windows.Forms.Button();
            this.buttonJSONDes = new System.Windows.Forms.Button();
            this.comboSerSelect = new System.Windows.Forms.ComboBox();
            this.labelSerSelect = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelToy);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelBreed);
            this.groupBox1.Controls.Add(this.textAge);
            this.groupBox1.Controls.Add(this.comboToy);
            this.groupBox1.Controls.Add(this.comboBreed);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(31, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter puppy info";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(231, 73);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(201, 26);
            this.textName.TabIndex = 2;
            // 
            // comboBreed
            // 
            this.comboBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBreed.FormattingEnabled = true;
            this.comboBreed.Location = new System.Drawing.Point(231, 33);
            this.comboBreed.Name = "comboBreed";
            this.comboBreed.Size = new System.Drawing.Size(201, 28);
            this.comboBreed.TabIndex = 1;
            // 
            // comboToy
            // 
            this.comboToy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboToy.FormattingEnabled = true;
            this.comboToy.Location = new System.Drawing.Point(231, 158);
            this.comboToy.Name = "comboToy";
            this.comboToy.Size = new System.Drawing.Size(201, 28);
            this.comboToy.TabIndex = 4;
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(231, 117);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(201, 26);
            this.textAge.TabIndex = 3;
            this.textAge.Leave += new System.EventHandler(this.textAge_Leave);
            // 
            // labelBreed
            // 
            this.labelBreed.AutoSize = true;
            this.labelBreed.BackColor = System.Drawing.Color.Chocolate;
            this.labelBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBreed.Location = new System.Drawing.Point(12, 36);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(144, 25);
            this.labelBreed.TabIndex = 1;
            this.labelBreed.Text = "Select breed";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Chocolate;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(12, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 25);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Enter name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.Chocolate;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAge.Location = new System.Drawing.Point(12, 120);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(113, 25);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Enter age";
            // 
            // labelToy
            // 
            this.labelToy.AutoSize = true;
            this.labelToy.BackColor = System.Drawing.Color.Chocolate;
            this.labelToy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelToy.Location = new System.Drawing.Point(12, 161);
            this.labelToy.Name = "labelToy";
            this.labelToy.Size = new System.Drawing.Size(203, 25);
            this.labelToy.TabIndex = 5;
            this.labelToy.Text = "Select favorite toy";
            // 
            // buttonBinSer
            // 
            this.buttonBinSer.BackColor = System.Drawing.Color.Transparent;
            this.buttonBinSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinSer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBinSer.Location = new System.Drawing.Point(31, 340);
            this.buttonBinSer.Name = "buttonBinSer";
            this.buttonBinSer.Size = new System.Drawing.Size(206, 51);
            this.buttonBinSer.TabIndex = 6;
            this.buttonBinSer.Text = "Binary Serialize";
            this.buttonBinSer.UseVisualStyleBackColor = false;
            this.buttonBinSer.Click += new System.EventHandler(this.buttonBinSer_Click);
            // 
            // buttonBinDes
            // 
            this.buttonBinDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinDes.Location = new System.Drawing.Point(31, 435);
            this.buttonBinDes.Name = "buttonBinDes";
            this.buttonBinDes.Size = new System.Drawing.Size(206, 51);
            this.buttonBinDes.TabIndex = 7;
            this.buttonBinDes.Text = "Binary DeSerialize";
            this.buttonBinDes.UseVisualStyleBackColor = true;
            this.buttonBinDes.Click += new System.EventHandler(this.buttonBinDes_Click);
            // 
            // buttonXMLSer
            // 
            this.buttonXMLSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXMLSer.Location = new System.Drawing.Point(305, 340);
            this.buttonXMLSer.Name = "buttonXMLSer";
            this.buttonXMLSer.Size = new System.Drawing.Size(206, 51);
            this.buttonXMLSer.TabIndex = 6;
            this.buttonXMLSer.Text = "XML Serialize";
            this.buttonXMLSer.UseVisualStyleBackColor = true;
            this.buttonXMLSer.Click += new System.EventHandler(this.buttonXMLSer_Click);
            // 
            // buttonXMLDes
            // 
            this.buttonXMLDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXMLDes.Location = new System.Drawing.Point(305, 435);
            this.buttonXMLDes.Name = "buttonXMLDes";
            this.buttonXMLDes.Size = new System.Drawing.Size(206, 51);
            this.buttonXMLDes.TabIndex = 7;
            this.buttonXMLDes.Text = "XML DeSerialize";
            this.buttonXMLDes.UseVisualStyleBackColor = true;
            this.buttonXMLDes.Click += new System.EventHandler(this.buttonXMLDes_Click);
            // 
            // buttonJSONSer
            // 
            this.buttonJSONSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJSONSer.Location = new System.Drawing.Point(575, 340);
            this.buttonJSONSer.Name = "buttonJSONSer";
            this.buttonJSONSer.Size = new System.Drawing.Size(206, 51);
            this.buttonJSONSer.TabIndex = 6;
            this.buttonJSONSer.Text = "JSON Serialize";
            this.buttonJSONSer.UseVisualStyleBackColor = true;
            this.buttonJSONSer.Click += new System.EventHandler(this.buttonJSONSer_Click);
            // 
            // buttonJSONDes
            // 
            this.buttonJSONDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJSONDes.Location = new System.Drawing.Point(575, 435);
            this.buttonJSONDes.Name = "buttonJSONDes";
            this.buttonJSONDes.Size = new System.Drawing.Size(206, 51);
            this.buttonJSONDes.TabIndex = 7;
            this.buttonJSONDes.Text = "JSON DeSerialize";
            this.buttonJSONDes.UseVisualStyleBackColor = true;
            this.buttonJSONDes.Click += new System.EventHandler(this.buttonJSONDes_Click);
            // 
            // comboSerSelect
            // 
            this.comboSerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSerSelect.FormattingEnabled = true;
            this.comboSerSelect.Location = new System.Drawing.Point(377, 270);
            this.comboSerSelect.Name = "comboSerSelect";
            this.comboSerSelect.Size = new System.Drawing.Size(263, 28);
            this.comboSerSelect.TabIndex = 5;
            this.comboSerSelect.SelectedIndexChanged += new System.EventHandler(this.comboSerSelect_SelectedIndexChanged);
            this.comboSerSelect.SelectedValueChanged += new System.EventHandler(this.comboSerSelect_SelectedValueChanged);
            // 
            // labelSerSelect
            // 
            this.labelSerSelect.AutoSize = true;
            this.labelSerSelect.BackColor = System.Drawing.Color.Chocolate;
            this.labelSerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSerSelect.Location = new System.Drawing.Point(43, 270);
            this.labelSerSelect.Name = "labelSerSelect";
            this.labelSerSelect.Size = new System.Drawing.Size(238, 20);
            this.labelSerSelect.TabIndex = 8;
            this.labelSerSelect.Text = "Select serialization method";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(305, 572);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(206, 64);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Return to Main Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 511);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(540, 511);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // FormPuppy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(823, 679);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelSerSelect);
            this.Controls.Add(this.comboSerSelect);
            this.Controls.Add(this.buttonJSONDes);
            this.Controls.Add(this.buttonJSONSer);
            this.Controls.Add(this.buttonXMLDes);
            this.Controls.Add(this.buttonXMLSer);
            this.Controls.Add(this.buttonBinDes);
            this.Controls.Add(this.buttonBinSer);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPuppy";
            this.Text = "FormPuppy";
            this.Load += new System.EventHandler(this.FormPuppy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.ComboBox comboToy;
        private System.Windows.Forms.ComboBox comboBreed;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelToy;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.Button buttonBinSer;
        private System.Windows.Forms.Button buttonBinDes;
        private System.Windows.Forms.Button buttonXMLSer;
        private System.Windows.Forms.Button buttonXMLDes;
        private System.Windows.Forms.Button buttonJSONSer;
        private System.Windows.Forms.Button buttonJSONDes;
        private System.Windows.Forms.ComboBox comboSerSelect;
        private System.Windows.Forms.Label labelSerSelect;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}