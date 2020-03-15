namespace Win.Challenge
{
    partial class ChallengeFrm
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
            this.btn_Fibonancci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Fibonancci
            // 
            this.btn_Fibonancci.Location = new System.Drawing.Point(12, 27);
            this.btn_Fibonancci.Name = "btn_Fibonancci";
            this.btn_Fibonancci.Size = new System.Drawing.Size(156, 23);
            this.btn_Fibonancci.TabIndex = 0;
            this.btn_Fibonancci.Text = "Compute Fibonancci(10)";
            this.btn_Fibonancci.UseVisualStyleBackColor = true;
            this.btn_Fibonancci.Click += new System.EventHandler(this.btn_Fibonancci_Click);
            // 
            // ChallengeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Fibonancci);
            this.Name = "ChallengeFrm";
            this.Text = "ChallengeFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fibonancci;
    }
}