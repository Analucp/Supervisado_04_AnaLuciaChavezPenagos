using System;

Console.WriteLine("Ana Lucía Chávez Penagos - 1067423");
    int n = 0;

try
{
    Console.WriteLine("Ingrese un número mayor que 0: ");
    n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        throw new Exception("El número que se ingresé debe ser mayor que 0");
}
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    return;
}

int a = 0, b = 1, c = 0;
int i = 0;

while (i < n)
{
    Console.WriteLine("{0}: {1}", i + 1, a);
    c = a + b;
    a = b;
    b = c;
    i++;
}
