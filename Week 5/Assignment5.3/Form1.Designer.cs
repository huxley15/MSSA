namespace Assignment5._3
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonPuppy = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPuppy
            // 
            this.buttonPuppy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPuppy.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonPuppy.Location = new System.Drawing.Point(236, 214);
            this.buttonPuppy.Name = "buttonPuppy";
            this.buttonPuppy.Size = new System.Drawing.Size(266, 54);
            this.buttonPuppy.TabIndex = 0;
            this.buttonPuppy.Text = "Enter Application";
            this.buttonPuppy.UseVisualStyleBackColor = true;
            this.buttonPuppy.Click += new System.EventHandler(this.buttonBinary_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelMenu.Location = new System.Drawing.Point(12, 83);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(691, 27);
            this.labelMenu.TabIndex = 3;
            this.labelMenu.Text = "Welcome to the puppy database!";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonExit.Location = new System.Drawing.Point(236, 309);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(266, 59);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Close Application";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(745, 461);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonPuppy);
            this.Name = "FormMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPuppy;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonExit;
    }
}

