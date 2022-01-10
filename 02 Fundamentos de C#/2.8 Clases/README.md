# 2.8 Clases
Hasta ahora el tipo de programación que hemos visto es secuencial es decir empezaba arriba y Unity lo ejecuta de arriba a abajo. En la programación orientada a objetos (POO) es un poco más compleja en el sentido de que está basada en la comunicación entre objetos.

## Clases
Además de poder utilizar los tipos de datos que C# nos provee dentro de sus librerías, nosotros podemos crear nuestros propios tipos de datos y la base para lograrlo son las clases. Con cada clase que creamos estamos creando también un nuevo tipo de dato, una clase es una especie de plano a partir del cual podemos crear un objeto o también podemos decir que creamos una instancia de clase.

Por ejemplo, nosotros podemos crear una clase llamada Car que contenga las variables (o atributos) y los métodos (o funciones) de un coche, a partir de esta clase podemos crear un objeto (o instancia de clase) y a este objeto podemos llamarle sportCar, luego podemos crear otro a partir de la misma clase llamarlo familyCar, ambos son objetos creados a partir de la misma clase, y para crearlos solo necesitamos declarar el tipo y el nombre, tal y como declararíamos una variable.

````C#
public class Car
{
	public string color: "blanco";

	public void Gas()
	{
		Console.WriteLine("Increase speed");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Car sportCar = new Car();
		Car familyCar = new Car();

		familyCar.color = "naranja";
		sportCar.color = "azul";

		sportCar.Gas();
	}
}

````

Primero vemos en la parte de arriba una clase con una variable y un método público, esto es importante para poder tener acceso desde otra clase, luego en nuestra clase principal creamos dos objetos a partir de esta clase, sportCar y familyCar y los inicializamos, no es importante entender por ahora como inicializar los objetos así que no entraremos en ese detalle, después vemos acceso a la variable color tanto en el objeto sportCar como en el familyCar, además también vemos un acceso al método gas del objeto sportCar, esto es un ejemplo muy pequeño y simple de una clase y cómo tener acceso a sus variables y métodos pero más que suficiente para lograr muchas cosas más adelante, esta es la base de la programación orientada objetos y el uso de clases.

## 1# Atributos
Vamos a crear una tabla de records en donde cada jugador pueda introducir el nombre, y que nos diga el número de partidas jugadas, el tiempo invertido de juego y si el jugador está activo o no.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class infoPlayer
{
    public string nombre;
    public int partida;
    public float tiempo;
    public bool activo;
}
````
En primer lugar, debes borrar todo lo que viene por defecto, puesto que vamos a crear una clase que nos proporcione información del player y luego para que podamos ver las variables y los atributos en el inspector de Unity debemos escribir entre corchetes System.Serializable.

El siguiente paso es crear una clase pública para poder acceder desde cualquier script y le ponemos el mismo nombre. Ahora solamente declaramos las variables que necesitamos: nombre, partida, tiempo y activo.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablaRecords : MonoBehaviour
{
    public infoPlayer player1;
    public infoPlayer player2;
    // Start is called before the first frame update
    void Start()
    {
        player1.nombre = "Paco";
        player1.partida = 8;
        player1.tiempo = 6.25f;
        player1.activo = true;

        player2.nombre = "María";
        player2.partida = 2;
        player2.tiempo = 4.2f;
        player2.activo = false;

        Debug.Log(player1.nombre + ", " + player1.partida + ", " + player1.tiempo + ", " + player1.activo);
        Debug.Log(player2.nombre + ", " + player2.partida + ", " + player2.tiempo + ", " + player2.activo);
    }
}
````

Este script es el que hemos agregado al objeto en Unity. Desde aquí vamos a acceder a la clase infoPlayer para crear nuestros players.

Si te fijas en la primera variable, utilizamos el nombre de la clase infoPlayer y le doy un nombre en este caso player1. player1 es un nuevo objeto de la clase infoPlayer.

Ahora en la función Start ya podemos acceder a sus atributos (es decir, sus variables). Para ello ponemos el nombre de la variable y un punto, y si todo es correcto en monodevelop te aparecen los atributos. Escoge el que necesites y le das el valor que quieres.

