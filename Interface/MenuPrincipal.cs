using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace RPG.Interface
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void CriarPer_Bt_Click(object sender, EventArgs e)
        {
            var CriarP = new Criar_Personagem();
            CriarP.Show();
        }

        private void EditarPer_Bt_Click(object sender, EventArgs e)
        {
            var EditarP = new Editar_Personagem();
            EditarP.Show();
        }

        private void CriarIni_Bt_Click(object sender, EventArgs e)
        {
            var CInimigo = new Criar_Inimigo();
            CInimigo.Show();
        }

        private void Jogar_Bt_Click(object sender, EventArgs e)
        {
            var J = new Jogar();
            J.Show();
        }
    }
}