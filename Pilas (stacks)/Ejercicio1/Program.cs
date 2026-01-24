using System;
using System.Collections.Generic;
class BalanceoParentesis
{
    static void Main()
    {
        string expresion = "{6 - [(4 + 9) - (2 * 7)] - (8 + 3) + 5}";
        
        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Si es símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es símbolo de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si no hay nada para poder cerrar
                if (pila.Count == 0)
                    return false;

                char ultimo = pila.Pop();

                if (!EsPar(ultimo, c))
                    return false;
            }
        }

        // Si la pila está vacía, está balanceada
        return pila.Count == 0;
    }
    static bool EsPar(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}