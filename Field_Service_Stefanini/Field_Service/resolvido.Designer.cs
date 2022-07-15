
namespace Field_Service
{
    partial class resolvido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resolvido));
            this.tb_chamado = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.lb_chanado = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_causa_solicitaçao = new System.Windows.Forms.TextBox();
            this.tb_resoluçao = new System.Windows.Forms.TextBox();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.lb_test = new System.Windows.Forms.Label();
            this.tb_validado = new System.Windows.Forms.TextBox();
            this.lb_validado = new System.Windows.Forms.Label();
            this.lb_field = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_anexar = new System.Windows.Forms.Button();
            this.rtb_resultado = new System.Windows.Forms.RichTextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.bt_copiar = new System.Windows.Forms.Button();
            this.lb_causa_solicitaçao = new System.Windows.Forms.Label();
            this.lb_resoluçao = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_name_feild = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_chamado
            // 
            this.tb_chamado.Location = new System.Drawing.Point(139, 38);
            this.tb_chamado.Name = "tb_chamado";
            this.tb_chamado.Size = new System.Drawing.Size(263, 20);
            this.tb_chamado.TabIndex = 15;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(139, 11);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(263, 20);
            this.tb_usuario.TabIndex = 14;
            // 
            // lb_chanado
            // 
            this.lb_chanado.AutoSize = true;
            this.lb_chanado.Location = new System.Drawing.Point(12, 42);
            this.lb_chanado.Name = "lb_chanado";
            this.lb_chanado.Size = new System.Drawing.Size(109, 13);
            this.lb_chanado.TabIndex = 13;
            this.lb_chanado.Text = "Numero do chamado:";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(12, 14);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(90, 13);
            this.lb_usuario.TabIndex = 12;
            this.lb_usuario.Text = "Nome do usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 54);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tb_causa_solicitaçao
            // 
            this.tb_causa_solicitaçao.Location = new System.Drawing.Point(139, 64);
            this.tb_causa_solicitaçao.Multiline = true;
            this.tb_causa_solicitaçao.Name = "tb_causa_solicitaçao";
            this.tb_causa_solicitaçao.Size = new System.Drawing.Size(655, 79);
            this.tb_causa_solicitaçao.TabIndex = 17;
            // 
            // tb_resoluçao
            // 
            this.tb_resoluçao.Location = new System.Drawing.Point(139, 149);
            this.tb_resoluçao.Multiline = true;
            this.tb_resoluçao.Name = "tb_resoluçao";
            this.tb_resoluçao.Size = new System.Drawing.Size(655, 79);
            this.tb_resoluçao.TabIndex = 18;
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(139, 234);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(655, 20);
            this.tb_test.TabIndex = 20;
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Location = new System.Drawing.Point(12, 238);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(92, 13);
            this.lb_test.TabIndex = 19;
            this.lb_test.Text = "Teste Realizados:";
            // 
            // tb_validado
            // 
            this.tb_validado.Location = new System.Drawing.Point(139, 260);
            this.tb_validado.Name = "tb_validado";
            this.tb_validado.Size = new System.Drawing.Size(253, 20);
            this.tb_validado.TabIndex = 22;
            // 
            // lb_validado
            // 
            this.lb_validado.AutoSize = true;
            this.lb_validado.Location = new System.Drawing.Point(12, 264);
            this.lb_validado.Name = "lb_validado";
            this.lb_validado.Size = new System.Drawing.Size(69, 13);
            this.lb_validado.TabIndex = 21;
            this.lb_validado.Text = "Validado por:";
            // 
            // lb_field
            // 
            this.lb_field.AutoSize = true;
            this.lb_field.Location = new System.Drawing.Point(12, 290);
            this.lb_field.Name = "lb_field";
            this.lb_field.Size = new System.Drawing.Size(78, 13);
            this.lb_field.TabIndex = 23;
            this.lb_field.Text = "Nome do Field:";
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(667, 260);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(126, 46);
            this.bt_voltar.TabIndex = 27;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(534, 260);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(126, 46);
            this.bt_limpar.TabIndex = 26;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            // 
            // bt_anexar
            // 
            this.bt_anexar.Location = new System.Drawing.Point(400, 260);
            this.bt_anexar.Name = "bt_anexar";
            this.bt_anexar.Size = new System.Drawing.Size(126, 46);
            this.bt_anexar.TabIndex = 25;
            this.bt_anexar.Text = "Anexar";
            this.bt_anexar.UseVisualStyleBackColor = true;
            // 
            // rtb_resultado
            // 
            this.rtb_resultado.Location = new System.Drawing.Point(91, 319);
            this.rtb_resultado.Name = "rtb_resultado";
            this.rtb_resultado.Size = new System.Drawing.Size(703, 198);
            this.rtb_resultado.TabIndex = 29;
            this.rtb_resultado.Text = "";
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(12, 399);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(58, 13);
            this.lb_resultado.TabIndex = 28;
            this.lb_resultado.Text = "Resultado:";
            // 
            // bt_copiar
            // 
            this.bt_copiar.Location = new System.Drawing.Point(668, 523);
            this.bt_copiar.Name = "bt_copiar";
            this.bt_copiar.Size = new System.Drawing.Size(126, 31);
            this.bt_copiar.TabIndex = 30;
            this.bt_copiar.Text = "Copiar";
            this.bt_copiar.UseVisualStyleBackColor = true;
            // 
            // lb_causa_solicitaçao
            // 
            this.lb_causa_solicitaçao.AutoSize = true;
            this.lb_causa_solicitaçao.Location = new System.Drawing.Point(12, 102);
            this.lb_causa_solicitaçao.Name = "lb_causa_solicitaçao";
            this.lb_causa_solicitaçao.Size = new System.Drawing.Size(103, 13);
            this.lb_causa_solicitaçao.TabIndex = 31;
            this.lb_causa_solicitaçao.Text = "Causa / Solicitação:";
            // 
            // lb_resoluçao
            // 
            this.lb_resoluçao.AutoSize = true;
            this.lb_resoluçao.Location = new System.Drawing.Point(12, 180);
            this.lb_resoluçao.Name = "lb_resoluçao";
            this.lb_resoluçao.Size = new System.Drawing.Size(61, 13);
            this.lb_resoluçao.TabIndex = 32;
            this.lb_resoluçao.Text = "Resolução:";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Location = new System.Drawing.Point(12, 539);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(42, 13);
            this.lb_hora.TabIndex = 33;
            this.lb_hora.Text = "lb_hora";
            // 
            // lb_name_feild
            // 
            this.lb_name_feild.AutoSize = true;
            this.lb_name_feild.Location = new System.Drawing.Point(136, 290);
            this.lb_name_feild.Name = "lb_name_feild";
            this.lb_name_feild.Size = new System.Drawing.Size(35, 13);
            this.lb_name_feild.TabIndex = 42;
            this.lb_name_feild.Text = "label1";
            // 
            // resolvido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.lb_name_feild);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.lb_resoluçao);
            this.Controls.Add(this.lb_causa_solicitaçao);
            this.Controls.Add(this.bt_copiar);
            this.Controls.Add(this.rtb_resultado);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_anexar);
            this.Controls.Add(this.lb_field);
            this.Controls.Add(this.tb_validado);
            this.Controls.Add(this.lb_validado);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.lb_test);
            this.Controls.Add(this.tb_resoluçao);
            this.Controls.Add(this.tb_causa_solicitaçao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_chamado);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.lb_chanado);
            this.Controls.Add(this.lb_usuario);
            this.Name = "resolvido";
            this.Text = "resolvido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_chamado;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label lb_chanado;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_causa_solicitaçao;
        private System.Windows.Forms.TextBox tb_resoluçao;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Label lb_test;
        private System.Windows.Forms.TextBox tb_validado;
        private System.Windows.Forms.Label lb_validado;
        private System.Windows.Forms.Label lb_field;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_anexar;
        private System.Windows.Forms.RichTextBox rtb_resultado;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Button bt_copiar;
        private System.Windows.Forms.Label lb_causa_solicitaçao;
        private System.Windows.Forms.Label lb_resoluçao;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_name_feild;
    }
}