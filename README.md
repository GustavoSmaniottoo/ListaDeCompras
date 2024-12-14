
# 🛒 Lista de Compras

## 📘 Descrição do Projeto
Este projeto consiste em uma aplicação de console que simula uma lista de compras. O objetivo é permitir que o usuário crie uma lista de compras, adicione itens, remova itens e exiba a lista completa. O projeto foi desenvolvido com foco no aprendizado de **C#**, **POO** e **boas práticas de programação**.

---

## 🚀 Funcionalidades
- **Criar uma lista de compras**: O usuário pode criar uma lista com um nome personalizado.
- **Adicionar ou incrementar um item na lista**: Caso o item já exista, a quantidade é incrementada.
- **Remover um item da lista**: Permite a remoção de itens existentes na lista.
- **Exibir a lista de compras**: Exibe todos os itens da lista de compras, incluindo nome, quantidade, preço e se o item foi comprado.
- **Salvar lista de compras em um arquivo JSON**: Permite salvar o estado atual da lista de compras.
- **Carregar lista de compras a partir de um arquivo JSON**: Carrega uma lista de compras previamente salva.

---

## 📦 Estrutura do Projeto

```
ListaDeCompras/
 ┣ 📂Models
 ┃ ┣ 📄 Item.cs
 ┃ ┗ 📄 ListaDeCompras.cs
 ┣ 📂Data
 ┣ 📂Services
 ┣ 📂bin/
 ┣ 📂obj/
 ┣ 📜 .gitignore
 ┣ 📜 README.md
 ┗ 📜 Program.cs
```

As pastas **Models**, **Data** e **Services** já estão criadas para organizar melhor o código e a lógica do sistema.

---

## 📘 Explicação das Classes

### 🗂️ **Classe `ListaDeCompras`**
A classe `ListaDeCompras` é responsável por gerenciar os itens de uma lista de compras.  

**Atributos:**
- **`Nome`**: Representa o nome da lista de compras.  
- **`Itens`**: Lista de objetos do tipo `Item`, que armazena todos os itens adicionados à lista.  

**Métodos:**
- **`ListaDeCompras(string nome)`**: Construtor que define o nome da lista e inicializa a lista de itens.  
  - Se o nome for nulo ou vazio, uma exceção é lançada.  
  - A lista de itens é inicializada para evitar valores nulos.  

- **`AdicionarOuIncrementarItem(Item item)`**: Adiciona um novo item ou incrementa a quantidade se o item já existir na lista.  

- **`RemoverItem(Item item)`**: Remove um item específico da lista.  

- **`ExibirLista()`**: Exibe todos os itens da lista.  

---

## 📈 Status do Desenvolvimento

### 🗂️ **Classe Item**
- [x] Criar a classe `Item`
- [x] Validação do nome no construtor
- [x] Validação da quantidade no construtor
- [x] Validação do preço no construtor
- [x] Método `MarcarComoComprado`
- [x] Método `DesmarcarComoComprado`
- [x] Método `ExibirItem`

### 🗂️ **Classe ListaDeCompras**
- [x] Criar a classe `ListaDeCompras`
- [x] Construtor com nome e inicialização de lista
- [x] Método `AdicionarOuIncrementarItem`
- [x] Validação de item nulo no método `AdicionarOuIncrementarItem`
- [x] Verificação de duplicados no método `AdicionarOuIncrementarItem`
- [ ] **Método `RemoverItem` (em andamento)**
- [ ] **Método `ExibirLista` (em andamento)**
- [ ] Método `SalvarListaJSON`
- [ ] Método `CarregarListaJSON`
- [ ] Método `BuscarItemPorNome`
- [ ] Método `OrdenarItensPorNome`
- [ ] Método `OrdenarItensPorQuantidade`
- [ ] Método `ExibirItensComprados`
- [ ] Método `ExibirItensNaoComprados`
- [ ] Método `LimparLista` (remover todos os itens da lista)

### 🗂️ **Classe Service (Futura)**
- [ ] Serviço de **Persistência de Dados** (para salvar e carregar a lista JSON)
- [ ] Serviço de **Validação de Dados** (separar as validações de campos em um serviço)

### 🗂️ **Classe Data (Futura)**
- [ ] Configuração de **arquivo de dados** para salvar listas de compras
- [ ] Definição de **diretórios de armazenamento**

---

## 🔥 Conceitos Aplicados
- **POO (Programação Orientada a Objetos)**
  - Criação de **Classes** para organizar os objetos (`Item`, `ListaDeCompras`, `Service` e `Data`).  
  - Uso de **Construtores** para inicializar os atributos das classes.  
  - Uso de **Encapsulamento** com as propriedades `Nome` e `Itens`, garantindo que os atributos sejam protegidos.  
  - Uso de **Métodos** para adicionar, remover e exibir os itens.  

- **Boas Práticas de Programação**
  - **Tratamento de exceções**: O método `ListaDeCompras` verifica se o nome da lista é nulo ou vazio e lança uma exceção.  
  - **Uso de variáveis descritivas**: Variáveis e métodos possuem nomes claros e objetivos, facilitando a manutenção do código.  

- **Princípio de Responsabilidade Única (SRP)**
  - Cada método tem uma única responsabilidade, como **adicionar um item**, **remover um item** ou **exibir a lista**.  

---

## 🧪 Exemplos de Uso

### **Exemplo 1 - Criar uma lista de compras**
O usuário cria uma lista chamada **"Compras do Mês"**.  

---

### **Exemplo 2 - Adicionar um novo item à lista**
O usuário adiciona o item **"Arroz"** com quantidade **2**.  

---

### **Exemplo 3 - Adicionar um item que já existe na lista**
O usuário adiciona o item **"Arroz"** com quantidade **3**.  

---

### **Exemplo 4 - Remover um item da lista**
O usuário remove o item **"Arroz"**.  

---

### **Exemplo 5 - Exibir a lista de compras**
O usuário solicita para exibir a lista.  

---

## 📘 Como Executar o Projeto

**Pré-requisitos:**  
- .NET 6 ou superior instalado na máquina.  

**Para executar o projeto, siga os passos abaixo:**

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/ListaDeCompras.git

# Acesse a pasta do projeto
cd ListaDeCompras

# Execute o projeto
dotnet run
```

---

## 🤝 Contribuições
Contribuições são bem-vindas! Para contribuir, siga os passos:  

1️⃣ Faça um fork do repositório.  
2️⃣ Crie uma nova branch:  
```bash
git checkout -b minha-feature
```
3️⃣ Faça suas alterações e crie um commit:  
```bash
git commit -m "Adicionando nova funcionalidade X"
```
4️⃣ Envie suas alterações:  
```bash
git push origin minha-feature
```

---
