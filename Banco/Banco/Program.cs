
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;
using Banco.Titular;
using Banco.Filtrar;
using System.Reflection;


namespace Banco
{
    class ClasseBanco
    {
        static void Main(string[] args)
        {
            ContaCorrente filtro = new ContaCorrente();

            Type tipo = typeof(ContaCorrente);

            if (!tipo.IsAbstract)
            {
                Console.WriteLine("Classe ContaCorrente tem os seguintes construtores: ");
                filtro.ImprimeConstrutores(tipo);
            }

            //Imprime todos os metodos
            filtro.ImprimeMetodos(tipo);

            //Imprime todas as propriedades
            filtro.ImprimePropriedades(tipo);

            //Imprime todos os campos
            //filtro.ImprimeCampos(tipo);

            //Imprime todos as interfaces
            //filtro.ImprimeInterfaces(tipo);

            //Imprime os atributos
            filtro.ImprimeAtributos(tipo);

            Console.ReadLine();


        }
    }
}
