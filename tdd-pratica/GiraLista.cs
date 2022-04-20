using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_pratica
{
    public class GiraLista
    {
        public int[] Girar(int[] lista)
        {
            var item1 = lista[1];

            return new int[] {item1, 0, 0, 0};
        }
    }
}
