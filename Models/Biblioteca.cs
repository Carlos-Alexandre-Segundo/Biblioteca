using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models;
public class Biblioteca
{
    public List<ItemBiblioteca> Catalogo { get; set; } = [];

    public void CadastrarItens(ItemBiblioteca itemBiblioteca)
    {
        Catalogo.Add(itemBiblioteca);
        Console.WriteLine("Produto cadastro");
    }
}