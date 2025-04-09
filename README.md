# Regla de Simpson 1/3
La regla de Simpson 1/3 obtiene su nombre gracias a un denominador común dentro de su formulación. Esta regla permite encontrar una aproximación del área debajo de una curva en dos dimensiones usando un polinomio interpolado de segundo grado. Dado que el polinomio generado por la interpolación requiere ser de segundo grado, para aplicar la solución se requieren por definición tres puntos base, de los cuales tradicionalmente se usan un límite superior, uno inferior y un punto medio de ambos.

## Fórmula (Sin subdivisiones)
$$ 
    \int_{a}^{b}{f(x)dx} \approx \frac{h}{3} \left\{ f(a) + 4\cdot f\left(\frac{a+b}{2}\right) + f(b) \right\}
$$
Donde:
* $h = \frac{b-a}{2}$

## Fórmula (Con subdivisiones)
$$
    \int_{a}^{b}{f(x)dx} \approx \frac{h}{3} \sum_{j=1}^{\frac{n}{2}}{\left\{ f(x_{2j-2}) + 4\cdot f(x_{2j-1}) + f(x_{2j}) \right\}}
$$
Donde: 
* $h = \frac{b-a}{2}$
* $x_j = a + j\cdot h, j = \left\{ k = 0|0<k\leq n - 1\right\}$
* $x_0 = a, x_n = b$