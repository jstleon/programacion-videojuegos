# 2.2 Variables, constantes y tipos de datos primitivos

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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
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

* No podemos iniciar el nombre con un número: ejemplo: 1Item  
* No podemos tener espacios en los nombres, por ejemplo: one item

También están las convenciones que siempre recomiendo seguir, en el caso de variables se utiliza camelCase para los nombres, es decir, la primera palabra va todo en minúscula y la primera letra de las palabras siguientes deben ir en mayúscula.

También como recomendación hay que usar nombres descriptivos, en este mismo ejemplo de la variable oneItem, si la declaramos con el nombre oI va a funcionar, está utilizando la convención correctamente, sin embargo no es para nada descriptiva y podría llegar a dificultar la lectura del código o encontrar un bug.

## Tipos de datos primitivos
Los tipos de datos indican qué tipo de valor vamos a guardar en la respectiva variable, ya vimos tres ejemplos de declaraciones, dos utilizando tipo de dato entero (**int**) y otro utilizando el tipo de dato flotante (**float**), usamos **int** para guardar un dato que siempre va a ser decimal (Números enteros) y **float** para cuando queremos guardar un dato de coma flotante, es decir, un número con decimales, **int** y **float** son tipos de datos primitivos (o Built-in) ya que C# puede hacer uso de ellos sin necesidad de crear código adicional, simplemente los podemos utilizar.

Además de estos hay varios otros tipos disponibles para que puedas utilizarlos a la hora de crear tu código, los más comunes a los demás de los que ya mencionamos son **byte**, **char** y **bool**, sin embargo esto puede variar dependiendo del tipo de aplicación que estés escribiendo.

Los tipos de datos tienen un rango que indica cuál es el dato menor y el dato mayor que puedes almacenar dentro de esa variable específica, por ejemplo si declaramos una variable de tipo byte, dentro solo podemos almacenar números entre 0 y 255, si por ejemplo queremos asignar un número negativo o un número mayor a 255 esto no está permitido y nos provocará un error en el código.

Además cada tipo de dato necesita reservar un número definido de bytes de memoria, es decir cada tipo ocupa un espacio en nuestra memoria, hay tipos de datos que consumen más que otros, aquí hay que tener cuidado y normalmente utilizar el tipo de dato que menos memoria consume dentro de las posibilidades de nuestra aplicación.

Para poner un ejemplo, si quiero almacenar el número 10.75 en memoria, puedo hacerlo en una variable de tipo **float** y también puedo hacerlo en una variable de tipo **double**, ambos casos están permitidos y aparentemente no afectaría el funcionamiento de nuestra aplicación, sin embargo, al utilizar el tipo double estaríamos utilizando el doble de memoria sin ninguna necesidad.


