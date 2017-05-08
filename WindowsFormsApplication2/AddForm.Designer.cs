namespace WindowsFormsApplication2
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdressTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpecializationTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.PossetionTxt = new System.Windows.Forms.ComboBox();
            this.TimeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.TimeToPicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneTxt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(121, 35);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 22);
            this.NameTxt.TabIndex = 1;
            this.NameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.LineValidating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Address";
            // 
            // AdressTxt
            // 
            this.AdressTxt.Location = new System.Drawing.Point(121, 86);
            this.AdressTxt.Name = "AdressTxt";
            this.AdressTxt.Size = new System.Drawing.Size(100, 22);
            this.AdressTxt.TabIndex = 2;
            this.AdressTxt.Validating += new System.ComponentModel.CancelEventHandler(this.LineValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Possetion type";
            // 
            // SpecializationTxt
            // 
            this.SpecializationTxt.Location = new System.Drawing.Point(121, 258);
            this.SpecializationTxt.Name = "SpecializationTxt";
            this.SpecializationTxt.Size = new System.Drawing.Size(100, 22);
            this.SpecializationTxt.TabIndex = 6;
            this.SpecializationTxt.Validating += new System.ComponentModel.CancelEventHandler(this.LineValidating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Specialization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Workshift";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(67, 373);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 23);
            this.AddButton.TabIndex = 54;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PossetionTxt
            // 
            this.PossetionTxt.AllowDrop = true;
            this.PossetionTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PossetionTxt.FormattingEnabled = true;
            this.PossetionTxt.Items.AddRange(new object[] {
            "Частная",
            "Государственная"});
            this.PossetionTxt.Location = new System.Drawing.Point(121, 316);
            this.PossetionTxt.Name = "PossetionTxt";
            this.PossetionTxt.Size = new System.Drawing.Size(121, 24);
            this.PossetionTxt.TabIndex = 7;
            // 
            // TimeFromPicker
            // 
            this.TimeFromPicker.CustomFormat = "";
            this.TimeFromPicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TimeFromPicker.Location = new System.Drawing.Point(121, 194);
            this.TimeFromPicker.Name = "TimeFromPicker";
            this.TimeFromPicker.Size = new System.Drawing.Size(65, 22);
            this.TimeFromPicker.TabIndex = 4;
            this.TimeFromPicker.Value = new System.DateTime(2017, 4, 27, 0, 0, 0, 0);
            // 
            // TimeToPicker
            // 
            this.TimeToPicker.CustomFormat = "";
            this.TimeToPicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TimeToPicker.Location = new System.Drawing.Point(213, 194);
            this.TimeToPicker.Name = "TimeToPicker";
            this.TimeToPicker.Size = new System.Drawing.Size(64, 22);
            this.TimeToPicker.TabIndex = 5;
            this.TimeToPicker.Value = new System.DateTime(2017, 4, 27, 23, 59, 0, 0);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.PhoneTxt.Location = new System.Drawing.Point(121, 139);
            this.PhoneTxt.Mask = "0000000000";
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.RejectInputOnFirstFailure = true;
            this.PhoneTxt.Size = new System.Drawing.Size(100, 22);
            this.PhoneTxt.TabIndex = 3;
            this.PhoneTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneTxt_Validating);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 426);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.TimeToPicker);
            this.Controls.Add(this.TimeFromPicker);
            this.Controls.Add(this.PossetionTxt);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdressTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecializationTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox NameTxt;
        public System.Windows.Forms.TextBox AdressTxt;
        public System.Windows.Forms.TextBox SpecializationTxt;
        public System.Windows.Forms.ComboBox PossetionTxt;
        public System.Windows.Forms.DateTimePicker TimeFromPicker;
        public System.Windows.Forms.DateTimePicker TimeToPicker;
        public System.Windows.Forms.MaskedTextBox PhoneTxt;
        public System.Windows.Forms.Button AddButton;
    }
}