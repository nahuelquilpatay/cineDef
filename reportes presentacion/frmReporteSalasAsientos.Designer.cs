﻿namespace cineLabo.reportes
{
    partial class frmReporteSalasAsientos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.consultaSalasAsientos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaSalasAsientos2TableAdapter = new cineLabo.DSClientesTicketsTableAdapters.consultaSalasAsientos2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaSalasAsientos2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSSalasAsientos";
            reportDataSource1.Value = this.consultaSalasAsientos2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cineLabo.rptSalasAsientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaSalasAsientos2BindingSource
            // 
            this.consultaSalasAsientos2BindingSource.DataMember = "consultaSalasAsientos2";
            this.consultaSalasAsientos2BindingSource.DataSource = this.dSClientesTickets;
            // 
            // consultaSalasAsientos2TableAdapter
            // 
            this.consultaSalasAsientos2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteSalasAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteSalasAsientos";
            this.Text = "frmReporteSalasAsientos";
            this.Load += new System.EventHandler(this.frmReporteSalasAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaSalasAsientos2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSClientesTickets dSClientesTickets;
        private System.Windows.Forms.BindingSource consultaSalasAsientos2BindingSource;
        private DSClientesTicketsTableAdapters.consultaSalasAsientos2TableAdapter consultaSalasAsientos2TableAdapter;
    }
}