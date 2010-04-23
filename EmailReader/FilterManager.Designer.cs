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
          this.txtValue = new System.Windows.Forms.TextBox();
          this.cmbTag = new System.Windows.Forms.ComboBox();
          this.cmbOperator = new System.Windows.Forms.ComboBox();
          this.rbCombinedFilter = new System.Windows.Forms.RadioButton();
          this.grCombinedFilter = new System.Windows.Forms.GroupBox();
          this.cmbFilter2OfCombinedFilter = new System.Windows.Forms.ComboBox();
          this.cmbOperatorOfCombinedFilter = new System.Windows.Forms.ComboBox();
          this.cmbFilter1OfCombinedFilter = new System.Windows.Forms.ComboBox();
          this.button7 = new System.Windows.Forms.Button();
          this.btnRedo = new System.Windows.Forms.Button();
          this.btnUndo = new System.Windows.Forms.Button();
          this.btSave = new System.Windows.Forms.Button();
          this.grNotFilter = new System.Windows.Forms.GroupBox();
          this.label3 = new System.Windows.Forms.Label();
          this.cmbFilterOfNotFilter = new System.Windows.Forms.ComboBox();
          this.rbNotFilter = new System.Windows.Forms.RadioButton();
          this.label1 = new System.Windows.Forms.Label();
          this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
          this.btDelete = new System.Windows.Forms.Button();
          this.label2 = new System.Windows.Forms.Label();
          this.txtFilterName = new System.Windows.Forms.TextBox();
          this.dtgFilterList = new System.Windows.Forms.DataGridView();
          this.btnEditFilter = new System.Windows.Forms.Button();
          this.grBasicFilter.SuspendLayout();
          this.grCombinedFilter.SuspendLayout();
          this.grNotFilter.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dtgFilterList)).BeginInit();
          this.SuspendLayout();
          // 
          // radioBasicFilter
          // 
          this.radioBasicFilter.AutoSize = true;
          this.radioBasicFilter.Checked = true;
          this.radioBasicFilter.Location = new System.Drawing.Point(12, 76);
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
          this.grBasicFilter.Controls.Add(this.txtValue);
          this.grBasicFilter.Controls.Add(this.cmbTag);
          this.grBasicFilter.Controls.Add(this.cmbOperator);
          this.grBasicFilter.Location = new System.Drawing.Point(12, 104);
          this.grBasicFilter.Name = "grBasicFilter";
          this.grBasicFilter.Size = new System.Drawing.Size(534, 69);
          this.grBasicFilter.TabIndex = 1;
          this.grBasicFilter.TabStop = false;
          this.grBasicFilter.Text = "Basic filter";
          // 
          // txtValue
          // 
          this.txtValue.Location = new System.Drawing.Point(334, 29);
          this.txtValue.Name = "txtValue";
          this.txtValue.Size = new System.Drawing.Size(184, 20);
          this.txtValue.TabIndex = 25;
          this.txtValue.Tag = "";
          // 
          // cmbTag
          // 
          this.cmbTag.FormattingEnabled = true;
          this.cmbTag.Location = new System.Drawing.Point(14, 28);
          this.cmbTag.Name = "cmbTag";
          this.cmbTag.Size = new System.Drawing.Size(184, 21);
          this.cmbTag.TabIndex = 22;
          // 
          // cmbOperator
          // 
          this.cmbOperator.FormattingEnabled = true;
          this.cmbOperator.Location = new System.Drawing.Point(204, 28);
          this.cmbOperator.Name = "cmbOperator";
          this.cmbOperator.Size = new System.Drawing.Size(124, 21);
          this.cmbOperator.TabIndex = 24;
          // 
          // rbCombinedFilter
          // 
          this.rbCombinedFilter.AutoSize = true;
          this.rbCombinedFilter.Location = new System.Drawing.Point(12, 184);
          this.rbCombinedFilter.Name = "rbCombinedFilter";
          this.rbCombinedFilter.Size = new System.Drawing.Size(153, 17);
          this.rbCombinedFilter.TabIndex = 2;
          this.rbCombinedFilter.Text = "Create/ edit Combined filter";
          this.rbCombinedFilter.UseVisualStyleBackColor = true;
          this.rbCombinedFilter.CheckedChanged += new System.EventHandler(this.rbCombinedFilter_CheckedChanged);
          // 
          // grCombinedFilter
          // 
          this.grCombinedFilter.Controls.Add(this.cmbFilter2OfCombinedFilter);
          this.grCombinedFilter.Controls.Add(this.cmbOperatorOfCombinedFilter);
          this.grCombinedFilter.Controls.Add(this.cmbFilter1OfCombinedFilter);
          this.grCombinedFilter.Enabled = false;
          this.grCombinedFilter.Location = new System.Drawing.Point(12, 212);
          this.grCombinedFilter.Name = "grCombinedFilter";
          this.grCombinedFilter.Size = new System.Drawing.Size(530, 49);
          this.grCombinedFilter.TabIndex = 3;
          this.grCombinedFilter.TabStop = false;
          this.grCombinedFilter.Text = "Combined Filter";
          // 
          // cmbFilter2OfCombinedFilter
          // 
          this.cmbFilter2OfCombinedFilter.FormattingEnabled = true;
          this.cmbFilter2OfCombinedFilter.Location = new System.Drawing.Point(334, 19);
          this.cmbFilter2OfCombinedFilter.Name = "cmbFilter2OfCombinedFilter";
          this.cmbFilter2OfCombinedFilter.Size = new System.Drawing.Size(184, 21);
          this.cmbFilter2OfCombinedFilter.TabIndex = 24;
          // 
          // cmbOperatorOfCombinedFilter
          // 
          this.cmbOperatorOfCombinedFilter.FormattingEnabled = true;
          this.cmbOperatorOfCombinedFilter.Items.AddRange(new object[] {
            "AND",
            "OR"});
          this.cmbOperatorOfCombinedFilter.Location = new System.Drawing.Point(204, 19);
          this.cmbOperatorOfCombinedFilter.Name = "cmbOperatorOfCombinedFilter";
          this.cmbOperatorOfCombinedFilter.Size = new System.Drawing.Size(121, 21);
          this.cmbOperatorOfCombinedFilter.TabIndex = 21;
          // 
          // cmbFilter1OfCombinedFilter
          // 
          this.cmbFilter1OfCombinedFilter.FormattingEnabled = true;
          this.cmbFilter1OfCombinedFilter.Location = new System.Drawing.Point(14, 19);
          this.cmbFilter1OfCombinedFilter.Name = "cmbFilter1OfCombinedFilter";
          this.cmbFilter1OfCombinedFilter.Size = new System.Drawing.Size(184, 21);
          this.cmbFilter1OfCombinedFilter.TabIndex = 19;
          // 
          // button7
          // 
          this.button7.Location = new System.Drawing.Point(732, 486);
          this.button7.Name = "button7";
          this.button7.Size = new System.Drawing.Size(75, 23);
          this.button7.TabIndex = 36;
          this.button7.Text = "Close";
          this.button7.UseVisualStyleBackColor = true;
          // 
          // btnRedo
          // 
          this.btnRedo.Location = new System.Drawing.Point(467, 409);
          this.btnRedo.Name = "btnRedo";
          this.btnRedo.Size = new System.Drawing.Size(75, 23);
          this.btnRedo.TabIndex = 35;
          this.btnRedo.Text = "Redo";
          this.btnRedo.UseVisualStyleBackColor = true;
          this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
          // 
          // btnUndo
          // 
          this.btnUndo.Location = new System.Drawing.Point(386, 409);
          this.btnUndo.Name = "btnUndo";
          this.btnUndo.Size = new System.Drawing.Size(75, 23);
          this.btnUndo.TabIndex = 34;
          this.btnUndo.Text = "Undo";
          this.btnUndo.UseVisualStyleBackColor = true;
          this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
          // 
          // btSave
          // 
          this.btSave.Location = new System.Drawing.Point(12, 409);
          this.btSave.Name = "btSave";
          this.btSave.Size = new System.Drawing.Size(75, 23);
          this.btSave.TabIndex = 33;
          this.btSave.Text = "Save";
          this.btSave.UseVisualStyleBackColor = true;
          this.btSave.Click += new System.EventHandler(this.btSave_Click);
          // 
          // grNotFilter
          // 
          this.grNotFilter.Controls.Add(this.label3);
          this.grNotFilter.Controls.Add(this.cmbFilterOfNotFilter);
          this.grNotFilter.Enabled = false;
          this.grNotFilter.Location = new System.Drawing.Point(12, 324);
          this.grNotFilter.Name = "grNotFilter";
          this.grNotFilter.Size = new System.Drawing.Size(530, 64);
          this.grNotFilter.TabIndex = 38;
          this.grNotFilter.TabStop = false;
          this.grNotFilter.Text = "Not filter";
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
          // cmbFilterOfNotFilter
          // 
          this.cmbFilterOfNotFilter.FormattingEnabled = true;
          this.cmbFilterOfNotFilter.Location = new System.Drawing.Point(46, 26);
          this.cmbFilterOfNotFilter.Name = "cmbFilterOfNotFilter";
          this.cmbFilterOfNotFilter.Size = new System.Drawing.Size(114, 21);
          this.cmbFilterOfNotFilter.TabIndex = 19;
          // 
          // rbNotFilter
          // 
          this.rbNotFilter.AutoSize = true;
          this.rbNotFilter.Location = new System.Drawing.Point(12, 296);
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
          this.btDelete.Location = new System.Drawing.Point(647, 409);
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
          this.label2.Location = new System.Drawing.Point(13, 23);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(61, 13);
          this.label2.TabIndex = 46;
          this.label2.Text = "Filter name:";
          // 
          // txtFilterName
          // 
          this.txtFilterName.Location = new System.Drawing.Point(76, 20);
          this.txtFilterName.Name = "txtFilterName";
          this.txtFilterName.Size = new System.Drawing.Size(184, 20);
          this.txtFilterName.TabIndex = 45;
          this.txtFilterName.Tag = "";
          // 
          // dtgFilterList
          // 
          this.dtgFilterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dtgFilterList.Location = new System.Drawing.Point(578, 36);
          this.dtgFilterList.Name = "dtgFilterList";
          this.dtgFilterList.Size = new System.Drawing.Size(225, 352);
          this.dtgFilterList.TabIndex = 47;
          // 
          // btnEditFilter
          // 
          this.btnEditFilter.Location = new System.Drawing.Point(728, 409);
          this.btnEditFilter.Name = "btnEditFilter";
          this.btnEditFilter.Size = new System.Drawing.Size(75, 23);
          this.btnEditFilter.TabIndex = 48;
          this.btnEditFilter.Text = "Edit";
          this.btnEditFilter.UseVisualStyleBackColor = true;
          this.btnEditFilter.Click += new System.EventHandler(this.btnEditFilter_Click);
          // 
          // FilterManager
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(820, 449);
          this.Controls.Add(this.btnEditFilter);
          this.Controls.Add(this.dtgFilterList);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.txtFilterName);
          this.Controls.Add(this.btDelete);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.grNotFilter);
          this.Controls.Add(this.rbNotFilter);
          this.Controls.Add(this.button7);
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
          this.grCombinedFilter.ResumeLayout(false);
          this.grNotFilter.ResumeLayout(false);
          this.grNotFilter.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dtgFilterList)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBasicFilter;
        private System.Windows.Forms.GroupBox grBasicFilter;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.RadioButton rbCombinedFilter;
        private System.Windows.Forms.GroupBox grCombinedFilter;
        private System.Windows.Forms.ComboBox cmbFilter2OfCombinedFilter;
        private System.Windows.Forms.ComboBox cmbOperatorOfCombinedFilter;
        private System.Windows.Forms.ComboBox cmbFilter1OfCombinedFilter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox grNotFilter;
        private System.Windows.Forms.ComboBox cmbFilterOfNotFilter;
        private System.Windows.Forms.RadioButton rbNotFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterName;
      private System.Windows.Forms.DataGridView dtgFilterList;
        private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnEditFilter;
    }
}