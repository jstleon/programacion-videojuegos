# 2.5 Loops

Un loop es un bucle, una repetición de una condición o serie de condiciones un cierto número de veces o hasta que se cumpla una o alguna de estas condiciones. Tenemos que tener cuidado con los loops porque si nos equivocamos podemos crear un loop infinito y bloquear Unity.

Los bucles también llamados, sentencias de iteración y son otra herramienta crucial en el momento de controlar el flujo del código, nos permiten hacer cosas como recorrer los elementos de un array en su totalidad o crear loops (bucles) infinitos que son esencialmente útiles para crear movimientos en pantalla, en otras palabras, estas sentencias se repiten a sí mismas mientras se cumpla una condición.

En C# existen cuatro tipos de sentencias de iteración, cada una con sus características de operación y con una sintaxis distinta, estas sentencias son:

**for ~ foreach ~ while ~ do-while**

## for
La sentencia **for** es probablemente la más utilizada de todas las sentencias de interacción, está compuesta de la palabra clave for y tres elementos que nos indican la forma en que esta sentencia será ejecutada, veamos un ejemplo:

````C#
for(int i = 0; i < 10; i++){
	/* código a repetir */
}
````

Como se puede apreciar dentro de la sentencia for, agregamos tres elementos que están separados por punto y coma (;)

El primero de ellos (int i = 0;) es el índice. Este elemento es básicamente la declaración de una variable de tipo numérico, en este ejemplo declaramos un entero (int) y lo inicializamos a 0 lo que quiere decir que nuestro índice inicial tendrá un valor de 0 y lo llamamos simplemente i.

El siguiente elemento es la condición en este caso es i < 10;, es decir, mientras el valor de i sea menor a 10 el código que metamos dentro del scope (alcance) de este for continuará ejecutándose en repetidas ocasiones, de lo contrario el for finalizará.

Después, también separado por punto y coma (;) tenemos el incremento, que básicamente hace eso, incrementar el valor de i, en este caso lo estamos haciendo de uno en uno porque utilizamos el operador ++, se puede incrementar el valor del índice en pasos más grandes pero para fines prácticos también por ser la operación más común lo hacemos de uno en uno.

Ejemplo de cómo podemos recorrer los elementos de un array utilizando una sentencia for:

````C#
int [ ] numberArray = {1, 2, 3};

for(int i = 0; i < 3; i++){
	Debug.Log(numArray[i]);
} 
````

Primero declaramos un arreglo (array) y lo inicializamos con los números 1, 2 y 3 dentro, después hacemos nuestra declaración del bucle for, que tiene condición iterar desde el índice 0 hasta el 2 ya que inicializamos nuestra variable i en 0 y la condición es que sea menor a 3, dentro del for imprimimos los valores que tienen numbersArray en cada uno de sus índices y vemos el resultado en la consola.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucleFor : MonoBehaviour
{
    public int tabla;
    private int resultado;
    private int valor;
    
    void Start()
    {
        for (valor = 0; valor <= 10; valor++) {
            resultado = valor * tabla;
            Debug.Log(valor + " x " + tabla + " = " + resultado);
        }
    }
}
````
## foreach
La sentencia de iteración **foreach** resulta muy conveniente en varios casos ya que su sintaxis es muy sencilla y puede alterar en cualquier tipo de dato en numerables, es decir, que esté compuesto de un listado de datos, puede hacerlo tanto en un array como en una cadena de caracteres ya que esta cadena está compuesta de caracteres individuales y no tiene la necesidad de utilizar un índice.

````C#
int[] numberArray = {1, 2, 3, 4, 5};

foreach(int number in numberArray) {
	Debug.Log(number);
}
````
Empezamos declarando un simple array y lo inicializamos con cinco números enteros, ya dentro del **foreach** empezamos con la declaración de la variable temporal **int number** seguida de la palabra clave **in** y el nombre del array.

Lo que estamos indicando aquí es que por cada número entero que exista dentro de la raíz **numberArray** y la sentencia **foreach** va a iterar una vez, y en cada una de esas interacciones va a imprimir en la consola el valor correspondiente a la iteración, es por eso que en la consola vemos los números del uno al cinco que son los que almacenamos en array. 

Aquí además vemos una gran ventaja al no utilizar un índice, ya que si por alguna razón cambiamos el tamaño del array, es decir, si agregamos o quitamos enteros del mismo, no es necesario modificar nuestro código del foreach ya que éste seguirá funcionando adecuadamente.

