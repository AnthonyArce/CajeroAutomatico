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
            this.label2 = new System.Windows.Forms.Label();
            this.grbCuentaDolares = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstvMovimientos = new System.Windows.Forms.ListView();
            this.col0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApellidoyNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCuentaPesos.SuspendLayout();
            this.grbCuentaDolares.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoCuentaPes
            // 
            this.lblTipoCuentaPes.AutoSize = true;
            this.lblTipoCuentaPes.Location = new System.Drawing.Point(27, 34);
            this.lblTipoCuentaPes.Name = "lblTipoCuentaPes";
            this.lblTipoCuentaPes.Size = new System.Drawing.Size(51, 20);
            this.lblTipoCuentaPes.TabIndex = 0;
            this.lblTipoCuentaPes.Text = "CA $:";
            // 
            // lblNumCuentaPes
            // 
            this.lblNumCuentaPes.AutoSize = true;
            this.lblNumCuentaPes.Location = new System.Drawing.Point(112, 34);
            this.lblNumCuentaPes.Name = "lblNumCuentaPes";
            this.lblNumCuentaPes.Size = new System.Drawing.Size(133, 20);
            this.lblNumCuentaPes.TabIndex = 1;
            this.lblNumCuentaPes.Text = "nroCuentaPesos";
            // 
            // lblMontoPes
            // 
            this.lblMontoPes.AutoSize = true;
            this.lblMontoPes.Location = new System.Drawing.Point(112, 76);
            this.lblMontoPes.Name = "lblMontoPes";
            this.lblMontoPes.Size = new System.Drawing.Size(85, 20);
            this.lblMontoPes.TabIndex = 2;
            this.lblMontoPes.Text = "$12345.70";
            // 
            // lblMontoDol
            // 
            this.lblMontoDol.AutoSize = true;
            this.lblMontoDol.Location = new System.Drawing.Point(136, 76);
            this.lblMontoDol.Name = "lblMontoDol";
            this.lblMontoDol.Size = new System.Drawing.Size(110, 20);
            this.lblMontoDol.TabIndex = 5;
            this.lblMontoDol.Text = "U$D12345.70";
            // 
            // lblNumCuentaDol
            // 
            this.lblNumCuentaDol.AutoSize = true;
            this.lblNumCuentaDol.Location = new System.Drawing.Point(136, 31);
            this.lblNumCuentaDol.Name = "lblNumCuentaDol";
            this.lblNumCuentaDol.Size = new System.Drawing.Size(145, 20);
            this.lblNumCuentaDol.TabIndex = 4;
            this.lblNumCuentaDol.Text = "nroCuentaDolares";
            // 
            // lblTipoCuentaDol
            // 
            this.lblTipoCuentaDol.AutoSize = true;
            this.lblTipoCuentaDol.Location = new System.Drawing.Point(27, 31);
            this.lblTipoCuentaDol.Name = "lblTipoCuentaDol";
            this.lblTipoCuentaDol.Size = new System.Drawing.Size(78, 20);
            this.lblTipoCuentaDol.TabIndex = 3;
            this.lblTipoCuentaDol.Text = "CA USD:";
            // 
            // grbCuentaPesos
            // 
            this.grbCuentaPesos.BackColor = System.Drawing.SystemColors.Control;
            this.grbCuentaPesos.Controls.Add(this.label2);
            this.grbCuentaPesos.Controls.Add(this.lblMontoPes);
            this.grbCuentaPesos.Controls.Add(this.lblTipoCuentaPes);
            this.grbCuentaPesos.Controls.Add(this.lblNumCuentaPes);
            this.grbCuentaPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCuentaPesos.Location = new System.Drawing.Point(201, 179);
            this.grbCuentaPesos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCuentaPesos.Name = "grbCuentaPesos";
            this.grbCuentaPesos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCuentaPesos.Size = new System.Drawing.Size(364, 124);
            this.grbCuentaPesos.TabIndex = 6;
            this.grbCuentaPesos.TabStop = false;
            this.grbCuentaPesos.Click += new System.EventHandler(this.grpBoxPesos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo:";
            // 
            // grbCuentaDolares
            // 
            this.grbCuentaDolares.BackColor = System.Drawing.SystemColors.Control;
            this.grbCuentaDolares.Controls.Add(this.label3);
            this.grbCuentaDolares.Controls.Add(this.lblMontoDol);
            this.grbCuentaDolares.Controls.Add(this.lblTipoCuentaDol);
            this.grbCuentaDolares.Controls.Add(this.lblNumCuentaDol);
            this.grbCuentaDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCuentaDolares.Location = new System.Drawing.Point(587, 179);
            this.grbCuentaDolares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCuentaDolares.Name = "grbCuentaDolares";
            this.grbCuentaDolares.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCuentaDolares.Size = new System.Drawing.Size(364, 124);
            this.grbCuentaDolares.TabIndex = 7;
            this.grbCuentaDolares.TabStop = false;
            this.grbCuentaDolares.Click += new System.EventHandler(this.grbCuentaDolares_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lstvMovimientos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(203, 330);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(748, 372);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // lstvMovimientos
            // 
            this.lstvMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col0,
            this.col1,
            this.col2,
            this.col3});
            this.lstvMovimientos.HideSelection = false;
            this.lstvMovimientos.Location = new System.Drawing.Point(79, 62);
            this.lstvMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.lstvMovimientos.Name = "lstvMovimientos";
            this.lstvMovimientos.Size = new System.Drawing.Size(603, 259);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Movimientos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(312, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bienvenido ";
            // 
            // lblApellidoyNombre
            // 
            this.lblApellidoyNombre.AutoSize = true;
            this.lblApellidoyNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombre.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoyNombre.Location = new System.Drawing.Point(474, 46);
            this.lblApellidoyNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoyNombre.Name = "lblApellidoyNombre";
            this.lblApellidoyNombre.Size = new System.Drawing.Size(263, 32);
            this.lblApellidoyNombre.TabIndex = 18;
            this.lblApellidoyNombre.Text = "Apellido y Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione para Consultar:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1064, 755);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellidoyNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbCuentaDolares);
            this.Controls.Add(this.grbCuentaPesos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grbCuentaPesos.ResumeLayout(false);
            this.grbCuentaPesos.PerformLayout();
            this.grbCuentaDolares.ResumeLayout(false);
            this.grbCuentaDolares.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbCuentaDolares;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApellidoyNombre;
        private System.Windows.Forms.ListView lstvMovimientos;
        private System.Windows.Forms.ColumnHeader col0;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}