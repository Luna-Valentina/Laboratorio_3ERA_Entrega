using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3ERA_Entrega
{
    public  class Parametros
    {
        public string Key { get; set; }
        public string Valor { get; set; }

        public Parametros(string key, string valor)
        {
            Key = key;
            Valor = valor;
        }


    }
}
