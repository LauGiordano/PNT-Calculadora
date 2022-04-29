namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Random rand = new Random();
            int nro1 = rand.Next(1,100);
            int nro2 = rand.Next(1, 100);
            int suma = calculadora.sumar(nro1, nro2);
            int resta = calculadora.restar(nro1, nro2);
            int multiplicacion = calculadora.multiplicar(nro1, nro2);
            int division = calculadora.dividir(nro1, nro2);
            int divisionCero = calculadora.dividir(nro1, 0);

            Console.WriteLine($"El resultado de la división entre {nro1} y {0} es {divisionCero}");
            Console.WriteLine($"El resultado de la suma entre {nro1} y {nro2} es {suma}");
            Console.WriteLine($"El resultado de la resta entre {nro1} y {nro2} es {resta}");
            Console.WriteLine($"El resultado de la multiplicación entre {nro1} y {nro2} es {multiplicacion}");
            Console.WriteLine($"El resultado de la división entre {nro1} y {nro2} es {division}");

        }
    }
}
        

