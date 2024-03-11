namespace NetTaller2_CARG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salirSistema = false;
            while (!salirSistema)
            {
                Console.WriteLine(
                "1- Votos de 3 candidatos." +
                "\n2- Promedio de peso por edades." +
                "\n3- Expendio de naranjas." +
                "\n4- Zoologico." +
                "\n5- Transito del DF." +
                "\n6- Porcentaje de reprobados." +
                "\n7- Envio de cartas.\n" +
                "\n0- CERRAR EL SISTEMA.\n" +
                "\nIngrese la opcion que desea:");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        salirSistema = true;
                        Console.WriteLine("\nNOSPIIII");
                        break;

                    case 1:
                        List<int> votos = new List<int>();

                        Console.WriteLine("\nIngrese los votos (1, 2, 3 para candidatos, 4 para voto en blanco, 0 para terminar):");

                        int voto;
                        do
                        {
                            Console.Write("Voto: ");
                            if (int.TryParse(Console.ReadLine(), out voto))
                            {
                                if (voto >= 1 && voto <= 4)
                                {
                                    votos.Add(voto);
                                }
                                else
                                {
                                    Console.WriteLine("\n¡Voto inválido! Por favor, ingrese un número entre 0 y 4.");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n¡Entrada inválida! Por favor, ingrese un número válido.");
                                continue;
                            }
                        } while (voto != 0);

                        double totalVotos = votos.Count;

                        double contadorCandidato1 = 0;
                        double contadorCandidato2 = 0;
                        double contadorCandidato3 = 0;
                        double blanco = 0;

                        foreach (int v in votos)
                        {
                            switch (v)
                            {
                                case 1:
                                    contadorCandidato1++;
                                    break;
                                case 2:
                                    contadorCandidato2++;
                                    break;
                                case 3:
                                    contadorCandidato3++;
                                    break;
                                case 4:
                                    blanco++;
                                    break;
                            }
                        }

                        double porcentajeCandidato1 = (contadorCandidato1 * 100.0) / totalVotos;
                        double porcentajeCandidato2 = (contadorCandidato2 * 100.0) / totalVotos;
                        double porcentajecandidato3 = (contadorCandidato3 * 100.0) / totalVotos;

                        int ganador = 0;
                        if (porcentajeCandidato1 > porcentajeCandidato2)
                        {
                            if (porcentajeCandidato1 > porcentajecandidato3)
                            {
                                ganador = 1;
                            }
                            else
                            {
                                ganador = 3;
                            }
                        }
                        else if (porcentajeCandidato2 > porcentajecandidato3)
                        {
                            ganador = 2;
                        }
                        else
                        {
                            ganador = 3;
                        }

                        Console.WriteLine("\nRESULTADOS");
                        Console.WriteLine($"El candidato 1 obtuvo el {porcentajeCandidato1.ToString("F1")}% ({contadorCandidato1} votos)");
                        Console.WriteLine($"El candidato 2 obtuvo el {porcentajeCandidato2.ToString("F1")}% ({contadorCandidato2} votos)");
                        Console.WriteLine($"El candidato 3 obtuvo el {porcentajecandidato3.ToString("F1")}% ({contadorCandidato3} votos)");
                        Console.WriteLine($"Votos en blanco: {blanco}");
                        Console.WriteLine($"El ganador es el candidato {ganador}\n");
                        break;

                    case 2:
                        List<double> ninos = new List<double>();
                        List<double> jovenes = new List<double>();
                        List<double> adultos = new List<double>();
                        List<double> viejos = new List<double>();

                        Console.WriteLine("\nIndique la cantidad de datos a ingresar: ");
                        int cantidadPersonas = int.Parse(Console.ReadLine());

                        for (int i = 0; i < cantidadPersonas;)
                        {
                            int edad = 0;
                            double peso = 0.0;

                            Console.WriteLine("\nIngrese edad: ");
                            String entradaEdad = Console.ReadLine();

                            Console.WriteLine("Ingrese peso: ");
                            String entradaPeso = Console.ReadLine();

                            if (int.TryParse(entradaEdad, out edad) && double.TryParse(entradaPeso, out peso))
                            {
                                if (peso < 0)
                                {
                                    Console.WriteLine("\n¡Error! Ingrese un dato valido");
                                    continue;
                                }

                                if (edad >= 0 && edad <= 12)
                                {
                                    ninos.Add(peso);
                                }
                                else if (edad >= 13 && edad <= 29)
                                {
                                    jovenes.Add(peso);
                                }
                                else if (edad >= 30 && edad <= 59)
                                {
                                    adultos.Add(peso);
                                }
                                else if (edad >= 60)
                                {
                                    viejos.Add(peso);
                                }
                                else
                                {
                                    Console.WriteLine("\n¡Error! Ingrese un dato valido");
                                    continue;
                                }
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("\n¡Error! Ingrese un dato valido");
                                continue;
                            }
                        }

                        double sumaN = 0.0;
                        foreach (double peso in ninos)
                        {
                            sumaN += peso;
                        }
                        double promedioN = sumaN / ninos.Count;

                        double sumaJ = 0.0;
                        foreach (double peso in jovenes)
                        {
                            sumaJ += peso;
                        }
                        double promedioJ = sumaJ / jovenes.Count;

                        double sumaA = 0.0;
                        foreach (double peso in adultos)
                        {
                            sumaA += peso;
                        }
                        double promedioA = sumaA / adultos.Count;

                        double sumaV = 0.0;
                        foreach (double peso in viejos)
                        {
                            sumaV += peso;
                        }
                        double promedioV = sumaV / viejos.Count;

                        Console.WriteLine("\nRESULTADOS");
                        Console.WriteLine($"El promedio de peso de los ninos es de: {promedioN}");
                        Console.WriteLine($"El promedio de peso de los jovenes es de: {promedioJ}");
                        Console.WriteLine($"El promedio de peso de los adultos es de: {promedioA}");
                        Console.WriteLine($"El promedio de peso de los viejos es de: {promedioV}\n");
                        break;

                    case 3:
                        Console.WriteLine("\n---BIENVENIDO/A AL SISTEMA DEL EXPENDIO DE NARANJAS--- \nRecuerda que los primeros 15 clientes tendrán un descuento del 15% si compran más de 10Kg");
                        Console.WriteLine("Ingrese el precio del kilo:");
                        double precioKilo = double.Parse(Console.ReadLine());
                        int clientes = 0;
                        double kilos = 0.0, descuento = 0.0, ganancias = 0.0;

                        while (true)
                        {
                            double pagar = 0.0;
                            Console.WriteLine("\n(Digite 0 para terminar)");
                            Console.WriteLine($"Ingrese la cantidad de kilos del cliente {clientes + 1}: ");
                            String entradaKilos = Console.ReadLine();

                            if (double.TryParse(entradaKilos, out kilos))
                            {
                                if (kilos < 0)
                                {
                                    Console.WriteLine("\n¡Error! Ingrese un dato valido");
                                    continue;
                                }

                                if (kilos != 0)
                                {
                                    pagar = kilos * precioKilo;
                                    clientes++;
                                }
                                else
                                {
                                    break;
                                }

                                if (kilos >= 10 && clientes <= 15)
                                {
                                    descuento = 0.15;
                                }
                                else
                                {
                                    descuento = 0.0;
                                }

                                descuento *= pagar;
                                pagar -= descuento;

                                if (descuento != 0)
                                {
                                    Console.WriteLine("\nEl cliente aplica para descuento");
                                    Console.WriteLine($"Se ha aplicado un descuento de ${descuento} (15%)");
                                }
                                Console.WriteLine($"\nEl cliente {clientes} debe pagar ${pagar}");
                                ganancias += pagar;
                            }
                            else
                            {
                                Console.WriteLine("\n¡Error! Ingrese un dato valido");
                                continue;
                            }
                        }
                        Console.WriteLine($"\nLas ganancias totales para el expendio son de ${ganancias}");
                        break;

                    case 4:
                        Console.WriteLine(
                        "\n1- Elefantes." +
                        "\n2- Jirafas." +
                        "\n3- Chimpancés." +
                        "\nSeleccione a qué animales desea estudiar:");
                        int animal = int.Parse(Console.ReadLine());


                        double porcentaje1, porcentaje2, porcentaje3, muestraAnimales, categoria1, categoria2, categoria3;

                        switch (animal)
                        {
                            case 1:
                                do
                                {
                                    Console.WriteLine("\nIngrese de los 20 elefantes, cuántos son de 0 a 1 año:");
                                    categoria1 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese de los 20 elefantes, cuántos son de más de 1 año y menos de 3:");
                                    categoria2 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese de los 20 elefantes, cuántos son de 3 o más años:");
                                    categoria3 = int.Parse(Console.ReadLine());

                                    muestraAnimales = categoria1 + categoria2 + categoria3;
                                    if (muestraAnimales != 20)
                                    {
                                        Console.WriteLine("\n¡Error! Recuerde que la muestra debe ser de 20 elefantes");
                                    }
                                } while (muestraAnimales != 20);

                                porcentaje1 = (categoria1 * 100) / 20;
                                porcentaje2 = (categoria2 * 100) / 20;
                                porcentaje3 = (categoria3 * 100) / 20;

                                Console.WriteLine("\nDe los 20 elefantes, tenemos los siguientes resultados:");
                                Console.WriteLine($"El {porcentaje1.ToString("F1")}% son de 0 a 1 año");
                                Console.WriteLine($"El {porcentaje2.ToString("F1")}% son de más de 1 año y menos de 3");
                                Console.WriteLine($"El {porcentaje3.ToString("F1")}% son de 3 o más años");
                                break;

                            case 2:
                                do
                                {
                                    Console.WriteLine("\nIngrese de las 15 jirafas, cuántas son de 0 a 1 año:");
                                    categoria1 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese de las 15 jirafas, cuántas son de más de 1 año y menos de 3:");
                                    categoria2 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese de las 15 jirafas, cuántas son de 3 o más años:");
                                    categoria3 = int.Parse(Console.ReadLine());

                                    muestraAnimales = categoria1 + categoria2 + categoria3;
                                    if (muestraAnimales != 15)
                                    {
                                        Console.WriteLine("\n¡Error! Recuerde que la muestra debe ser de 15 jirafas");
                                    }
                                } while (muestraAnimales != 15);

                                porcentaje1 = (categoria1 * 100) / 15;
                                porcentaje2 = (categoria2 * 100) / 15;
                                porcentaje3 = (categoria3 * 100) / 15;

                                Console.WriteLine("\nDe las 15 jirafas, tenemos los siguientes resultados:");
                                Console.WriteLine($"El {porcentaje1.ToString("F1")}% son de 0 a 1 año");
                                Console.WriteLine($"El {porcentaje2.ToString("F1")}% son de más de 1 año y menos de 3");
                                Console.WriteLine($"El {porcentaje3.ToString("F1")}% son de 3 o más años");
                                break;

                            case 3:
                                do
                                {
                                    Console.WriteLine("\nIngrese de los 40 chimpancés, cuántos son de 0 a 1 año:");
                                    categoria1 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese de los 40 chimpancés, cuántos son de más de 1 año y menos de 3:");
                                    categoria2 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese de los 40 chimpancés, cuántos son de 3 o más años:");
                                    categoria3 = int.Parse(Console.ReadLine());

                                    muestraAnimales = categoria1 + categoria2 + categoria3;
                                    if (muestraAnimales != 40)
                                    {
                                        Console.WriteLine("\n¡Error! Recuerde que la muestra debe ser de 40 chimpancés");
                                    }
                                } while (muestraAnimales != 40);

                                porcentaje1 = (categoria1 * 100) / 40;
                                porcentaje2 = (categoria2 * 100) / 40;
                                porcentaje3 = (categoria3 * 100) / 40;

                                Console.WriteLine("\nDe los 40 chimpancés tenemos los siguientes resultados:");
                                Console.WriteLine($"El {porcentaje1.ToString("F1")}% son de 0 a 1 año");
                                Console.WriteLine($"El {porcentaje2.ToString("F1")}% son de más de 1 año y menos de 3");
                                Console.WriteLine($"El {porcentaje3.ToString("F1")}% son de 3 o más años");
                                break;
                        }
                        break;

                    case 5:
                        int amarilla = 0, rosa = 0, roja = 0, verde = 0, azul = 0, contadorVehiculos = 0;
                        Console.WriteLine("\nDIGITA 'C' PARA CERRAR EL SISTEMA");
                        Console.WriteLine("Ingresa el último digito de la placa de cada automovil");

                        while (true)
                        {
                            Console.WriteLine($"Vehiculo {contadorVehiculos + 1}:");
                            String entradaPlaca = Console.ReadLine();
                            int digitoPlaca;

                            if (int.TryParse(entradaPlaca, out digitoPlaca))
                            {
                                if (digitoPlaca == 1 || digitoPlaca == 2)
                                {
                                    amarilla++;
                                }
                                else if (digitoPlaca == 3 || digitoPlaca == 4)
                                {
                                    rosa++;
                                }
                                else if (digitoPlaca == 5 || digitoPlaca == 6)
                                {
                                    roja++;
                                }
                                else if (digitoPlaca == 7 || digitoPlaca == 8)
                                {
                                    verde++;
                                }
                                else if (digitoPlaca == 9 || digitoPlaca == 0)
                                {
                                    azul++;
                                }
                                else
                                {
                                    Console.WriteLine("\n¡Error! Ingrese un dato valido");
                                    continue;
                                }
                            }
                            else if (entradaPlaca.ToUpper() == "C")
                            {
                                Console.WriteLine("\nFIN DEL INGRESO DE DATOS");
                                break;
                            }
                            else if (entradaPlaca.ToUpper() != "C")
                            {
                                Console.WriteLine("\n¡Error! Ingrese un dato valido");
                                continue;
                            }

                            contadorVehiculos++;
                        }

                        Console.WriteLine($"\nResultados de los {contadorVehiculos} vehiculos");
                        Console.WriteLine($"Calcomania amarilla: {amarilla} autos");
                        Console.WriteLine($"Calcomania rosa: {rosa} autos");
                        Console.WriteLine($"Calcomania roja: {roja} autos");
                        Console.WriteLine($"Calcomania verde: {verde} autos");
                        Console.WriteLine($"Calcomania azul: {azul} autos");
                        break;

                    case 6:
                        Console.WriteLine("\nIngrese la cantidad de notas finales de estudiantes que va a digitar:");
                        double cantidadNotas = double.Parse(Console.ReadLine());

                        Console.WriteLine("\n(Digite notas entre el 0 y el 100)");
                        int notaEstudiante;
                        double cantidadReprobados = 0;

                        for (int contadorNotas = 0; contadorNotas < cantidadNotas;)
                        {
                            Console.Write($"Nota del estudiante {contadorNotas + 1}: ");

                            if (int.TryParse(Console.ReadLine(), out notaEstudiante))
                            {
                                if (notaEstudiante < 0)
                                {
                                    Console.WriteLine("¡Error! La nota debe ser mayor o igual a 0");
                                    continue;
                                }
                                else if (notaEstudiante < 70)
                                {
                                    cantidadReprobados++;
                                }
                                else if (notaEstudiante > 100)
                                {
                                    Console.WriteLine("¡Error! La nota debe ser menor o igual a 100");
                                    continue;
                                }

                                contadorNotas++;
                            }
                            else
                            {
                                Console.WriteLine("¡Error! Digite un dato válido");
                                continue;
                            }
                        }

                        double porcentajeReprobados = (cantidadReprobados * 100) / cantidadNotas;
                        Console.WriteLine($"\nDe los {cantidadNotas} estudiantes, el {porcentajeReprobados.ToString("F1")}% ha reprobado ({cantidadReprobados} estudiantes)");
                        break;

                    case 7:
                        int totalCorrientes = 0;
                        int totalRecomendados = 0;
                        double totalRecaudadoLocal = 0;
                        double totalRecaudadoNacional = 0;
                        double totalRecaudadoInternacional = 0;

                        while (true)
                        {
                            Console.WriteLine("\n¿Desea calcular el valor de envío de una carta? (S/N)");
                            string continuar = Console.ReadLine().ToUpper();

                            if (continuar.ToUpper() != "S")
                            {
                                break;
                            }

                            Console.WriteLine("Ingrese el peso de la carta en gramos:");
                            int peso = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el tipo de envío (Corriente/Recomendado):");
                            string tipoEnvio = Console.ReadLine().ToUpper();

                            Console.WriteLine("Ingrese el destino (Local/Nacional/Internacional):");
                            string destino = Console.ReadLine().ToUpper();

                            double valorEnvio = 0;

                            if (tipoEnvio == "CORRIENTE")
                            {
                                switch (destino)
                                {
                                    case "LOCAL":
                                        valorEnvio = 100;
                                        break;
                                    case "NACIONAL":
                                        valorEnvio = 150;
                                        break;
                                    case "INTERNACIONAL":
                                        valorEnvio = 200;
                                        break;
                                    default:
                                        Console.WriteLine("\n¡Error! Destino no válido.");
                                        continue;
                                }
                                totalCorrientes++;
                            }
                            else if (tipoEnvio == "RECOMENDADO")
                            {
                                switch (destino)
                                {
                                    case "LOCAL":
                                        valorEnvio = 200;
                                        break;
                                    case "NACIONAL":
                                        valorEnvio = 300;
                                        break;
                                    case "INTERNACIONAL":
                                        valorEnvio = 400;
                                        break;
                                    default:
                                        Console.WriteLine("\n¡Error! Destino no válido.");
                                        continue;
                                }
                                totalRecomendados++;
                            }
                            else
                            {
                                Console.WriteLine("\n¡Error! Tipo de envío no válido.");
                                continue;
                            }

                            double iva = valorEnvio * 0.16;
                            double valorTotal = valorEnvio + iva;

                            Console.WriteLine($"\nValor a pagar por el envío: {valorTotal:C}");
                            Console.WriteLine($"IVA (16%): {iva:C}");

                            switch (destino)
                            {
                                case "LOCAL":
                                    totalRecaudadoLocal += valorTotal;
                                    break;
                                case "NACIONAL":
                                    totalRecaudadoNacional += valorTotal;
                                    break;
                                case "INTERNACIONAL":
                                    totalRecaudadoInternacional += valorTotal;
                                    break;
                            }
                        }

                        Console.WriteLine("\nRESULTADO");
                        Console.WriteLine($"Total de cartas corrientes: {totalCorrientes}");
                        Console.WriteLine($"Total de cartas recomendadas: {totalRecomendados}");
                        Console.WriteLine($"Recaudación total en envíos locales: {totalRecaudadoLocal:C}");
                        Console.WriteLine($"Recaudación total en envíos nacionales: {totalRecaudadoNacional:C}");
                        Console.WriteLine($"Recaudación total en envíos internacionales: {totalRecaudadoInternacional:C}");
                        break;

                    default:
                        Console.WriteLine("\nSELECCIONE UNA OPCIÓN VÁLIDA");
                        continue;

                }
            }
        }
    }
}
