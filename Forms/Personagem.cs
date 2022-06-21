using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace RPG
{
    public partial class Personagem : Form
    {
        public Personagem()
        {
            InitializeComponent();
        }

        private void ClasseCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Personagem_Load(object sender, EventArgs e)
        {

        }

        private void SalvarBt_Click(object sender, EventArgs e)
        {
            try
            {
                var Persona = new Persona();
                Persona.Nome = NomeTb.Text;
                Persona.Classe = Convert.ToString(ClasseCb.SelectedItem);
                Persona.For = Convert.ToInt32(ForTb.Text);
                Persona.Dex = Convert.ToInt32(DexTb.Text);
                Persona.Con = Convert.ToInt32(ConTb.Text);
                Persona.Int = Convert.ToInt32(IntTb.Text);
                Persona.Per = Convert.ToInt32(PerTb.Text);
                Persona.Car = Convert.ToInt32(CarTb.Text);
                foreach (var van in VantagemBx.SelectedItems)
                {
                    Persona.Vantagem.Add(van.ToString());
                }
                foreach (var des in DesvantagemBx.SelectedItems)
                {
                    Persona.Desvantagem.Add(des.ToString());
                }
                string json = JsonConvert.SerializeObject(Persona);

                var sfd = new SaveFileDialog();
                sfd.Title = "Salvar";
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    File.WriteAllText(sfd.FileName, json);
                    MessageBox.Show("Personagem Salvo!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ação cancelada!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show("Erro:" , ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForPlusBt_Click(object sender, EventArgs e)
        {
            int forca = Convert.ToInt32(ForTb.Text);
            forca = forca + 1;
            ForTb.Text = forca.ToString();

        }

        private void ForMinusBt_Click(object sender, EventArgs e)
        {
            int forca = Convert.ToInt32(ForTb.Text);

            if (forca <= 0)
                ForTb.Text = "0";
            else
                forca = forca - 1;
                ForTb.Text = forca.ToString();
        }

        private void DexPlusBt_Click(object sender, EventArgs e)
        {
            int destreza = Convert.ToInt32(DexTb.Text);
            destreza = destreza + 1;
            DexTb.Text = destreza.ToString();
        }

        private void DexMinusBt_Click(object sender, EventArgs e)
        {
            int destreza = Convert.ToInt32(DexTb.Text);

            if (destreza <= 0)
                ForTb.Text = "0";
            else
                destreza = destreza - 1;
            DexTb.Text = destreza.ToString();
        }

        private void ConPlusBt_Click(object sender, EventArgs e)
        {
            int constituicao = Convert.ToInt32(ConTb.Text);
            constituicao = constituicao + 1;
            ConTb.Text = constituicao.ToString();
        }

        private void ConMinusBt_Click(object sender, EventArgs e)
        {
            int constituicao = Convert.ToInt32(ConTb.Text);

            if (constituicao <= 0)
                ConTb.Text = "0";
            else
                constituicao = constituicao - 1;
            ConTb.Text = constituicao.ToString();
        }

        private void PerPlusBt_Click(object sender, EventArgs e)
        {
            int percepcao = Convert.ToInt32(PerTb.Text);
            percepcao = percepcao + 1;
            PerTb.Text = percepcao.ToString();
        }

        private void PerMinusBt_Click(object sender, EventArgs e)
        {
            int percepcao = Convert.ToInt32(PerTb.Text);

            if (percepcao <= 0)
                PerTb.Text = "0";
            else
                percepcao = percepcao - 1;
            PerTb.Text = percepcao.ToString();
        }

        private void CarisPlusBt_Click(object sender, EventArgs e)
        {
            int carisma = Convert.ToInt32(CarTb.Text);
            carisma = carisma + 1;
            CarTb.Text = carisma.ToString();
        }

        private void CarisMinusBt_Click(object sender, EventArgs e)
        {
            int carisma = Convert.ToInt32(CarTb.Text);

            if (carisma <= 0)
                CarTb.Text = "0";
            else
                carisma = carisma - 1;
            CarTb.Text = carisma.ToString();
        }

        private void IntPlusBt_Click(object sender, EventArgs e)
        {
            int inteligencia = Convert.ToInt32(IntTb.Text);
            inteligencia = inteligencia + 1;
            IntTb.Text = inteligencia.ToString();
        }

        private void IntMinusBt_Click(object sender, EventArgs e)
        {
            int inteligencia = Convert.ToInt32(IntTb.Text);

            if (inteligencia <= 0)
                IntTb.Text = "0";
            else
                inteligencia = inteligencia - 1;
            IntTb.Text = inteligencia.ToString();
        }

        private void CarregarBt_Click(object sender, EventArgs e)
        {

            try
            {
                var sfd = new OpenFileDialog();
                sfd.Title = "Carregar";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var Leitura = File.ReadAllText(sfd.FileName);
                    var personagem = JsonConvert.DeserializeObject<Persona>(Leitura);
                    NomeTb.Text = personagem.Nome;
                    ClasseCb.SelectedItem = personagem.Classe;
                    ForTb.Text = Convert.ToString(personagem.For);
                    DexTb.Text = Convert.ToString(personagem.Dex);
                    ConTb.Text = Convert.ToString(personagem.Con);
                    IntTb.Text = Convert.ToString(personagem.Int);
                    PerTb.Text = Convert.ToString(personagem.Per);
                    CarTb.Text = Convert.ToString(personagem.Car);
                    //VantagemBx.Text = personagem.Vantagem;
                    //DesvantagemBx.Text = Persona.Desvantagem;
                    MessageBox.Show("Personagem Carregado!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ação cancelada!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
