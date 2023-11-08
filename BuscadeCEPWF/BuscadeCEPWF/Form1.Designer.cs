
namespace BuscadeCEPWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtComplemento2 = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.maskCep = new System.Windows.Forms.MaskedTextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.Label();
            this.Municipio = new System.Windows.Forms.Label();
            this.Complemento2 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.logradouro = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.Label();
            this.Cep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(this.txtComplemento2);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.maskCep);
            this.groupBox1.Controls.Add(this.Estado);
            this.groupBox1.Controls.Add(this.Complemento);
            this.groupBox1.Controls.Add(this.Municipio);
            this.groupBox1.Controls.Add(this.Complemento2);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.logradouro);
            this.groupBox1.Controls.Add(this.Bairro);
            this.groupBox1.Controls.Add(this.Cep);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1013, 904);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(107, 565);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(399, 28);
            this.txtEstado.TabIndex = 16;
            this.txtEstado.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(159, 519);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(347, 28);
            this.txtMunicipio.TabIndex = 15;
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.Location = new System.Drawing.Point(196, 468);
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(310, 28);
            this.txtComplemento2.TabIndex = 14;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(196, 416);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(310, 28);
            this.txtComplemento.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(133, 361);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(373, 28);
            this.txtBairro.TabIndex = 12;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(148, 313);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(358, 28);
            this.txtNumero.TabIndex = 11;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(171, 266);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(335, 28);
            this.txtLogradouro.TabIndex = 10;
            // 
            // maskCep
            // 
            this.maskCep.Location = new System.Drawing.Point(115, 213);
            this.maskCep.Mask = "00000-000";
            this.maskCep.Name = "maskCep";
            this.maskCep.Size = new System.Drawing.Size(391, 28);
            this.maskCep.TabIndex = 9;
            this.maskCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskCep.Leave += new System.EventHandler(this.maskCep_leave);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(73, 573);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(28, 20);
            this.Estado.TabIndex = 8;
            this.Estado.Text = "UF";
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.Location = new System.Drawing.Point(73, 419);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(117, 20);
            this.Complemento.TabIndex = 7;
            this.Complemento.Text = "Complemento1";
            // 
            // Municipio
            // 
            this.Municipio.AutoSize = true;
            this.Municipio.Location = new System.Drawing.Point(74, 522);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(79, 20);
            this.Municipio.TabIndex = 6;
            this.Municipio.Text = "Municipio";
            // 
            // Complemento2
            // 
            this.Complemento2.AutoSize = true;
            this.Complemento2.Location = new System.Drawing.Point(73, 471);
            this.Complemento2.Name = "Complemento2";
            this.Complemento2.Size = new System.Drawing.Size(119, 20);
            this.Complemento2.TabIndex = 5;
            this.Complemento2.Text = "Complemento2";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(73, 316);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(69, 20);
            this.numero.TabIndex = 4;
            this.numero.Text = "Numero";
            // 
            // logradouro
            // 
            this.logradouro.AutoSize = true;
            this.logradouro.Location = new System.Drawing.Point(72, 269);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(93, 20);
            this.logradouro.TabIndex = 3;
            this.logradouro.Text = "Logradouro";
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.Location = new System.Drawing.Point(73, 364);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(54, 20);
            this.Bairro.TabIndex = 2;
            this.Bairro.Text = "Bairro";
            // 
            // Cep
            // 
            this.Cep.AutoSize = true;
            this.Cep.Location = new System.Drawing.Point(73, 216);
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(36, 20);
            this.Cep.TabIndex = 1;
            this.Cep.Text = "CEP";
            this.Cep.Leave += new System.EventHandler(this.maskCep_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCACEP - EVOLUTIONSENAI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 904);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BuscadeCEPWF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtComplemento2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.MaskedTextBox maskCep;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.Label Municipio;
        private System.Windows.Forms.Label Complemento2;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label logradouro;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.Label Cep;
    }
}

