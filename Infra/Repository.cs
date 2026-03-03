using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra;
public static class Repository
{
    public static List<Usuario> Usuarios { get; set; } = [];

    public static List<ItemBiblioteca> itemBibliotecas { get; set; } = [];

    public static List<Models.Biblioteca> Bibliotecas { get; set; } = [];
}
