using System;

public class ValidadorComprobante
{
    static bool ValidarComprobanteElectronico(string numero)
    {
        // Verifica que el largo total sea exactamente 13 caracteres
        // YXXX-XXXXXXXX = 4 + 1 + 8 = 13
        if (numero.Length != 13)
            return false;

        // Verifica que el primer carácter sea B o F
        char tipo = numero[0];
        if (tipo != 'B' && tipo != 'F')
            return false;

        // Verifica que los caracteres 1, 2 y 3 sean dígitos
        if (!char.IsDigit(numero[1]) || !char.IsDigit(numero[2]) || !char.IsDigit(numero[3]))
            return false;

        // Verifica que el carácter 4 sea un guión
        if (numero[4] != '-')
            return false;

        // Verifica que los 8 caracteres después del guión sean dígitos
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