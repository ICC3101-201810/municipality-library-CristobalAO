using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace LAB10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personas = new List<Person>();
            List<Car> autos = new List<Car>();
            List<Address> direcciones = new List<Address>();
            int respuesta, ano, cinturones, numeroP, numeroB, anoConstruccion, piezas, numero, bano, i;
            string nombre, apellido, rut, marca, modelo, patente, comuna, ciudad, calle, respuestaS;
            DateTime fNacimiento;
            bool diesel, patio, piscina;
            while (true)
            {
                MENU:
                Console.WriteLine("Que desea hacer\n  1.Agregar Persona\n  2.Agregar Auto\n  3.Agregar una direccion\n\n  4.Editar direccion\n  5.Editar dueño de un auto\n\n  6.Salir");
                try
                {
                    respuesta = Convert.ToInt32(Console.ReadLine());
                }

                catch { respuesta = 0; }
                if (respuesta == 1)
                {
                    PERSONA:
                    try
                    {
                        Console.WriteLine("Ingrese el nombre: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido: ");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese la fecha de nacimiento (En DateTime): ");
                        fNacimiento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Ingrese el rut: ");
                        rut = Console.ReadLine();
                        Person persona = new Person(nombre, apellido, fNacimiento, null, rut, null, null);
                        personas.Add(persona);
                        Console.WriteLine(persona.First_name + " " + persona.Last_name + " creado con exito "); System.Threading.Thread.Sleep(600);

                        Console.Clear();
                        Console.WriteLine("Quisieras cambiar algo antes de volver? (Si o No)");
                        respuestaS = Console.ReadLine();
                        if (respuestaS.ToLower() == "no") { goto MENU; }
                        if (respuestaS.ToLower() == "si")
                        {
                            PP:
                            Console.WriteLine("Que quieres cambiar: \n  1.Nombre\n  2.Apellido");
                            try
                            {
                                respuesta = Convert.ToInt32(Console.ReadLine());
                            }

                            catch { Error(); goto PP; }
                            if (respuesta == 1) { Console.WriteLine("Cual es el nuevo nombre?"); nombre = (Console.ReadLine()); persona.changeFirstName(nombre); }
                            else if (respuesta == 2) { Console.WriteLine("Cual es el nuevo apellido?"); apellido = (Console.ReadLine()); persona.changeLastName(apellido); }
                            Console.WriteLine(persona.First_name + " " + persona.Last_name + " editado con exito "); System.Threading.Thread.Sleep(600);

                        }


                    }
                    catch
                    {
                        Console.Clear();
                        REPETIRPERSONA:
                        Console.WriteLine("Datos incorrectos, si quiere reingresarlos presione 1, para volver presione 0");
                        Console.Beep();
                        try
                        {
                            respuesta = Convert.ToInt32(Console.ReadLine());
                        }

                        catch { respuesta = 0; }
                        Console.Clear();
                        if (respuesta == 1) { goto PERSONA; }
                        else if (respuesta == 0) { goto MENU; }
                        else { Error(); goto REPETIRPERSONA; }
                    }

                }
                else if (respuesta == 2)
                {
                    AUTO:
                    try
                    {
                        Console.WriteLine("Ingrese el modelo: ");
                        modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese la marca: ");
                        marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el año: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la patente: ");
                        patente = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de cinturones: ");
                        cinturones = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Utiliza diesel (true o false):");
                        diesel = Convert.ToBoolean(Console.ReadLine());
                        Car auto = new Car(marca, modelo, ano, null, patente, cinturones, diesel);
                        autos.Add(auto);
                        Console.WriteLine("Auto creado con exito "); System.Threading.Thread.Sleep(500);
                    }
                    catch
                    {
                        Console.Clear();
                        REPETIRAUTO:
                        Console.WriteLine("Datos incorrectos, si quiere reingresarlos presione 1, para volver presione 0");
                        Console.Beep();
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (respuesta == 1) { goto AUTO; }
                        else if (respuesta == 0) { goto MENU; }
                        else { Error(); goto REPETIRAUTO; }
                    }
                }
                else if (respuesta == 3)
                {
                    DIRECCION:
                    try
                    {
                        Console.WriteLine("Ingrese la calle: ");
                        calle = Console.ReadLine();
                        Console.WriteLine("Ingrese la comuna: ");
                        comuna = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la ciudad: ");
                        ciudad = Console.ReadLine();
                        Console.WriteLine("Ingrese el año de construccion: ");
                        anoConstruccion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de baños: ");
                        bano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de piezas: ");
                        piezas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tiene patio (true o false):");
                        patio = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Tiene piscina (true o false):");
                        piscina = Convert.ToBoolean(Console.ReadLine());
                        Address direccion = new Address(calle, numero, comuna, ciudad, null, anoConstruccion, piezas, bano, patio, piscina);
                        direcciones.Add(direccion);
                        Console.WriteLine("Direccion creada con exito "); System.Threading.Thread.Sleep(500);

                    }
                    catch
                    {
                        Console.Clear();
                        REPETIRDIRECCION:
                        Console.WriteLine("Datos incorrectos, si quiere reingresarlos presione 1, para volver presione 0");
                        Console.Beep();
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (respuesta == 1) { goto DIRECCION; }
                        else if (respuesta == 0) { goto MENU; }
                        else { Error(); goto REPETIRDIRECCION; }
                    }
                }
                else if (respuesta == 4)
                {
                    try
                    {
                        i = 0;
                        foreach (Address direccion in direcciones) { Console.WriteLine(i + "-  " + direccion.Street + "  " + direccion.Number); i = i + 1; }
                        Console.WriteLine("Ingrese el numero de la direccion a editar");
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        Address dir = direcciones[respuesta];

                        Console.WriteLine("Ingrese el numero de piezas que desea anadir");
                        numeroP = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero de banos que desea anadir");
                        numeroB = Convert.ToInt32(Console.ReadLine());
                        foreach (Person persona in personas) { Console.WriteLine(i + "-  " + persona.Rut); i = i + 1; }
                        Console.WriteLine("Ingrese el numero del nuevo dueño");
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        dir.changeOwner(personas[respuesta]);
                    }
                    catch { Error(); goto MENU; }
                    //dir.Bathrooms = dir.Bathrooms + numeroB;
                    //dir.Beedrooms = dir.Beedrooms + numeroP;
                }
                else if (respuesta == 5)
                {
                    try
                    {
                        i = 0;
                        foreach (Car auto in autos) { Console.WriteLine(i + "-  " + auto.License_plate); i = i + 1; }
                        Console.WriteLine("Ingrese el numero del vehiculo a editar");
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        Car au = autos[respuesta];
                        i = 0;
                        foreach (Person persona in personas) { Console.WriteLine(i + "-  " + persona.Rut); i = i + 1; }
                        Console.WriteLine("Ingrese el numero del nuevo dueño");
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        au.giveUpOwnershipToThirdParty(personas[respuesta]);
                    }
                    catch { Error(); goto MENU; }
                }
                else if (respuesta == 6) { break; }

                else { Error(); }

                Console.Clear();

            }

            void Error()
            {
                Console.Clear();
                Console.WriteLine("Respuesta invalida");
                Console.Beep();
                System.Threading.Thread.Sleep(500);
            }

            #region Codigo usado para la parte 1 (Comentado)
            //Assembly archivoAssembly = Assembly.LoadFile(@"C:\Users\calle\Desktop\municipality-library-CristobalAO\Clases.dll");
            //foreach (Type type in archivoAssembly.GetTypes())
            //{
            //    if (type.IsClass) Console.WriteLine("class");
            //    else if (type.IsInterface) Console.WriteLine("interface");
            //    else Console.WriteLine("otro tipo");

            //    Console.WriteLine(type.Name);

            //    var atributos = type.GetProperties();
            //    Console.WriteLine("Atributos: ");
            //    foreach (var at in atributos)
            //    {
            //        Console.WriteLine("+ " + at.Name + ": " + at.PropertyType);

            //    }

            //    MethodInfo[] metodos = type.GetMethods();
            //    Console.WriteLine("Metodos: ");
            //    foreach (MethodInfo met in metodos)
            //    {
            //        Console.WriteLine("+ " + met.Name + " (" + "): " + met.ReturnType);
            //        ParameterInfo[] parametros = met.GetParameters();
            //        foreach (var p in parametros)
            //        {
            //            Console.WriteLine(p.ParameterType);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion 
        }
    }
}
