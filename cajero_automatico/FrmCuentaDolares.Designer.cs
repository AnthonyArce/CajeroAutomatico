namespace cajero_automatico
{
    partial class FrmCuentaDolares
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstvMovimientos = new System.Windows.Forms.ListView();
            this.col0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.btnExtraerDolares = new System.Windows.Forms.Button();
            this.btnTransferirDolares = new System.Windows.Forms.Button();
            this.btnDepositarDolares = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Consulta de Caja de Ahorros en Dólares";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lstvMovimientos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(199, 378);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(663, 357);
            this.groupBox3.TabIndex = 29;
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
            this.lstvMovimientos.Location = new System.Drawing.Point(30, 58);
            this.lstvMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.lstvMovimientos.Name = "lstvMovimientos";
            this.lstvMovimientos.Size = new System.Drawing.Size(603, 259);
            this.lstvMovimientos.TabIndex = 2;
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
            // btnExtraerDolares
            // 
            this.btnExtraerDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraerDolares.Location = new System.Drawing.Point(648, 254);
            this.btnExtraerDolares.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtraerDolares.Name = "btnExtraerDolares";
            this.btnExtraerDolares.Size = new System.Drawing.Size(221, 97);
            this.btnExtraerDolares.TabIndex = 28;
            this.btnExtraerDolares.Text = "Extraer";
            this.btnExtraerDolares.UseVisualStyleBackColor = true;
            // 
            // btnTransferirDolares
            // 
            this.btnTransferirDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferirDolares.Location = new System.Drawing.Point(419, 254);
            this.btnTransferirDolares.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransferirDolares.Name = "btnTransferirDolares";
            this.btnTransferirDolares.Size = new System.Drawing.Size(221, 97);
            this.btnTransferirDolares.TabIndex = 27;
            this.btnTransferirDolares.Text = "Transferir";
            this.btnTransferirDolares.UseVisualStyleBackColor = true;
            // 
            // btnDepositarDolares
            // 
            this.btnDepositarDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositarDolares.Location = new System.Drawing.Point(189, 254);
            this.btnDepositarDolares.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepositarDolares.Name = "btnDepositarDolares";
            this.btnDepositarDolares.Size = new System.Drawing.Size(221, 97);
            this.btnDepositarDolares.TabIndex = 26;
            this.btnDepositarDolares.Text = "Depositar";
            this.btnDepositarDolares.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(34, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 153);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "1231231231231";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "1231231231231";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Saldo actual:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "CBU:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(240, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "1231231231231";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(61, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Numero de Cuenta:";
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(38, 566);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(117, 58);
            this.btnInicio.TabIndex = 46;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(38, 640);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(117, 58);
            this.btnAtras.TabIndex = 45;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // FrmCuentaDolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1064, 755);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExtraerDolares);
            this.Controls.Add(this.btnTransferirDolares);
            this.Controls.Add(this.btnDepositarDolares);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCuentaDolares";
            this.Text = "CuentaDolares";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstvMovimientos;
        private System.Windows.Forms.ColumnHeader col0;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExtraerDolares;
        private System.Windows.Forms.Button btnTransferirDolares;
        private System.Windows.Forms.Button btnDepositarDolares;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAtras;
    }
}