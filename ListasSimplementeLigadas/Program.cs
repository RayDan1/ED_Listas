using ListasSimplementeLigadas;

Lista listas = new Lista();
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("Buscando nodo Dos");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine("Borrando Dos");
Console.WriteLine(nodoDos.Valor); 
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());
