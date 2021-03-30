using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        //Método Genérico
        public static void AddVarios<T>(this List<T> lista , params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void Teste()
        {
            List<int> idades = new List<int>();

            idades.AddVarios(3, 2, 4);

            //ListExtensoes<int>.AddVarios(idades, 2, 3, 4);

            List<string> nomes = new List<string>();
            nomes.AddVarios("Marcos", "Lucas", "Felipe");

           // ListExtensoes<string>.AddVarios(nomes,"Lucas", "Marcos", "João");
        }
    }
}
