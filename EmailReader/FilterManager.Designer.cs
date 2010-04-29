namespace EmailReader
{
    partial class FilterManager
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
          this.radioBasicFilter = new System.Windows.Forms.RadioButton();
          this.grBasicFilter = new System.Windows.Forms.GroupBox();
          this.iOperatorComboBox = new System.Windows.Forms.ComboBox();
          this.iOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.iTagComboBox = new System.Windows.Forms.ComboBox();
          this.iTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.txtValue = new System.Windows.Forms.TextBox();
          this.rbCombinedFilter = new System.Windows.Forms.RadioButton();
          this.grCombinedFilter = new System.Windows.Forms.GroupBox();
          this.cmbOperatorOfCombinedFilter = new System.Windows.Forms.ComboBox();
          this.iFilterComboBox_F1 = new System.Windows.Forms.ComboBox();
          this.iFilterBindingSource_F1 = new System.Windows.Forms.BindingSource(this.components);
          this.iFilterComboBox_F2 = new System.Windows.Forms.ComboBox();
          this.iFilterBindingSource_F2 = new System.Windows.Forms.BindingSource(this.components);
          this.btnClose = new System.Windows.Forms.Button();
          this.btnRedo = new System.Windows.Forms.Button();
          this.btnUndo = new System.Windows.Forms.Button();
          this.btSave = new System.Windows.Forms.Button();
          this.grNotFilter = new System.Windows.Forms.GroupBox();
          this.iFilterComboBox_NotF = new System.Windows.Forms.ComboBox();
          this.iFilterBindingSource_NotF = new System.Windows.Forms.BindingSource(this.components);
          this.label3 = new System.Windows.Forms.Label();
          this.rbNotFilter = new System.Windows.Forms.RadioButton();
          this.label1 = new System.Windows.Forms.Label();
          this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
          this.btDelete = new System.Windows.Forms.Button();
          this.label2 = new System.Windows.Forms.Label();
          this.txtFilterName = new System.Windows.Forms.TextBox();
          this.btnEditFilter = new System.Windows.Forms.Button();
          this.iFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.iFilterDataGridView = new System.Windows.Forms.DataGridView();
          this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.lblStatus = new System.Windows.Forms.Label();
          this.grBasicFilter.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.iOperatorBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.iTagBindingSource)).BeginInit();
          this.grCombinedFilter.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource_F1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource_F2)).BeginInit();
          this.grNotFilter.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource_NotF)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterDataGridView)).BeginInit();
          this.SuspendLayout();
          // 
          // radioBasicFilter
          // 
          this.radioBasicFilter.AutoSize = true;
          this.radioBasicFilter.Checked = true;
          this.radioBasicFilter.Location = new System.Drawing.Point(12, 43);
          this.radioBasicFilter.Name = "radioBasicFilter";
          this.radioBasicFilter.Size = new System.Drawing.Size(132, 17);
          this.radioBasicFilter.TabIndex = 0;
          this.radioBasicFilter.TabStop = true;
          this.radioBasicFilter.Text = "Create/ edit Basic filter";
          this.radioBasicFilter.UseVisualStyleBackColor = true;
          this.radioBasicFilter.CheckedChanged += new System.EventHandler(this.radioBasicFilter_CheckedChanged);
          // 
          // grBasicFilter
          // 
          this.grBasicFilter.Controls.Add(this.iOperatorComboBox);
          this.grBasicFilter.Controls.Add(this.iTagComboBox);
          this.grBasicFilter.Controls.Add(this.txtValue);
          this.grBasicFilter.Location = new System.Drawing.Point(12, 71);
          this.grBasicFilter.Name = "grBasicFilter";
          this.grBasicFilter.Size = new System.Drawing.Size(534, 69);
          this.grBasicFilter.TabIndex = 1;
          this.grBasicFilter.TabStop = false;
          this.grBasicFilter.Text = "Basic filter";
          // 
          // iOperatorComboBox
          // 
          this.iOperatorComboBox.DataSource = this.iOperatorBindingSource;
          this.iOperatorComboBox.DisplayMember = "Name";
          this.iOperatorComboBox.Location = new System.Drawing.Point(204, 29);
          this.iOperatorComboBox.Name = "iOperatorComboBox";
          this.iOperatorComboBox.Size = new System.Drawing.Size(124, 21);
          this.iOperatorComboBox.TabIndex = 50;
          this.iOperatorComboBox.ValueMember = "Name";
          // 
          // iOperatorBindingSource
          // 
          this.iOperatorBindingSource.DataSource = typeof(EmailReader.Model.Operator.IOperator);
          // 
          // iTagComboBox
          // 
          this.iTagComboBox.DataSource = this.iTagBindingSource;
          this.iTagComboBox.DisplayMember = "Name";
          this.iTagComboBox.Location = new System.Drawing.Point(13, 28);
          this.iTagComboBox.Name = "iTagComboBox";
          this.iTagComboBox.Size = new System.Drawing.Size(184, 21);
          this.iTagComboBox.TabIndex = 50;
          this.iTagComboBox.ValueMember = "isDefaultTag";
          // 
          // iTagBindingSource
          // 
          this.iTagBindingSource.DataSource = typeof(EmailReader.Model.ITag);
          // 
          // txtValue
          // 
          this.txtValue.Location = new System.Drawing.Point(334, 29);
          this.txtValue.Name = "txtValue";
          this.txtValue.Size = new System.Drawing.Size(184, 20);
          this.txtValue.TabIndex = 25;
          this.txtValue.Tag = "";
          // 
          // rbCombinedFilter
          // 
          this.rbCombinedFilter.AutoSize = true;
          this.rbCombinedFilter.Location = new System.Drawing.Point(12, 146);
          this.rbCombinedFilter.Name = "rbCombinedFilter";
          this.rbCombinedFilter.Size = new System.Drawing.Size(153, 17);
          this.rbCombinedFilter.TabIndex = 2;
          this.rbCombinedFilter.Text = "Create/ edit Combined filter";
          this.rbCombinedFilter.UseVisualStyleBackColor = true;
          this.rbCombinedFilter.CheckedChanged += new System.EventHandler(this.rbCombinedFilter_CheckedChanged);
          // 
          // grCombinedFilter
          // 
          this.grCombinedFilter.Controls.Add(this.cmbOperatorOfCombinedFilter);
          this.grCombinedFilter.Controls.Add(this.iFilterComboBox_F1);
          this.grCombinedFilter.Controls.Add(this.iFilterComboBox_F2);
          this.grCombinedFilter.Enabled = false;
          this.grCombinedFilter.Location = new System.Drawing.Point(12, 174);
          this.grCombinedFilter.Name = "grCombinedFilter";
          this.grCombinedFilter.Size = new System.Drawing.Size(530, 49);
          this.grCombinedFilter.TabIndex = 3;
          this.grCombinedFilter.TabStop = false;
          this.grCombinedFilter.Text = "Combined Filter";
          // 
          // cmbOperatorOfCombinedFilter
          // 
          this.cmbOperatorOfCombinedFilter.FormattingEnabled = true;
          this.cmbOperatorOfCombinedFilter.Items.AddRange(new object[] {
            "AND",
            "OR"});
          this.cmbOperatorOfCombinedFilter.Location = new System.Drawing.Point(204, 19);
          this.cmbOperatorOfCombinedFilter.Name = "cmbOperatorOfCombinedFilter";
          this.cmbOperatorOfCombinedFilter.Size = new System.Drawing.Size(124, 21);
          this.cmbOperatorOfCombinedFilter.TabIndex = 21;
          // 
          // iFilterComboBox_F1
          // 
          this.iFilterComboBox_F1.DataSource = this.iFilterBindingSource_F1;
          this.iFilterComboBox_F1.DisplayMember = "Name";
          this.iFilterComboBox_F1.Location = new System.Drawing.Point(14, 19);
          this.iFilterComboBox_F1.Name = "iFilterComboBox_F1";
          this.iFilterComboBox_F1.Size = new System.Drawing.Size(184, 21);
          this.iFilterComboBox_F1.TabIndex = 49;
          this.iFilterComboBox_F1.ValueMember = "Name";
          // 
          // iFilterBindingSource_F1
          // 
          this.iFilterBindingSource_F1.DataSource = typeof(EmailReader.Model.IFilter);
          // 
          // iFilterComboBox_F2
          // 
          this.iFilterComboBox_F2.DataSource = this.iFilterBindingSource_F2;
          this.iFilterComboBox_F2.DisplayMember = "Name";
          this.iFilterComboBox_F2.Location = new System.Drawing.Point(334, 19);
          this.iFilterComboBox_F2.Name = "iFilterComboBox_F2";
          this.iFilterComboBox_F2.Size = new System.Drawing.Size(184, 21);
          this.iFilterComboBox_F2.TabIndex = 49;
          this.iFilterComboBox_F2.ValueMember = "Name";
          // 
          // iFilterBindingSource_F2
          // 
          this.iFilterBindingSource_F2.DataSource = typeof(EmailReader.Model.IFilter);
          // 
          // btnClose
          // 
          this.btnClose.Location = new System.Drawing.Point(714, 342);
          this.btnClose.Name = "btnClose";
          this.btnClose.Size = new System.Drawing.Size(75, 23);
          this.btnClose.TabIndex = 36;
          this.btnClose.Text = "Close";
          this.btnClose.UseVisualStyleBackColor = true;
          this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
          // 
          // btnRedo
          // 
          this.btnRedo.Location = new System.Drawing.Point(360, 342);
          this.btnRedo.Name = "btnRedo";
          this.btnRedo.Size = new System.Drawing.Size(75, 23);
          this.btnRedo.TabIndex = 35;
          this.btnRedo.Text = "Redo";
          this.btnRedo.UseVisualStyleBackColor = true;
          this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
          // 
          // btnUndo
          // 
          this.btnUndo.Location = new System.Drawing.Point(279, 342);
          this.btnUndo.Name = "btnUndo";
          this.btnUndo.Size = new System.Drawing.Size(75, 23);
          this.btnUndo.TabIndex = 34;
          this.btnUndo.Text = "Undo";
          this.btnUndo.UseVisualStyleBackColor = true;
          this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
          // 
          // btSave
          // 
          this.btSave.Location = new System.Drawing.Point(471, 342);
          this.btSave.Name = "btSave";
          this.btSave.Size = new System.Drawing.Size(75, 23);
          this.btSave.TabIndex = 33;
          this.btSave.Text = "Save";
          this.btSave.UseVisualStyleBackColor = true;
          this.btSave.Click += new System.EventHandler(this.btSave_Click);
          // 
          // grNotFilter
          // 
          this.grNotFilter.Controls.Add(this.iFilterComboBox_NotF);
          this.grNotFilter.Controls.Add(this.label3);
          this.grNotFilter.Enabled = false;
          this.grNotFilter.Location = new System.Drawing.Point(12, 257);
          this.grNotFilter.Name = "grNotFilter";
          this.grNotFilter.Size = new System.Drawing.Size(530, 64);
          this.grNotFilter.TabIndex = 38;
          this.grNotFilter.TabStop = false;
          this.grNotFilter.Text = "Not filter";
          // 
          // iFilterComboBox_NotF
          // 
          this.iFilterComboBox_NotF.DataSource = this.iFilterBindingSource_NotF;
          this.iFilterComboBox_NotF.DisplayMember = "Name";
          this.iFilterComboBox_NotF.Location = new System.Drawing.Point(46, 26);
          this.iFilterComboBox_NotF.Name = "iFilterComboBox_NotF";
          this.iFilterComboBox_NotF.Size = new System.Drawing.Size(151, 21);
          this.iFilterComboBox_NotF.TabIndex = 49;
          this.iFilterComboBox_NotF.ValueMember = "Name";
          // 
          // iFilterBindingSource_NotF
          // 
          this.iFilterBindingSource_NotF.DataSource = typeof(EmailReader.Model.IFilter);
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(10, 29);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(30, 13);
          this.label3.TabIndex = 20;
          this.label3.Text = "NOT";
          // 
          // rbNotFilter
          // 
          this.rbNotFilter.AutoSize = true;
          this.rbNotFilter.Location = new System.Drawing.Point(12, 229);
          this.rbNotFilter.Name = "rbNotFilter";
          this.rbNotFilter.Size = new System.Drawing.Size(129, 17);
          this.rbNotFilter.TabIndex = 37;
          this.rbNotFilter.Text = "Create/ edit NOT filter";
          this.rbNotFilter.UseVisualStyleBackColor = true;
          this.rbNotFilter.CheckedChanged += new System.EventHandler(this.rbNotFilter_CheckedChanged);
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(575, 20);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(48, 13);
          this.label1.TabIndex = 40;
          this.label1.Text = "All filters:";
          // 
          // toolTip1
          // 
          this.toolTip1.ToolTipTitle = "Select a Filter to edit";
          // 
          // btDelete
          // 
          this.btDelete.Location = new System.Drawing.Point(552, 342);
          this.btDelete.Name = "btDelete";
          this.btDelete.Size = new System.Drawing.Size(75, 23);
          this.btDelete.TabIndex = 41;
          this.btDelete.Text = "Delete ";
          this.btDelete.UseVisualStyleBackColor = true;
          this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(13, 20);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(61, 13);
          this.label2.TabIndex = 46;
          this.label2.Text = "Filter name:";
          // 
          // txtFilterName
          // 
          this.txtFilterName.Location = new System.Drawing.Point(76, 17);
          this.txtFilterName.Name = "txtFilterName";
          this.txtFilterName.Size = new System.Drawing.Size(184, 20);
          this.txtFilterName.TabIndex = 45;
          this.txtFilterName.Tag = "";
          // 
          // btnEditFilter
          // 
          this.btnEditFilter.Location = new System.Drawing.Point(633, 342);
          this.btnEditFilter.Name = "btnEditFilter";
          this.btnEditFilter.Size = new System.Drawing.Size(75, 23);
          this.btnEditFilter.TabIndex = 48;
          this.btnEditFilter.Text = "Edit";
          this.btnEditFilter.UseVisualStyleBackColor = true;
          this.btnEditFilter.Click += new System.EventHandler(this.btnEditFilter_Click);
          // 
          // iFilterBindingSource
          // 
          this.iFilterBindingSource.DataSource = typeof(EmailReader.Model.IFilter);
          // 
          // iFilterDataGridView
          // 
          this.iFilterDataGridView.AllowUserToAddRows = false;
          this.iFilterDataGridView.AllowUserToDeleteRows = false;
          this.iFilterDataGridView.AllowUserToResizeRows = false;
          this.iFilterDataGridView.AutoGenerateColumns = false;
          this.iFilterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
          this.iFilterDataGridView.DataSource = this.iFilterBindingSource;
          this.iFilterDataGridView.Location = new System.Drawing.Point(552, 41);
          this.iFilterDataGridView.MultiSelect = false;
          this.iFilterDataGridView.Name = "iFilterDataGridView";
          this.iFilterDataGridView.Size = new System.Drawing.Size(237, 280);
          this.iFilterDataGridView.TabIndex = 49;
          // 
          // dataGridViewTextBoxColumn1
          // 
          this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
          this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
          this.dataGridViewTextBoxColumn1.HeaderText = "Name";
          this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
          this.dataGridViewTextBoxColumn1.ReadOnly = true;
          // 
          // lblStatus
          // 
          this.lblStatus.AutoSize = true;
          this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblStatus.Location = new System.Drawing.Point(13, 347);
          this.lblStatus.Name = "lblStatus";
          this.lblStatus.Size = new System.Drawing.Size(41, 13);
          this.lblStatus.TabIndex = 50;
          this.lblStatus.Text = "status";
          // 
          // FilterManager
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(809, 385);
          this.Controls.Add(this.lblStatus);
          this.Controls.Add(this.iFilterDataGridView);
          this.Controls.Add(this.btnEditFilter);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.txtFilterName);
          this.Controls.Add(this.btDelete);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.grNotFilter);
          this.Controls.Add(this.rbNotFilter);
          this.Controls.Add(this.btnClose);
          this.Controls.Add(this.btnRedo);
          this.Controls.Add(this.btnUndo);
          this.Controls.Add(this.btSave);
          this.Controls.Add(this.grCombinedFilter);
          this.Controls.Add(this.rbCombinedFilter);
          this.Controls.Add(this.grBasicFilter);
          this.Controls.Add(this.radioBasicFilter);
          this.Name = "FilterManager";
          this.Text = "Filter Manager";
          this.Load += new System.EventHandler(this.FilterManager_Load);
          this.grBasicFilter.ResumeLayout(false);
          this.grBasicFilter.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.iOperatorBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.iTagBindingSource)).EndInit();
          this.grCombinedFilter.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource_F1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource_F2)).EndInit();
          this.grNotFilter.ResumeLayout(false);
          this.grNotFilter.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource_NotF)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.iFilterDataGridView)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBasicFilter;
        private System.Windows.Forms.GroupBox grBasicFilter;
      private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RadioButton rbCombinedFilter;
      private System.Windows.Forms.GroupBox grCombinedFilter;
      private System.Windows.Forms.ComboBox cmbOperatorOfCombinedFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btSave;
      private System.Windows.Forms.GroupBox grNotFilter;
        private System.Windows.Forms.RadioButton rbNotFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnEditFilter;
      private System.Windows.Forms.BindingSource iFilterBindingSource_F1;
      private System.Windows.Forms.ComboBox iFilterComboBox_F1;
      private System.Windows.Forms.BindingSource iFilterBindingSource_F2;
      private System.Windows.Forms.ComboBox iFilterComboBox_F2;
      private System.Windows.Forms.BindingSource iFilterBindingSource_NotF;
      private System.Windows.Forms.ComboBox iFilterComboBox_NotF;
      private System.Windows.Forms.BindingSource iFilterBindingSource;
      private System.Windows.Forms.DataGridView iFilterDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.BindingSource iTagBindingSource;
      private System.Windows.Forms.ComboBox iTagComboBox;
      private System.Windows.Forms.BindingSource iOperatorBindingSource;
      private System.Windows.Forms.ComboBox iOperatorComboBox;
    }
}