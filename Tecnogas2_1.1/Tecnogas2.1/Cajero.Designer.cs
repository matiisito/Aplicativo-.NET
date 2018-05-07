namespace Tecnogas2._1
{
    partial class Cajero
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajero));
            this.CANTIDAD_DE_PRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Tecnogas2._1.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CANTIDAD_DE_PRODUCTOSTableAdapter = new Tecnogas2._1.DataSet1TableAdapters.CANTIDAD_DE_PRODUCTOSTableAdapter();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CANTIDAD_DE_PRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CANTIDAD_DE_PRODUCTOSBindingSource
            // 
            this.CANTIDAD_DE_PRODUCTOSBindingSource.DataMember = "CANTIDAD_DE_PRODUCTOS";
            this.CANTIDAD_DE_PRODUCTOSBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CANTIDAD_DE_PRODUCTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tecnogas2._1.Cajeros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 461);
            this.reportViewer1.TabIndex = 1;
            // 
            // CANTIDAD_DE_PRODUCTOSTableAdapter
            // 
            this.CANTIDAD_DE_PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(354, 416);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Cajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajero";
            this.Load += new System.EventHandler(this.Cajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CANTIDAD_DE_PRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CANTIDAD_DE_PRODUCTOSBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.CANTIDAD_DE_PRODUCTOSTableAdapter CANTIDAD_DE_PRODUCTOSTableAdapter;
        private System.Windows.Forms.Button Volver;
    }
}