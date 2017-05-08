namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textSearchName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textSearchAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textSearchPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textSearchSpecialization = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textSearchPossetion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.returnToBase = new System.Windows.Forms.Button();
            this.SearchTimeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.SearchTimeToPicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SaveExcelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possetionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.possetionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(232, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 599);
            this.dataGridView1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dataGridView1, "Doubleclick for editing");
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddBtn.Location = new System.Drawing.Point(2, 198);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(224, 98);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add company";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddCompany_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(8, 80);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 64);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete (selected)";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.DeleteCompany);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(302, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Name";
            // 
            // textSearchName
            // 
            this.textSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSearchName.Location = new System.Drawing.Point(307, 35);
            this.textSearchName.Name = "textSearchName";
            this.textSearchName.Size = new System.Drawing.Size(100, 36);
            this.textSearchName.TabIndex = 1;
            this.textSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(435, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Address";
            // 
            // textSearchAddress
            // 
            this.textSearchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSearchAddress.Location = new System.Drawing.Point(433, 35);
            this.textSearchAddress.Name = "textSearchAddress";
            this.textSearchAddress.Size = new System.Drawing.Size(100, 36);
            this.textSearchAddress.TabIndex = 2;
            this.textSearchAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(558, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "Phone";
            // 
            // textSearchPhone
            // 
            this.textSearchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSearchPhone.Location = new System.Drawing.Point(563, 35);
            this.textSearchPhone.Name = "textSearchPhone";
            this.textSearchPhone.Size = new System.Drawing.Size(100, 36);
            this.textSearchPhone.TabIndex = 3;
            this.textSearchPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(906, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "Possetion type";
            // 
            // textSearchSpecialization
            // 
            this.textSearchSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSearchSpecialization.Location = new System.Drawing.Point(756, 36);
            this.textSearchSpecialization.Name = "textSearchSpecialization";
            this.textSearchSpecialization.Size = new System.Drawing.Size(100, 36);
            this.textSearchSpecialization.TabIndex = 4;
            this.textSearchSpecialization.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(702, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Specialization";
            // 
            // textSearchPossetion
            // 
            this.textSearchPossetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSearchPossetion.Location = new System.Drawing.Point(938, 34);
            this.textSearchPossetion.Name = "textSearchPossetion";
            this.textSearchPossetion.Size = new System.Drawing.Size(100, 36);
            this.textSearchPossetion.TabIndex = 5;
            this.textSearchPossetion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label14.Location = new System.Drawing.Point(1156, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 29);
            this.label14.TabIndex = 25;
            this.label14.Text = "Workshift";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(8, 50);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 33);
            this.save.TabIndex = 36;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(8, 21);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(114, 33);
            this.open.TabIndex = 37;
            this.open.Text = "Open base";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // returnToBase
            // 
            this.returnToBase.Location = new System.Drawing.Point(128, 111);
            this.returnToBase.Name = "returnToBase";
            this.returnToBase.Size = new System.Drawing.Size(98, 71);
            this.returnToBase.TabIndex = 38;
            this.returnToBase.Text = "Return to the main base";
            this.returnToBase.UseVisualStyleBackColor = true;
            this.returnToBase.Click += new System.EventHandler(this.ReturnToBase_Click);
            // 
            // SearchTimeFromPicker
            // 
            this.SearchTimeFromPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchTimeFromPicker.Location = new System.Drawing.Point(1139, 41);
            this.SearchTimeFromPicker.Name = "SearchTimeFromPicker";
            this.SearchTimeFromPicker.Size = new System.Drawing.Size(95, 36);
            this.SearchTimeFromPicker.TabIndex = 6;
            this.SearchTimeFromPicker.Value = new System.DateTime(2017, 4, 29, 0, 0, 0, 0);
            this.SearchTimeFromPicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // SearchTimeToPicker
            // 
            this.SearchTimeToPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchTimeToPicker.Location = new System.Drawing.Point(1240, 41);
            this.SearchTimeToPicker.Name = "SearchTimeToPicker";
            this.SearchTimeToPicker.Size = new System.Drawing.Size(98, 36);
            this.SearchTimeToPicker.TabIndex = 7;
            this.SearchTimeToPicker.Value = new System.DateTime(2017, 4, 29, 23, 59, 0, 0);
            this.SearchTimeToPicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolTip1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ShowAlways = true;
            // 
            // SaveExcelBtn
            // 
            this.SaveExcelBtn.Location = new System.Drawing.Point(8, 140);
            this.SaveExcelBtn.Name = "SaveExcelBtn";
            this.SaveExcelBtn.Size = new System.Drawing.Size(114, 42);
            this.SaveExcelBtn.TabIndex = 39;
            this.SaveExcelBtn.Text = "Save excel ";
            this.SaveExcelBtn.UseVisualStyleBackColor = true;
            this.SaveExcelBtn.Click += new System.EventHandler(this.SaveExcelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SearchBtn.Location = new System.Drawing.Point(203, 35);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(98, 37);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 110;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 135;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 115;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.ReadOnly = true;
            this.specializationDataGridViewTextBoxColumn.Width = 200;
            // 
            // possetionDataGridViewTextBoxColumn
            // 
            this.possetionDataGridViewTextBoxColumn.DataPropertyName = "Possetion";
            this.possetionDataGridViewTextBoxColumn.HeaderText = "Possetion";
            this.possetionDataGridViewTextBoxColumn.Name = "possetionDataGridViewTextBoxColumn";
            this.possetionDataGridViewTextBoxColumn.ReadOnly = true;
            this.possetionDataGridViewTextBoxColumn.Width = 154;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApplication2.Base);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1509, 681);
            this.Controls.Add(this.SaveExcelBtn);
            this.Controls.Add(this.SearchTimeToPicker);
            this.Controls.Add(this.SearchTimeFromPicker);
            this.Controls.Add(this.returnToBase);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textSearchName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSearchAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textSearchPhone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textSearchSpecialization);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textSearchPossetion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1530, 730);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSearchName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSearchAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textSearchPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textSearchSpecialization;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textSearchPossetion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button returnToBase;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn possetionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker SearchTimeFromPicker;
        private System.Windows.Forms.DateTimePicker SearchTimeToPicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SaveExcelBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}

