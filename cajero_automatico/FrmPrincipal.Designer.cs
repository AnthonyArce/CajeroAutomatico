namespace cajero_automatico
{
    partial class FrmPrincipal
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
            this.lblTipoCuentaPes = new System.Windows.Forms.Label();
            this.lblNumCuentaPes = new System.Windows.Forms.Label();
            this.lblMontoPes = new System.Windows.Forms.Label();
            this.lblMontoDol = new System.Windows.Forms.Label();
            this.lblNumCuentaDol = new System.Windows.Forms.Label();
            this.lblTipoCuentaDol = new System.Windows.Forms.Label();
            this.grbCuentaPesos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApellidoyNombre = new System.Windows.Forms.Label();
            this.lstvMovimientos = new System.Windows.Forms.ListView();
            this.col0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbCuentaPesos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoCuentaPes
            // 
            this.lblTipoCuentaPes.AutoSize = true;
            this.lblTipoCuentaPes.Location = new System.Drawing.Point(20, 28);
            this.lblTipoCuentaPes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCuentaPes.Name = "lblTipoCuentaPes";
            this.lblTipoCuentaPes.Size = new System.Drawing.Size(30, 13);
            this.lblTipoCuentaPes.TabIndex = 0;
            this.lblTipoCuentaPes.Text = "CA $";
            // 
            // lblNumCuentaPes
            // 
            this.lblNumCuentaPes.AutoSize = true;
            this.lblNumCuentaPes.Location = new System.Drawing.Point(68, 28);
            this.lblNumCuentaPes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCuentaPes.Name = "lblNumCuentaPes";
            this.lblNumCuentaPes.Size = new System.Drawing.Size(85, 13);
            this.lblNumCuentaPes.TabIndex = 1;
            this.lblNumCuentaPes.Text = "nroCuentaPesos";
            // 
            // lblMontoPes
            // 
            this.lblMontoPes.AutoSize = true;
            this.lblMontoPes.Location = new System.Drawing.Point(22, 65);
            this.lblMontoPes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoPes.Name = "lblMontoPes";
            this.lblMontoPes.Size = new System.Drawing.Size(58, 13);
            this.lblMontoPes.TabIndex = 2;
            this.lblMontoPes.Text = "$12345.70";
            // 
            // lblMontoDol
            // 
            this.lblMontoDol.AutoSize = true;
            this.lblMontoDol.Location = new System.Drawing.Point(22, 62);
            this.lblMontoDol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoDol.Name = "lblMontoDol";
            this.lblMontoDol.Size = new System.Drawing.Size(74, 13);
            this.lblMontoDol.TabIndex = 5;
            this.lblMontoDol.Text = "U$D12345.70";
            // 
            // lblNumCuentaDol
            // 
            this.lblNumCuentaDol.AutoSize = true;
            this.lblNumCuentaDol.Location = new System.Drawing.Point(68, 25);
            this.lblNumCuentaDol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCuentaDol.Name = "lblNumCuentaDol";
            this.lblNumCuentaDol.Size = new System.Drawing.Size(92, 13);
            this.lblNumCuentaDol.TabIndex = 4;
            this.lblNumCuentaDol.Text = "nroCuentaDolares";
            // 
            // lblTipoCuentaDol
            // 
            this.lblTipoCuentaDol.AutoSize = true;
            this.lblTipoCuentaDol.Location = new System.Drawing.Point(20, 25);
            this.lblTipoCuentaDol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCuentaDol.Name = "lblTipoCuentaDol";
            this.lblTipoCuentaDol.Size = new System.Drawing.Size(46, 13);
            this.lblTipoCuentaDol.TabIndex = 3;
            this.lblTipoCuentaDol.Text = "CA U$D";
            // 
            // grbCuentaPesos
            // 
            this.grbCuentaPesos.Controls.Add(this.lblMontoPes);
            this.grbCuentaPesos.Controls.Add(this.lblTipoCuentaPes);
            this.grbCuentaPesos.Controls.Add(this.lblNumCuentaPes);
            this.grbCuentaPesos.Location = new System.Drawing.Point(42, 64);
            this.grbCuentaPesos.Margin = new System.Windows.Forms.Padding(2);
            this.grbCuentaPesos.Name = "grbCuentaPesos";
            this.grbCuentaPesos.Padding = new System.Windows.Forms.Padding(2);
            this.grbCuentaPesos.Size = new System.Drawing.Size(194, 101);
            this.grbCuentaPesos.TabIndex = 6;
            this.grbCuentaPesos.TabStop = false;
            this.grbCuentaPesos.Text = "groupBox1";
            this.grbCuentaPesos.Enter += new System.EventHandler(this.grpBox_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMontoDol);
            this.groupBox2.Controls.Add(this.lblTipoCuentaDol);
            this.groupBox2.Controls.Add(this.lblNumCuentaDol);
            this.groupBox2.Location = new System.Drawing.Point(372, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(194, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstvMovimientos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(42, 169);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(497, 233);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Movimientos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bienvenido ";
            // 
            // lblApellidoyNombre
            // 
            this.lblApellidoyNombre.AutoSize = true;
            this.lblApellidoyNombre.Location = new System.Drawing.Point(113, 13);
            this.lblApellidoyNombre.Name = "lblApellidoyNombre";
            this.lblApellidoyNombre.Size = new System.Drawing.Size(92, 13);
            this.lblApellidoyNombre.TabIndex = 18;
            this.lblApellidoyNombre.Text = "Apellido y Nombre";
            // 
            // lstvMovimientos
            // 
            this.lstvMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col0,
            this.col1,
            this.col2,
            this.col3});
            this.lstvMovimientos.HideSelection = false;
            this.lstvMovimientos.Location = new System.Drawing.Point(25, 33);
            this.lstvMovimientos.Name = "lstvMovimientos";
            this.lstvMovimientos.Size = new System.Drawing.Size(453, 195);
            this.lstvMovimientos.TabIndex = 1;
            this.lstvMovimientos.UseCompatibleStateImageBehavior = false;
            this.lstvMovimientos.View = System.Windows.Forms.View.Details;
            // 
            // col0
            // 
            this.col0.Text = "ID TRANSACCION";
            this.col0.Width = 105;
            // 
            // col1
            // 
            this.col1.Text = "FECHA";
            this.col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col1.Width = 97;
            // 
            // col2
            // 
            this.col2.Text = "Destinatario";
            this.col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col2.Width = 129;
            // 
            // col3
            // 
            this.col3.Text = "Monto";
            this.col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col3.Width = 136;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 442);
            this.Controls.Add(this.lblApellidoyNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbCuentaPesos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grbCuentaPesos.ResumeLayout(false);
            this.grbCuentaPesos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCuentaPes;
        private System.Windows.Forms.Label lblNumCuentaPes;
        private System.Windows.Forms.Label lblMontoPes;
        private System.Windows.Forms.Label lblMontoDol;
        private System.Windows.Forms.Label lblNumCuentaDol;
        private System.Windows.Forms.Label lblTipoCuentaDol;
        private System.Windows.Forms.GroupBox grbCuentaPesos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApellidoyNombre;
        private System.Windows.Forms.ListView lstvMovimientos;
        private System.Windows.Forms.ColumnHeader col0;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
    }
}