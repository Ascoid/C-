
namespace Field_Service
{
    partial class contato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contato));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_copiar = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.tb_chamado = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.lb_field = new System.Windows.Forms.Label();
            this.lb_chanado = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_anexar = new System.Windows.Forms.Button();
            this.tb_ramal = new System.Windows.Forms.TextBox();
            this.lb_ramal = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.tb_tentativas = new System.Windows.Forms.TextBox();
            this.lb_tentativas = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.rtb_resultado = new System.Windows.Forms.RichTextBox();
            this.lb_name_feild = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_copiar
            // 
            this.bt_copiar.Location = new System.Drawing.Point(569, 356);
            this.bt_copiar.Name = "bt_copiar";
            this.bt_copiar.Size = new System.Drawing.Size(126, 33);
            this.bt_copiar.TabIndex = 32;
            this.bt_copiar.Text = "Copiar";
            this.bt_copiar.UseVisualStyleBackColor = true;
            this.bt_copiar.Click += new System.EventHandler(this.bt_copiar_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(12, 190);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(58, 13);
            this.lb_resultado.TabIndex = 31;
            this.lb_resultado.Text = "Resultado:";
            // 
            // tb_chamado
            // 
            this.tb_chamado.Location = new System.Drawing.Point(139, 34);
            this.tb_chamado.Name = "tb_chamado";
            this.tb_chamado.Size = new System.Drawing.Size(253, 20);
            this.tb_chamado.TabIndex = 27;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(139, 7);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(253, 20);
            this.tb_usuario.TabIndex = 26;
            // 
            // lb_field
            // 
            this.lb_field.AutoSize = true;
            this.lb_field.Location = new System.Drawing.Point(12, 143);
            this.lb_field.Name = "lb_field";
            this.lb_field.Size = new System.Drawing.Size(78, 13);
            this.lb_field.TabIndex = 25;
            this.lb_field.Text = "Nome do Field:";
            // 
            // lb_chanado
            // 
            this.lb_chanado.AutoSize = true;
            this.lb_chanado.Location = new System.Drawing.Point(12, 38);
            this.lb_chanado.Name = "lb_chanado";
            this.lb_chanado.Size = new System.Drawing.Size(109, 13);
            this.lb_chanado.TabIndex = 23;
            this.lb_chanado.Text = "Numero do chamado:";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(12, 10);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(90, 13);
            this.lb_usuario.TabIndex = 22;
            this.lb_usuario.Text = "Nome do usuario:";
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(398, 129);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(126, 33);
            this.bt_voltar.TabIndex = 21;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(398, 90);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(126, 33);
            this.bt_limpar.TabIndex = 20;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_anexar
            // 
            this.bt_anexar.Location = new System.Drawing.Point(398, 51);
            this.bt_anexar.Name = "bt_anexar";
            this.bt_anexar.Size = new System.Drawing.Size(126, 33);
            this.bt_anexar.TabIndex = 19;
            this.bt_anexar.Text = "Anexar";
            this.bt_anexar.UseVisualStyleBackColor = true;
            this.bt_anexar.Click += new System.EventHandler(this.bt_anexar_Click);
            // 
            // tb_ramal
            // 
            this.tb_ramal.Location = new System.Drawing.Point(139, 60);
            this.tb_ramal.Name = "tb_ramal";
            this.tb_ramal.Size = new System.Drawing.Size(253, 20);
            this.tb_ramal.TabIndex = 34;
            // 
            // lb_ramal
            // 
            this.lb_ramal.AutoSize = true;
            this.lb_ramal.Location = new System.Drawing.Point(12, 64);
            this.lb_ramal.Name = "lb_ramal";
            this.lb_ramal.Size = new System.Drawing.Size(43, 13);
            this.lb_ramal.TabIndex = 33;
            this.lb_ramal.Text = "Ramal: ";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(139, 86);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(253, 20);
            this.tb_telefone.TabIndex = 36;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(12, 90);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(52, 13);
            this.lb_telefone.TabIndex = 35;
            this.lb_telefone.Text = "Telefone:";
            // 
            // tb_tentativas
            // 
            this.tb_tentativas.Location = new System.Drawing.Point(139, 112);
            this.tb_tentativas.Name = "tb_tentativas";
            this.tb_tentativas.Size = new System.Drawing.Size(253, 20);
            this.tb_tentativas.TabIndex = 38;
            // 
            // lb_tentativas
            // 
            this.lb_tentativas.AutoSize = true;
            this.lb_tentativas.Location = new System.Drawing.Point(12, 116);
            this.lb_tentativas.Name = "lb_tentativas";
            this.lb_tentativas.Size = new System.Drawing.Size(60, 13);
            this.lb_tentativas.TabIndex = 37;
            this.lb_tentativas.Text = "Tentativas:";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Location = new System.Drawing.Point(12, 372);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(42, 13);
            this.lb_hora.TabIndex = 39;
            this.lb_hora.Text = "lb_hora";
            // 
            // rtb_resultado
            // 
            this.rtb_resultado.Location = new System.Drawing.Point(76, 168);
            this.rtb_resultado.Name = "rtb_resultado";
            this.rtb_resultado.Size = new System.Drawing.Size(619, 182);
            this.rtb_resultado.TabIndex = 40;
            this.rtb_resultado.Text = "";
            // 
            // lb_name_feild
            // 
            this.lb_name_feild.AutoSize = true;
            this.lb_name_feild.Location = new System.Drawing.Point(136, 143);
            this.lb_name_feild.Name = "lb_name_feild";
            this.lb_name_feild.Size = new System.Drawing.Size(35, 13);
            this.lb_name_feild.TabIndex = 41;
            this.lb_name_feild.Text = "label1";
            // 
            // contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 394);
            this.Controls.Add(this.lb_name_feild);
            this.Controls.Add(this.rtb_resultado);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.tb_tentativas);
            this.Controls.Add(this.lb_tentativas);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.tb_ramal);
            this.Controls.Add(this.lb_ramal);
            this.Controls.Add(this.bt_copiar);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.tb_chamado);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.lb_field);
            this.Controls.Add(this.lb_chanado);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_anexar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "contato";
            this.Text = "STEFANINI - TENTATIVA DE CONTATO";
            this.Load += new System.EventHandler(this.contato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_copiar;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.TextBox tb_chamado;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label lb_field;
        private System.Windows.Forms.Label lb_chanado;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_anexar;
        private System.Windows.Forms.TextBox tb_ramal;
        private System.Windows.Forms.Label lb_ramal;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.TextBox tb_tentativas;
        private System.Windows.Forms.Label lb_tentativas;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.RichTextBox rtb_resultado;
        private System.Windows.Forms.Label lb_name_feild;
    }
}