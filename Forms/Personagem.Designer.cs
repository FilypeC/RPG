namespace RPG
{
    partial class Personagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClasseCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ForTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DexTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PerTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CarTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IntTb = new System.Windows.Forms.TextBox();
            this.ForPlusBt = new System.Windows.Forms.Button();
            this.ForMinusBt = new System.Windows.Forms.Button();
            this.DexMinusBt = new System.Windows.Forms.Button();
            this.DexPlusBt = new System.Windows.Forms.Button();
            this.ConMinusBt = new System.Windows.Forms.Button();
            this.ConPlusBt = new System.Windows.Forms.Button();
            this.PerMinusBt = new System.Windows.Forms.Button();
            this.PerPlusBt = new System.Windows.Forms.Button();
            this.CarisMinusBt = new System.Windows.Forms.Button();
            this.CarisPlusBt = new System.Windows.Forms.Button();
            this.IntMinusBt = new System.Windows.Forms.Button();
            this.IntPlusBt = new System.Windows.Forms.Button();
            this.SalvarBt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.VantagemBx = new System.Windows.Forms.CheckedListBox();
            this.DesvantagemBx = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CarregarBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficha";
            // 
            // NomeTb
            // 
            this.NomeTb.Location = new System.Drawing.Point(12, 61);
            this.NomeTb.Name = "NomeTb";
            this.NomeTb.Size = new System.Drawing.Size(193, 20);
            this.NomeTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // ClasseCb
            // 
            this.ClasseCb.Items.AddRange(new object[] {
            "Mago",
            "Guerreiro",
            "Bardo",
            "Clerigo",
            "Ladrão"});
            this.ClasseCb.Location = new System.Drawing.Point(266, 60);
            this.ClasseCb.Name = "ClasseCb";
            this.ClasseCb.Size = new System.Drawing.Size(121, 21);
            this.ClasseCb.TabIndex = 0;
            this.ClasseCb.SelectedIndexChanged += new System.EventHandler(this.ClasseCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Classe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Força";
            // 
            // ForTb
            // 
            this.ForTb.Location = new System.Drawing.Point(76, 120);
            this.ForTb.Name = "ForTb";
            this.ForTb.ReadOnly = true;
            this.ForTb.Size = new System.Drawing.Size(29, 20);
            this.ForTb.TabIndex = 6;
            this.ForTb.Text = "1";
            this.ForTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destreza";
            // 
            // DexTb
            // 
            this.DexTb.Location = new System.Drawing.Point(76, 151);
            this.DexTb.Name = "DexTb";
            this.DexTb.ReadOnly = true;
            this.DexTb.Size = new System.Drawing.Size(31, 20);
            this.DexTb.TabIndex = 8;
            this.DexTb.Text = "1";
            this.DexTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Constituição";
            // 
            // ConTb
            // 
            this.ConTb.Location = new System.Drawing.Point(76, 180);
            this.ConTb.Name = "ConTb";
            this.ConTb.ReadOnly = true;
            this.ConTb.Size = new System.Drawing.Size(29, 20);
            this.ConTb.TabIndex = 10;
            this.ConTb.Text = "1";
            this.ConTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Percepção";
            // 
            // PerTb
            // 
            this.PerTb.Location = new System.Drawing.Point(76, 207);
            this.PerTb.Name = "PerTb";
            this.PerTb.ReadOnly = true;
            this.PerTb.Size = new System.Drawing.Size(29, 20);
            this.PerTb.TabIndex = 12;
            this.PerTb.Text = "1";
            this.PerTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Carisma";
            // 
            // CarTb
            // 
            this.CarTb.Location = new System.Drawing.Point(76, 236);
            this.CarTb.Name = "CarTb";
            this.CarTb.ReadOnly = true;
            this.CarTb.Size = new System.Drawing.Size(29, 20);
            this.CarTb.TabIndex = 14;
            this.CarTb.Text = "1";
            this.CarTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Inteligencia";
            // 
            // IntTb
            // 
            this.IntTb.Location = new System.Drawing.Point(76, 265);
            this.IntTb.Name = "IntTb";
            this.IntTb.ReadOnly = true;
            this.IntTb.Size = new System.Drawing.Size(29, 20);
            this.IntTb.TabIndex = 16;
            this.IntTb.Text = "1";
            this.IntTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ForPlusBt
            // 
            this.ForPlusBt.Location = new System.Drawing.Point(123, 120);
            this.ForPlusBt.Name = "ForPlusBt";
            this.ForPlusBt.Size = new System.Drawing.Size(23, 23);
            this.ForPlusBt.TabIndex = 18;
            this.ForPlusBt.Text = "+";
            this.ForPlusBt.UseVisualStyleBackColor = true;
            this.ForPlusBt.Click += new System.EventHandler(this.ForPlusBt_Click);
            // 
            // ForMinusBt
            // 
            this.ForMinusBt.Location = new System.Drawing.Point(152, 120);
            this.ForMinusBt.Name = "ForMinusBt";
            this.ForMinusBt.Size = new System.Drawing.Size(23, 23);
            this.ForMinusBt.TabIndex = 19;
            this.ForMinusBt.Text = "-";
            this.ForMinusBt.UseVisualStyleBackColor = true;
            this.ForMinusBt.Click += new System.EventHandler(this.ForMinusBt_Click);
            // 
            // DexMinusBt
            // 
            this.DexMinusBt.Location = new System.Drawing.Point(152, 149);
            this.DexMinusBt.Name = "DexMinusBt";
            this.DexMinusBt.Size = new System.Drawing.Size(23, 23);
            this.DexMinusBt.TabIndex = 21;
            this.DexMinusBt.Text = "-";
            this.DexMinusBt.UseVisualStyleBackColor = true;
            this.DexMinusBt.Click += new System.EventHandler(this.DexMinusBt_Click);
            // 
            // DexPlusBt
            // 
            this.DexPlusBt.Location = new System.Drawing.Point(123, 149);
            this.DexPlusBt.Name = "DexPlusBt";
            this.DexPlusBt.Size = new System.Drawing.Size(23, 23);
            this.DexPlusBt.TabIndex = 20;
            this.DexPlusBt.Text = "+";
            this.DexPlusBt.UseVisualStyleBackColor = true;
            this.DexPlusBt.Click += new System.EventHandler(this.DexPlusBt_Click);
            // 
            // ConMinusBt
            // 
            this.ConMinusBt.Location = new System.Drawing.Point(152, 178);
            this.ConMinusBt.Name = "ConMinusBt";
            this.ConMinusBt.Size = new System.Drawing.Size(23, 23);
            this.ConMinusBt.TabIndex = 23;
            this.ConMinusBt.Text = "-";
            this.ConMinusBt.UseVisualStyleBackColor = true;
            this.ConMinusBt.Click += new System.EventHandler(this.ConMinusBt_Click);
            // 
            // ConPlusBt
            // 
            this.ConPlusBt.Location = new System.Drawing.Point(123, 178);
            this.ConPlusBt.Name = "ConPlusBt";
            this.ConPlusBt.Size = new System.Drawing.Size(23, 23);
            this.ConPlusBt.TabIndex = 22;
            this.ConPlusBt.Text = "+";
            this.ConPlusBt.UseVisualStyleBackColor = true;
            this.ConPlusBt.Click += new System.EventHandler(this.ConPlusBt_Click);
            // 
            // PerMinusBt
            // 
            this.PerMinusBt.Location = new System.Drawing.Point(152, 207);
            this.PerMinusBt.Name = "PerMinusBt";
            this.PerMinusBt.Size = new System.Drawing.Size(23, 23);
            this.PerMinusBt.TabIndex = 25;
            this.PerMinusBt.Text = "-";
            this.PerMinusBt.UseVisualStyleBackColor = true;
            this.PerMinusBt.Click += new System.EventHandler(this.PerMinusBt_Click);
            // 
            // PerPlusBt
            // 
            this.PerPlusBt.Location = new System.Drawing.Point(123, 207);
            this.PerPlusBt.Name = "PerPlusBt";
            this.PerPlusBt.Size = new System.Drawing.Size(23, 23);
            this.PerPlusBt.TabIndex = 24;
            this.PerPlusBt.Text = "+";
            this.PerPlusBt.UseVisualStyleBackColor = true;
            this.PerPlusBt.Click += new System.EventHandler(this.PerPlusBt_Click);
            // 
            // CarisMinusBt
            // 
            this.CarisMinusBt.Location = new System.Drawing.Point(152, 236);
            this.CarisMinusBt.Name = "CarisMinusBt";
            this.CarisMinusBt.Size = new System.Drawing.Size(23, 23);
            this.CarisMinusBt.TabIndex = 27;
            this.CarisMinusBt.Text = "-";
            this.CarisMinusBt.UseVisualStyleBackColor = true;
            this.CarisMinusBt.Click += new System.EventHandler(this.CarisMinusBt_Click);
            // 
            // CarisPlusBt
            // 
            this.CarisPlusBt.Location = new System.Drawing.Point(123, 236);
            this.CarisPlusBt.Name = "CarisPlusBt";
            this.CarisPlusBt.Size = new System.Drawing.Size(23, 23);
            this.CarisPlusBt.TabIndex = 26;
            this.CarisPlusBt.Text = "+";
            this.CarisPlusBt.UseVisualStyleBackColor = true;
            this.CarisPlusBt.Click += new System.EventHandler(this.CarisPlusBt_Click);
            // 
            // IntMinusBt
            // 
            this.IntMinusBt.Location = new System.Drawing.Point(152, 265);
            this.IntMinusBt.Name = "IntMinusBt";
            this.IntMinusBt.Size = new System.Drawing.Size(23, 23);
            this.IntMinusBt.TabIndex = 29;
            this.IntMinusBt.Text = "-";
            this.IntMinusBt.UseVisualStyleBackColor = true;
            this.IntMinusBt.Click += new System.EventHandler(this.IntMinusBt_Click);
            // 
            // IntPlusBt
            // 
            this.IntPlusBt.Location = new System.Drawing.Point(123, 265);
            this.IntPlusBt.Name = "IntPlusBt";
            this.IntPlusBt.Size = new System.Drawing.Size(23, 23);
            this.IntPlusBt.TabIndex = 28;
            this.IntPlusBt.Text = "+";
            this.IntPlusBt.UseVisualStyleBackColor = true;
            this.IntPlusBt.Click += new System.EventHandler(this.IntPlusBt_Click);
            // 
            // SalvarBt
            // 
            this.SalvarBt.Location = new System.Drawing.Point(313, 415);
            this.SalvarBt.Name = "SalvarBt";
            this.SalvarBt.Size = new System.Drawing.Size(75, 23);
            this.SalvarBt.TabIndex = 30;
            this.SalvarBt.Text = "Salvar";
            this.SalvarBt.UseVisualStyleBackColor = true;
            this.SalvarBt.Click += new System.EventHandler(this.SalvarBt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Vantagens";
            // 
            // VantagemBx
            // 
            this.VantagemBx.FormattingEnabled = true;
            this.VantagemBx.Items.AddRange(new object[] {
            "Inteligente",
            "Corajoso",
            "Carismatico"});
            this.VantagemBx.Location = new System.Drawing.Point(228, 119);
            this.VantagemBx.Name = "VantagemBx";
            this.VantagemBx.Size = new System.Drawing.Size(120, 94);
            this.VantagemBx.TabIndex = 34;
            // 
            // DesvantagemBx
            // 
            this.DesvantagemBx.FormattingEnabled = true;
            this.DesvantagemBx.Items.AddRange(new object[] {
            "Bebado",
            "Claustrofobico",
            "Caolho"});
            this.DesvantagemBx.Location = new System.Drawing.Point(375, 119);
            this.DesvantagemBx.Name = "DesvantagemBx";
            this.DesvantagemBx.Size = new System.Drawing.Size(120, 94);
            this.DesvantagemBx.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Desvantagens";
            // 
            // CarregarBt
            // 
            this.CarregarBt.Location = new System.Drawing.Point(472, 415);
            this.CarregarBt.Name = "CarregarBt";
            this.CarregarBt.Size = new System.Drawing.Size(75, 23);
            this.CarregarBt.TabIndex = 37;
            this.CarregarBt.Text = "Carregar";
            this.CarregarBt.UseVisualStyleBackColor = true;
            this.CarregarBt.Click += new System.EventHandler(this.CarregarBt_Click);
            // 
            // Personagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarregarBt);
            this.Controls.Add(this.DesvantagemBx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VantagemBx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SalvarBt);
            this.Controls.Add(this.IntMinusBt);
            this.Controls.Add(this.IntPlusBt);
            this.Controls.Add(this.CarisMinusBt);
            this.Controls.Add(this.CarisPlusBt);
            this.Controls.Add(this.PerMinusBt);
            this.Controls.Add(this.PerPlusBt);
            this.Controls.Add(this.ConMinusBt);
            this.Controls.Add(this.ConPlusBt);
            this.Controls.Add(this.DexMinusBt);
            this.Controls.Add(this.DexPlusBt);
            this.Controls.Add(this.ForMinusBt);
            this.Controls.Add(this.ForPlusBt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IntTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CarTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PerTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ConTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DexTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ForTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClasseCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeTb);
            this.Controls.Add(this.label1);
            this.Name = "Personagem";
            this.Text = "Personagem";
            this.Load += new System.EventHandler(this.Personagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClasseCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ForTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DexTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ConTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PerTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CarTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IntTb;
        private System.Windows.Forms.Button ForPlusBt;
        private System.Windows.Forms.Button ForMinusBt;
        private System.Windows.Forms.Button DexMinusBt;
        private System.Windows.Forms.Button DexPlusBt;
        private System.Windows.Forms.Button ConMinusBt;
        private System.Windows.Forms.Button ConPlusBt;
        private System.Windows.Forms.Button PerMinusBt;
        private System.Windows.Forms.Button PerPlusBt;
        private System.Windows.Forms.Button CarisMinusBt;
        private System.Windows.Forms.Button CarisPlusBt;
        private System.Windows.Forms.Button IntMinusBt;
        private System.Windows.Forms.Button IntPlusBt;
        private System.Windows.Forms.Button SalvarBt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox VantagemBx;
        private System.Windows.Forms.CheckedListBox DesvantagemBx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CarregarBt;
    }
}