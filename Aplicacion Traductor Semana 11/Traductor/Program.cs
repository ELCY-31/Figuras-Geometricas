using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"time", "tiempo"},
            {"my", "mi"},
            {"the", "el"},
            {"person", "persona"},
            {"year", "año"},
            {"is", "es"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };
        int opcion = -1;
        while (opcion != 0)
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }
            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;
                case 2:
                    AgregarPalabra(diccionario);
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la frase: ");
        string frase = Console.ReadLine() ?? "";
        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string resultado = "";
        foreach (string palabra in palabras)
        {
            string limpia = palabra
                .ToLower()
                .Trim(',', '.', ';', ':', '¡', '!', '¿', '?');
            if (diccionario.ContainsKey(limpia))
            {
                resultado += diccionario[limpia] + " ";
            }
            else
            {
                var item = diccionario.FirstOrDefault(x => x.Value == limpia);
                if (!string.IsNullOrEmpty(item.Key))
                    resultado += item.Key + " ";
                else
                    resultado += palabra + " ";
            }
        }
        Console.WriteLine("\nTraducción: " + resultado.Trim());
    }
    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese palabra en inglés: ");
        string ingles = Console.ReadLine() ?? "";
        Console.Write("Ingrese traducción en español: ");
        string espanol = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(ingles) || string.IsNullOrWhiteSpace(espanol))
        {
            Console.WriteLine("Datos inválidos.");
            return;
        }
        ingles = ingles.ToLower();
        espanol = espanol.ToLower();
        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe.");
        }
    }
}
