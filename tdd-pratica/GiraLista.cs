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
            var item0 = lista[0];
            var item1 = lista[1];
            var item2 = lista[2];
            var item3 = lista[3];

            return new int[] {item1, item2, item3, item0 };
        }
    }
}
