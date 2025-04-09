double lim_inferior, lim_superior;
bool mostrarInformacion;

// f(x) = x^2
double fx(double x) {
    return x*x;
}

// Aplicación de regla simpson 1/3
// NOTa: Esta forma únicamente es válida cuando, y solo cuando, no se requiere de hacer subdivisiones entre los intervalos.
double simpson13(Func<double, double> f, double a, double b) {

    double h = (b - a) / 2;
    double x0 = a;
    double x1 = a + h;
    double x2 = b;

    if (mostrarInformacion) {
        Console.WriteLine($"h = {b} - {a} / 2 = {h}");
        Console.WriteLine($"x0 = {a} = {x0}");
        Console.WriteLine($"x1 = {a} + {h} = {x1}");
        Console.WriteLine($"x2 = {b} = {x2}");
    }

    return h/3 * (f(x0) + 4 * f(x1) + f(x2));
}

// Titulo
Console.WriteLine(new string('*', 50));
Console.WriteLine(new string('-',15) + "Regla de Simpson 1/3" + new string('-',15));
Console.WriteLine(new string('*', 50));

// Solicitar limite inferior
Console.WriteLine("Ingrese el limite inferior: ");
Console.Write(">>"); lim_inferior = Double.Parse(Console.ReadLine()!);

// Solicitar limite superior
Console.WriteLine("Ingrese el limite superior: ");
Console.Write(">>"); lim_superior = Double.Parse(Console.ReadLine()!);

// Preguntar si se imprime toda la información
Console.WriteLine("(Opcional) ¿Mostrar información de parametros? (s/n)");
Console.Write(">>"); mostrarInformacion = Console.ReadLine()!.Equals("s", StringComparison.CurrentCultureIgnoreCase);

// Calculo de area
double area = simpson13(fx, lim_inferior, lim_superior);
Console.WriteLine($"|   El area bajo la curva es: {area} u^2   |");