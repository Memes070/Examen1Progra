using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra
{
    static class Menu
    {

     

        static Menu() { }

        public static void Opciones()
        {

            byte opcion = 1;
            do
            {
                Console.WriteLine("Menu de Vehiculos");
                Console.WriteLine("1. Vehiculos");
                Console.WriteLine("2. Ventas");
                Console.WriteLine("3. Reportes");
                Console.WriteLine("4. Salida");
                Console.WriteLine("Seleccione una opcion: ");
                opcion = byte.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1: SubMenuVehiculo();break;
                    
                    


                }
            } while (opcion != 4);

        }

    }

    public static void SubMenuVehiculo()
    {
        byte opcion = 1;
        do
        {
            Console.WriteLine("****SubMenuVehiculos****");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Modificar");
            Console.WriteLine("3. Consultar");
            opcion = byte.Parse(Console.ReadLine());
            Console.Clear();

            switch(opcion)
            {
                case 1:Console.WriteLine("Que desea agregar");break;
                case 2:Console.WriteLine("Que desea Modificar");break;
                case 3:Console.WriteLine("Que desea consultar");break;
                case 4: Menu.Opciones();break;
                default:
                    break;
            }

        } while (opcion != 3);
    }
    
    public static void Agregar()
    {
        Console.WriteLine("Ingrese un Codigo");
        Console.WriteLine("Ingrese la Marca");
        Console.WriteLine("Ingrese el Modelo");
        Console.WriteLine("El precio del veheiculo es: ");
        
    }
     public static void Modificar()
    {
        int codigo;
        
        Boolean Existe = false;
        Console.WriteLine(("Ingrese el codigo de su vehiculo: "); codigo = int.Parse(Console.ReadLine());
        for(int i=0; i < 5; i++)
        {
           if(codigo == Codigo[i])
            {
                Console.WriteLine("Ingrese la marca"); marca[i] = Console.ReadLine();
                Console.WriteLine("Inrese el modelo"); modelo[i] = Console.ReadLine();
                Console.WriteLine("Precio del vehiculo"); costo[i] = Console.ReadLine();
                Existe = true;
            }
        }
        if (!Existe) Console.WriteLine("Vehiculo no existe");
    }

    public static void Consultar()
    {
        int codigo;
        Boolean Existe = false;
        Console.WriteLine("Consulta el codigo del vehiculo:");codigo = int.Parse(Console.ReadLine());
        for(int i = 0; i < 5; i++)
        {
            if(codigo == Codigo[i])
            {
                Console.WriteLine($"Marca : {marca[i]}");
                Console.WriteLine($"Modelo : {modelo[i]}");
                Console.WriteLine($"costo : {costo[i]}");
                Existe = true;
            }
        }
        if (!Existe) Console.WriteLine("Vehiculo no existe");
    }
}



  