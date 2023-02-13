namespace GepteremProjekt
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
            this.panel = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.jobb = new System.Windows.Forms.Button();
            this.bal = new System.Windows.Forms.Button();
            this.kep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(387, 22);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(401, 229);
            this.panel.TabIndex = 5;
            // 
            // save
            // 
            this.save.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Location = new System.Drawing.Point(141, 196);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(86, 55);
            this.save.TabIndex = 4;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // jobb
            // 
            this.jobb.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.jobb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobb.Location = new System.Drawing.Point(270, 87);
            this.jobb.Name = "jobb";
            this.jobb.Size = new System.Drawing.Size(83, 49);
            this.jobb.TabIndex = 3;
            this.jobb.UseVisualStyleBackColor = true;
            this.jobb.Click += new System.EventHandler(this.jobb_Click);
            // 
            // bal
            // 
            this.bal.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.bal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bal.Location = new System.Drawing.Point(24, 87);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(78, 54);
            this.bal.TabIndex = 2;
            this.bal.UseVisualStyleBackColor = true;
            this.bal.Click += new System.EventHandler(this.bal_Click);
            // 
            // kep
            // 
            this.kep.Location = new System.Drawing.Point(124, 22);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(123, 168);
            this.kep.TabIndex = 1;
            this.kep.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.jobb);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.kep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kep;
        private System.Windows.Forms.Button bal;
        private System.Windows.Forms.Button jobb;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel;
    }
}

