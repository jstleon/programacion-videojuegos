# 2.3 Conversión de datos, operadores y comentarios

## Convertir un tipo de datos en otro
En ocasiones es necesario convertir un tipo de dato en otro, anteriormente en la sección de overflowing vimos que a veces tenemos casos en los que hay que meter un número más grande del que la variable puede guardar por el tipo de la misma, incluso los IDE nos pueden sugerir hacia qué tipo debemos de cambiar nuestra variable.

Existe más de una forma en que un tipo de dato se puede convertir en otro, a veces es de forma implícita y en ocasiones de forma explícita.

## Conversión implícita
La conversión implícita se hace automáticamente, ya hablamos de números que no caben en una variable por su tipo de dato, pero también sucede que números de un tipo de dato se asignan a variables de otro tipo en donde no tendrían problemas con el espacio, por ejemplo, si tenemos las siguientes dos variables.

````C#

byte counter = 1;
int number = counter;

````
En la primera línea declaramos counter que es de tipo byte, si recuerdas la tabla de cuánto espacio necesita el tipo byte en memoria recordarás que solo necesita un byte (de ahí su nombre), en la segunda línea estamos guardando el valor de counter en la variable tipo entero number, si recuerdas, las variables tipo entero utilizan 4 bytes en memoria, por lo tanto no tenemos problemas de espacio aun cuando counter esté en su número más alto, tomamos la siguiente tabla como referencia.

| Variable | Espacio en memoria |
| ------------- | --------------|
| counter | 00000001 |
| number | 00000000 00000000 00000000 00000001 | 

Aquí fácilmente nos podemos dar cuenta de que counter cabe dentro de number y en casos se realiza una conversión explícita en donde en realidad no tenemos que hacer absolutamente nada, es importante destacar aquí que, aunque number solo esté guardando el número 1, dentro está ocupado todos los 4 bytes (32 bits) en memoria.

Pero ¿qué pasaría si el caso fuera al revés? Es decir, si quisiéramos meter un entero dentro de un byte, por ejemplo.

````C#
int number = 1;
byte counter = number;

````
En este caso estamos intentando guardar un entero en un byte y aunque el número 1 que tiene dentro ese entero cabría perfectamente en una variable de tipo byte, no se puede guardar porque en realidad es más grande que el máximo número que soporta el tipo byte, recuerda que su tamaño en realidad es cuatro veces más grande debido a que está ocupando 4 bytes en memoria, de hecho puedes ver que Visual Studio Code pone una línea de advertencia en color rojo debajo de number, esto indica que tendremos un error si intentamos procesar este código, para este tipo de casos también podemos hacer una conversión pero lo que necesitamos ahora es un conversión explícita.

## Conversión explícita (casting)
La conversión explícita también se le conoce como casting y consiste escribir código que cambia un tipo de dato a otro, en el caso que tenemos actualmente donde no podemos asignar number a counter debido a que un entero necesita más espacio que un byte, podemos escribir el tipo de dato al que queremos convertir justo detrás del nombre de variable para explícitamente indicarle hacia qué tipo queremos convertir, en este caso para convertir hacia entero ponemos int entre paréntesis de la siguiente forma.

````C#
int number = 1;
byte counter = (byte)number;
````
De esta forma el número 1 almacenado dentro de number podemos asignarlo sin problema dentro de counter, si procesamos nuestro código en este momento funcionará sin problemas, si imprimimos counter, la consola debería de verse similar a esto.

````C#
int number = 1;
byte counter = (byte)number;
Debug.Log(counter);
````
Sin embargo, hay que tener cuidado porque aquí no estamos exentos de problemas, aun haciendo un casting podemos toparnos con problemas de **overflowing** si asignamos un número mayor a 255 a number, es totalmente viable pero mira lo que pasa si asigno el número 260 a number y vuelvo a ejecutar este código.


Aquí podemos ver un caso de overflowing  en el momento de hacer conversión del tipo int  a byte  y esto genera pérdida de datos, hay que tener mucho cuidado con esto porque, aunque es un error, nuestro código va a procesarse normalmente IDE no nos advierte de estos casos.

