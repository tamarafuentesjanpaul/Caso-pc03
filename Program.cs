using System;

public class ValidadorComprobante
{
    static bool ValidarComprobanteElectronico(string numero)
    {
        
        if (numero.Length != 13)
            return false;

        
        char tipo = numero[0];
        if (tipo != 'B' && tipo != 'F')
            return false;

        
        if (!char.IsDigit(numero[1]) || !char.IsDigit(numero[2]) || !char.IsDigit(numero[3]))
            return false;

        
        if (numero[4] != '-')
            return false;

        
        for (int i = 5; i <= 12; i++)
        {
            if (!char.IsDigit(numero[i]))
                return false;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   Validador de Comprobante Electrónico  ");
        Console.WriteLine("========================================");

        Console.Write("Ingrese el número de comprobante: ");
        string numero = Console.ReadLine() ?? "";

        bool resultado = ValidarComprobanteElectronico(numero);

        if (resultado)
            Console.WriteLine($"✓ '{numero}' es VÁLIDO");
        else
            Console.WriteLine($"✗ '{numero}' es INVÁLIDO");

        Console.WriteLine("========================================");
    }
}
