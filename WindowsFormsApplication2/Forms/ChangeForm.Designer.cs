namespace Shopper_handbok.Forms
{
    partial class ChangeForm
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
            this.SuspendLayout();
            // 
            // PossetionTxt
            // 
            this.PossetionTxt.Size = new System.Drawing.Size(121, 24);
            // 
            // TimeFromPicker
            // 
            this.TimeFromPicker.Value = new System.DateTime(2017, 4, 27, 0, 1, 0, 0);
            // 
            // AddButton
            // 
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 446);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}