using ClassesAbstratasESeladas.Abstract;
using ClassesAbstratasESeladas.Sealed;
using System;

namespace ClassesAbstratasESeladas
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplos abstratos
            var cliente = new ClienteEntity();
            cliente.DataCriacao = DateTime.Now;

            //exemplos sealed
            var request = new ProdutoRequest();
            var rbase = new RequestBase();            
        }
    }
}
