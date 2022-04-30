// See https://aka.ms/new-console-template for more information

using ListaDoblementeLigada;

Listas listas = new Listas();
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");

Nodo nodoTres=listas.Buscar("Tres");
Console.WriteLine("Buscando nodo Tres");
Console.WriteLine(nodoTres.NodoAnterior.Valor);


Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("Buscando nodo Dos");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine("Borrando Dos");
Console.WriteLine(nodoDos.Valor);
listas.BorrarNodo("Dos");
Console.WriteLine(nodoDos.Valor);
nodoTres = listas.Buscar("Tres");
Console.WriteLine("Anterior de Nodo Tres despues de borrar el Nodo Dos");
Console.WriteLine(nodoTres.NodoAnterior.Valor);
Console.WriteLine(listas.RecorrerLista());

return;