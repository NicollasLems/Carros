namespace Carros
{
    partial class frmcarro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcarro = new System.Windows.Forms.Label();
            this.lblimposto = new System.Windows.Forms.Label();
            this.lbllucro = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblvfinal = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtcarro = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtimposto = new System.Windows.Forms.TextBox();
            this.txtlucro = new System.Windows.Forms.TextBox();
            this.txtvfinal = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcarro
            // 
            this.lblcarro.AutoSize = true;
            this.lblcarro.Location = new System.Drawing.Point(24, 32);
            this.lblcarro.Name = "lblcarro";
            this.lblcarro.Size = new System.Drawing.Size(84, 13);
            this.lblcarro.TabIndex = 0;
            this.lblcarro.Text = "Modelo do carro";
            // 
            // lblimposto
            // 
            this.lblimposto.AutoSize = true;
            this.lblimposto.Location = new System.Drawing.Point(24, 108);
            this.lblimposto.Name = "lblimposto";
            this.lblimposto.Size = new System.Drawing.Size(67, 13);
            this.lblimposto.TabIndex = 1;
            this.lblimposto.Text = "Imposto (R$)";
            // 
            // lbllucro
            // 
            this.lbllucro.AutoSize = true;
            this.lbllucro.Location = new System.Drawing.Point(25, 146);
            this.lbllucro.Name = "lbllucro";
            this.lbllucro.Size = new System.Drawing.Size(57, 13);
            this.lbllucro.TabIndex = 2;
            this.lbllucro.Text = "Lucro (R$)";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(24, 69);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(58, 13);
            this.lblpreco.TabIndex = 3;
            this.lblpreco.Text = "Preço (R$)";
            // 
            // lblvfinal
            // 
            this.lblvfinal.AutoSize = true;
            this.lblvfinal.Location = new System.Drawing.Point(24, 180);
            this.lblvfinal.Name = "lblvfinal";
            this.lblvfinal.Size = new System.Drawing.Size(79, 13);
            this.lblvfinal.TabIndex = 4;
            this.lblvfinal.Text = "Valor Final (R$)";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(27, 229);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(110, 28);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(161, 229);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(110, 28);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcarro
            // 
            this.txtcarro.BackColor = System.Drawing.Color.LightYellow;
            this.txtcarro.Location = new System.Drawing.Point(109, 32);
            this.txtcarro.Name = "txtcarro";
            this.txtcarro.Size = new System.Drawing.Size(130, 20);
            this.txtcarro.TabIndex = 7;
            // 
            // txtpreco
            // 
            this.txtpreco.BackColor = System.Drawing.Color.LightYellow;
            this.txtpreco.Location = new System.Drawing.Point(109, 66);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(130, 20);
            this.txtpreco.TabIndex = 8;
            // 
            // txtimposto
            // 
            this.txtimposto.BackColor = System.Drawing.Color.LightYellow;
            this.txtimposto.Enabled = false;
            this.txtimposto.Location = new System.Drawing.Point(109, 108);
            this.txtimposto.Name = "txtimposto";
            this.txtimposto.ReadOnly = true;
            this.txtimposto.Size = new System.Drawing.Size(130, 20);
            this.txtimposto.TabIndex = 9;
            // 
            // txtlucro
            // 
            this.txtlucro.BackColor = System.Drawing.Color.LightYellow;
            this.txtlucro.Enabled = false;
            this.txtlucro.Location = new System.Drawing.Point(109, 143);
            this.txtlucro.Name = "txtlucro";
            this.txtlucro.ReadOnly = true;
            this.txtlucro.Size = new System.Drawing.Size(130, 20);
            this.txtlucro.TabIndex = 10;
            // 
            // txtvfinal
            // 
            this.txtvfinal.BackColor = System.Drawing.Color.LightYellow;
            this.txtvfinal.Enabled = false;
            this.txtvfinal.Location = new System.Drawing.Point(109, 177);
            this.txtvfinal.Name = "txtvfinal";
            this.txtvfinal.ReadOnly = true;
            this.txtvfinal.Size = new System.Drawing.Size(130, 20);
            this.txtvfinal.TabIndex = 11;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(293, 229);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(110, 28);
            this.btnsair.TabIndex = 12;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmcarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.txtvfinal);
            this.Controls.Add(this.txtlucro);
            this.Controls.Add(this.txtimposto);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtcarro);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblvfinal);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lbllucro);
            this.Controls.Add(this.lblimposto);
            this.Controls.Add(this.lblcarro);
            this.Name = "frmcarro";
            this.Text = "Carros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcarro;
        private System.Windows.Forms.Label lblimposto;
        private System.Windows.Forms.Label lbllucro;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblvfinal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtcarro;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtimposto;
        private System.Windows.Forms.TextBox txtlucro;
        private System.Windows.Forms.TextBox txtvfinal;
        private System.Windows.Forms.Button btnsair;
    }
}