````C#
string greeting = "Hola!";
foreach(char c in greeting);
Debug.Log(c);
````
En este ejemplo podemos observar que no declaramos array alguno, ni utilizamos ningún índice, sin embargo, foreach nos permite iterar a través de cada uno de los caracteres de la cadena y los imprime uno por uno.

## while
también tenemos disponibles los bucles while, los cuales seguirán iterando mientras una condición indicada entre paréntesis se siga cumpliendo, aquí un ejemplo para revisar su sintaxis.
````C#
int i = 0;
while(i < 10){
	i++;
}
````
Primero tenemos que declarar un índice, luego entre paréntesis agregamos nuestra condición y dentro del **while** incrementamos el valor del índice, si tenemos un índice, una condición y un incremento, básicamente es lo mismo que una sentencia **for** pero con una sintaxis diferente.
````C#
public class bucleWhile : MonoBehaviour
{

    private int valor = 0;
    public int tabla;
    private int resultado;
    
    void Start()
    {
        while (valor <= 10) {
            resultado = valor * tabla;
            Debug.Log(valor + " x " + tabla + " = " + resultado);
            valor++;
        }
    }
}
````

## do-while
La sentencia de iteración do-while es una variante de while en la cual el código dentro de la sentencia se ejecuta al menos una vez y la condición se evalúa al final de la sentencia en lugar de al inicio:

````C#
bool playerIsAlive = false;

do {
	/* El código escrito aquí se
	ejecutará al menos una vez */
}while(playerAlive == true);
````

Aquí declaramos el índice antes de la sentencia, igual que con un while, pero utilizamos la palabra clave do para iniciar la sentencia, todo el código que está dentro del scope (alcance) dentro del bloque de código ({ })se ejecutará al menos una vez y al final evaluamos la condición para ver si seguiremos liderando.

También en este código vemos que podemos utilizar otro tipo de condiciones y no necesariamente contadores, en este caso el código de do-while se ejecutará al menos una vez y lo seguirá haciendo mientras la variable playerIsAlive sea igual a true.

## break y continue
Las palabras claves break y continue también forman parte importante de las herramientas de las que disponemos para controlar el flujo del código, anteriormente utilizamos **break** para finalizar la ejecución de la sentencias switch-case, al utilizarla dentro de una sentencia de iteración lo que logramos es salir de la misma y no seguimos iterando, si utilizamos **continue** lo que logramos es saltar a la siguiente iteración de la sentencia, es decir, solo ignoramos el código restante después de la palabra clave continue pero la sentencia seguirá iterando si su condición se sigue cumpliendo.

> Ejercicio: Imprime los números del 10 al 1

````C#
for(int i = 10; i > 0; i--){
	Debug.Log(i);
}
````

En esta solución utilizamos un **for** en el cual inicializamos un índice en 10 que es el primer número que queremos imprimir, después en nuestra condición indicamos que siga iterando mientras el índice sea mayor a cero ya que queremos seguir imprimiendo los números hasta llegar 1, y también cambiamos la forma de modificar el índice, ya que en este caso estamos de decrementando en lugar de incrementar el valor del índice, así obtenemos el resultado deseado en nuestra consola.

````C#
int i = 10;
while(i > 0){
	Debug.log(i);
	i--;
}
````

Aunque en este caso estamos utilizando un while, en realidad el comportamiento del índice y la condición son idénticos a los que utilizamos para el primer caso, iniciamos nuestro índice en 10, y se ejecuta un bucle mientras el índice sea mayor a cero y de incrementamos el índice en lugar de implementarlo.

La sentencia de iteración pueden resultar un poco confusas en un principio, sin embargo, son bastante sencillas de implementar y bastante comunes de utilizar en el día día, como siempre, la recomendación es seguir practicando con ejercicios sencillos.

Algo muy importante a tomar en cuenta es que podemos crear sentencias de interacción infinitas, mejor conocidas como Luke’s infinitos, es decir, sentencias cuya condición de finalización nunca se cumple, en algunas ocasiones estas pueden resultar útiles, pero también en ocasiones pueden ser muy peligrosas y causar el fallo en la ejecución de una publicación, tomemos como ejemplo el siguiente código:

````C#
int i = 10;
while(i > 0){
	Debug.log(i);
	i++;
}
````

Es prácticamente el mismo código que nuestro ejemplo anterior, con la diferencia de que el índice está incrementando, lo cual causaría que la condición siempre se cumpla y una vez que nuestra aplicación llegue a esa parte del código, ahí se va a quedar para siempre y probablemente dejaría de comportarse como queremos e incluso en algunas ocasiones provocar que la aplicación se cierre de imprevisto.





