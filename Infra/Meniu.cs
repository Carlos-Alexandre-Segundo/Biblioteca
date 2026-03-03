using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra;
public static class Meniu
{
    public static void BoasVindas()
    {
        Console.Clear();
        Console.WriteLine("Olá");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine($"\n1 - CADASTRO DE USUÁRIO");
        Console.WriteLine($"\n2 - CADASTRO DE DVD");
        Console.WriteLine($"\n3 - EMPRESTAR DVD");
        Console.WriteLine($"\n4 - LISTA DE ITENS");

        
        var Resposta = int.Parse(Console.ReadLine());

        switch (Resposta){
            case 1: 
                CadastrarUsuarios(); 
                break;
            case 2:
                CadastroDvds();
                break;
            case 3:
                EmprestarItens();
                break;
            //case 4:
            //    ConsultaDeItens();
            //    break;
            default: 
                Console.WriteLine("fds");
                break;
        }
        BoasVindas();

        
    }
    public static void CadastrarUsuarios()
    {
        Console.Clear();
        Console.WriteLine("Qual teu nome");

        var NomeDoNovoUser = Console.ReadLine();

        Console.WriteLine("Qual a tua idade");

        var IdadeDoNovoUser = int.Parse(Console.ReadLine());

        var User = new Usuario()
        {
            Idade = IdadeDoNovoUser,
            Nome = NomeDoNovoUser
        }; 

        Repository.Usuarios.Add(User);

        Console.WriteLine("Usuário cadastrado com sucesso");
    }
    public static void CadastroDvds()
    {
        Console.Clear();
        Console.WriteLine($"Qual o nome do DVD ?");

        var NomeDoDVD = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Qual o nome do diretor do DVD");

        var NomeDiretor = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Qual o ano do lançamento ?");

        var AnoDoLancamento = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine($"Quantos minutos de duração tem o DVD ?");

        var TempoDeDuracao = TimeSpan.Parse(Console.ReadLine());

        var dvd = new Dvd(NomeDoDVD, NomeDiretor, AnoDoLancamento, TempoDeDuracao)
        {
            Titulo = NomeDoDVD,
            Diretor = NomeDiretor,
            AnoDeLancamento = AnoDoLancamento,
            Duracao = TempoDeDuracao
        };

        Repository.itemBibliotecas.Add(dvd);

        Console.Clear();
        Console.WriteLine($"Dvd cadastrado com sucesso!");

    }

    public static void EmprestarItens()
    {
        Console.WriteLine($"Selecione o DVD que você deseja pegar emprestado");

        for (int i = 0; i < Repository.itemBibliotecas.Count; i++)
        {

            var item = Repository.itemBibliotecas[i];

            if (item is Dvd dvd)
            {
                Console.WriteLine($"DVD {i + 1}:");
                Console.WriteLine($"Título: {dvd.Titulo}");
                Console.WriteLine($"Diretor: {dvd.Diretor}");
                Console.WriteLine($"Ano de lançamento: {dvd.AnoDeLancamento}");
                Console.WriteLine($"Tempo de duração em minutos: {dvd.Duracao}");
                Console.WriteLine($"Disponibilidade:{dvd.Disponivel}");
            }
            else 
            {
                Console.WriteLine($"Não foi encontrado nenhum item");
            }        
        }
    }
}
