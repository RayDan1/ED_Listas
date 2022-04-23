using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeLigada
{
    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo nodoAnterior { get; set; }
        public Nodo nodoSiguiente { get; set; }
    }
}
