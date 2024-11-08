namespace cajero_automatico
{
    partial class FrmCuentaPesos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNroCuenta = new System.Windows.Forms.Label();
            this.lblMontoPes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExtraerPesos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstvMovimientosPes = new System.Windows.Forms.ListView();
            this.col0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero cuenta";
            // 
            // lblNroCuenta
            // 
            this.lblNroCuenta.AutoSize = true;
            this.lblNroCuenta.Location = new System.Drawing.Point(147, 89);
            this.lblNroCuenta.Name = "lblNroCuenta";
            this.lblNroCuenta.Size = new System.Drawing.Size(85, 13);
            this.lblNroCuenta.TabIndex = 1;
            this.lblNroCuenta.Text = "1231231231231";
            // 
            // lblMontoPes
            // 
            this.lblMontoPes.AutoSize = true;
            this.lblMontoPes.Location = new System.Drawing.Point(61, 112);
            this.lblMontoPes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoPes.Name = "lblMontoPes";
            this.lblMontoPes.Size = new System.Drawing.Size(58, 13);
            this.lblMontoPes.TabIndex = 3;
            this.lblMontoPes.Text = "$12345.70";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 79);
            this.button2.TabIndex = 5;
            this.button2.Text = "Transferir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExtraerPesos
            // 
            this.btnExtraerPesos.Location = new System.Drawing.Point(408, 146);
            this.btnExtraerPesos.Name = "btnExtraerPesos";
            this.btnExtraerPesos.Size = new System.Drawing.Size(166, 79);
            this.btnExtraerPesos.TabIndex = 6;
            this.btnExtraerPesos.Text = "Extraer";
            this.btnExtraerPesos.UseVisualStyleBackColor = true;
            this.btnExtraerPesos.Click += new System.EventHandler(this.btnExtraerPesos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstvMovimientosPes);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(101, 256);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(497, 354);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lstvMovimientosPes
            // 
            this.lstvMovimientosPes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col0,
            this.col1,
            this.col2,
            this.col3});
            this.lstvMovimientosPes.HideSelection = false;
            this.lstvMovimientosPes.Location = new System.Drawing.Point(49, 84);
            this.lstvMovimientosPes.Name = "lstvMovimientosPes";
            this.lstvMovimientosPes.Size = new System.Drawing.Size(424, 195);
            this.lstvMovimientosPes.TabIndex = 1;
            this.lstvMovimientosPes.UseCompatibleStateImageBehavior = false;
            this.lstvMovimientosPes.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "FECHA";
            // 
            // col2
            // 
            this.col2.Text = "Destino";
            // 
            // col3
            // 
            this.col3.Text = "MONTO";
            this.col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(580, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 79);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cargar Telefono";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmCuentaPesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExtraerPesos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMontoPes);
            this.Controls.Add(this.lblNroCuenta);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuentaPesos";
            this.Text = "FrmCuentaPesos";
            this.Load += new System.EventHandler(this.FrmCuentaPesos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNroCuenta;
        private System.Windows.Forms.Label lblMontoPes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExtraerPesos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lstvMovimientosPes;
        private System.Windows.Forms.ColumnHeader col0;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
    }
}