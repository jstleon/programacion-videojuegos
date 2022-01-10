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
int [\] numberArray = {1, 2, 3};

for(int i = 0; i < 3; i++){
	Debug.Log(numArray[i]);
} 
````