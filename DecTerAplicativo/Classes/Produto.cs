using System;
using System.Collections.Generic;
using System.Globalization;

namespace DecTerAplicativo.Classes
{
    class Produto
    {

        // Properties "Variáveis"
        public string Nome { get; set; }
        //public int Id { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        // Constructor
        public Produto() { }

        // Methods - "Funções"

        // CRUD - C
        public void CriaProduto()
        {
            Console.WriteLine("Insira o nome do produto: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Insira o valor do produto: ");
            Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade em estoque: ");
            Quantidade = int.Parse(Console.ReadLine());
        }

        // CRUD - R 
        public void MostraProduto()
        {
            Console.Clear();
            Console.WriteLine("-----Produto-----");
            Console.WriteLine($"Nome: {Nome} || Preço: R$ {Valor} || Quantidade em Estoque: ${Quantidade}");
        }

        // CRUD - U
        public void RemoveQuantidade()
        {
            Console.Clear();
            Console.WriteLine("Quantas unidades serão removidas?");
            int n = int.Parse(Console.ReadLine());
            Quantidade -= n;
        }

        // CRUD - U
        public void AdicionaQuantidade()
        {
            Console.Clear();
            Console.WriteLine("Quantas unidades serão adicionadas?");
            int n = int.Parse(Console.ReadLine());
            Quantidade += n;
        }

        // CRUD - U
        public void AtualizaProduto()
        {
            Console.Clear();
            string option = "";
            while (option != "N" || option != "P" || option != "Q" || option != "C")
            {
                Console.WriteLine("Qual propriedade será atualizada?");
                Console.WriteLine("(N) - Nome || (P) - Preço || (Q) - Quantidade || (C) - Cancelar");
                option = Console.ReadLine().ToUpper();
                option = option.ToUpper();
                switch (option)
                {
                    case "N":
                        Console.Clear();
                        Console.WriteLine($"Insira novo nome (atual:{Nome}):");
                        Nome = Console.ReadLine();
                        break;
                    case "P":
                        Console.Clear();
                        Console.WriteLine($"Insira novo preço (atual: R${Valor}):");
                        Valor = double.Parse(Console.ReadLine());
                        break;
                    case "C":
                        break;
                }
            }
        }

        // CRUD - D
        public void DeletaProduto()
        {
            string option = "";
            while (option != "SIM" || option != "NÃO")
            {
                Console.Clear();
                Console.WriteLine("Tem certeza?");
                option = Console.ReadLine().ToUpper();
                if (option == "SIM")
                {
                    Nome = null;
                    Valor = 0;
                    Quantidade = 0;
                }
            }
        }
    }
}
