class Program
{
    static List<string> estudiantes = new List<string>();
    static List<double> calificaciones = new List<double>();

    static void Main(string[] args)
    {
        double agregar_calificacioncon(double num)
        {
            while (!double.TryParse(Console.ReadLine(), out num) || num <0)
            {

                Console.WriteLine("Introduce un numero correcto");
            }
            return num;
        }

        void agregar_estudiante()
        {
            double calificacion = 0;
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la calificación del estudiante: ");
            calificacion = agregar_calificacioncon(calificacion);
            estudiantes.Add(nombre);
            calificaciones.Add(calificacion);
            Console.WriteLine("Estudiante agregado correctamente.");
        }

        void lista_estudiantes()
        {
            if (estudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
            }
            else
            {
                Console.WriteLine("\nLista de estudiantes:");
                for (int i = 0; i < estudiantes.Count; i++)
                {
                    Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
                }
            }
        }

        void promedio_calificaciones()
        {
            if (calificaciones.Count == 0)
            {
                Console.WriteLine("No hay calificaciones registradas.");
            }
            else
            {
                double suma = 0;
                foreach (double calificacion in calificaciones)
                {
                    suma += calificacion;
                }
                double promedio = suma / calificaciones.Count;
                Console.WriteLine($"El promedio de calificaciones es: {promedio}");
            }
        }

        void calificacion_alta()
        {
            if (calificaciones.Count == 0)
            {
                Console.WriteLine("No hay calificaciones registradas.");
            }
            else
            {
                double maxCalificacion = calificaciones[0];
                string estudianteMax = estudiantes[0];
                for (int i = 1; i < calificaciones.Count; i++)
                {
                    if (calificaciones[i] > maxCalificacion)
                    {
                        maxCalificacion = calificaciones[i];
                        estudianteMax = estudiantes[i];
                    }
                }
                Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");
            }
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de gestión de estudiantes.");
            Console.WriteLine("\n1. Agregar estudiante");
            Console.WriteLine("2. Mostrar lista de estudiantes");
            Console.WriteLine("3. Calcular promedio de calificaciones");
            Console.WriteLine("4. Mostrar estudiante con la calificación más alta");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    agregar_estudiante();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                    break;

                case 2:
                    lista_estudiantes();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                    break;

                case 3:
                    promedio_calificaciones();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                    break;

                case 4:
                    calificacion_alta();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
