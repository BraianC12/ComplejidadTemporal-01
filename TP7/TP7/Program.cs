namespace TP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo<string> zona = new Grafo<string>();

            Vertice<string> baseRescate = new Vertice<string>("Base de rescate");
            Vertice<string> A = new Vertice<string>("Puesto A");
            Vertice<string> B = new Vertice<string>("Puesto B");
            Vertice<string> C = new Vertice<string>("Puesto C");
            Vertice<string> D = new Vertice<string>("Puesto D");
            Vertice<string> objetivo = new Vertice<string>("Objetivo");


            zona.agregarVertice(baseRescate);
            zona.agregarVertice(A);
            zona.agregarVertice(B);
            zona.agregarVertice(C);
            zona.agregarVertice(D);
            zona.agregarVertice(objetivo);

            zona.conectar(baseRescate, A, 8);
            zona.conectar(baseRescate, C, 15);
            zona.conectar(A, B, 9);
            zona.conectar(A, D, 9);
            zona.conectar(B, objetivo, 5);
            zona.conectar(C, B, 7);
            zona.conectar(D, objetivo, 11);
            zona.conectar(D, B, 10);

            RutasGrafos rutas = new RutasGrafos();

            List<string> resultado = rutas.rutasRescateOptimal(zona, "Base de rescate", "Objetivo", 12);

            if(resultado.Count == 0)
            {
                Console.WriteLine("No existe una ruta segura");
            }

            else
            {
                Console.Write("Ruta de menor duracion: ");
                for(int i=0; i<resultado.Count; i++)
                {
                    Console.Write(resultado[i]);
                    if(i<resultado.Count - 1)
                    {
                        Console.Write(" -> ");
                    }
                }
                Console.WriteLine();
            }

                Console.ReadKey();
        }
    }
}
