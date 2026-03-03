using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models;
public class Dvd : ItemBiblioteca
{
    public TimeSpan Duracao { get; set; }
    public string Diretor {  get; set; }

    public Dvd(string titulo, string diretor, int anoDeLancamento, TimeSpan duracao)
    {
        Titulo = titulo;
        Diretor = diretor;
        AnoDeLancamento = anoDeLancamento;
        Duracao = duracao;
        Disponivel = true;
    }

    public override void Alugar()
    {
       
    }

    public override void DevolverAluguel()
    {
        
    }

    public override void Emprestar()
    {
        
    }
    

    public override void DevolverEmprestimo()
    {
        
    }

    public override string ObterDescricao()
    {
       return $"O DVD {Titulo}, foi lançado em {AnoDeLancamento} e se encontra {(Disponivel ? "Disponivel":"Indisponível")}";
    }
}