Existen tipos de datos que nos son compatibles y que requieren un poco más de nuestro esfuerzo para poder realizar una conversión, un caso común es cuando queremos convertir un string a un int como en el siguiente caso.

````C#
string number = "1";
int numberAsInt = (int)number;
````
Esto no funciona debido a que int y string no son compatibles, la buena noticia es que tenemos formas de hacerlo y es bastante simple, hay dos formas que yo utilizo comúnmente y aunque no son las únicas sí me parecen las más sencillas de utilizar, la primera es utilizando un método llamado **Parse**, este método pertenece a la clase **int** y nos permite hacer una conversión hacia entero de un string que pasamos como parámetro, se utiliza de la siguiente forma.

````C#
string number = "1";
int numberAsInt = int.Parse(number);
````

Ahora ya no tenemos ningún error, porque así estamos convirtiendo correctamente una variable de tipo string a int, si queremos ahora incluso podemos crear operaciones matemáticas con numberAsInt.

````C#
string number = "1";
int numberAsInt = int.Parse(number);
int sum = numberAsInt + 13;
Debug.log(sum);
````
Aquí vemos el resultado de una suma, que utiliza el número que inicialmente era un string, guardarse en una nueva variable llamada sum cuyo valor se imprime en la consola.

Otro método que yo constantemente utilizo para convertir en este caso de int a string es la concatenación, sí, ya utilizamos concatenación anteriormente pero aquí va un pequeño truco para que usándola puedas pasar números enteros a cadenas de caracteres sin utilizar algún método, solo tienes que concatenar una cadena vacía a tu número para que funcione, aquí el ejemplo:

````C#
int numberAsInt = 1;
string number = "" + numberAsInt;
````

Así de sencillo puedes asignar un número entero a una cadena de caracteres.

## Operadores
En esta sección veremos con detalle de los operadores, ya utilizamos algunos de los más comunes, pero existen muchos más e incluso están divididos en categorías: aritméticos, comparativos, de asignación, lógicos y bitwise. Revisemos cada una de las categorías separadas en tablas para que sea más fácil identificarlos.

### Operadores aritméticos
| Operador | Sígno |
| --------- | ------- |
| Suma | + |
| Resta | - |
| Multiplicación | * |
| Divisor | / |
| Módulo | % |
| Incremento | ++ |
| Decremento | -- |

Probablemente la mayoría de los aritméticos son muy obvios.

El operador + suma dos números o variables, además del uso que ya vimos para concatenación.

El operador - resta dos números o variables, también puede usarse para indicar que un número es negativo.

El operador * se usa para multiplicar dos números o variables

El operador / Divide

El operador % devuelve el resto de una división entre dos números o variables

los operadores de incremento ++ y decremento -- se colocan delante o detrás de una variable int o byte para incrementar o decrementar su valor 1.

Los operadores aritméticos nos permiten realizar operaciones con nuestras variables, es decir si tenemos una variable energía = 100 y un enemigo te dispara con un arma de daño = 50, a tu energía se le restará 50.

Vamos a calcular la velocidad que tiene un objeto sabiendo la distancia recorrida y el tiempo que hemos utilizado.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcularVelocidad : MonoBehaviour
{
    private float velocidad;
    public float tiempo = 5.1f;
    public float distancia = 8.1f;

    void Start()
    {
        
    }

    void Update()
    {
        velocidad = distancia / tiempo;
        Debug.Log("Mi velocidad es de: " + velocidad);
    }
}
````
### Operadores de Asignación
| Operador | Sígno |
| --------- | ------- |
| Asignar | = |
| Asignar suma | += |
| Asignar resta | -= |
| Asignar multiplicación | *= |
| Asignar división | /= |

Los operadores de asignación se usan básicamente para guardar un dato en una variable, de la forma que ya utilizamos el operador = para asignar valores anteriormente, podemos utilizar los operadores ``+=``, ``-=``, ``*=`` y ``/=`` para en el momento de asignar además ejecutar una operación, por ejemplo, si a la variable le quiero sumar el contenido de la variable b, normalmente escribiremos la siguiente línea.

````C#
a = a + b;
````
Podemos tomar un atajo utilizando el operador += de la siguiente forma.
````C#
a += b;
````
Y lo mismo puedo hacer para restas, multiplicaciones y divisiones utilizando el resto de los operadores.

