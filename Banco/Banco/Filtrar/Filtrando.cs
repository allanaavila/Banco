using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Filtrar
{
    internal class Filtrando
    {
        //Método para imprimir todos os construtores da classe
        public static void ImprimeConstrutores(Type pTipo)
        {
            Console.WriteLine("Imprimindo os Construtores da Classe System.Type");
            Console.WriteLine(" ");

            ConstructorInfo[] construtores = pTipo.GetConstructors();

            Console.WriteLine("Existe(m)" + construtores.Length + " construtores.");
            Console.WriteLine(" ");

            foreach(ConstructorInfo construtor in construtores)
            {
                Console.WriteLine("Nome = " + construtor.Name);
                ParameterInfo[] parametros = construtor.GetParameters();

                if(parametros.Length > 0)
                {
                    Console.WriteLine("parametros do construtor");

                    foreach(ParameterInfo parametro in parametros)
                    {
                        Console.WriteLine("Posição: " + parametro.Position);
                        Console.WriteLine("Nome: " + parametro.Name);
                        Console.WriteLine("Tipo: " + parametro.GetType());
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("========================================== ");
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