## 2# Métodos
Si seguimos con el ejemplo anterior, también podemos crear funciones dentro de las clases. Para esta actividad vamos a crear una función que nos muestre por consola los atributos de la clase, 

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class infoPlayer
{
    public string nombre;
    public int partida;
    public float tiempo;
    public bool activo;

    public void muestraInfo() {
        Debug.Log("Nombre del jugador:" + nombre);
        Debug.Log("Número de partidas:" + partida);
        Debug.Log("Tiempo de juego:" + tiempo);
        Debug.Log("Actividad actual:" + activo);
    }
}
````
Creamos a continuación de las variables una función con el nombre que quieras en este caso es muestraInfo y dentro escribimos varios Debug.Log con los mensajes y el nombre de la variable que deseamos que se muestren.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablaRecords : MonoBehaviour
{
    public infoPlayer player1;
    public infoPlayer player2;
    // Start is called before the first frame update
    void Start()
    {
        player1.nombre = "Paco";
        player1.partida = 8;
        player1.tiempo = 6.25f;
        player1.activo = true;

        player2.nombre = "María";
        player2.partida = 2;
        player2.tiempo = 4.2f;
        player2.activo = false;

        player1.muestraInfo();
        player2.muestraInfo();
    }
}
````

## 3# Constructor básico
Creamos funciones dentro de una clase para que se ejecuten cuando creamos un objeto de esa clase; o dicho correctamente, se instancia un objeto de esa clase. En los ejemplos anteriores hemos creado 2 players y ahora en el script infoPlayer vamos a crear el constructor de la clase, que nos va a informar de que se ha creado un nuevo objeto de esta clase.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class infoPlayer
{
    public string nombre;
    public int partida;
    public float tiempo;
    public bool activo;

    public infoPlayer()
    {
        Debug.Log("Se ha creado un objeto de la clase infoPlayer");
    }

    public void muestraInfo()
    {
        Debug.Log("Nombre del jugador:" + nombre);
        Debug.Log("Número de partidas:" + partida);
        Debug.Log("Tiempo de juego:" + tiempo);
        Debug.Log("Actividad actual:" + activo);
    }
}
````

Dentro de la clase; debemos crear después de los atributos una función pública con el mismo nombre de la clase y dentro ponemos un mensaje.

A continuación vamos a crear los objetos de la clase infoPlayer en nuestro archivo tablaRecords.

## #4 Constructor inicializando valores
También podemos crear los objetos con valores directamente, esto quiere decir que cuando creamos el player1 ya le podemos poner los valores directamente y evitamos tener que escribir tanto código.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class infoPlayer
{
    public string nombre;
    public int partida;
    public float tiempo;
    public bool activo;

    public infoPlayer()
    {
        Debug.Log("Se ha creado un objeto de la clase infoPlayer");
    }

    public infoPlayer(string n, int p, float t, bool a) {
        nombre = n;
        partida = p;
        tiempo = t;
        activo = a;
    }

    public void muestraInfo()
    {
        Debug.Log("Nombre del jugador:" + nombre);
        Debug.Log("Número de partidas:" + partida);
        Debug.Log("Tiempo de juego:" + tiempo);
        Debug.Log("Actividad actual:" + activo);
    }
}
````
Ahora tenemos un constructor pero con una serie de argumentos. Dentro constructor guardamos estos argumentos dentro de las variables que son los atributos que necesitaremos para crear un objeto de esta clase.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablaRecords : MonoBehaviour
{
    public infoPlayer player1;
    public infoPlayer player2 = new infoPlayer();
    // Start is called before the first frame update
    void Start()
    {
        player1 = new infoPlayer("Paco", 8, 6.25f, true);
        player2 = new infoPlayer("María", 2, 4.2f, false);

        player1.muestraInfo();
        player2.muestraInfo();
    }
}
````

Hasta aquí esta pequeña introducción a la programación en C#, todavía no hemos entrado en muchos detalles de programación básica, lo que estamos aprendiendo son las reglas del juego. Estas son algunas de las habilidades que debes entender y utilizar a pesar de que te equivoques, porque los próximos capítulos empezaremos a ver cómo este lenguaje nos permite controlar objetos y que estos interactúen. La estructura que debes comprender cuando hablamos del concepto, (principalmente abstracto), de programación es:

* Dispones de unas variables para almacenar información compleja.
* Puedes realizar operaciones, comparar valores y tomar decisiones con estas variables.
* Puedes automatizar con bucles operaciones que se repiten continuamente.
* Puedes agrupar todo en una función para utilizarla más adelante.
* Puedes crear tus propias clases que encapsulan todo lo anterior.

