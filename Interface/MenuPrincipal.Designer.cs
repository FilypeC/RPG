
namespace RPG.Interface
{
    partial class MenuPrincipal
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
            this.CriarPer_Bt = new System.Windows.Forms.Button();
            this.EditarPer_Bt = new System.Windows.Forms.Button();
            this.Jogar_Bt = new System.Windows.Forms.Button();
            this.CriarIni_Bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CriarPer_Bt
            // 
            this.CriarPer_Bt.Location = new System.Drawing.Point(88, 81);
            this.CriarPer_Bt.Name = "CriarPer_Bt";
            this.CriarPer_Bt.Size = new System.Drawing.Size(219, 82);
            this.CriarPer_Bt.TabIndex = 0;
            this.CriarPer_Bt.Text = "Criar Personagem";
            this.CriarPer_Bt.UseVisualStyleBackColor = true;
            this.CriarPer_Bt.Click += new System.EventHandler(this.CriarPer_Bt_Click);
            // 
            // EditarPer_Bt
            // 
            this.EditarPer_Bt.Location = new System.Drawing.Point(88, 169);
            this.EditarPer_Bt.Name = "EditarPer_Bt";
            this.EditarPer_Bt.Size = new System.Drawing.Size(219, 82);
            this.EditarPer_Bt.TabIndex = 1;
            this.EditarPer_Bt.Text = "Editar Personagem";
            this.EditarPer_Bt.UseVisualStyleBackColor = true;
            this.EditarPer_Bt.Click += new System.EventHandler(this.EditarPer_Bt_Click);
            // 
            // Jogar_Bt
            // 
            this.Jogar_Bt.Location = new System.Drawing.Point(396, 169);
            this.Jogar_Bt.Name = "Jogar_Bt";
            this.Jogar_Bt.Size = new System.Drawing.Size(219, 82);
            this.Jogar_Bt.TabIndex = 2;
            this.Jogar_Bt.Text = "Jogar!";
            this.Jogar_Bt.UseVisualStyleBackColor = true;
            this.Jogar_Bt.Click += new System.EventHandler(this.Jogar_Bt_Click);
            // 
            // CriarIni_Bt
            // 
            this.CriarIni_Bt.Location = new System.Drawing.Point(396, 81);
            this.CriarIni_Bt.Name = "CriarIni_Bt";
            this.CriarIni_Bt.Size = new System.Drawing.Size(219, 82);
            this.CriarIni_Bt.TabIndex = 3;
            this.CriarIni_Bt.Text = "Criar Inimigo";
            this.CriarIni_Bt.UseVisualStyleBackColor = true;
            this.CriarIni_Bt.Click += new System.EventHandler(this.CriarIni_Bt_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CriarIni_Bt);
            this.Controls.Add(this.Jogar_Bt);
            this.Controls.Add(this.EditarPer_Bt);
            this.Controls.Add(this.CriarPer_Bt);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CriarPer_Bt;
        private System.Windows.Forms.Button EditarPer_Bt;
        private System.Windows.Forms.Button Jogar_Bt;
        private System.Windows.Forms.Button CriarIni_Bt;
    }
}