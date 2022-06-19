namespace RPG
{
    partial class Menu
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
            this.PersonagemBt = new System.Windows.Forms.Button();
            this.InimigoBt = new System.Windows.Forms.Button();
            this.NpcBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonagemBt
            // 
            this.PersonagemBt.Location = new System.Drawing.Point(12, 25);
            this.PersonagemBt.Name = "PersonagemBt";
            this.PersonagemBt.Size = new System.Drawing.Size(198, 86);
            this.PersonagemBt.TabIndex = 0;
            this.PersonagemBt.Text = "Personagem";
            this.PersonagemBt.UseVisualStyleBackColor = true;
            this.PersonagemBt.Click += new System.EventHandler(this.PersonagemBt_Click);
            // 
            // InimigoBt
            // 
            this.InimigoBt.Location = new System.Drawing.Point(247, 25);
            this.InimigoBt.Name = "InimigoBt";
            this.InimigoBt.Size = new System.Drawing.Size(198, 86);
            this.InimigoBt.TabIndex = 1;
            this.InimigoBt.Text = "Inimigo";
            this.InimigoBt.UseVisualStyleBackColor = true;
            // 
            // NpcBt
            // 
            this.NpcBt.Location = new System.Drawing.Point(476, 25);
            this.NpcBt.Name = "NpcBt";
            this.NpcBt.Size = new System.Drawing.Size(198, 86);
            this.NpcBt.TabIndex = 2;
            this.NpcBt.Text = "NPC";
            this.NpcBt.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.NpcBt);
            this.Controls.Add(this.InimigoBt);
            this.Controls.Add(this.PersonagemBt);
            this.Name = "Menu";
            this.Text = "RPG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PersonagemBt;
        private System.Windows.Forms.Button InimigoBt;
        private System.Windows.Forms.Button NpcBt;
    }
}

