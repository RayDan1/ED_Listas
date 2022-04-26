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
        public Nodo NodoAnterior { get; set; }
        public Nodo NodoSiguiente { get; set; }
        
        public Nodo(string valor = "", Nodo nodoanterior = null, Nodo nodosiguiente = null)
        {
            Valor = valor;
            NodoAnterior = nodoanterior;
            NodoSiguiente = nodosiguiente;
        }
    }
}