### Operadores comparativos
| Operador | Sígno |
| --------- | ------- |
| Igual que | == |
| Diferentes a | != |
| Mayor que | > |
| Mayor o igual que | >= |
| Menor que | < |
| Menor o igual que | <= |

Cuando usamos los operadores comparativos el resultado siempre se representa como verdadero o falso.

El operador == nos regresa verdadero en caso de que los datos en ambos lados del operador sean iguales.

!= devuelve verdadero cuando los datos comparados son diferentes.

El operador > regresa verdadero cuando el dato a la izquierda del operador es mayor que el dato al lado derecho.

El operador >= además de retornar verdadero cuando el dato de la izquierda es mayor, también lo hace cuando ambos datos son iguales.

El operador > devuelve verdadero cuando el dato a la izquierda es menor que el dato a la derecha.

El operador >= regresará verdadero cuando el dato a la izquierda es menor y también cuando los datos comparados son iguales.

### Operadores lógicos
| Operador | Sígno |
| --------- | ------- |
| AND | && |
| OR  | \|\| |
| NOT | ! |

Los operadores lógicos los utilizamos en sentencias condicionales, por ejemplo, cuando una condición se cumple y necesitamos que otra más se cumpla utilizamos el operador **&&**, si necesitamos que se cumpla una de las dos condiciones entonces utilizamos el operador **||**, también tenemos el operador **!** que simplemente actúa como una negación de la condición, más adelante veremos ejemplos de estas sentencias de condición.

**&&  (AND)**  = Ambos deben ser verdaderos
**|| (OR)** = Uno de los dos debe ser verdadero
**! (NOT)** = !true = false

### Operadores Bitwise
| Operador | Sígno |
| --------- | ------- |
| AND | & |
| OR  | \| |

Los operadores **Bitwise** se usan operadores a nivel de bits, son comúnmente utilizadas en programación de bajo nivel, uso de máscaras o encriptación, todos temas muy avanzados para el alcance de este manual, solo vamos a comentar que son equivalente de los operadores && y || pero los bitwise manejan esas comparaciones lógicas bit por bit.

No te preocupes si no entiendes del todo el uso de los operadores, tampoco tienes que preocuparte por memorizarlos, en el transcurso de este módulo estaremos utilizando prácticamente todos (con excepción de bitwise) y verás que poco a poco los estarás utilizando intuitivamente.

## Comentarios
Los comentarios son líneas de texto que podemos escribir junto con nuestro código y que nos permiten entre otras cosas agregar indicadores de cómo funcionan partes de nuestro código, escribir pseudocódigo para planear bien el código que vamos a escribir antes de hacerlo, deshabilitar parte de nuestro código en busca de errores o simplemente para probar comportamientos diferentes, etc.

> Nota: le llamamos pseudo código a una representación menos abstracta (si lo vemos desde el punto de vista del programador) de la tarea que va a realizar nuestro código que nos ayuda en el planteamiento antes de escribir línea de código.

En C# existen dos formas de escribir un comentario, la primera es el comentario de línea simple y para escribir este tipo de comentarios basta con escribir dos diagonales seguidas, todo lo que esté a la derecha de esas diagonales contará como comentario y no afectará el comportamiento de nuestro código.

````C#
// Este es un comentario de línea
int numberAsInt = 1;
````
También tenemos los comentarios multilínea o de bloque, esto no nos sirven principalmente para comentar varias líneas de código texto que se encuentren dentro del Scop del comentario, para abrir el Scop se utiliza una diagonal seguida de un asterisco (/*) y para cerrarlo usamos un asterisco seguido de una diagonal (*/)

````C#
/* Este es un comentario en bloque
int numberAsInt = 1;
string number = "" + numberAsInt;
*/ 
````
Tienes que tener en mente siempre que, aunque los comentarios nos pueden ayudar en gran medida entender entender el código que estamos implementando, siempre es mejor mantener los comentarios al mínimo escribir código limpio, bien organizado y que sigan las convenciones, siempre será prioridad y nos permitirá solo escribir comentarios cuando sea absolutamente necesario.