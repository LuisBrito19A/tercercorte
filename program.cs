using System;

namespace Programa_04
{
    class Program
    {
        public static void Main(string[] args)
        {
             
            string dato = "";
            int TamañoPerro = 0;
            int ActividadPerro = 0;
            double peso = 0.0;
            int opcion = 0;
            
            
            
            do{
                
                Console.WriteLine("Bienvenidos a programa de cuanto debe comer tu perro.\n\n");
                
                
                
                Console.WriteLine("¿Cual es el peso de su perro?:");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                
                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);
                
                
                //Tamaño Miniatura
                if(peso <= 5 && peso >= 2) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45 -85 gramos.");
                            break;
                    }
                    
                }
                
                
                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
                
            }while(opcion != 4);
                        
            
        
            
            
        }
    }
}
