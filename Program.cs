using System;
namespace indices
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Texto de teste";
            //MÉTODOS COM MESMA FUNCIONALIDADE DO JS.
            Console.WriteLine(texto.IndexOf("f"));//RETORNA -1 (NÃO HOUVE OCORRÊNCIA)
            Console.WriteLine(texto.LastIndexOf("e"));//RETORNA 13 (ÚLTIMA OCORRÊNCIA)
        }
    }
}
