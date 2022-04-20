using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_pratica
{
    public class GiraLista
    {
        public List<int> Girar(List<int> lista)
        {
            var nova = new List<int>();
            nova.AddRange(lista);
            nova.Add(lista[0]);
            nova.RemoveAt(0);
            return nova;
        }
    }
}
