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
          this.dataGridView1 = new System.Windows.Forms.DataGridView();
          this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.dataGridView2 = new System.Windows.Forms.DataGridView();
          this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.button2 = new System.Windows.Forms.Button();
          this.button3 = new System.Windows.Forms.Button();
          this.comboBox1 = new System.Windows.Forms.ComboBox();
          this.textBox1 = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.button4 = new System.Windows.Forms.Button();
          this.button5 = new System.Windows.Forms.Button();
          this.label3 = new System.Windows.Forms.Label();
          this.button1 = new System.Windows.Forms.Button();
          this.dataGridView3 = new System.Windows.Forms.DataGridView();
          this.selectedFilters = new System.Windows.Forms.DataGridViewCheckBoxColumn();
          this.selectedFilterNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.button6 = new System.Windows.Forms.Button();
          this.button7 = new System.Windows.Forms.Button();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
          this.SuspendLayout();
          // 
          // dataGridView1
          // 
          this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.From,
            this.Subject});
          this.dataGridView1.Location = new System.Drawing.Point(285, 61);
          this.dataGridView1.Name = "dataGridView1";
          this.dataGridView1.Size = new System.Drawing.Size(593, 207);
          this.dataGridView1.TabIndex = 0;
          // 
          // Date
          // 
          this.Date.HeaderText = "Date";
          this.Date.Name = "Date";
          // 
          // From
          // 
          this.From.HeaderText = "From";
          this.From.Name = "From";
          // 
          // Subject
          // 
          this.Subject.HeaderText = "Subject";
          this.Subject.Name = "Subject";
          // 
          // dataGridView2
          // 
          this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagName,
            this.Value});
          this.dataGridView2.Location = new System.Drawing.Point(285, 331);
          this.dataGridView2.Name = "dataGridView2";
          this.dataGridView2.Size = new System.Drawing.Size(593, 160);
          this.dataGridView2.TabIndex = 1;
          // 
          // TagName
          // 
          this.TagName.HeaderText = "Name";
          this.TagName.Name = "TagName";
          // 
          // Value
          // 
          this.Value.HeaderText = "Value";
          this.Value.Name = "Value";
          // 
          // button2
          // 
          this.button2.Location = new System.Drawing.Point(803, 539);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(75, 23);
          this.button2.TabIndex = 3;
          this.button2.Text = "Exit";
          this.button2.UseVisualStyleBackColor = true;
          // 
          // button3
          // 
          this.button3.Location = new System.Drawing.Point(803, 510);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(75, 23);
          this.button3.TabIndex = 4;
          this.button3.Text = "Add Tag";
          this.button3.UseVisualStyleBackColor = true;
          // 
          // comboBox1
          // 
          this.comboBox1.FormattingEnabled = true;
          this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B ",
            "C"});
          this.comboBox1.Location = new System.Drawing.Point(285, 510);
          this.comboBox1.Name = "comboBox1";
          this.comboBox1.Size = new System.Drawing.Size(147, 21);
          this.comboBox1.TabIndex = 5;
          this.comboBox1.Text = "Select name or type new";
          // 
          // textBox1
          // 
          this.textBox1.Location = new System.Drawing.Point(438, 511);
          this.textBox1.Name = "textBox1";
          this.textBox1.Size = new System.Drawing.Size(354, 20);
          this.textBox1.TabIndex = 6;
          this.textBox1.Text = "value";
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
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(282, 494);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(67, 13);
          this.label2.TabIndex = 8;
          this.label2.Text = "Add new tag";
          // 
          // button4
          // 
          this.button4.Location = new System.Drawing.Point(717, 14);
          this.button4.Name = "button4";
          this.button4.Size = new System.Drawing.Size(75, 23);
          this.button4.TabIndex = 9;
          this.button4.Text = "Undo";
          this.button4.UseVisualStyleBackColor = true;
          // 
          // button5
          // 
          this.button5.Location = new System.Drawing.Point(803, 14);
          this.button5.Name = "button5";
          this.button5.Size = new System.Drawing.Size(75, 23);
          this.button5.TabIndex = 10;
          this.button5.Text = "Redo";
          this.button5.UseVisualStyleBackColor = true;
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
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(285, 537);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(82, 23);
          this.button1.TabIndex = 13;
          this.button1.Text = "Delete tag";
          this.button1.UseVisualStyleBackColor = true;
          // 
          // dataGridView3
          // 
          this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedFilters,
            this.selectedFilterNames});
          this.dataGridView3.Location = new System.Drawing.Point(12, 61);
          this.dataGridView3.Name = "dataGridView3";
          this.dataGridView3.Size = new System.Drawing.Size(264, 429);
          this.dataGridView3.TabIndex = 14;
          // 
          // selectedFilters
          // 
          this.selectedFilters.HeaderText = "";
          this.selectedFilters.Name = "selectedFilters";
          this.selectedFilters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
          this.selectedFilters.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
          this.selectedFilters.Width = 20;
          // 
          // selectedFilterNames
          // 
          this.selectedFilterNames.HeaderText = "Selected filters";
          this.selectedFilterNames.Name = "selectedFilterNames";
          this.selectedFilterNames.Width = 200;
          // 
          // button6
          // 
          this.button6.Location = new System.Drawing.Point(282, 274);
          this.button6.Name = "button6";
          this.button6.Size = new System.Drawing.Size(82, 23);
          this.button6.TabIndex = 15;
          this.button6.Text = "Delete mail";
          this.button6.UseVisualStyleBackColor = true;
          // 
          // button7
          // 
          this.button7.Location = new System.Drawing.Point(14, 511);
          this.button7.Name = "button7";
          this.button7.Size = new System.Drawing.Size(128, 24);
          this.button7.TabIndex = 16;
          this.button7.Text = "Manage Filters";
          this.button7.UseVisualStyleBackColor = true;
          // 
          // MainScreen
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(890, 569);
          this.Controls.Add(this.button7);
          this.Controls.Add(this.button6);
          this.Controls.Add(this.dataGridView3);
          this.Controls.Add(this.button1);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.button5);
          this.Controls.Add(this.button4);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.textBox1);
          this.Controls.Add(this.comboBox1);
          this.Controls.Add(this.button3);
          this.Controls.Add(this.button2);
          this.Controls.Add(this.dataGridView2);
          this.Controls.Add(this.dataGridView1);
          this.Name = "MainScreen";
          this.Text = "MainScreen";
          this.Load += new System.EventHandler(this.MainScreen_Load);
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
      private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedFilterNames;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
      private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
      private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}