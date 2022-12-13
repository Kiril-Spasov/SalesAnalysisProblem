namespace SalesAnalysisProblem
{
    partial class FormSalesAnalysis
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
            this.BtnShowAnalysis = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnShowAnalysis
            // 
            this.BtnShowAnalysis.Location = new System.Drawing.Point(37, 47);
            this.BtnShowAnalysis.Name = "BtnShowAnalysis";
            this.BtnShowAnalysis.Size = new System.Drawing.Size(179, 56);
            this.BtnShowAnalysis.TabIndex = 0;
            this.BtnShowAnalysis.Text = "Show Analysis";
            this.BtnShowAnalysis.UseVisualStyleBackColor = true;
            this.BtnShowAnalysis.Click += new System.EventHandler(this.BtnShowAnalysis_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(249, 47);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(467, 350);
            this.TxtResult.TabIndex = 1;
            // 
            // FormSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnShowAnalysis);
            this.Name = "FormSalesAnalysis";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowAnalysis;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

