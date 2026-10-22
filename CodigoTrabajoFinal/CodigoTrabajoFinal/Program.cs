using System;

namespace CodigoTrabajoFinal
{
    internal class Program
    {
        static string[] infoCajero = new string[] {"Yuanma", "Contra"};
        static void Main(string[] args)
        {
            MenuCajero();
        }
        static void MenuCajero()
        {
            /*bool passwordIsCorrect = false;
            bool userIsCorrect = false;
            Console.WriteLine("------------------MENÚ------------------");
            Console.WriteLine("               Bienvenido               ");
            Console.WriteLine("     Ingrese su usuario y Contraseña    ");
            Console.Write("Usuario:");
            infoCajero[0] = Console.ReadLine();
            Console.Write("Contraseña:");
            infoCajero[1] = Console.ReadLine();
            if (infoCajero[0] == infoCajero[0])
            {
                passwordIsCorrect = true;
            }
            if (infoCajero[1] == infoCajero[1])
            {
                userIsCorrect = true;
            }
            if (passwordIsCorrect == true && userIsCorrect == true)
            {*/
                Console.WriteLine("Presione 1: Para gestionar su cuenta de cajero");
                Console.WriteLine("Presione 2: Para gestionar sus rutas");
                Console.WriteLine("Presione 3: Para realizar una venta");
                int eleccionMenuCajero = int.Parse(Console.ReadLine());
                switch (eleccionMenuCajero)
                {
                case 1:
                    BorrarPantalla();
                    GestionCuentaCajero();
                    break;
                case 2:
                    BorrarPantalla();
                    GestionRutas();
                    break;
                case 3:
                    BorrarPantalla();
                    RealizarVenta();
                    break;
                    default:
                    BorrarPantalla();
                    Console.BackgroundColor = ConsoleColor.Red;                  
                    Console.WriteLine("Ingrese una opción válida del menú");
                    Console.BackgroundColor = ConsoleColor.Black;
                    MenuCajero();
                    break;
                }
                if (eleccionMenuCajero == 1)
                {
                    BorrarPantalla();
                    GestionCuentaCajero();
                }
                else if (eleccionMenuCajero == 2)
                {
                    BorrarPantalla();
                    GestionRutas();
                }
            
        }
        static void GestionCuentaCajero()
        {
            Console.WriteLine("-------------GESTIÓN DE CUENTA------------");
            Console.WriteLine("Presione 1: Para editar su usuario.");
            Console.WriteLine("Presione 2: Para editar su contraseña.");
            Console.WriteLine("Presione 3: Para salir.");
            int decisionUsuario = int.Parse(Console.ReadLine());
            if (decisionUsuario == 1)
            {
                BorrarPantalla();
                EditarUsuarioC();
            }
            if (decisionUsuario == 2)
            {
                BorrarPantalla();
                EditarContraseñaC();
            }
            if (decisionUsuario == 3)
            {
                BorrarPantalla();
                MenuCajero();
            }
        }

        static void EditarUsuarioC()
        {
            Console.WriteLine("--------------EDITAR USUARIO-------------");
            Console.WriteLine("         Ingrese el nuevo usuario        ");
            string usuarioNuevo = Console.ReadLine();

            char respuesta = ' ';
            Console.WriteLine("¿Desea guardar sus cambios? N: no, S: Sí");
            respuesta = char.Parse(Console.ReadLine().ToUpper());
            if (respuesta == 'S'  )
            {
                infoCajero[0] = usuarioNuevo;
                BorrarPantalla();
                MenuCajero();
            }
        }
        static void EditarContraseñaC()
        {
            Console.WriteLine("--------------EDITAR CONTRASEÑA-------------");
            Console.WriteLine("         Ingrese su nueva contraseña     ");
            string usuarioNuevo = Console.ReadLine();

            char respuesta = ' ';
            Console.WriteLine("¿Desea guardar sus cambios? N: no, S: Sí");
            respuesta = char.Parse(Console.ReadLine().ToUpper());
            if (respuesta == 'S')
            {
                infoCajero[1] = usuarioNuevo;
                BorrarPantalla();
                MenuCajero();
            }
        }
        static void RealizarVenta()
        {
            float valorTiquete = 59.900f;
            Console.WriteLine("Ingrese el nombre del cliente.");
            string nombreCliente = Console.ReadLine();
            Console.WriteLine("Seleccione una de las rutas disponibles.");
            Console.WriteLine("Ingrese la cantidad de tiquetes que desea comprar.");
            int cantidadTiquetes = int.Parse(Console.ReadLine());
            float precioFinal = valorTiquete * cantidadTiquetes;
            Console.WriteLine("----------------------------RECIBO-----------------------------");
            Console.WriteLine($"|Nombre del cliente: {nombreCliente}.");
            Console.WriteLine($"|Ruta: Ruta Medelín-Bogotá.");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("   Unidades                 Producto                Precio     ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"|{cantidadTiquetes}                         Tiquete                  {valorTiquete}.");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"|Total:                                        ${precioFinal}.");

            Console.WriteLine("Presione cualquier tecla para volver al menú.");
            char respuestaInutil = char.Parse(Console.ReadLine());
            BorrarPantalla();
            MenuCajero();
        }
        static void GestionRutas()
        {
            Console.WriteLine("-------------GESTIÓN DE RUTAS------------");
            Console.WriteLine("Presione 1: Para asignar una ruta.");
            Console.WriteLine("Presione 2: Para crear una ruta.");
            Console.WriteLine("Presione 3: Para editar una ruta.");
            Console.WriteLine("Presione 4: Para salir.");
            int decisionUsuario = int.Parse(Console.ReadLine());
            if (decisionUsuario == 4)
            {
                BorrarPantalla();
                MenuCajero();
            }
        }
        static void BorrarPantalla()
        {
            Console.Clear();
        }
    }
}