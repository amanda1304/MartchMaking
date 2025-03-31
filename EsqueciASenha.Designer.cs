namespace Login_Register
{
    partial class EsqueciASenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueciASenha));
            this.BtnEnviarCodigo = new System.Windows.Forms.Button();
            this.txtNameUserLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Label();
            this.panelUserRecuperarSenha = new System.Windows.Forms.Panel();
            this.textBoxRecuperarSenha = new System.Windows.Forms.TextBox();
            this.btnVoltarRecuperarSenha = new System.Windows.Forms.Button();
            this.panelUserRecuperarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEnviarCodigo
            // 
            this.BtnEnviarCodigo.FlatAppearance.BorderSize = 0;
            this.BtnEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviarCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarCodigo.ForeColor = System.Drawing.Color.White;
            this.BtnEnviarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnviarCodigo.Image")));
            this.BtnEnviarCodigo.Location = new System.Drawing.Point(84, 361);
            this.BtnEnviarCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEnviarCodigo.Name = "BtnEnviarCodigo";
            this.BtnEnviarCodigo.Size = new System.Drawing.Size(270, 39);
            this.BtnEnviarCodigo.TabIndex = 56;
            this.BtnEnviarCodigo.Text = "Enviar Código";
            this.BtnEnviarCodigo.UseVisualStyleBackColor = true;
            // 
            // txtNameUserLogin
            // 
            this.txtNameUserLogin.AutoSize = true;
            this.txtNameUserLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUserLogin.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNameUserLogin.Location = new System.Drawing.Point(87, 281);
            this.txtNameUserLogin.Name = "txtNameUserLogin";
            this.txtNameUserLogin.Size = new System.Drawing.Size(169, 17);
            this.txtNameUserLogin.TabIndex = 54;
            this.txtNameUserLogin.Text = "Digite o Email Cadastrado";
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLogin.Location = new System.Drawing.Point(101, 226);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(230, 36);
            this.txtLogin.TabIndex = 53;
            this.txtLogin.Text = "Recuperar Senha";
            // 
            // panelUserRecuperarSenha
            // 
            this.panelUserRecuperarSenha.BackColor = System.Drawing.Color.White;
            this.panelUserRecuperarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelUserRecuperarSenha.Controls.Add(this.textBoxRecuperarSenha);
            this.panelUserRecuperarSenha.Location = new System.Drawing.Point(84, 301);
            this.panelUserRecuperarSenha.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserRecuperarSenha.Name = "panelUserRecuperarSenha";
            this.panelUserRecuperarSenha.Size = new System.Drawing.Size(270, 37);
            this.panelUserRecuperarSenha.TabIndex = 57;
            // 
            // textBoxRecuperarSenha
            // 
            this.textBoxRecuperarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecuperarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRecuperarSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecuperarSenha.Location = new System.Drawing.Point(14, 9);
            this.textBoxRecuperarSenha.Multiline = true;
            this.textBoxRecuperarSenha.Name = "textBoxRecuperarSenha";
            this.textBoxRecuperarSenha.Size = new System.Drawing.Size(242, 22);
            this.textBoxRecuperarSenha.TabIndex = 2;
            // 
            // btnVoltarRecuperarSenha
            // 
            this.btnVoltarRecuperarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarRecuperarSenha.BackgroundImage")));
            this.btnVoltarRecuperarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltarRecuperarSenha.FlatAppearance.BorderSize = 0;
            this.btnVoltarRecuperarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarRecuperarSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarRecuperarSenha.Location = new System.Drawing.Point(84, 422);
            this.btnVoltarRecuperarSenha.Name = "btnVoltarRecuperarSenha";
            this.btnVoltarRecuperarSenha.Size = new System.Drawing.Size(95, 32);
            this.btnVoltarRecuperarSenha.TabIndex = 58;
            this.btnVoltarRecuperarSenha.UseVisualStyleBackColor = true;
            this.btnVoltarRecuperarSenha.Click += new System.EventHandler(this.btnVoltarRecuperarSenha_Click);
            // 
            // EsqueciASenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(429, 561);
            this.Controls.Add(this.btnVoltarRecuperarSenha);
            this.Controls.Add(this.BtnEnviarCodigo);
            this.Controls.Add(this.txtNameUserLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.panelUserRecuperarSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EsqueciASenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EsqueciASenha";
            this.panelUserRecuperarSenha.ResumeLayout(false);
            this.panelUserRecuperarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnviarCodigo;
        private System.Windows.Forms.Label txtNameUserLogin;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Panel panelUserRecuperarSenha;
        private System.Windows.Forms.TextBox textBoxRecuperarSenha;
        private System.Windows.Forms.Button btnVoltarRecuperarSenha;
    }
}