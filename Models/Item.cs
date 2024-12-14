using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Models
{
    public class Item
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public bool Comprado { get; set; }

        public Item(string nome, int quantidade, double preco)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome do item não pode ser nulo ou vazio!");
            }

            if (quantidade <= 0)
            {
                throw new ArgumentException("Quantidade do item deve ser maior que zero!");
            }

            if (preco < 0)
            {
                throw new ArgumentException("Preço do item não pode ser negativo!");
            }

            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
            Comprado = false;

        }

        public void MarcarComoComprado() //método para marcar o item como comprado
        {
            Comprado = true;
        }

        public void DesmarcarComoComprado()//método para desmarcar o item como comprado
        {
            Comprado = false;
        }

       
        public String ExibirItem()//método para exibir o item, o C2 é uma formatação para exibir o preço em moeda
        {//esta definido como String para que o método retorne uma string em vez de imprimir na tela

            string status = Comprado ? "Sim" : "Não"; //aqui, estou criando uma variável status que recebe "Sim" se o item estiver comprado e "Não" se não estiver

            return $"Nome: {Nome} - Quantidade: {Quantidade} - Preço: {Preco:C2} - Comprado: {status}";
        }

    }
}
