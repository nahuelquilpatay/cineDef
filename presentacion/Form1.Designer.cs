﻿namespace cineLabo
{
    partial class frmCine
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tICKETSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESTICKETSCOMPRADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALASYASIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUCURSALESYRECAUDACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESCON1TICKETELMESPASADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaMenu = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tICKETSToolStripMenuItem,
            this.cONSULTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tICKETSToolStripMenuItem
            // 
            this.tICKETSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem});
            this.tICKETSToolStripMenuItem.Name = "tICKETSToolStripMenuItem";
            this.tICKETSToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tICKETSToolStripMenuItem.Text = "NUEVO";
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.nUEVOToolStripMenuItem.Text = "TICKET";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // cONSULTASToolStripMenuItem
            // 
            this.cONSULTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESTICKETSCOMPRADOSToolStripMenuItem,
            this.sALASYASIENTOSToolStripMenuItem,
            this.sUCURSALESYRECAUDACIÓNToolStripMenuItem,
            this.cLIENTESCON1TICKETELMESPASADOToolStripMenuItem});
            this.cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            this.cONSULTASToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.cONSULTASToolStripMenuItem.Text = "REPORTES";
            // 
            // cLIENTESTICKETSCOMPRADOSToolStripMenuItem
            // 
            this.cLIENTESTICKETSCOMPRADOSToolStripMenuItem.Name = "cLIENTESTICKETSCOMPRADOSToolStripMenuItem";
            this.cLIENTESTICKETSCOMPRADOSToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.cLIENTESTICKETSCOMPRADOSToolStripMenuItem.Text = "CLIENTES Y TICKETS COMPRADOS";
            this.cLIENTESTICKETSCOMPRADOSToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESTICKETSCOMPRADOSToolStripMenuItem_Click);
            // 
            // sALASYASIENTOSToolStripMenuItem
            // 
            this.sALASYASIENTOSToolStripMenuItem.Name = "sALASYASIENTOSToolStripMenuItem";
            this.sALASYASIENTOSToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.sALASYASIENTOSToolStripMenuItem.Text = "SALAS Y ASIENTOS";
            this.sALASYASIENTOSToolStripMenuItem.Click += new System.EventHandler(this.sALASYASIENTOSToolStripMenuItem_Click);
            // 
            // sUCURSALESYRECAUDACIÓNToolStripMenuItem
            // 
            this.sUCURSALESYRECAUDACIÓNToolStripMenuItem.Name = "sUCURSALESYRECAUDACIÓNToolStripMenuItem";
            this.sUCURSALESYRECAUDACIÓNToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.sUCURSALESYRECAUDACIÓNToolStripMenuItem.Text = "SUCURSALES Y RECAUDACIÓN";
            this.sUCURSALESYRECAUDACIÓNToolStripMenuItem.Click += new System.EventHandler(this.sUCURSALESYRECAUDACIÓNToolStripMenuItem_Click);
            // 
            // cLIENTESCON1TICKETELMESPASADOToolStripMenuItem
            // 
            this.cLIENTESCON1TICKETELMESPASADOToolStripMenuItem.Name = "cLIENTESCON1TICKETELMESPASADOToolStripMenuItem";
            this.cLIENTESCON1TICKETELMESPASADOToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.cLIENTESCON1TICKETELMESPASADOToolStripMenuItem.Text = "CLIENTES CON +1 TICKET EL MES PASADO";
            this.cLIENTESCON1TICKETELMESPASADOToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESCON1TICKETELMESPASADOToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "CINE";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(237, 161);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(155, 25);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de hoy: ";
            // 
            // dtpFechaMenu
            // 
            this.dtpFechaMenu.Enabled = false;
            this.dtpFechaMenu.Location = new System.Drawing.Point(398, 164);
            this.dtpFechaMenu.Name = "dtpFechaMenu";
            this.dtpFechaMenu.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMenu.TabIndex = 3;
            // 
            // frmCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(798, 370);
            this.Controls.Add(this.dtpFechaMenu);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCine";
            this.Text = "CINE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tICKETSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTASToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaMenu;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESTICKETSCOMPRADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALASYASIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUCURSALESYRECAUDACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESCON1TICKETELMESPASADOToolStripMenuItem;
    }
}

