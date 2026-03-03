using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Interfaces;
public interface IAlugar
{
    abstract void Alugar();
    void DevolverAluguel();
}
