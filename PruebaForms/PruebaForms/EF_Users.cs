
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PruebaForms
{
    public partial class EF_Users : Form
    {
        public EF_Users()
        {
            InitializeComponent();
            
        }
        private void EF_Users_Load(object sender, EventArgs e)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            RaceHeroe.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassHeroe.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void MaleHeroe_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarImagen();
        }

        private void FemaleHeroe_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarImagen();
        }

        private void RaceHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarImagen();
        }

        private void ActualizarImagen()
        {
            if (MaleHeroe.Checked)
            {
                if (RaceHeroe.SelectedIndex.Equals(0))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Saitama.png");
                }
                else if (RaceHeroe.SelectedIndex.Equals(1))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Kazuma.png");
                }
                else if (RaceHeroe.SelectedIndex.Equals(2))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Steven.png");
                }
                else if (RaceHeroe.SelectedIndex.Equals(3))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Shinra.png");
                }
            }
            else if (FemaleHeroe.Checked)
            {
                if (RaceHeroe.SelectedIndex.Equals(0))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Mimosa.png");
                }
                else if (RaceHeroe.SelectedIndex.Equals(1))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Shera.png");
                }
                else if (RaceHeroe.SelectedIndex.Equals(2))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Sailor.png");
                }
                else if (RaceHeroe.SelectedIndex.Equals(3))
                {
                    ImageHeroe.Image = Image.FromFile("C:\\Users\\zzbakh\\source\\repos\\PruebaForms\\PruebaForms\\ImagenesHeroes\\Mercury.png");
                }
            } 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if((!MaleHeroe.Checked) || (!FemaleHeroe.Checked) || )
            System.Diagnostics.Process.Start(@"C:\Users\zzbakh\Documents\Games\Juego\Juego\bin\Release\netcoreapp2.1\win10-x64\Juego.exe");
        }
    }
}
