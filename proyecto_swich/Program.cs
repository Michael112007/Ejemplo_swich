// See https://aka.ms/new-console-template for more information

Console.WriteLine("operacion de suma y resta");



Console.Write("elija una opcion (suma=s | resta=r)");
char operacion = Convert.ToChar(Console.ReadLine());

switch (operacion)
{

    case 's':
        Console.WriteLine("ha seleccionado la oppcion de suma ");
        break;
    case 'r':
        Console.WriteLine("ha seleccionado la oppcion de resta ");
        break;
    default:
        Console.WriteLine("ha seleccionado la opcion incorrecta");
        break;
}
Console.WriteLine("programa terminado.");








 


