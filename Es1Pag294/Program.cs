using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1Pag294
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int max = 1000;
            int min = int.MinValue;
            int n = 30;
            List<int> lista = new List<int>();
            List<int> Npari = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lista.Add (random.Next(min, max));
                if (lista[i] % 2 == 0)
                    Npari.Add(lista[i]);
            }
        }
    }
}
