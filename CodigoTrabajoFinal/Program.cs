using System;

namespace CodigoTrabajoFinal
{
    internal class Program
    {
        static string[] adminInfo = new string[] { "Jero", "Contraseña" };
        static void Main(string[] args)
        {
            InicioSesion();
        }
        static string[] InicioSesion()
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
                EditarUsuarioA();
            }
            else
            {
                Console.WriteLine("BLOQUEO EN 3 INTENTOS");
            }
            return adminInfo;        
        }
        static string[] EditarUsuarioA()
        {
            string[] adminInfoNew = new string[1];
            string resp;
            do
            {
                Console.WriteLine("Escriba el nuevo nombre de usuario");
                adminInfoNew[0] = Console.ReadLine();
                Console.WriteLine("Escriba la nueva contraseña");
                adminInfoNew[1] = Console.ReadLine();
                Console.WriteLine("¿Esta contento con los cambios?");
                Console.WriteLine("S = Si                   N = No");
                resp = Console.ReadLine();
                if (resp == "S")
                {
                    adminInfoActual = adminInfoNew;
                    
                }
            } while (resp == "N");
            string[] adminInfo = new string[1];
            adminInfo = EditarUsuarioA();
            adminInfo = InicioSesion();
            return adminInfo;
        }

    }
}
