namespace MiCalculadora
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cmbSigno = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvBin = new System.Windows.Forms.Button();
            this.btnConvDec = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(31, 64);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(127, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(396, 64);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(127, 22);
            this.txtNum2.TabIndex = 2;
            // 
            // cmbSigno
            // 
            this.cmbSigno.AutoCompleteCustomSource.AddRange(new string[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbSigno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSigno.FormattingEnabled = true;
            this.cmbSigno.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbSigno.Location = new System.Drawing.Point(225, 62);
            this.cmbSigno.Name = "cmbSigno";
            this.cmbSigno.Size = new System.Drawing.Size(117, 24);
            this.cmbSigno.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(31, 139);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(127, 43);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(224, 139);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 43);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(396, 139);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 43);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnConvBin
            // 
            this.btnConvBin.Location = new System.Drawing.Point(31, 228);
            this.btnConvBin.Name = "btnConvBin";
            this.btnConvBin.Size = new System.Drawing.Size(200, 35);
            this.btnConvBin.TabIndex = 6;
            this.btnConvBin.Text = "Convertir a binario";
            this.btnConvBin.UseVisualStyleBackColor = true;
            this.btnConvBin.Click += new System.EventHandler(this.BtnConvBin_Click);
            // 
            // btnConvDec
            // 
            this.btnConvDec.Location = new System.Drawing.Point(320, 228);
            this.btnConvDec.Name = "btnConvDec";
            this.btnConvDec.Size = new System.Drawing.Size(203, 35);
            this.btnConvDec.TabIndex = 7;
            this.btnConvDec.Text = "Convertir a decimal";
            this.btnConvDec.UseVisualStyleBackColor = true;
            this.btnConvDec.Click += new System.EventHandler(this.BtnConvDec_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(451, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 17);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 299);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvDec);
            this.Controls.Add(this.btnConvBin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.cmbSigno);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora de Gonzalo Mey 2A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cmbSigno;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvBin;
        private System.Windows.Forms.Button btnConvDec;
        private System.Windows.Forms.Label lblResult;
    }
}

