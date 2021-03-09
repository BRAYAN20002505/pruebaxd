using arbolsimple.clases.JuegoAnimal;
using System;
using System.Collections;
namespace arbolsimple
{
    class Program
    {
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquierdo());
                preorden(r.subarbolDerecho());

            }

        }

        public static void indorden(Nodo r)
        {
            if (r != null)
            {
                indorden(r.subarbolIzquierdo());
                r.visitar();
                indorden(r.subarbolDerecho());
            }
        }

        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }


    //    public static void ()

    //        try
    //        {

    //            ArbolBinario arbol;
    //    Nodo a1, a2, a;
    //    Stack pila = new Stack();
    //    a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
    //            a2 = ArbolBinario.nuevoArbol(null, "Fabrizio", null);
    //            a = ArbolBinario.nuevoArbol(a1, "Gaby", a2);
    //            pila.Push(a);//apilar
    //            a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
    //            a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
    //            a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
    //            pila.Push(a);//apilar

    //            a1 = (Nodo) pila.Pop();
    //    a2 = (Nodo) pila.Pop();

    //    a = ArbolBinario.nuevoArbol(a1, "Hector", a2);
    //            arbol = new ArbolBinario(a);


    //    Console.WriteLine("preorden");
    //            preorden(a);

    //    Console.WriteLine("postorden");
    //            postorden(a);
    //    Console.WriteLine("inorden");
    //            indorden(a);

    //}
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Ups hubo un error!" + ex.Message);
    //        }


        static void juegoAnimales()
        {
            Console.WriteLine("juguemos a adivinar animales");
            Boolean otroJuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {
                juego.jugar();
                Console.WriteLine("jugamos otra vez");
                otroJuego = juego.respuesta();

            } while (otroJuego);
        }
static void Main(string[] args)
        {
            juegoAnimales();
        }
    }
}
