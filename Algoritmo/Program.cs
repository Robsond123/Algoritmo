using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Teste teste = new Teste();

            teste.InitialValues();

            var a = teste.compannies.OrderBy(x => x.TimeSpentVisiting).ToList();

            foreach (var item in a)
            {
              Console.WriteLine(item.TimeSpentVisiting);
            }
            
            Console.ReadKey();

        }
    }


   
}
