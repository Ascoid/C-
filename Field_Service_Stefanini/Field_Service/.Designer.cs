
namespace Field_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_anexar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_chanado = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_field = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_chamado = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.bt_copiar = new System.Windows.Forms.Button();
            this.rtb_resultado = new System.Windows.Forms.RichTextBox();
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_name_feild = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_anexar
            // 
            this.bt_anexar.Location = new System.Drawing.Point(398, 81);
            this.bt_anexar.Name = "bt_anexar";
            this.bt_anexar.Size = new System.Drawing.Size(126, 33);
            this.bt_anexar.TabIndex = 3;
            this.bt_anexar.Text = "Anexar";
            this.bt_anexar.UseVisualStyleBackColor = true;
            this.bt_anexar.Click += new System.EventHandler(this.bt_anexar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(530, 81);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(126, 33);
            this.bt_limpar.TabIndex = 4;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(662, 81);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(126, 33);
            this.bt_voltar.TabIndex = 5;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(12, 14);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(90, 13);
            this.lb_usuario.TabIndex = 6;
            this.lb_usuario.Text = "Nome do usuario:";
            // 
            // lb_chanado
            // 
            this.lb_chanado.AutoSize = true;
            this.lb_chanado.Location = new System.Drawing.Point(12, 42);
            this.lb_chanado.Name = "lb_chanado";
            this.lb_chanado.Size = new System.Drawing.Size(109, 13);
            this.lb_chanado.TabIndex = 7;
            this.lb_chanado.Text = "Numero do chamado:";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(12, 66);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(33, 13);
            this.lb_data.TabIndex = 8;
            this.lb_data.Text = "Data:";
            // 
            // lb_field
            // 
            this.lb_field.AutoSize = true;
            this.lb_field.Location = new System.Drawing.Point(12, 96);
            this.lb_field.Name = "lb_field";
            this.lb_field.Size = new System.Drawing.Size(78, 13);
            this.lb_field.TabIndex = 9;
            this.lb_field.Text = "Nome do Field:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(139, 11);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(253, 20);
            this.tb_usuario.TabIndex = 10;
            // 
            // tb_chamado
            // 
            this.tb_chamado.Location = new System.Drawing.Point(139, 38);
            this.tb_chamado.Name = "tb_chamado";
            this.tb_chamado.Size = new System.Drawing.Size(253, 20);
            this.tb_chamado.TabIndex = 11;
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(139, 65);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(253, 20);
            this.dtp_data.TabIndex = 14;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(12, 197);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(58, 13);
            this.lb_resultado.TabIndex = 16;
            this.lb_resultado.Text = "Resultado:";
            // 
            // bt_copiar
            // 
            this.bt_copiar.Location = new System.Drawing.Point(654, 322);
            this.bt_copiar.Name = "bt_copiar";
            this.bt_copiar.Size = new System.Drawing.Size(126, 33);
            this.bt_copiar.TabIndex = 17;
            this.bt_copiar.Text = "Copiar";
            this.bt_copiar.UseVisualStyleBackColor = true;
            this.bt_copiar.Click += new System.EventHandler(this.bt_copiar_Click);
            // 
            // rtb_resultado
            // 
            this.rtb_resultado.Location = new System.Drawing.Point(85, 118);
            this.rtb_resultado.Name = "rtb_resultado";
            this.rtb_resultado.Size = new System.Drawing.Size(703, 198);
            this.rtb_resultado.TabIndex = 18;
            this.rtb_resultado.Text = "";
            this.rtb_resultado.TextChanged += new System.EventHandler(this.rtb_resultado_TextChanged);
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Location = new System.Drawing.Point(15, 336);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(42, 13);
            this.lb_hora.TabIndex = 19;
            this.lb_hora.Text = "lb_hora";
            this.lb_hora.Click += new System.EventHandler(this.lb_hora_Click);
            // 
            // lb_name_feild
            // 
            this.lb_name_feild.AutoSize = true;
            this.lb_name_feild.Location = new System.Drawing.Point(139, 96);
            this.lb_name_feild.Name = "lb_name_feild";
            this.lb_name_feild.Size = new System.Drawing.Size(35, 13);
            this.lb_name_feild.TabIndex = 20;
            this.lb_name_feild.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 361);
            this.Controls.Add(this.lb_name_feild);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.rtb_resultado);
            this.Controls.Add(this.bt_copiar);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.tb_chamado);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.lb_field);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_chanado);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_anexar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "STEFANINI - ATENDIMENTO AGENDADO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_anexar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_chanado;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_field;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_chamado;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Button bt_copiar;
        private System.Windows.Forms.RichTextBox rtb_resultado;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_name_feild;
    }
}