using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Models
{
    public class ListaDeCompras
    {
        public string Nome { get; set; }
        public List<Item> Itens { get; set; } //aqui, estou criando o atributo Itens que é uma lista de itens

        public ListaDeCompras(string nome)
        { //construtor da classe ListaDeCompras

            if (string.IsNullOrWhiteSpace(nome)) //Verificando se o nome da lista de compras é nulo ou vazio
            {
                throw new ArgumentException("Nome da lista de compras não pode ser nulo ou vazio!"); //metodo de exceção caso o nome seja nulo ou vazio
            }

            Nome = nome;
            Itens = new List<Item>(); //Inicializando a lista de itens para que ela não seja nula
        }

        public String AdicionarOuIncrementarItem(Item item)
        { //Aqui eu estou criando o método AdicionarItem, que recebe um item como parâmetro

            if(item == null) //Condicional para verificar se o item é nulo
            {
                throw new ArgumentException("Item não pode ser nulo!"); //Exceção caso o item seja nulo
            }

            

            var itemExistente = Itens.FirstOrDefault(i => i.Nome.Equals(item.Nome, StringComparison.OrdinalIgnoreCase));
            //Éssa linha é uma condicional que verifica se o item já existe na lista de itens, o StringComparison.OrdinalIgnoreCase é para ignorar a diferença entre letras maiúsculas e minúsculas

            var mensagem = ""; //armazenar a mensagem de sucesso

            //se o var itemExistente não encontrar item na lista, a variável itemExistente será atribuída como nula, por isso o if abaixo:
            if (itemExistente != null) //se o for diferente de nulo, o item já existe na lista
            {
                itemExistente.Quantidade += item.Quantidade; //Se o item já existir na lista, a quantidade do item será incrementada
                mensagem = $"Item {item.Nome} já existe na lista, quantidade atualizada para {itemExistente.Quantidade}"; //mensagem de sucesso
            }
            else
            { //se o item não existir na lista

                Itens.Add(item); //Adicionando o item na lista de itens
                mensagem = $"Item {item.Nome} adicionado com sucesso!"; //mensagem de sucesso

            }

            return mensagem; //retornando a mensagem de sucesso
        }

        public void RemoverItem(Item item)
        { //aqui estou criando o método RemoverItem, que recebe um item como parâmetro

            if (Itens.Contains(item))//Condicional pra casos onde o item não está na lista
            {
                Itens.Remove(item);
                Console.WriteLine($"Item {item.Nome} removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Item {item.Nome} não encontrado na lista!"); //mensagem caso o item não seja encontrado
            }

        }

        public void ExibirLista()
        { //aqui estou criando o método ExibirLista

            if (Itens.Count == 0)
            {
                Console.WriteLine("Lista vazia!"); //verificação se a lista de itens está vazia e exibindo uma mensagem caso esteja
                return;
            }

            Console.WriteLine($"Lista de compras: {Nome}"); //Nome da lista

            int contador = 1; //aqui, estou criando uma variável contador, que será usada para exibir o número do item no foreach

            foreach (var item in Itens) //o var é um tipo de variável que o compilador infere o tipo, nesse caso, ele está inferindo que o tipo é Item
            
            {
                //uso o foreach pra percorrer a lista de itens e exibindo cada item
                Console.WriteLine($"{contador}. Item: {item.Nome} - Quantidade: {item.Quantidade} - Preço: {item.Preco} - Comprado: {(item.Comprado ? "Sim" : "Não")}");
                contador++;
            }


        }
    }
}
