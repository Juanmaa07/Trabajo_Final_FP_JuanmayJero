using System;

namespace CodigoTrabajoFinal
{
    internal class Program
    {
        static string[] adminInfo = new string[] { "Jero", "Contraseña" };
        static string[,] Cajeros = new string[15, 2];
        static void Main(string[] args)
        {
            while (true)
            {
                InicioSesion();
            }
        }
        static void InicioSesion()
        {

            Console.WriteLine("---------------------MENÚ--------------------");
            Console.WriteLine("                  Bienvenido                  ");
            Console.WriteLine("        Ingrese su usuario y contraseña           ");
            Console.Write("Usuario: ");
            string tryuser = Console.ReadLine();
            Console.Write("Contraseña: ");
            string trypassword = Console.ReadLine();
            if (tryuser == adminInfo[0] && adminInfo[1] == trypassword)
            {
                MenuAdmin();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("BLOQUEO EN 3 INTENTOS");
            }
        }

        static void MenuAdmin()
        {
            {
                bool continuar = true;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("----- MENÚ ADMINISTRADOR -----");
                    Console.WriteLine("1. Gestionar Administrador");
                    Console.WriteLine("2. Gestionar Cajero");
                    Console.WriteLine("3. Salir");
                    Console.Write("Seleccione una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            GestionAdmin();
                            break;
                        case "2":
                            GestionCajero();
                            break;
                        case "3":
                            SalirAdmin();
                            continuar = false;
                            break;
                    }
                } while (continuar);
            }
        }
        static void GestionAdmin()
        {
            bool continuar = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("----- GESTION ADMINISTRADOR -----");
                Console.WriteLine("1. Cambiar usuario y contraseña");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        userpassAdmin();
                        break;

                    case "2":
                        SalirAdmin();
                        continuar = false;
                        break;
                }
            } while (continuar == true);
        }
        static void userpassAdmin()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Escriba el nuevo nombre de usuario: ");
            string nuevoUsuario = Console.ReadLine();

            Console.Write("Escriba la nueva contraseña: ");
            string nuevaPassword = Console.ReadLine();

            Console.Write("¿Está contento con los cambios? S/N: ");
            string respuesta = Console.ReadLine();

            if (respuesta == "S")
            {
                adminInfo[0] = nuevoUsuario;
                adminInfo[1] = nuevaPassword;

                Console.WriteLine("Usuario y contraseña actualizados.");
            }
            else
            {
                Console.WriteLine("Cambios cancelados.");
            }
        }
        static void SalirAdmin()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Saliendo de la edición...");
            Console.WriteLine("Regresando al inicio de sesión...");
        }

        static void GestionCajero()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----- GESTIONAR CAJERO -----");
            Console.WriteLine("1. Crear Cajero");
            Console.WriteLine("2. Editar Cajero");
            Console.WriteLine("3. Ver lista de Cajeros");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    CrearCajero();
                    break;
                case "2":
                    EditarCajero();
                    break;
                case "3":
                    ListaCajeros(); 
                    break;
            }
        }
        static void CrearCajero()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int posicionLibre = -1;
            for (int i = 0; i < Cajeros.GetLength(0); i++)
            {
                if (Cajeros[i, 0] == null)
                {
                    posicionLibre = i;
                    break;
                }
            }
            if (posicionLibre == -1)
            {
                Console.WriteLine("No se pueden crear más cajeros. Se alcanzó el máximo de 15.");
                return;
            }


            Console.WriteLine("Ingrese el nombre del cajero: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña del cajero: ");
            string pass = Console.ReadLine();

            Cajeros[posicionLibre, 0] = nombre;
            Cajeros[posicionLibre, 1] = pass;

            Console.WriteLine("Cajero creado correctamente.");
            for (int i = 0; i < Cajeros.GetLength(0); i++)
            {
                if (Cajeros[i, 0] != null)
                    Console.WriteLine($"{i + 1}: {Cajeros[i, 0]} / {Cajeros[i, 1]}");
            }
        }
        static void EditarCajero()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el número del cajero que desea editar: ");
            int numeroCajero = int.Parse(Console.ReadLine()) - 1;
            if (numeroCajero < 0 || numeroCajero >= Cajeros.GetLength(0) || Cajeros[numeroCajero, 0] == null)
            {
                Console.WriteLine("Número de cajero inválido.");
                return;
            }
            Console.WriteLine($"Nombre actual: {Cajeros[numeroCajero, 0]}");
            Console.WriteLine($"Contraseña actual: {Cajeros[numeroCajero, 1]}");
            Console.WriteLine("Ingrese el nuevo nombre del cajero: ");
            string nuevoNombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva contraseña del cajero: ");
            string nuevaPass = Console.ReadLine();
            Cajeros[numeroCajero, 0] = nuevoNombre;
            Cajeros[numeroCajero, 1] = nuevaPass;
            Console.WriteLine("Cajero editado correctamente.");
        }
        static void ListaCajeros()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("LISTA DE CAJEROS");
            for (int i = 0; i < Cajeros.GetLength(0); i++)
            {
                if (Cajeros[i, 0] != null)
                    Console.WriteLine($"{i + 1}: {Cajeros[i, 0]} / {Cajeros[i, 1]}");
                
            }
        }
    }
}