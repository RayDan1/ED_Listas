using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    public class Listas
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Listas()
        {
            nodoInicial = new Nodo();
            nodoInicial.Enlace = nodoInicial;
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.Enlace == nodoInicial);

        }
        public void Vaciar()
        {
            nodoInicial.Enlace = nodoInicial;
        }
        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.Enlace != nodoInicial)
            {
                nodoActual = nodoActual.Enlace;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {
           
            nodoActual = nodoInicial;
            while (nodoActual.Enlace != nodoInicial)
            {
                nodoActual = nodoActual.Enlace;
            }
            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.Enlace = nodoNuevo;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Enlace != nodoInicial)
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
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
                while (nodoBusqueda.Enlace != nodoInicial)
                {
                    nodoBusqueda = nodoInicial.Enlace;
                    Indice++;
                    if (Indice == Indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarAnterior(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Enlace != nodoInicial && nodoBusqueda.Enlace.Valor != dato)
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    if (nodoBusqueda.Enlace.Valor == dato)
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
                if (nodoActual != nodoInicial)
                {
                    Nodo nodoAnterior = BuscarAnterior(dato);
                    nodoAnterior.Enlace = nodoActual.Enlace;
                    nodoActual.Enlace = null;
                }
            }
        }
    }
}
