using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace FilaMedica
{
    public partial class Background : Form
    {
        // Inicia Filas
        Queue<Pessoa> filaNormal = new Queue<Pessoa>();
        Queue<Pessoa> filaPref = new Queue<Pessoa>();
        int cont = 0;
        public Background()
        {
            InitializeComponent();
            carregar();
        }

        //salvar dados
        void salvar()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("primeiraFila.txt", FileMode.Create)))
            {
                writer.Write(filaNormal.Count());
                foreach (Pessoa p in filaNormal)
                {
                    writer.Write(p.Nome);
                    writer.Write(p.Rg);
                    writer.Write(p.Idade);
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open("segundaFila.txt", FileMode.Create)))
            {
                writer.Write(filaPref.Count());
                foreach (Pessoa p in filaPref)
                {
                    writer.Write(p.Nome);
                    writer.Write(p.Rg);
                    writer.Write(p.Idade);
                }
            }
        }

        //carrega os dados salvos
        void carregar()
        {
            if (File.Exists("primeiraFila.txt"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open("primeiraFila.txt", FileMode.Open)))
                {
                    int qtd = reader.ReadInt32();
                    for (int i = 0; i < qtd; i++)
                    {
                        Pessoa p = new Pessoa();
                        p.Nome = reader.ReadString();
                        p.Rg = reader.ReadInt32();
                        p.Idade = reader.ReadInt32();
                        filaNormal.Enqueue(p);
                    }// fim for
                }

            }// Fila Preferencial

            if (File.Exists("segundaFila.txt"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open("segundaFila.txt", FileMode.Open)))
                {
                    int qtd = reader.ReadInt32();
                    for (int i = 0; i < qtd; i++)
                    {
                        Pessoa p = new Pessoa();
                        p.Nome = reader.ReadString();
                        p.Rg = reader.ReadInt32();
                        p.Idade = reader.ReadInt32();
                        filaPref.Enqueue(p);
                    }// fim for
                }

            }// Fila normal

            mostra();
        }

        void mostra()
        {
            listNormal.Items.Clear();
            foreach (Pessoa s in filaNormal)
            {
                listNormal.Items.Add(s.Nome + " - Idade:" + s.Idade);
            }

            listPref.Items.Clear();
            foreach (Pessoa s in filaPref)
            {
                listPref.Items.Add(s.Nome + " - Idade:" + s.Idade);
            }
        }

        void limpa()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtRg.Clear();
            txtNome.Focus();
        }


        void removePref()
        {

            if (filaPref.Count > 0)
            {
                foreach (Pessoa s in filaPref)
                {
                    lblAtend.Text = s.Nome;
                    filaPref.Dequeue();
                    cont += 1;
                    break;
                }
            }
                else if (filaNormal.Count > 0)
                {
                    foreach (Pessoa s in filaNormal)
                    {
                        lblAtend.Text = s.Nome;
                        filaNormal.Dequeue();
                        break;
                    }
                }
                    else
                    {
                           MessageBox.Show("Filas Vazias!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
        }

        void removeNormal()
        {
            if (filaNormal.Count > 0)
            {
                foreach (Pessoa s in filaNormal)
                {
                    lblAtend.Text = s.Nome;
                    filaNormal.Dequeue();
                    break;
                }
            }
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Rg = Convert.ToInt32(txtRg.Text);
            p.Idade = Convert.ToInt32(txtIdade.Text);
            if (p.Idade > 60)
            {
                filaPref.Enqueue(p);
            }
                else
                {
                    filaNormal.Enqueue(p);
                }
            limpa();
            mostra();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            if (cont <= 2)
            {
                    removePref();
                    mostra();
            }
                else
                {
                    removeNormal();
                    mostra();
                    cont = 0;
                }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Mover a janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTopo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Fim move janela
    }
}