![Tabla tipos de datos 2.2.1](https://github.com/jstleon/programacion-videojuegos/blob/main/02%20Fundamentos%20de%20C%23/2.2%20Variables%2C%20constantes%20y%20tipos%20de%20datos%20primitivos/img/tabla_tipos_de_dato_2.2.1.png)
Fig. 2.2.1 Tabla tipo de datos

Por supuesto que estos no son los únicos, pero no tendremos que tener que recurrir a otros tipos de datos primitivos. Además de los tipos primitivos podemos crear nuestros propios tipos y utilizarlos como nos convenga.

## Overflowing
Seguramente durante tu proceso de aprendizaje o carrera como programador vas a tener que hacer muchas operaciones matemáticas, contrario a lo que muchos pensábamos al inicio, la mayoría de estas operaciones son muy básicas como sumas, restas, multiplicaciones y divisiones. Sin embargo, es muy común cometer errores incluso al utilizar estas operaciones, escribo esto para entrar en contexto de lo que es **overflowing**. Veamos un ejemplo donde una simple suma puede causar un error grave en nuestro código.

Si por ejemplo declaro la variable:

````C#
byte number = 155;
````

Yo puedo sumarle alguna cantidad a este 155 más adelante en el código con solo escribir number = number + 5; lo que quiere decir que la variable number ahora tiene un tiene almacenado el número 160, ahora, ¿qué pasa si a este número le sumo un 100?

Puedes pensar que el resultado es 260, pero si lo recuerdas, nuestras variables de tipo byte solo pueden almacenar números en un rango de 0 a 255, aun así no vamos a obtener un error, lo que vamos a obtener como resultado es que number tendría almacenado el número 5, ¿de dónde salió ese 5? Bueno, en realidad es fácil de entender, aquí el número máximo que podemos almacenar dentro de number es 255, al sumarle 1 a ese 255 lo que pasa es que regresa a 0 y empieza a sumar desde el inicio de rango, a este comportamiento se le conoce como overflowing.

En nuestro ejemplo queremos almacenar 260 dentro en number que es el tipo byte pero al no haber espacio suficiente en este tipo de dato la suma retorna a cero y empieza a sumar desde ahí, es por esto que intentar meter un 260 en un byte nos da como resultado un 5, muchos IDE modernos incluso nos mostrarán una advertencia al momento de escribir código como este y hasta nos puede sugerir que cambiemos la variable a que sea de tipo entero.

## Scope
En programación de computadoras, el ámbito (referido mediante su denominación en inglés scope) es el contexto que pertenece a un nombre dentro de un programa.

El ámbito determina en qué partes del programa una entidad puede ser usada.
Esto sirve para que se pueda volver a definir una variable con un mismo nombre en diferentes partes del programa sin que haya conflictos entre ellos.

Si una variable es declarada dentro de un bloque (método/función/procedimiento), esta será válida sólo dentro de ese bloque y se destruirá al terminar el bloque.

Adicionalmente, la variable no podrá verse ni usarse fuera del bloque (en el exterior del bloque). La variable dentro del bloque es una variable local y solo tiene alcance dentro del bloque que se creó y sus bloques hijos, pero no en bloques hermanos ni padres, una variable definida fuera de cualquier bloque es una variable global y cualquier bloque puede acceder a ella y modificarla.

````C#
bloqueDeCodigo
{
    // Alcance o ámbito de la variable (Scope)
}

````
Una variable local es aquella a la que se le otorga un [ámbito](https://es.wikipedia.org/wiki/%C3%81mbito_(programaci%C3%B3n)) local. Tales variables sólo pueden accederse desde la función o bloque de instrucciones en donde se declaran. Las variables locales se contraponen a las [variables globales](https://es.wikipedia.org/wiki/Variable_global).

Una variable global es aquella que es accesible en todos los ámbitos de un programa informático. Los mecanismos de interacción con variables globales se denominan mecanismos de entorno global. El concepto de entorno global contrasta con el de entorno local donde todas las variables son locales.

https://es.wikipedia.org/wiki/Ámbito_(programación)
https://es.wikipedia.org/wiki/Variable_local
https://es.wikipedia.org/wiki/Variable_global

## Declaración e impresión de variables

Nosotros trabajaremos principalmente con estos tipos de datos básicos:

**int - números enteros**
**float - números con coma flotante**
**bool - verdadero/falso**
**string - Cadenas de textos**

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int edad = 56;
    public string nombre = "Oscar";
    public float peso = 65.45f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + " tengo: "
        + edad + " años y mi peso es " + peso + "Kg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
````

## Cadenas de caracteres
Las cadenas son probablemente el tipo de dato no primitivo más común, podemos decir que las cadenas son simplemente una secuencia de caracteres, por ejemplo: “Hello world”, en C# siempre escribimos las cadenas dentro de comillas dobles.

````C#
string name = "John";
````

De hecho, podemos componer grandes cadenas utilizando la concatenación, se logra con el operador + aquí un ejemplo donde se une un nombre con el apellido y se coloca un espacio vacío entre cada palabra:

````C#
string name = "John" + " " + "Doe";
````
En este caso la variable name tiene el nombre y el apellido separados por un espacio dentro, si por ejemplo imprimimos el resultado en la consola obtenemos lo siguiente.

````C#
// John Doe
````

El nombre y el apellido aparecen concatenados. 

Las cadenas (string) en realidad son una secuencia de caracteres, o visto desde otro punto de vista, son un array de caracteres, sí, son arrays y podemos tener acceso a sus caracteres individualmente si los tratamos como tal.

Aquí se aprecia cómo podemos tener acceso a la primera letra del nombre si tratamos la cadena como un array y vemos el resultado al imprimir la variable firstChar en nuestra consola. Más adelante seguiremos trabajando con cadenas y las analizaremos en profundidad.

## Enumeradores
Los enumeradores (o enums) son grupos de constantes relacionados entre sí. Comúnmente son utilizados para representar valores numéricos de una forma más simple de recordar o simplemente para crear una lista de selección.

````C#
public enum Speed : int {
    slow =  5,
    high = 10,
    max = 20 
}

Speed vehicleSpeed = Speed.high;
````
Por ejemplo, si tenemos que almacenar tres velocidades diferentes para un vehículo y estas son constantes, en lugar de asignar y crear tres variables, podemos directamente almacenarlas en un enumerador y nuestro código se volverá un poco más explícito.

En nuestro ejemplo vemos el bloque de declaración del enumerador (enum), luego creamos una variable de tipo Speed (nuestro enumerador) y le podemos asignar cualquier valor constante que tengamos dentro de nuestro enumerador, en este caso asignamos el valor de high, y ese valor fácilmente lo podemos convertir a un entero con tan solo hacer una conversión de datos (casting) de la siguiente forma:

````C#
Speed vehicleSpeed = Speed.high;
Debug.Log((int)vehicleSpeed);
````

Aquí se puede apreciar la conversión del valor de high hacia un entero (int) y al imprimirlo obtenemos el valor que tiene la constante high almacenada.

## Tipos por referencia y tipos por valor
En C# tenemos básicamente dos formas de crear nuevos tipos, la primera es con estructuras y la segunda es con clases.

Una de las principales diferencias entre estructuras y clases es cómo se maneja internamente su memoria, las estructuras ocupan solo 8 bytes en memoria, en cambio, las clases pueden utilizar cantidades diferentes de memoria, lo que quiere decir que al no conocer con exactitud el tamaño podría llevar a nuestra aplicación a comportarse de forma inesperada, sin embargo, no tenemos que preocuparnos por esto ya que las estructuras y las clases se manejan de forma diferente.

Las estructuras se manejan como **tipo por valor** y las clases como **tipos por referencia**, OK, si estás algo confundido, es normal y no tienes porqué preocuparte, lo que en realidad importa es conocer el proceso que sigue un tipo y el proceso que sigue el otro.

Los **tipos por valor** son creados a partir de una estructura, todos los tipos de datos primitivos son así y también todas las estructuras personalizadas que creemos en nuestro código, lo que pasa con estos tipos es que se almacenan en una memoria llamada Stack, esta memoria se maneja automáticamente, una vez que los datos dejan de utilizarse, estos son eliminados de la memoria.

Los **tipos por referencia** son creados a partir de una clase, las cadenas de caracteres (strings) y los arreglos (arrays) son tipos por referencia, también todos los tipos personalizados que creemos a partir de una clase, en este caso la memoria la reservamos manualmente utilizando la palabra clave new, además aquí utilizamos una parte diferente de la memoria llamada Heap, esta memoria no se libera automáticamente, todos los objetos creados en esta memoria permanecerán ahí, incluso cuando ya no están siendo utilizados, para limpiar estos objetos existe un proceso llamado Garbage Collection (recolectar basura) que cada cierta cantidad de tiempo se encarga de analizar los objetos que ya no están en uso y los elimina.

