using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models;
public class Usuario
{
    public string Nome { get; set; }

    public int Idade { get; set; }

    public List<ItemBiblioteca> ItensEmprestadosOuAlugados { get; set; } = [];

}
