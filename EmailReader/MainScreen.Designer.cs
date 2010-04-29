namespace EmailReader
{
    partial class MainScreen
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
          this.dtgListEmail = new System.Windows.Forms.DataGridView();
          this.btnExit = new System.Windows.Forms.Button();
          this.btnAddTag = new System.Windows.Forms.Button();
          this.txtNewTagValue = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.btnUndo = new System.Windows.Forms.Button();
          this.btnRedo = new System.Windows.Forms.Button();
          this.label3 = new System.Windows.Forms.Label();
          this.btnDeleteTagFromEmail = new System.Windows.Forms.Button();
          this.btnManageFilter = new System.Windows.Forms.Button();
          this.a = new System.Windows.Forms.Label();
          this.btnApplyFilter = new System.Windows.Forms.Button();
          this.filterBriefInfoDataGridView = new System.Windows.Forms.DataGridView();
          this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
          this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.filterBriefInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.iTagComboBox = new System.Windows.Forms.ComboBox();
          this.iTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.tagBriefInfoDataGridView = new System.Windows.Forms.DataGridView();
          this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.tagBriefInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.btnDeleteTagType = new System.Windows.Forms.Button();
          this.label4 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.label5 = new System.Windows.Forms.Label();
          this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
          ((System.ComponentModel.ISupportInitialize)(this.dtgListEmail)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.filterBriefInfoDataGridView)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.filterBriefInfoBindingSource)).BeginInit();
          this.groupBox1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.iTagBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.tagBriefInfoDataGridView)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.tagBriefInfoBindingSource)).BeginInit();
          this.SuspendLayout();
          // 
          // dtgListEmail
          // 
          this.dtgListEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dtgListEmail.Location = new System.Drawing.Point(285, 87);
          this.dtgListEmail.Name = "dtgListEmail";
          this.dtgListEmail.ReadOnly = true;
          this.dtgListEmail.Size = new System.Drawing.Size(593, 217);
          this.dtgListEmail.TabIndex = 0;
          this.dtgListEmail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListEmail_CellEnter);
          // 
          // btnExit
          // 
          this.btnExit.Location = new System.Drawing.Point(522, 230);
          this.btnExit.Name = "btnExit";
          this.btnExit.Size = new System.Drawing.Size(75, 23);
          this.btnExit.TabIndex = 3;
          this.btnExit.Text = "Exit";
          this.btnExit.UseVisualStyleBackColor = true;
          this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
          // 
          // btnAddTag
          // 
          this.btnAddTag.Location = new System.Drawing.Point(6, 227);
          this.btnAddTag.Name = "btnAddTag";
          this.btnAddTag.Size = new System.Drawing.Size(75, 23);
          this.btnAddTag.TabIndex = 4;
          this.btnAddTag.Text = "Save";
          this.toolTip1.SetToolTip(this.btnAddTag, "Save tag value in email. If this tag type doesn\'t exist EmailReader auto creates " +
                  "a new one");
          this.btnAddTag.UseVisualStyleBackColor = true;
          this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
          // 
          // txtNewTagValue
          // 
          this.txtNewTagValue.Location = new System.Drawing.Point(173, 201);
          this.txtNewTagValue.Name = "txtNewTagValue";
          this.txtNewTagValue.Size = new System.Drawing.Size(422, 20);
          this.txtNewTagValue.TabIndex = 6;
          this.toolTip1.SetToolTip(this.txtNewTagValue, "Enter value of tag for selected email");
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(282, 315);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(34, 13);
          this.label1.TabIndex = 7;
          this.label1.Text = "Tags:";
          // 
          // btnUndo
          // 
          this.btnUndo.Location = new System.Drawing.Point(717, 55);
          this.btnUndo.Name = "btnUndo";
          this.btnUndo.Size = new System.Drawing.Size(75, 23);
          this.btnUndo.TabIndex = 9;
          this.btnUndo.Text = "Undo";
          this.btnUndo.UseVisualStyleBackColor = true;
          this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
          // 
          // btnRedo
          // 
          this.btnRedo.Location = new System.Drawing.Point(803, 55);
          this.btnRedo.Name = "btnRedo";
          this.btnRedo.Size = new System.Drawing.Size(75, 23);
          this.btnRedo.TabIndex = 10;
          this.btnRedo.Text = "Redo";
          this.btnRedo.UseVisualStyleBackColor = true;
          this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label3.Location = new System.Drawing.Point(8, 14);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(177, 31);
          this.label3.TabIndex = 11;
          this.label3.Text = "Email Reader";
          // 
          // btnDeleteTagFromEmail
          // 
          this.btnDeleteTagFromEmail.Location = new System.Drawing.Point(87, 227);
          this.btnDeleteTagFromEmail.Name = "btnDeleteTagFromEmail";
          this.btnDeleteTagFromEmail.Size = new System.Drawing.Size(185, 23);
          this.btnDeleteTagFromEmail.TabIndex = 13;
          this.btnDeleteTagFromEmail.Text = "Delete Tag from this Email only";
          this.btnDeleteTagFromEmail.UseVisualStyleBackColor = true;
          this.btnDeleteTagFromEmail.Click += new System.EventHandler(this.btnDeleteTagFromEmail_Click);
          // 
          // btnManageFilter
          // 
          this.btnManageFilter.Location = new System.Drawing.Point(149, 537);
          this.btnManageFilter.Name = "btnManageFilter";
          this.btnManageFilter.Size = new System.Drawing.Size(128, 24);
          this.btnManageFilter.TabIndex = 16;
          this.btnManageFilter.Text = "Manage Filters";
          this.btnManageFilter.UseVisualStyleBackColor = true;
          this.btnManageFilter.Click += new System.EventHandler(this.btnManageFilter_Click);
          // 
          // a
          // 
          this.a.AutoSize = true;
          this.a.Location = new System.Drawing.Point(12, 61);
          this.a.Name = "a";
          this.a.Size = new System.Drawing.Size(67, 13);
          this.a.TabIndex = 17;
          this.a.Text = "Select filters:";
          // 
          // btnApplyFilter
          // 
          this.btnApplyFilter.Location = new System.Drawing.Point(195, 55);
          this.btnApplyFilter.Name = "btnApplyFilter";
          this.btnApplyFilter.Size = new System.Drawing.Size(81, 25);
          this.btnApplyFilter.TabIndex = 18;
          this.btnApplyFilter.Text = "Apply filters";
          this.btnApplyFilter.UseVisualStyleBackColor = true;
          this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
          // 
          // filterBriefInfoDataGridView
          // 
          this.filterBriefInfoDataGridView.AutoGenerateColumns = false;
          this.filterBriefInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
          this.filterBriefInfoDataGridView.DataSource = this.filterBriefInfoBindingSource;
          this.filterBriefInfoDataGridView.Location = new System.Drawing.Point(12, 87);
          this.filterBriefInfoDataGridView.Name = "filterBriefInfoDataGridView";
          this.filterBriefInfoDataGridView.Size = new System.Drawing.Size(264, 444);
          this.filterBriefInfoDataGridView.TabIndex = 19;
          // 
          // dataGridViewCheckBoxColumn1
          // 
          this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
          this.dataGridViewCheckBoxColumn1.HeaderText = "";
          this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
          // 
          // dataGridViewTextBoxColumn1
          // 
          this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
          this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
          this.dataGridViewTextBoxColumn1.HeaderText = "Name";
          this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
          this.dataGridViewTextBoxColumn1.ReadOnly = true;
          // 
          // filterBriefInfoBindingSource
          // 
          this.filterBriefInfoBindingSource.DataSource = typeof(EmailReader.View.FilterBriefInfo);
          // 
          // groupBox1
          // 
          this.groupBox1.Controls.Add(this.iTagComboBox);
          this.groupBox1.Controls.Add(this.tagBriefInfoDataGridView);
          this.groupBox1.Controls.Add(this.btnDeleteTagType);
          this.groupBox1.Controls.Add(this.label4);
          this.groupBox1.Controls.Add(this.label2);
          this.groupBox1.Controls.Add(this.btnDeleteTagFromEmail);
          this.groupBox1.Controls.Add(this.txtNewTagValue);
          this.groupBox1.Controls.Add(this.btnAddTag);
          this.groupBox1.Controls.Add(this.btnExit);
          this.groupBox1.Location = new System.Drawing.Point(283, 310);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Size = new System.Drawing.Size(603, 259);
          this.groupBox1.TabIndex = 20;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Details of selected email:";
          // 
          // iTagComboBox
          // 
          this.iTagComboBox.DataSource = this.iTagBindingSource;
          this.iTagComboBox.DisplayMember = "Name";
          this.iTagComboBox.Location = new System.Drawing.Point(6, 200);
          this.iTagComboBox.Name = "iTagComboBox";
          this.iTagComboBox.Size = new System.Drawing.Size(158, 21);
          this.iTagComboBox.TabIndex = 21;
          this.iTagComboBox.ValueMember = "isDefaultTag";
          this.iTagComboBox.SelectedIndexChanged += new System.EventHandler(this.iTagComboBox_SelectedIndexChanged);
          // 
          // iTagBindingSource
          // 
          this.iTagBindingSource.DataSource = typeof(EmailReader.Model.ITag);
          // 
          // tagBriefInfoDataGridView
          // 
          this.tagBriefInfoDataGridView.AutoGenerateColumns = false;
          this.tagBriefInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
          this.tagBriefInfoDataGridView.DataSource = this.tagBriefInfoBindingSource;
          this.tagBriefInfoDataGridView.Location = new System.Drawing.Point(6, 19);
          this.tagBriefInfoDataGridView.Name = "tagBriefInfoDataGridView";
          this.tagBriefInfoDataGridView.Size = new System.Drawing.Size(589, 160);
          this.tagBriefInfoDataGridView.TabIndex = 21;
          this.tagBriefInfoDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tagBriefInfoDataGridView_RowEnter);
          // 
          // dataGridViewTextBoxColumn2
          // 
          this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
          this.dataGridViewTextBoxColumn2.HeaderText = "Name";
          this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
          // 
          // dataGridViewTextBoxColumn3
          // 
          this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
          this.dataGridViewTextBoxColumn3.DataPropertyName = "Value";
          this.dataGridViewTextBoxColumn3.HeaderText = "Value";
          this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
          // 
          // tagBriefInfoBindingSource
          // 
          this.tagBriefInfoBindingSource.DataSource = typeof(EmailReader.View.TagBriefInfo);
          // 
          // btnDeleteTagType
          // 
          this.btnDeleteTagType.Location = new System.Drawing.Point(278, 227);
          this.btnDeleteTagType.Name = "btnDeleteTagType";
          this.btnDeleteTagType.Size = new System.Drawing.Size(142, 23);
          this.btnDeleteTagType.TabIndex = 16;
          this.btnDeleteTagType.Text = "Delete Tag type";
          this.btnDeleteTagType.UseVisualStyleBackColor = true;
          this.btnDeleteTagType.Click += new System.EventHandler(this.btnDeleteTagType_Click);
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(170, 183);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(34, 13);
          this.label4.TabIndex = 15;
          this.label4.Text = "Value";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(6, 183);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(157, 13);
          this.label2.TabIndex = 14;
          this.label2.Text = "Tag (type name for adding new)";
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Location = new System.Drawing.Point(284, 61);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(40, 13);
          this.label5.TabIndex = 21;
          this.label5.Text = "Emails:";
          // 
          // MainScreen
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.AutoScroll = true;
          this.ClientSize = new System.Drawing.Size(915, 593);
          this.Controls.Add(this.label5);
          this.Controls.Add(this.groupBox1);
          this.Controls.Add(this.filterBriefInfoDataGridView);
          this.Controls.Add(this.btnApplyFilter);
          this.Controls.Add(this.a);
          this.Controls.Add(this.btnManageFilter);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.btnRedo);
          this.Controls.Add(this.btnUndo);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.dtgListEmail);
          this.Name = "MainScreen";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "MainScreen";
          this.Load += new System.EventHandler(this.MainScreen_Load);
          ((System.ComponentModel.ISupportInitialize)(this.dtgListEmail)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.filterBriefInfoDataGridView)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.filterBriefInfoBindingSource)).EndInit();
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.iTagBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.tagBriefInfoDataGridView)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.tagBriefInfoBindingSource)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

      private System.Windows.Forms.DataGridView dtgListEmail;
        private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox txtNewTagValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteTagFromEmail;
        private System.Windows.Forms.Button btnManageFilter;
        private System.Windows.Forms.Label a;
      private System.Windows.Forms.Button btnApplyFilter;
      private System.Windows.Forms.BindingSource filterBriefInfoBindingSource;
      private System.Windows.Forms.DataGridView filterBriefInfoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteTagType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.BindingSource tagBriefInfoBindingSource;
      private System.Windows.Forms.DataGridView tagBriefInfoDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.BindingSource iTagBindingSource;
      private System.Windows.Forms.ComboBox iTagComboBox;
      private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}