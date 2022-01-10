# 2.4 Estructuras condicionales

## if-else
En la vida diaria tomamos decisiones a cada momento. Según nuestra toma de decisiones suceden acontecimientos, es decir, imaginate tu personaje en una gruta con dos posibles salidas; salida de la izquierda y salida de la derecha.

Resulta que si escoges la de la derecha encuentras el tesoro y si escoges la salida izquierda se te come un dragón. De eso se encarga la declaración if, de comparar situaciones o valores y darnos un resultado según nuestra decisión.

A estas estructuras las llamamos condicionales o sentencias de condición, y son las herramientas básicas que podemos utilizar en C# para controlar el flujo de nuestro código, y tal vez la más común de todas estas es la sentencia if, que comúnmente se utiliza en conjunto con una sentencia else. 

La idea detrás de un condicional es decidir si ejecutar o no una parte del código basándose en si se cumplen una o varias condiciones.

````C#
if(/* condición */) {
  /* Aquí va el código que solo se
  ejecuta si se cumple la condición */
}
````
Así de simple, si la condición se cumple, se ejecuta el código, si no, se ignora.

A esta sentencia if le podemos añadirlas en una sentencia else, esta sentencia lo que hace es considerar todos los casos no contemplados en la sentencia if.

````C#

if(/* condición */) {
  /* Aquí va el código que solo se
  ejecuta si se cumple la condición */
}else{
  /* En caso de que la sentencia if
  no se cumpla ejecutamos el código
  que se encuentra aquí */
}

````

En el siguiente ejemplo dependiendo del valor de la puntuación, mostrará en la consola si el jugador es: Principiante, Intermedio o Experto.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparaciones : MonoBehaviour
{

    public int puntuacion = 35;

    void Start()
    {
        
    }

    void Update()
    {
        if (puntuacion >= 100)
        {
            Debug.Log("Experto");
        }
        else if (puntuacion < 100 && puntuacion >= 50)
        {
            Debug.Log("Intermedio");
        }
        else
        {
            Debug.Log("Principiante");
        }
    }
}
````

Es importante distinguir de manera correcta la sintaxis de una sentencia if-else, cada parte tiene un par de llaves para englobar el código que escribiremos dentro. También es posible anidar las sentencias if, es decir, dentro de una, el código puede ser otra sentencia similar.
````C#
if( */condición*/ )  {
	if( */otra condición*/ ) {

      }else{

  }
}

````

En este caso la sentencia **if-else** sólo será considerada para evaluación en caso de que la primera condición se cumpla, de lo contrario se ignora por completo.

Parece algo un poco trivial, pero ser capaz de anidar sentencias de condición se convierte en una herramienta muy poderosa para controlar el flujo de nuestro código.

````C#

int score = 0;
int power = 1;

if(score > 100){
	power = 3;
}

````

En este caso la variable power que inicializamos con un valor de 1 y tendrá un valor de 3 en caso de que el valor almacenado en score sea mayor a 100, es decir, en este caso la condición no se cumple dado que el valor de score es cero y la línea:
````C#
power = 3;
````
será ignorada.

Cuando se presentan casos como el siguiente:

````C#
int score = 0;
int power = 1;

if(score == 100){
	power = 3;
}

if(score == 200){
	power = 7;
}

if(score == 300){
	power = 10;
}

if(score == 400) {
	power = 13;
}

if(score == 500){
	power = 17;
}
````

Aquí nos topamos con una serie de sentencias if una detrás de otra y aunque el código puede cumplir su propósito, también sucede que empieza a volverse algo largo innecesariamente, para este tipo de propósito existe una sentencia de condición llamada **switch-case**.


## switch-case
El switch nos permite tomar de una variable su valor y realizar múltiples operaciones dependiendo del valor de la variable. La sentencia de condición switch-case tiene una sintaxis muy peculiar que podemos ver en el siguiente código:
````C#
int score = 0;
byte power = 1;

switch(score){
	case 100:
		power = 3;
		break;
	case 200:
		power = 7;
		break;
	case 300:
		power = 10;
		break;
	case 400:
		power = 13;
		break;
	case 500:
		power = 17;
		break;
}
````

Este código tendría el mismo resultado que tener varias sentencias if, una detrás de otra, pero con dos principales ventajas: es más ordenado y es más rápido.

Primero hay que entender la sintaxis, se comienza con la palabra clave **switch** y se pone entre paréntesis la variable a evaluar (en este caso **score**) luego se abren las llaves, dentro de las llaves tenemos varias veces la palabra clave **case** que nos indica un posible resultado positivo de la evaluación de score, es decir, en el primer caso nos dice que si score es igual a 100 entonces power será igual a 3, después algo muy importante la palabra clave **break**, este comando nos permite salir del scope del switch al encontrar un resultado positivo, por ejemplo, si score resulta ser igual a 100 se ejecuta en ese caso y el break rompe el flujo y no hace las demás evaluaciones, lo que provoca que no se ejecuten operaciones innecesarias en comparación con tener varias sentencias if.

> Reto: Crea un código que imprima que puedes acceder a un lugar dependiendo de la edad que introduzca el usuario.

Vamos a realizar un ejercicio muy básico para mostrar las posibilidades de switch.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public int arma = 0;

    void Start()
    {
        
    }

    void Update()
    {
        switch (arma)
        {
            case 1:
                Debug.Log("Pistola");
                break;
            case 2:
                Debug.Log("Escopeta");
                break;
            default:
                Debug.Log("Nada");
                break;
        }
    }
}
````