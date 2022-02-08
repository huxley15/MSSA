namespace Assignment5._1
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(244, 58);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(176, 22);
            this.textNum1.TabIndex = 0;
            this.textNum1.Leave += new System.EventHandler(this.textNum1_Leave);
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.BackColor = System.Drawing.Color.PeachPuff;
            this.labelNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNum1.Location = new System.Drawing.Point(54, 61);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(99, 18);
            this.labelNum1.TabIndex = 1;
            this.labelNum1.Text = "Enter a number";
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(244, 109);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(176, 22);
            this.textNum2.TabIndex = 2;
            this.textNum2.Leave += new System.EventHandler(this.textNum2_Leave);
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNum2.Location = new System.Drawing.Point(54, 108);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(147, 18);
            this.labelNum2.TabIndex = 3;
            this.labelNum2.Text = "Enter a second number";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(244, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(176, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add them!";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSub.Location = new System.Drawing.Point(244, 230);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(176, 39);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "Subtract them!";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMult.Location = new System.Drawing.Point(244, 295);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(176, 39);
            this.buttonMult.TabIndex = 6;
            this.buttonMult.Text = "Multiply them!";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDiv.Location = new System.Drawing.Point(244, 359);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(176, 39);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Text = "Divide them!";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturn.Location = new System.Drawing.Point(26, 260);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(187, 41);
            this.buttonReturn.TabIndex = 8;
            this.buttonReturn.Text = "Return to main menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.textNum1);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}