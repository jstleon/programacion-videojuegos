# 2.2 Variables, constantes y tipos de datos primitivos?

## Scripts en Unity
Cuando creamos un Script en Unity, tendrá la siguiente apariencia:
````C#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

````

El primer bloque que encontramos en la parte de arriba:

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
````

Son necesarias porque es la forma que tenemos en C# de llamar directamente al Engine de Unity y para que se utilicen las colecciones genéricas para empezar a programar. Normalmente cuando creas un script en Unity ya se crean automáticamente, pero en algunos casos deberemos ser nosotros mismos los que agreguemos alguna otra colección.

````C#
public class NewBehaviourScript : MonoBehaviour

````

Este código que vemos es el nombre de la clase que debe ser el mismo que el nombre del script y después de los dos puntos nos indica a qué clase pertenece y en este caso y siempre por defecto pertenece a monoBehaviour. Esta clase debe contener en su interior todo el contenido de nuestro script o dicho de otra manera el comportamiento que queremos que se ejecute.

````C#
    void Start()
    {
        
    }

    void Update()
    {

    }
````

En este bloque o parte del script, es donde declararemos variables y utilizaremos nuestras funciones. En el script tenemos dos comentarios que sirven para informar y siempre van después de un par de comentarios (//) y dos funciones (void Start) y (void Update) que veremos a continuación para que sirven.

### void Start y void Update
Para entender cómo funciona vamos a crear un mensaje para cada función que se va a mostrar por la ventana de Consola de Unity.

Cuando queremos imprimir un mensaje debemos escribir la palabra:
**Debug.Log(“”);**

````C#
void Start()
    {
        Debug.Log("Hola Mundo!");
    }

void Update()
    {
        Debug.Log("Este mensaje se repite hasta el infinito");
    }
````

***void Start*** - Solo se llama una vez.
***void Update*** - Se repite cada frame.

## Variables y Constantes
Para un programador la creación de variables y constantes es algo muy cotidiano, posiblemente las usamos tanto que a veces olvidamos lo que realmente son.

Una **variable*** es un nombre que le damos a un contenedor de datos, este contenedor es una ubicación en memoria de la computadora en la cual está funcionando nuestro programa.

Una **constante** es una variable que guarda un valor que no tiene permitido cambiar.
    
En C# podemos declarar variables de varias formas, aquí hay tres ejemplos:


````C#
int number;
int Number = 10;
const float Pi = 3.14f;
````

En el primer ejemplo ponemos la palabra **int** que indica que esta variable va a contener un número entero y el nombre de la variable es ***number***.

En el segundo caso, también es una varible de números enteros, seguido del nombre de la variable:'Number' y seguidamente asignando un número 10 utilizando el operador =, es decir, esto indica que desde el momento que la creamos, la variable ya tiene un valor por defecto de **10**, el nombre Number empieza con mayúscula, aquí primero hay que aclarar que ***en el mismo scope de código no se pueden declarar dos variables con el mismo nombre***, sin embargo, esta declaración es válida porque **C#** distingue entre mayúsculas y minúsculas (case sensitive) haciendo que *number* y *Number* sean nombres completamente diferentes y aunque no es buena idea empezar los nombres de nuestras variables con mayúscula, aquí solo está para demostrar el punto. Para finalizar el primer ejemplo tenemos simplemente que indicar el final de nuestra sentencia con punto y coma: (;)

El tercer ejemplo es la forma en que declaramos una constante, aquí hay tres puntos principales a resaltar, el primero es que tenemos que iniciar la declaración con la palabra clave **const**, lo que significa que estamos declarando una constante, el tipo de dato que va a almacenar es un **float**, este tipo de dato nos permite almacenar valores con decimales en el espacio de memoria. Como vemos en el ejemplo se está almacenando el valor de **Pi** que contiene decimales, algo muy importante la declaración de constantes es que no es opcional el valor inicial, aquí forzosamente tenemos que asignar un valor al momento de declarar.

Adicionalmente en esta declaración podemos notar que se agregó una letra f después del número decimal, esto es algo que C# se tiene que hacer siempre al finalizar de escribir decimales.

Al igual que con los métodos hay ciertos rasgos que debemos seguir a la hora de declarar nombres de nuestras variables, por ejemplo, el nombre de variable oneItem no va a funcionar en los siguientes casos:

· No podemos iniciar el nombre con un número: ejemplo: 1Item
· No podemos tener espacios en los nombres, por ejemplo: one item

También están las convenciones que siempre recomiendo seguir, en el caso de variables se utiliza camelCase para los nombres, es decir, la primera palabra va todo en minúscula y la primera letra de las palabras siguientes deben ir en mayúscula.

También como recomendación hay que usar nombres descriptivos, en este mismo ejemplo de la variable oneItem, si la declaramos con el nombre oI va a funcionar, está utilizando la convención correctamente, sin embargo no es para nada descriptiva y podría llegar a dificultar la lectura del código o encontrar un bug.

## Tipos de datos primitivos
Los tipos de datos indican qué tipo de valor vamos a guardar en la respectiva variable, ya vimos tres ejemplos de declaraciones, dos utilizando tipo de dato entero (**int**) y otro utilizando el tipo de dato flotante (**float**), usamos **int** para guardar un dato que siempre va a ser decimal (Números enteros) y **float** para cuando queremos guardar un dato de coma flotante, es decir, un número con decimales, **int** y **float** son tipos de datos primitivos (o Built-in) ya que C# puede hacer uso de ellos sin necesidad de crear código adicional, simplemente los podemos utilizar.




