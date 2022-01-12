# 3.7 Time.deltaTime
Vamos a ver un método de la clase Time que nos permite utilizar tiempo y no frames en la función Update. Es una variable estática dentro de la clase time y almacena valores float, puedes consultar en:

https://docs.unity3d.com/ScriptReference/Time-deltaTime.html

¿Qué es eso exactamente?
La respuesta es que Update utiliza frameRate o un rango de fotogramas para ejecutar el juego. Con esto debes comprender que si tu equipo es muy potente la ejecución de tu juego será mucho más rápida, por el contrario si tu equipo es antiguo, tu juego será bastante más lento.

Por eso existe el método Time, que es la clase y deltaTime que es el método. Cuando decimos delta hacemos referencia a un cambio en una cantidad; esto significa que deltaTime es un cambio en la cantidad de tiempo en segundos desde el último fotograma.

![Fig. 7.3.1 Time, Frames y Time.deltaTime](https://github.com/jstleon/programacion-videojuegos/blob/main/03%20C%23%20con%20Unity/3.7%20Time.deltaTime/img/Fig.%203.7.1_Time.deltaTime.png)
> Fig. 7.3.1 Time, Frames y Time.deltaTime

Vamos a utilizar el método Time.deltaTime para no depender del rango de fotogramas de la función Update, y crearemos una variable speed que será de tipo float y a la que multiplicaremos al tiempo para acelerar el movimiento de los GameObjects.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovConstante : MonoBehaviour
{

    public GameObject miAmarillo;
    public GameObject miRojo;
    public GameObject miAzul;

    public Transform directAmarillo;
    public Transform directRojo;
    public Transform directAzul;

    public float speed;

    void Start()
    {
        miAmarillo = GameObject.Find("Esfera Amarilla");
        miRojo = GameObject.Find("Cubo Rojo");
        miAzul = GameObject.Find("Capsula Azul");

        directAmarillo = miAmarillo.GetComponent<Transform>();
        directRojo = miRojo.GetComponent<Transform>();
        directAzul = miAzul.GetComponent<Transform>();

        speed = 2f;
    }

    void Update()
    {
        directAmarillo.transform.position += transform.forward * Time.deltaTime * speed;
        directRojo.transform.position += transform.up * Time.deltaTime * speed;
        directAzul.transform.position += transform.right * Time.deltaTime * speed;
    }
}

````
Si pruebas este código, podrás observar que los GameObject se mueven a una velocidad más lenta. Simplemente hemos multiplicado Time.deltaTime para que utilice el tiempo en vez de los fotogramas por segundo del Update y al crear una variable velocidad con valor 5 los objetos se moverán a una velocidad más lenta que anteriormente.

Entonces lo que debes comprender es que en Unity usamos Time.deltaTime para establecer el tiempo, y el tiempo lo usamos para muchos cálculos en física, por ejemplo para conocer la velocidad de un vehículo usamos distancia/tiempo, decimos que va a x Km/h.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    public float PosX = 5.0f;
    public float PosY = 6.0f;
    public float contador = 0;
    public float Speed = 0.5f;

    void Update()
    {
        PosX += Time.deltaTime * Speed;
        transform.position = new Vector3(PosX, PosY, 0);
        contador = contador + Time.deltaTime;
        Debug.Log(contador);
    }
}
````
Si queremos crear un contador de tiempo también podemos usar Time.deltaTime.

Independientemente de la potencia de computación del equipo en el que se ejecute nuestro videojuego, Time.deltaTime se mantendrá estable.



