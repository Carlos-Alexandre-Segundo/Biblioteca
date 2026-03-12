using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            case 4:
                ConsultaDeItens();
                break;
            default: 
                Console.WriteLine("fds = fim de semana");
                break;
        }
        BoasVindas();

        
    }
    public static List<Usuario> usuariosCadastrados { get; set; } = [];
    public static void CadastrarUsuarios()
    {

        Console.Clear();
        Console.WriteLine("Qual seu nome");
        var NomeDoNovoUser = Console.ReadLine();


        Console.Clear();
        Console.WriteLine("Qual a tua idade");
        var IdadeDoNovoUser = int.Parse(Console.ReadLine());


        var User = new Usuario()
        {
            Idade = IdadeDoNovoUser,
            Nome = NomeDoNovoUser
        };

        usuariosCadastrados.Add(User);
        Console.WriteLine("Usuário cadastrado com sucesso");
    }

    public static List<Dvd> dvdCadastrado { get; set; } = [];

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

        dvdCadastrado.Add(dvd);
        Console.Clear();
        Console.WriteLine($"Dvd cadastrado com sucesso!");
    }


    public static void EmprestarItens()
    {
        Console.Clear();
        Console.WriteLine("Essa é a nossa lista de DVDs:");
        Console.WriteLine();

        bool encontrouDvd = false;

        for (int i = 0; i < dvdCadastrado.Count; i++)
        {

            var item = dvdCadastrado[i];

            if (item is Dvd dvd)
            {
                Console.WriteLine($"DVD {i + 1}:");
                Console.Write($"Título: {dvd.Titulo}");
                Console.WriteLine();
                encontrouDvd = true;
            }                
        }

        if (!encontrouDvd)
        {        
            Console.WriteLine("Não foi encontrado nenhum item");            
            Console.WriteLine("Aperte alguma tecla para continuar");
            Console.ReadLine();
            return;
        }


        Console.Clear();
        Console.WriteLine("Agora selecione qual dvd você deseja pegar emprestado");
    }
    public static void ConsultaDeItens()
    {
        Console.Clear();
        Console.WriteLine("Essa é a nossa lista de itens:");
        Console.WriteLine();

        bool listaitens = false;

        for (int i = 0; i < Repository.itemBibliotecas.Count; i++)
        {
            var itensDaBiblioteca = Repository.itemBibliotecas[i];

            if(itensDaBiblioteca is Dvd dvd)
            {

                Console.WriteLine($"Item {i + 1}:");
                Console.WriteLine($"Dvd : {dvd.Titulo}");
                Console.WriteLine();
                listaitens = true;
            }
        }
        
        if (!listaitens)
        {
            Console.WriteLine("Não foi encontrado nenhum item na lista");
        }
        Console.WriteLine("Aperte alguma tecla para continuar");
        Console.ReadLine();
    }

}
