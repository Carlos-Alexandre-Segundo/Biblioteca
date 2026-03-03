using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models;
public abstract class ItemBiblioteca : IAlugar, IEmprestar
{
    public string Titulo { get; set; }
    public int AnoDeLancamento { get; set; }
    public bool Disponivel { get; protected set; }

    public abstract string ObterDescricao();

   

    public abstract void Alugar();
    
    public abstract void DevolverAluguel();

    public abstract void Emprestar();

    public abstract void DevolverEmprestimo();
}
