namespace LatinTranslator
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
            this.btnLatinsinister = new System.Windows.Forms.Button();
            this.btnLatinMedium = new System.Windows.Forms.Button();
            this.btnLatinDexter = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLatinsinister
            // 
            this.btnLatinsinister.Location = new System.Drawing.Point(78, 344);
            this.btnLatinsinister.Name = "btnLatinsinister";
            this.btnLatinsinister.Size = new System.Drawing.Size(136, 35);
            this.btnLatinsinister.TabIndex = 0;
            this.btnLatinsinister.Text = "Sinister";
            this.btnLatinsinister.UseVisualStyleBackColor = true;
            // 
            // btnLatinMedium
            // 
            this.btnLatinMedium.Location = new System.Drawing.Point(311, 344);
            this.btnLatinMedium.Name = "btnLatinMedium";
            this.btnLatinMedium.Size = new System.Drawing.Size(129, 36);
            this.btnLatinMedium.TabIndex = 1;
            this.btnLatinMedium.Text = "Medium";
            this.btnLatinMedium.UseVisualStyleBackColor = true;
            this.btnLatinMedium.Click += new System.EventHandler(this.btnLatinMedium_Click);
            // 
            // btnLatinDexter
            // 
            this.btnLatinDexter.Location = new System.Drawing.Point(540, 344);
            this.btnLatinDexter.Name = "btnLatinDexter";
            this.btnLatinDexter.Size = new System.Drawing.Size(153, 35);
            this.btnLatinDexter.TabIndex = 2;
            this.btnLatinDexter.Text = "Dexter";
            this.btnLatinDexter.UseVisualStyleBackColor = true;
            this.btnLatinDexter.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(306, 87);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 25);
            this.lblOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnLatinDexter);
            this.Controls.Add(this.btnLatinMedium);
            this.Controls.Add(this.btnLatinsinister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLatinsinister;
        private System.Windows.Forms.Button btnLatinMedium;
        private System.Windows.Forms.Button btnLatinDexter;
        private System.Windows.Forms.Label lblOutput;
    }
}

