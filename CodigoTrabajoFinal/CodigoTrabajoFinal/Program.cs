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
        static string[] MenuCajero()
        {
            bool passwordIsCorrect = false;
            bool userIsCorrect = false;
            Console.WriteLine("------------------MENÚ------------------");
            Console.WriteLine("               Bienvenido               ");
            Console.WriteLine("     Ingrese su usuario y Contraseña    ");
            Console.Write("Usuario:");
            infoCajero[0] = Console.ReadLine();
            Console.Write("Contraseña:");
            infoCajero[1] = Console.ReadLine();
            if (infoCajero[0] == "Yuanma")
            {
                passwordIsCorrect = true;
            }
            if (infoCajero[1] == "Contra")
            {
                userIsCorrect = true;
            }
            if (passwordIsCorrect == true && userIsCorrect == true)
            {
                Console.WriteLine("Presione 1: Para gestionar su cuenta de cajero");
                Console.WriteLine("Presione 2: Para gestionar sus rutas");
                Console.WriteLine("Presione 3: Para realizar una venta");
                int eleccionMenuCajero = int.Parse(Console.ReadLine());

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
            return infoCajero;
        }
        static void GestionCuentaCajero()
        {
            Console.WriteLine("-------------GESTIÓN DE CUENTA------------");
            Console.WriteLine("Presione 1: Para editar su usuario.");
            Console.WriteLine("Presione 2: Para editar su contraseña.");
            Console.WriteLine("Presione 3: Para salir.");
            int decisionUsuario = int.Parse(Console.ReadLine());
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
            usuarioNuevo = infoCajero[0].ToString();
        }
        static void EditarContraseñaC()
        {
            Console.WriteLine("--------------EDITAR USUARIO-------------");
            Console.WriteLine("         Ingrese su nueva contraseña     ");
            string usuarioNuevo = Console.ReadLine();
            usuarioNuevo = infoCajero[1].ToString();

            char respuesta = ' ';
            Console.WriteLine("¿Desea guardar sus cambios? N: no, S");
            respuesta = char.Parse(Console.ReadLine());
            if (respuesta == 'S')
            {

            }
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
