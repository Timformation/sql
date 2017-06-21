namespace getCityState
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
            this.btnGetCityState = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetCityState
            // 
            this.btnGetCityState.Location = new System.Drawing.Point(323, 265);
            this.btnGetCityState.Name = "btnGetCityState";
            this.btnGetCityState.Size = new System.Drawing.Size(164, 52);
            this.btnGetCityState.TabIndex = 0;
            this.btnGetCityState.Text = "Get City/State";
            this.btnGetCityState.UseVisualStyleBackColor = true;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(323, 176);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 31);
            this.txtZip.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 448);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.btnGetCityState);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCityState;
        private System.Windows.Forms.TextBox txtZip;
    }
}

