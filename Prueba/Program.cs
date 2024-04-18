Console.WriteLine("Por favor, ingrese un texto: ");

string inputTexto;
inputTexto = Console.ReadLine();

if (inputTexto == "") {

    Console.WriteLine("No hay texto ingresado!");
   
} else {
    string opcion, cambiarPalabra;
    Console.WriteLine("\nOpciones:\n 1 - Texto en Mayúsculas\n 2 - Texto en Minúsculas\n 3 - Longitud de Texto\n 0 - Salir");
    Console.WriteLine("\nIngrese opcion: ");
    opcion = Console.ReadLine();

    while (opcion != "0") {
        switch (opcion) {
            case "1":
                Console.WriteLine("\nTexto en Mayùsculas: " + inputTexto.ToUpper());
                break;
            case "2":
                Console.WriteLine("\nTexto en Minùsculas: " + inputTexto.ToLower());
                break;

            case "3":
                Console.WriteLine("\nLongitud del Texto Ingresado: " + inputTexto.Length);
                break;
            default:
                Console.WriteLine("\nLa opción ingresada no existe!");
                break;
        }

        Console.WriteLine("\n¿Querés cambiar de palabra? <Si - No>");
        cambiarPalabra = Console.ReadLine();
        while (cambiarPalabra.ToLower() != "si" && cambiarPalabra.ToLower() != "no")
        {
            Console.WriteLine("Error! <Si - No>");
            cambiarPalabra = Console.ReadLine();
        }

        if (cambiarPalabra.ToLower() == "si")
        {
            Console.Clear();
            Console.WriteLine("Por favor, ingrese la nueva palabra: ");
            inputTexto = Console.ReadLine();

        }

        Console.WriteLine("\nOpciones:\n 1 - Texto en Mayúsculas\n 2 - Texto en Minúsculas\n 3 - Longitud de Texto\n 0 - Salir");
        Console.WriteLine("\nIngrese opcion: ");
        opcion = Console.ReadLine();

    }
}
