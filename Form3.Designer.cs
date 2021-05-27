namespace Simonov_KR
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.astronomyDataSet = new Simonov_KR.astronomyDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSpectrumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectrumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectrumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDLightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.colorTableAdapter = new Simonov_KR.astronomyDataSetTableAdapters.colorTableAdapter();
            this.spectrumTableAdapter = new Simonov_KR.astronomyDataSetTableAdapters.spectrumTableAdapter();
            this.lightTableAdapter = new Simonov_KR.astronomyDataSetTableAdapters.lightTableAdapter();
            this.astronomyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectrumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lightBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronomyDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronomyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 125);
            this.tabControl1.Location = new System.Drawing.Point(9, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 266);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(129, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(327, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Цвета";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDColorDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(319, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "color";
            this.colorBindingSource.DataSource = this.astronomyDataSet;
            // 
            // astronomyDataSet
            // 
            this.astronomyDataSet.DataSetName = "astronomyDataSet";
            this.astronomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(129, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(454, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спектральные классы";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSpectrumDataGridViewTextBoxColumn,
            this.spectrumDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.spectrumBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(4, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(383, 249);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDSpectrumDataGridViewTextBoxColumn
            // 
            this.iDSpectrumDataGridViewTextBoxColumn.DataPropertyName = "ID_Spectrum";
            this.iDSpectrumDataGridViewTextBoxColumn.HeaderText = "ID_Spectrum";
            this.iDSpectrumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSpectrumDataGridViewTextBoxColumn.Name = "iDSpectrumDataGridViewTextBoxColumn";
            this.iDSpectrumDataGridViewTextBoxColumn.Width = 125;
            // 
            // spectrumDataGridViewTextBoxColumn
            // 
            this.spectrumDataGridViewTextBoxColumn.DataPropertyName = "Spectrum";
            this.spectrumDataGridViewTextBoxColumn.HeaderText = "Spectrum";
            this.spectrumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spectrumDataGridViewTextBoxColumn.Name = "spectrumDataGridViewTextBoxColumn";
            this.spectrumDataGridViewTextBoxColumn.Width = 125;
            // 
            // spectrumBindingSource
            // 
            this.spectrumBindingSource.DataMember = "spectrum";
            this.spectrumBindingSource.DataSource = this.astronomyDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Lavender;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(129, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(454, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Классы светимости";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLightDataGridViewTextBoxColumn,
            this.lightDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.lightBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(4, 5);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(368, 249);
            this.dataGridView3.TabIndex = 1;
            // 
            // iDLightDataGridViewTextBoxColumn
            // 
            this.iDLightDataGridViewTextBoxColumn.DataPropertyName = "ID_Light";
            this.iDLightDataGridViewTextBoxColumn.HeaderText = "ID_Light";
            this.iDLightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDLightDataGridViewTextBoxColumn.Name = "iDLightDataGridViewTextBoxColumn";
            this.iDLightDataGridViewTextBoxColumn.Width = 125;
            // 
            // lightDataGridViewTextBoxColumn
            // 
            this.lightDataGridViewTextBoxColumn.DataPropertyName = "Light";
            this.lightDataGridViewTextBoxColumn.HeaderText = "Light";
            this.lightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lightDataGridViewTextBoxColumn.Name = "lightDataGridViewTextBoxColumn";
            this.lightDataGridViewTextBoxColumn.Width = 125;
            // 
            // lightBindingSource
            // 
            this.lightBindingSource.DataMember = "light";
            this.lightBindingSource.DataSource = this.astronomyDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(101, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Справочные данные";
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // spectrumTableAdapter
            // 
            this.spectrumTableAdapter.ClearBeforeFill = true;
            // 
            // lightTableAdapter
            // 
            this.lightTableAdapter.ClearBeforeFill = true;
            // 
            // astronomyDataSetBindingSource
            // 
            this.astronomyDataSetBindingSource.DataSource = this.astronomyDataSet;
            this.astronomyDataSetBindingSource.Position = 0;
            // 
            // colorBindingSource1
            // 
            this.colorBindingSource1.DataMember = "color";
            this.colorBindingSource1.DataSource = this.astronomyDataSet;
            // 
            // iDColorDataGridViewTextBoxColumn
            // 
            this.iDColorDataGridViewTextBoxColumn.DataPropertyName = "ID_Color";
            this.iDColorDataGridViewTextBoxColumn.HeaderText = "ID_Color";
            this.iDColorDataGridViewTextBoxColumn.Name = "iDColorDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // spectrumBindingSource1
            // 
            this.spectrumBindingSource1.DataMember = "spectrum";
            this.spectrumBindingSource1.DataSource = this.astronomyDataSet;
            // 
            // lightBindingSource1
            // 
            this.lightBindingSource1.DataMember = "light";
            this.lightBindingSource1.DataSource = this.astronomyDataSet;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(789, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочные таблицы";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronomyDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronomyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private astronomyDataSet astronomyDataSet;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private astronomyDataSetTableAdapters.colorTableAdapter colorTableAdapter;
        private System.Windows.Forms.BindingSource spectrumBindingSource;
        private astronomyDataSetTableAdapters.spectrumTableAdapter spectrumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSpectrumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectrumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lightBindingSource;
        private astronomyDataSetTableAdapters.lightTableAdapter lightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colorBindingSource1;
        private System.Windows.Forms.BindingSource astronomyDataSetBindingSource;
        private System.Windows.Forms.BindingSource spectrumBindingSource1;
        private System.Windows.Forms.BindingSource lightBindingSource1;
    }
}