using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeLigada
{
    public class Listas
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Listas()
        {
            nodoInicial = new Nodo();
            nodoActual = nodoInicial;

        }
        public bool ValidaVacio()
        {
            return (nodoInicial.NodoSiguiente == null);

        }
        public void Vaciar()
        {
            nodoInicial.NodoSiguiente = null;
        }
        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.NodoSiguiente != null)
            {
                nodoActual = nodoActual.NodoSiguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.NodoSiguiente != null)
            {
                nodoActual = nodoActual.NodoSiguiente;
            }
            Nodo nodoNuevo = new Nodo(dato, nodoActual);
            nodoActual.NodoSiguiente = nodoNuevo;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.NodoSiguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.NodoSiguiente;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.NodoSiguiente != null)
                {
                    nodoBusqueda = nodoInicial.NodoSiguiente;
                    Indice++;
                    if (Indice == Indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
       
        public void BorrarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(dato);
                if (nodoActual != null)
                {
                    Nodo nodoAnterior = nodoActual.NodoAnterior;
                    nodoAnterior.NodoSiguiente = nodoActual.NodoSiguiente;
                    nodoActual.NodoSiguiente = null;
                    nodoActual.NodoAnterior = null;
                }
            }
        }
    }
}
    

