namespace Tecnogas2._1
{
    partial class TablaStock
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaStock));
            this.STOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Tecnogas2._1.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRODUCTOTableAdapter = new Tecnogas2._1.DataSet1TableAdapters.PRODUCTOTableAdapter();
            this.STOCKTableAdapter = new Tecnogas2._1.DataSet1TableAdapters.STOCKTableAdapter();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.STOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // STOCKBindingSource
            // 
            this.STOCKBindingSource.DataMember = "STOCK";
            this.STOCKBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.STOCKBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tecnogas2._1.tablastock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(384, 687);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PRODUCTOBindingSource
            // 
            this.PRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.PRODUCTOBindingSource.DataSource = this.DataSet1;
            // 
            // PRODUCTOTableAdapter
            // 
            this.PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // STOCKTableAdapter
            // 
            this.STOCKTableAdapter.ClearBeforeFill = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(460, 363);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(252, 109);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // TablaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 687);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 1200);
            this.MinimumSize = new System.Drawing.Size(400, 726);
            this.Name = "TablaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaStock";
            this.Load += new System.EventHandler(this.TablaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.STOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRODUCTOBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PRODUCTOTableAdapter PRODUCTOTableAdapter;
        private System.Windows.Forms.BindingSource STOCKBindingSource;
        private DataSet1TableAdapters.STOCKTableAdapter STOCKTableAdapter;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button Volver;
    }
}