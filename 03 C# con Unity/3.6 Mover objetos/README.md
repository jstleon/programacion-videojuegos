# 3.6 Mover objetos
Ahora que ya hemos jugado con las posiciones de los objetos vamos a ver como podemos moverlos o crear una animación continua de estos objetos.

Para mover objetos de forma continua cada frame usaremos la función Update que tenemos en los scripts por defecto cuando creamos uno. La función Update se encarga de repetir continuamente todo lo que pongamos dentro.

Crea una nueva escena y añade los tres Prefabs que te tienes en el siguiente Package:

Tienes un cubo Rojo, una esfera Amarilla y una cápsula Azul. Crea un GameObject vacío y añade como componente el siguiente script.

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

    void Start()
    {
        miAmarillo = GameObject.Find("Esfera Amarilla");
        miRojo = GameObject.Find("Cubo Rojo");
        miAzul = GameObject.Find("Capsula Azul");

        directAmarillo = miAmarillo.GetComponent<Transform>();
        directRojo = miRojo.GetComponent<Transform>();
        directAzul = miAzul.GetComponent<Transform>();
    }

    void Update()
    {
        directAmarillo.transform.position += transform.forward;
        directRojo.transform.position += transform.up;
        directAzul.transform.position += transform.right;
    }
}
````

Primero creamos tres variables públicas de GameObjects, tres variables públicas de Transform.

En el Start asignamos e inicializamos nuestras variables. Los GameObjects los buscamos con Find por su nombre. Una vez que tenemos guardado los GameObjects en sus respectivas variables podemos acceder al componente guardándolo en variables diferentes de tipo  Transform. 

En el Update sumamos a la posición actual vectores a cada GameObject. Si le das al play, verás que los GameObject se alejan entre sí cada uno en un eje diferente. Además podrás apreciar que lo hacen demasiado rápido. Ya que ahora mismo avanza 1 unidad de Unity por cada frame. Si una unidad fuera un metro de longitud, serían, por ejemplo entre 30 y 60 metros por cada segundo.

Debemos cambiar a tiempo en lugar de frames, y eso lo tenemos que  hacer con [Time.deltaTime][1].

[1]: https://