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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.rbCombinedFilter = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFilter2OfCombinedFilter = new System.Windows.Forms.ComboBox();
            this.cmbOperatorOfCombinedFilter = new System.Windows.Forms.ComboBox();
            this.cmbFilter1OfCombinedFilter = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterOfNotFilter = new System.Windows.Forms.ComboBox();
            this.rbNotFilter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.dtgFilterList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditFilter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.cmbTag);
            this.groupBox1.Controls.Add(this.cmbOperator);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic filter";
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
            this.rbCombinedFilter.Location = new System.Drawing.Point(12, 183);
            this.rbCombinedFilter.Name = "rbCombinedFilter";
            this.rbCombinedFilter.Size = new System.Drawing.Size(153, 17);
            this.rbCombinedFilter.TabIndex = 2;
            this.rbCombinedFilter.Text = "Create/ edit Combined filter";
            this.rbCombinedFilter.UseVisualStyleBackColor = true;
            this.rbCombinedFilter.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFilter2OfCombinedFilter);
            this.groupBox2.Controls.Add(this.cmbOperatorOfCombinedFilter);
            this.groupBox2.Controls.Add(this.cmbFilter1OfCombinedFilter);
            this.groupBox2.Location = new System.Drawing.Point(16, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combined Filter";
            // 
            // cmbFilter2OfCombinedFilter
            // 
            this.cmbFilter2OfCombinedFilter.FormattingEnabled = true;
            this.cmbFilter2OfCombinedFilter.Location = new System.Drawing.Point(287, 36);
            this.cmbFilter2OfCombinedFilter.Name = "cmbFilter2OfCombinedFilter";
            this.cmbFilter2OfCombinedFilter.Size = new System.Drawing.Size(162, 21);
            this.cmbFilter2OfCombinedFilter.TabIndex = 24;
            // 
            // cmbOperatorOfCombinedFilter
            // 
            this.cmbOperatorOfCombinedFilter.FormattingEnabled = true;
            this.cmbOperatorOfCombinedFilter.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbOperatorOfCombinedFilter.Location = new System.Drawing.Point(160, 36);
            this.cmbOperatorOfCombinedFilter.Name = "cmbOperatorOfCombinedFilter";
            this.cmbOperatorOfCombinedFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbOperatorOfCombinedFilter.TabIndex = 21;
            // 
            // cmbFilter1OfCombinedFilter
            // 
            this.cmbFilter1OfCombinedFilter.FormattingEnabled = true;
            this.cmbFilter1OfCombinedFilter.Location = new System.Drawing.Point(11, 36);
            this.cmbFilter1OfCombinedFilter.Name = "cmbFilter1OfCombinedFilter";
            this.cmbFilter1OfCombinedFilter.Size = new System.Drawing.Size(143, 21);
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
            this.btnRedo.Location = new System.Drawing.Point(255, 409);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 35;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(174, 409);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbFilterOfNotFilter);
            this.groupBox3.Location = new System.Drawing.Point(16, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 64);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Not filter";
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
            this.cmbFilterOfNotFilter.Location = new System.Drawing.Point(60, 28);
            this.cmbFilterOfNotFilter.Name = "cmbFilterOfNotFilter";
            this.cmbFilterOfNotFilter.Size = new System.Drawing.Size(114, 21);
            this.cmbFilterOfNotFilter.TabIndex = 19;
            // 
            // rbNotFilter
            // 
            this.rbNotFilter.AutoSize = true;
            this.rbNotFilter.Location = new System.Drawing.Point(12, 299);
            this.rbNotFilter.Name = "rbNotFilter";
            this.rbNotFilter.Size = new System.Drawing.Size(129, 17);
            this.rbNotFilter.TabIndex = 37;
            this.rbNotFilter.Text = "Create/ edit NOT filter";
            this.rbNotFilter.UseVisualStyleBackColor = true;
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
            this.btDelete.Location = new System.Drawing.Point(578, 384);
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
            this.dtgFilterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Name});
            this.dtgFilterList.Location = new System.Drawing.Point(578, 46);
            this.dtgFilterList.Name = "dtgFilterList";
            this.dtgFilterList.Size = new System.Drawing.Size(225, 329);
            this.dtgFilterList.TabIndex = 47;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IsSelected";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // btnEditFilter
            // 
            this.btnEditFilter.Location = new System.Drawing.Point(659, 384);
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
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rbNotFilter);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbCombinedFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioBasicFilter);
            this.Text = "Filter Manager";
            this.Load += new System.EventHandler(this.FilterManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFilterList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBasicFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.RadioButton rbCombinedFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbFilter2OfCombinedFilter;
        private System.Windows.Forms.ComboBox cmbOperatorOfCombinedFilter;
        private System.Windows.Forms.ComboBox cmbFilter1OfCombinedFilter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFilterOfNotFilter;
        private System.Windows.Forms.RadioButton rbNotFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.DataGridView dtgFilterList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditFilter;
    }
}