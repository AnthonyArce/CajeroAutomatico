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
            this.lblTipoCuentaPes.Size = new System.Drawing.Size(38, 17);
            this.lblTipoCuentaPes.TabIndex = 0;
            this.lblTipoCuentaPes.Text = "CA $";
            // 
            // lblNumCuentaPes
            // 
            this.lblNumCuentaPes.AutoSize = true;
            this.lblNumCuentaPes.Location = new System.Drawing.Point(68, 28);
            this.lblNumCuentaPes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCuentaPes.Name = "lblNumCuentaPes";
            this.lblNumCuentaPes.Size = new System.Drawing.Size(113, 17);
            this.lblNumCuentaPes.TabIndex = 1;
            this.lblNumCuentaPes.Text = "nroCuentaPesos";
            // 
            // lblMontoPes
            // 
            this.lblMontoPes.AutoSize = true;
            this.lblMontoPes.Location = new System.Drawing.Point(22, 65);
            this.lblMontoPes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoPes.Name = "lblMontoPes";
            this.lblMontoPes.Size = new System.Drawing.Size(76, 17);
            this.lblMontoPes.TabIndex = 2;
            this.lblMontoPes.Text = "$12345.70";
            // 
            // lblMontoDol
            // 
            this.lblMontoDol.AutoSize = true;
            this.lblMontoDol.Location = new System.Drawing.Point(22, 62);
            this.lblMontoDol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoDol.Name = "lblMontoDol";
            this.lblMontoDol.Size = new System.Drawing.Size(96, 17);
            this.lblMontoDol.TabIndex = 5;
            this.lblMontoDol.Text = "U$D12345.70";
            // 
            // lblNumCuentaDol
            // 
            this.lblNumCuentaDol.AutoSize = true;
            this.lblNumCuentaDol.Location = new System.Drawing.Point(68, 25);
            this.lblNumCuentaDol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCuentaDol.Name = "lblNumCuentaDol";
            this.lblNumCuentaDol.Size = new System.Drawing.Size(123, 17);
            this.lblNumCuentaDol.TabIndex = 4;
            this.lblNumCuentaDol.Text = "nroCuentaDolares";
            // 
            // lblTipoCuentaDol
            // 
            this.lblTipoCuentaDol.AutoSize = true;
            this.lblTipoCuentaDol.Location = new System.Drawing.Point(20, 25);
            this.lblTipoCuentaDol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCuentaDol.Name = "lblTipoCuentaDol";
            this.lblTipoCuentaDol.Size = new System.Drawing.Size(58, 17);
            this.lblTipoCuentaDol.TabIndex = 3;
            this.lblTipoCuentaDol.Text = "CA U$D";
            // 
            // grbCuentaPesos
            // 
            this.grbCuentaPesos.BackColor = System.Drawing.SystemColors.Control;
            this.grbCuentaPesos.Controls.Add(this.lblMontoPes);
            this.grbCuentaPesos.Controls.Add(this.lblTipoCuentaPes);
            this.grbCuentaPesos.Controls.Add(this.lblNumCuentaPes);
            this.grbCuentaPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCuentaPesos.Location = new System.Drawing.Point(151, 145);
            this.grbCuentaPesos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCuentaPesos.Name = "grbCuentaPesos";
            this.grbCuentaPesos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCuentaPesos.Size = new System.Drawing.Size(194, 101);
            this.grbCuentaPesos.TabIndex = 6;
            this.grbCuentaPesos.TabStop = false;
            this.grbCuentaPesos.Text = "groupBox1";
            this.grbCuentaPesos.Click += new System.EventHandler(this.grpBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblMontoDol);
            this.groupBox2.Controls.Add(this.lblTipoCuentaDol);
            this.groupBox2.Controls.Add(this.lblNumCuentaDol);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(443, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(194, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lstvMovimientos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(151, 268);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(487, 281);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lstvMovimientos
            // 
            this.lstvMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col0,
            this.col1,
            this.col2,
            this.col3});
            this.lstvMovimientos.HideSelection = false;
            this.lstvMovimientos.Location = new System.Drawing.Point(17, 52);
            this.lstvMovimientos.Name = "lstvMovimientos";
            this.lstvMovimientos.Size = new System.Drawing.Size(453, 211);
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
            this.label7.Location = new System.Drawing.Point(207, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Movimientos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(234, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bienvenido ";
            // 
            // lblApellidoyNombre
            // 
            this.lblApellidoyNombre.AutoSize = true;
            this.lblApellidoyNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombre.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoyNombre.Location = new System.Drawing.Point(356, 37);
            this.lblApellidoyNombre.Name = "lblApellidoyNombre";
            this.lblApellidoyNombre.Size = new System.Drawing.Size(208, 26);
            this.lblApellidoyNombre.TabIndex = 18;
            this.lblApellidoyNombre.Text = "Apellido y Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione para Consultar:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(798, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellidoyNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbCuentaPesos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
    }
}