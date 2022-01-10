# 2.7 Arrays

Los arrays son matrices que nos permiten almacenar múltiples objetos en una misma variable.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public string[] lista;
    
    void Start()
    {
        lista = new string[4] { "Juan,", "María", "Antonio", "Lourdes" };
        foreach (string nombre in lista) {
            Debug.Log(nombre);
        }
    }
}
````

## Arrays
Los arreglos (Arrays) son otro tipo de dato no primitivo que podemos definir como una colección de datos del mismo tipo, de hecho, En C# existen varios tipos de colecciones de datos y podemos considerar los Arrays como los más básicos y también más utilizados.

Si por ejemplo queremos guardar los valores X, Y y Z de un vector en variables, podríamos declarar tres variables de tipo entero, una para cada eje, pero también podemos declarar un arreglo que pueda contener tres números enteros en una sola variable, aquí un ejemplo de ambos casos:

````C#
int xAxis;
int yAxis;
int zAxis;

int [ ] vector3 = new int [3];
````

Aquí primero vemos la declaración de tres variables de tipo entero y después la declaración de un array que permitiría almacenar el mismo tipo y cantidad de datos pero utilizando una sola variable, es importante resaltar la sintaxis de la declaración que después del tipo (en este caso int) debemos añadir corchetes para indicar que estamos creando una matriz, luego, después del símbolo = vemos la palabra clave **new** que indica que vamos a reservar memoria para esta variable, al final además añadimos de nuevo el tipo Y entre corchetes la cantidad de valores que vamos a guardar o también le podemos llamar el tamaño del **array**.

En un principio puede resultar un poco confusa esta sintaxis, pero no te preocupes, basta con que la analices detenidamente por unos minutos y empezará a cobrar sentido, además de que estaremos utilizando arrays en varias ocasiones, por ahora la duda más grande que deberías tener es, ¿una vez declarado el array, como leo o escribo datos dentro de él? Vamos a verlo en un ejemplo donde utilizamos un índice para indicar a qué elemento del array estamos haciendo referencia:

````C#
int xAxis;
int yAxis;
int zAxis;

int [ ] vector3 = new int [3];

vector3[0] = 1;
vector3[1] = 2;
vector3[2] = 3;
````

En la imagen vemos cómo podemos almacenar datos dentro de un array, sabemos que nuestro array puede almacenar hasta tres enteros dentro y para guardar un dato en el primer entero utilizamos el índice 0, en este caso para almacenar el número 1, luego utilizamos 1 para el segundo entero y 2 para el tercero almacenando un número 2 y un número 3 respectivamente. Es muy importante recordar que el índice de una raíz siempre empieza en 0. Uno de los errores más comunes que cometemos al empezar a trabajar con arrays. Es pensar que el índice empieza en uno.

Al igual que una variable normal se puede inicializar un array al momento de declararlos esto se hace de la siguiente forma:

````C#
int [ ] vector3 = new int[3] { 1, 2, 3 };
````

Aquí estamos indicando entre llaves los valores iniciales que tendrá nuestro array, de hecho, al utilizar la sintaxis de llaves podemos prescindir de la palabra clave **new** y del tamaño que tendrá nuestro array, quedaría de la siguiente forma:

````C#
int [ ] vector3 = { 1, 2, 3 };
````

Para leer un valor almacenado dentro de una raíz es la misma lógica que al escribirlo, solo indicamos el índice del elemento del cual queremos extraer la información, quedaría de la siguiente forma:

````C#
int [ ] vector3 = { 1, 2, 3 };
Debug.Log(vector3[2]);
```
Este código imprime el número tres en la consola.



