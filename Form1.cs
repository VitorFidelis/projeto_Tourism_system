using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismo_2022
{
    public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
        }

        decimal fortaleza, PortoSeguro, Paris, Milao;//Guarda o Preço das viagens
        int d1, d2, d3, d4;//guarda o valor de passagens disponiveis
        decimal q1, q2, q3, q4;//Guarda a quantidade de cada produto

        private void Num_1_ValueChanged(object sender, EventArgs e)
        {
            q1 = Num_1.Value;//Recebe a quantidade de passagens disponiveis
            Lbl_Passagens1.Text = "Disponivel:" + (d1 - q1);//Indica o restante de passagens  disponiveis de cada viagem
            Total();//usando metodo total
            Totalpassa();
        }

        private void Num_2_ValueChanged(object sender, EventArgs e)
        {
            q2 = Num_2.Value;//Recebe a quantidade de passagens disponiveis
            Lbl_Passagens2.Text = "Disponivel:" + (d2 - q2);//Indica o restante de passagens  disponiveis de cada viagem
            Total();//Usando o metodo total
            Totalpassa();
        }

        private void Num_3_ValueChanged(object sender, EventArgs e)
        {
            q3 = Num_3.Value;//Recebe a quantidade de passagens disponiveis
            Lbl_Passagens3.Text = "Disponivel:" + (d3 - q3);//Indica o restante de passagens  disponiveis de cada viagem
            Total();//Usando o metodo total
            Totalpassa();
        }

        private void Num_4_ValueChanged(object sender, EventArgs e)
        {
            q4 = Num_4.Value;//Recebe a quantidade de passagens disponiveis
            Lbl_Passagens4.Text = "Disponivel:" + (d4 - q4);//Indica o restante de passagens  disponiveis de cada viagem
            Total();//Usando o metodo total
            Totalpassa();
        }

        private void Chk_Pacote1_CheckedChanged(object sender, EventArgs e)
        {
            fortaleza = 580;//Valor da passagem
            d1 = 50;//Quantidade de passagens

            if (Chk_Pacote1.Checked == true)
            {
                Lbl_Destino1.Text = "Fortaleza";//Muda o nome destino para Fortaleza 
                Pic_Image1.Image = Properties.Resources.Fortaleza;//Aparece a imagens de fortaleza
                Lbl_Passagens1.Text = "Disponivel:"+d1;//Quantidade de passagens disponiveis
                ListDestino.Items.Add("Fortaleza");//Adicona o nome Fortaleza na lista
                ListPreco.Items.Add(fortaleza);//Adiciona o preço da passagem na lista
                Num_1.Visible = true;// Mostra a quantidade de passagens
                Num_1.Maximum = d1;//Limita o estoque com o valor da variavel

            }
            else
            {

                Lbl_Destino1.Text = "Destino";//Volta o nome Fortaleza para Destino
                Pic_Image1.Image = Properties.Resources.Nacional;//tira a imagem de fortaleza e volta para a padrão
                Lbl_Passagens1.Text = "Passagens";//Volta a quantidade de passagens disponiveis para passagem
                ListDestino.Items.Remove("Fortaleza");//Deleta o nome Fortaleza da lista
                ListPreco.Items.Remove(fortaleza);//Remove o preço da passagem na lista
                Num_1.Visible = false;//Desaparece a quantidade de passagens
                Num_1.Value = 0;//Zera o estoque
            }
        }

        private void Chk_Pacote4_CheckedChanged(object sender, EventArgs e)
        {
            Milao = 3871; //Valor da Passagem
            d4 = 50; //Quantidade de passagens

            if (Chk_Pacote4.Checked == true)
            {
                Lbl_Destino4.Text = "Milão";//Muda o nome destino para Milao 
                Pic_Image4.Image = Properties.Resources.Milao;//Aparece a imagens de Milão
                Lbl_Passagens4.Text = "Disponivel:"+d4;//Quantidade de passagens disponiveis
                ListDestino.Items.Add("Milão");//Adiciona o nome MIlão na lista
                ListPreco.Items.Add(Milao);//Adiciona o preço da passagem na lista
                Num_4.Visible = true;// Mostra a quantidade de passagens
                Num_4.Maximum = d4;//Limita o estoque com o valor da variavel
            }
            else
            {
                Lbl_Destino4.Text = "Destino";//Volta o nome Milao para Destino
                Pic_Image4.Image = Properties.Resources.Internacional;//tira a imagem de Milão e volta para a padrão
                Lbl_Passagens4.Text = "Passagens";//Volta a quantidade de passagens disponiveis para passagem
                ListDestino.Items.Remove("Milão");//Remove nome Milão da lista
                ListPreco.Items.Remove(Milao);//Remove o preço da passagem na lista
                Num_4.Visible = false;//Desaparece a quantidade de passagens
                Num_4.Value = 0;//Zera o estoque
            }
        }

        private void Chk_Pacote3_CheckedChanged(object sender, EventArgs e)
        {
            Paris = 3845;//Valor da passagem
            d3 = 50;//Quantidade de passagens

            if (Chk_Pacote3.Checked == true)
            {
                Lbl_Destino3.Text = "Paris";//Muda o nome destino para Paris
                Pic_Image3.Image = Properties.Resources.Paris;//Aparece a imagens de Paris
                Lbl_Passagens3.Text = "Disponivel:"+d3;//Quantidade de passagens disponiveis
                ListDestino.Items.Add("Paris");//Adiciona o nome Paris na lista
                ListPreco.Items.Add(Paris);//Adiciona o preço da passagem na lista
                Num_3.Visible = true;// Mostra a quantidade de passagens
                Num_3.Maximum = d3;//Limita o estoque com o valor da variavel
            }
            else
            {
                Lbl_Destino3.Text = "Destino";//Volta o nome Paris para Destino
                Pic_Image3.Image = Properties.Resources.Internacional;//tira a imagem de Paris e volta para a padrão
                Lbl_Passagens3.Text = "Passagens";//Volta a quantidade de passagens disponiveis para passagem
                ListDestino.Items.Remove("Paris");//Remove o valor de Milão na lista
                ListPreco.Items.Remove(Paris);//Remove o preço da passagem na lista
                Num_3.Visible = false;//Desaparece a quantidade de passagens
                Num_3.Value = 0;//Zera o estoque
            }
        }
        private void Total()//Criando um metodo para calcular o valor das passagens mais a quantidade de passagens compradas
        {
            Lbl_ResultadoPaga.Text = ((fortaleza * q1) + (PortoSeguro * q2) + (Paris * q3) + (Milao * q4)).ToString("C2");
        }

        private void Totalpassa()
        {
            Lbl_Totalpassa.Text = Convert.ToString(Num_1.Value + Num_2.Value + Num_3.Value + Num_4.Value);//Mostra o total de passagens compradas
        }

        private void Chk_Pacote2_CheckedChanged(object sender, EventArgs e)
        {
            PortoSeguro = 528;
            d2 = 50;

            if (Chk_Pacote2.Checked == true)
            {

                Lbl_Destino2.Text = "Porto Seguro";//Muda o nome destino para Porto Seguro
                Pic_Image2.Image = Properties.Resources.PortoSeguro;//Aparece a imagens de Porto Seguro
                Lbl_Passagens2.Text = "Disponivel:"+d2;//Quantidade de passagens disponiveis
                ListDestino.Items.Add("Porto Seguro");//Adiciona o valor de Porto Seguro na lista
                ListPreco.Items.Add(PortoSeguro);//Adiciona o preço da passagem na lista
                Num_2.Visible = true;// Mostra a quantidade de passagens
                Num_2.Maximum = d2;//Limita o estoque com o valor da variavel
            }
            else
            {
                Lbl_Destino2.Text = "Destino";//Volta o nome Porto Seguro para Destino
                Pic_Image2.Image = Properties.Resources.Nacional;//tira a imagem de Porto Seguro e volta para a padrão
                Lbl_Passagens2.Text = "Passagens";//Volta a quantidade de passagens disponiveis para passagem
                ListDestino.Items.Remove("Porto Seguro");//Remove o valor de Porto Seguro na lista
                ListPreco.Items.Remove(PortoSeguro);//Remove o preço da passagem na lista
                Num_2.Visible = false;//Desaparece a quantidade de passagens
                Num_2.Value = 0;//Zera o estoque
            }
        }
    }
}