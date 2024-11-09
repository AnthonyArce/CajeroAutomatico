namespace cajero_automatico
{
    partial class FrmTransferir
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.txtALIAS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCBU = new System.Windows.Forms.Label();
            this.lblMontoTrans = new System.Windows.Forms.Label();
            this.lblCbuTrans = new System.Windows.Forms.Label();
            this.lblNroCuenta = new System.Windows.Forms.Label();
            this.lblNroCuentaTrans = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransferirMonto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblALIAS = new System.Windows.Forms.Label();
            this.lblAliasTrans = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "CBU:";
            // 
            // txtCBU
            // 
            this.txtCBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCBU.Location = new System.Drawing.Point(302, 278);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(207, 28);
            this.txtCBU.TabIndex = 2;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(322, 418);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(179, 79);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // txtALIAS
            // 
            this.txtALIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtALIAS.Location = new System.Drawing.Point(302, 316);
            this.txtALIAS.Name = "txtALIAS";
            this.txtALIAS.Size = new System.Drawing.Size(207, 28);
            this.txtALIAS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alias (Opcional):";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(180, 82);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(126, 20);
            this.lblMonto.TabIndex = 36;
            this.lblMonto.Text = "1231231231231";
            // 
            // lblCBU
            // 
            this.lblCBU.AutoSize = true;
            this.lblCBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBU.Location = new System.Drawing.Point(180, 54);
            this.lblCBU.Name = "lblCBU";
            this.lblCBU.Size = new System.Drawing.Size(126, 20);
            this.lblCBU.TabIndex = 35;
            this.lblCBU.Text = "1231231231231";
            // 
            // lblMontoTrans
            // 
            this.lblMontoTrans.AutoSize = true;
            this.lblMontoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTrans.Location = new System.Drawing.Point(68, 82);
            this.lblMontoTrans.Name = "lblMontoTrans";
            this.lblMontoTrans.Size = new System.Drawing.Size(101, 20);
            this.lblMontoTrans.TabIndex = 34;
            this.lblMontoTrans.Text = "Saldo actual:";
            // 
            // lblCbuTrans
            // 
            this.lblCbuTrans.AutoSize = true;
            this.lblCbuTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbuTrans.Location = new System.Drawing.Point(122, 54);
            this.lblCbuTrans.Name = "lblCbuTrans";
            this.lblCbuTrans.Size = new System.Drawing.Size(47, 20);
            this.lblCbuTrans.TabIndex = 33;
            this.lblCbuTrans.Text = "CBU:";
            // 
            // lblNroCuenta
            // 
            this.lblNroCuenta.AutoSize = true;
            this.lblNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCuenta.Location = new System.Drawing.Point(180, 25);
            this.lblNroCuenta.Name = "lblNroCuenta";
            this.lblNroCuenta.Size = new System.Drawing.Size(126, 20);
            this.lblNroCuenta.TabIndex = 32;
            this.lblNroCuenta.Text = "1231231231231";
            // 
            // lblNroCuentaTrans
            // 
            this.lblNroCuentaTrans.AutoSize = true;
            this.lblNroCuentaTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCuentaTrans.Location = new System.Drawing.Point(28, 25);
            this.lblNroCuentaTrans.Name = "lblNroCuentaTrans";
            this.lblNroCuentaTrans.Size = new System.Drawing.Size(147, 20);
            this.lblNroCuentaTrans.TabIndex = 31;
            this.lblNroCuentaTrans.Text = "Numero de Cuenta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 26);
            this.label9.TabIndex = 30;
            this.label9.Text = "TRANSFERENCIA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(145, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Monto:";
            // 
            // txtTransferirMonto
            // 
            this.txtTransferirMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferirMonto.Location = new System.Drawing.Point(302, 355);
            this.txtTransferirMonto.Name = "txtTransferirMonto";
            this.txtTransferirMonto.Size = new System.Drawing.Size(207, 28);
            this.txtTransferirMonto.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(364, 230);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ingresar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblALIAS);
            this.groupBox1.Controls.Add(this.lblAliasTrans);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.lblCBU);
            this.groupBox1.Controls.Add(this.lblMontoTrans);
            this.groupBox1.Controls.Add(this.lblCbuTrans);
            this.groupBox1.Controls.Add(this.lblNroCuenta);
            this.groupBox1.Controls.Add(this.lblNroCuentaTrans);
            this.groupBox1.Location = new System.Drawing.Point(23, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(746, 153);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblALIAS
            // 
            this.lblALIAS.AutoSize = true;
            this.lblALIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALIAS.Location = new System.Drawing.Point(180, 111);
            this.lblALIAS.Name = "lblALIAS";
            this.lblALIAS.Size = new System.Drawing.Size(126, 20);
            this.lblALIAS.TabIndex = 38;
            this.lblALIAS.Text = "1231231231231";
            // 
            // lblAliasTrans
            // 
            this.lblAliasTrans.AutoSize = true;
            this.lblAliasTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliasTrans.Location = new System.Drawing.Point(109, 111);
            this.lblAliasTrans.Name = "lblAliasTrans";
            this.lblAliasTrans.Size = new System.Drawing.Size(60, 20);
            this.lblAliasTrans.TabIndex = 37;
            this.lblAliasTrans.Text = "ALIAS:";
            // 
            // FrmTransferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(798, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTransferirMonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtALIAS);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.txtCBU);
            this.Controls.Add(this.label2);
            this.Name = "FrmTransferir";
            this.Text = "FrmTransferir";
            this.Load += new System.EventHandler(this.FrmTransferir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCBU;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox txtALIAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCBU;
        private System.Windows.Forms.Label lblMontoTrans;
        private System.Windows.Forms.Label lblCbuTrans;
        private System.Windows.Forms.Label lblNroCuenta;
        private System.Windows.Forms.Label lblNroCuentaTrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransferirMonto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblALIAS;
        private System.Windows.Forms.Label lblAliasTrans;
    }
}