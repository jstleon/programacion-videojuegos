# 3.8 Mover objetos con Transform.Translate
La clase Transform tiene un método que se llama Translate que nos permite desplazar un objeto en cualquiera de los ejes x, y, z, con la opción de escoger en qué tipo de espacio en relación al objeto (Local, Global).

https://docs.unity3d.com/ScriptReference/Transform.Translate.html

Cuando trabajamos en 3D tenemos que tener otro factor en cuenta: qué tipo de referencia utilizamos para los ejes de coordenadas, el local o el global. Para distinguir de una forma sencilla cuál es el que nos conviene debemos preguntarnos si queremos que el movimiento esté basado en el objeto o en el espacio 3D.

Si queremos que el movimiento se base en el objeto debemos utilizar la relación Local, por el contrario si queremos que siga una única dirección o la del espacio 3d usaremos la relación Global.

Para el siguiente ejercicio crea una nueva escena y arrastra el PreFab de la cápsula a tu nueva escena. Recuerda resetear el componente Transform. Modifica la rotación de la cápsula introduciendo los siguientes valores: Rotation(60, 90, 30).

Observa como el Gizmo cambia su dirección dependiendo si te encuentras en local y global.

> Fig. 3.8.1 Gizmo en Local y en Global

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public Transform directAzul;
    public float speed = 2f;
    private float acceleration;

    void Start()
    {
        directAzul = gameObject.GetComponent<Transform>();
        acceleration = speed * Time.deltaTime;
    }

    void Update()
    {
        directAzul.transform.Translate(Vector3.forward * acceleration, Space.World); // Mover en Eje Global
    }
}
````

En este caso estamos aplicando una fórmula de aceleración que es igual a velocidad por tiempo. De este modo no tendremos que escribir tanto en Update.

En la función Start se guarda el componente Transform dentro de la variable directAzul y utilizamos la variable de aceleración de tipo float para guardar la velocidad multiplicada por el Time.deltaTime.

Dentro de la función Update en la variable que contiene la información de transformación, ya no utilizamos el método position, ahora utilizamos el método Translate que nos pide un Vector3 que utilizamos con el método forward multiplicado por la variable de aceleración y el último parámetro es decirle que referencia en el espacio utiliza, la local (según el objeto) o la global (según el espacio).

A continuación se muestra como quedaría con Local y Global:

````C#
directAzul.transform.Translate(Vector3.forward * acceleration, Space.Self); // Local
directAzul.transform.Translate(Vector3.forward * acceleration, Space.World); // Global
````

### Mover objetos de un punto A a un punto B
Para esta escena vamos añadir un Prefab llamado plataforma, en amarillo y una cápsula Azul que puede ser nuetro Player.

> Fig. 3.8.2 Escena Unity Mover de A to B
Existen varias formas de hacer esto. Para este ejemplo vamos a utilizar dos métodos de Vector3. Uno es Lerp y el otro es MoveTowards. Para este ejemplo vamos a crear dos scripts, uno se va a llamar **MoveLerp.cs** y el otro **MoveForward.cs**. Primero vamos a ver el código de Lerp:

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
    public Transform vectorPlayer;
    public GameObject positionA;
    public GameObject positionB;
    public Vector3 posA;
    public Vector3 posB;
    void Start()
    {
        vectorPlayer = gameObject.GetComponent<Transform>();
        positionA = GameObject.Find("PositionA");
        positionB = GameObject.Find("PositionB");
        posA = positionA.transform.position;
        posB = positionB.transform.position;
    }

    void Update()
    {
        vectorPlayer.transform.position = Vector3.Lerp(posA, posB, Time.time * 0.5f);
    }
}
````

En realidad el método Lerp permite mover un objeto de una posición a otra con una interpolación de movimiento suave.

https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html

Para el siguiente ejemplo creamos un nuevo script y lo llamamos MoveTowards.cs

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
    public Transform vectorPlayer;
    public GameObject positionA;
    public GameObject positionB;
    public Vector3 posA;
    public Vector3 posB;
    void Start()
    {
        vectorPlayer = gameObject.GetComponent<Transform>();
        positionA = GameObject.Find("PositionA");
        positionB = GameObject.Find("PositionB");
        posA = positionA.transform.position;
        posB = positionB.transform.position;

    }

    void Update()
    {
        
        vectorPlayer.transform.position = Vector3.MoveTowards(posA, posB, Time.time * 0.5f);
    }
}
````

Este ejemplo es igual que el anterior excepto la línea que se encuentra en el Update. El método MoveTowards mueve un punto a lo largo de una línea recta hacia un punto marcado.

La fórmula de este método es Vector3.MoveTowards(Vector3 inicial, Vector3 como punto final, valor float con una cantidad máxima de distancia). Esta función la tenemos que considerar como una forma de acercarnos a un punto destino.

https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html

### Mover objetos de ida y vuelta
Para esta escena vamos a utilizar tres plataformas, dos de ellas definirán los vectores 3D hacia los que debe moverse la plataforma amarilla. El objetivo es intentar que la plataforma realice un movimiento de ida y vuelta desde el objetivo PosicionA hasta el objeto PosicionB. Para ello crearemos un Script con el nombre de MovPingPong.cs

Para conseguir este movimiento vamos a utilizar un método que viene de una estructura del UnityEngine que es Mathf con una colección de funciones matemáticas. El método se llama PingPong, esta función necesita los argumentos siguientes:

PingPong(tiempo, distancia)

https://docs.unity3d.com/ScriptReference/Mathf.PingPong.html

> Fig. 3.8.3 Escena Unity Ping-Pong

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPingPong : MonoBehaviour
{
    public Transform miPosicion;
    public float velocidad;
    public float rango;
    public float distancia;

    private float posX;
    private float posY;
    private float posZ;

    void Start()
    {
        miPosicion = gameObject.GetComponent<Transform>();
        posX = miPosicion.transform.position.x;
        posY = miPosicion.transform.position.y;
        posZ = miPosicion.transform.position.z;
        velocidad = 2.0f;
        distancia = 4.7f;
        rango = -2.4f;
    }

    // Update is called once per frame
    void Update()
    {
        posX = Mathf.PingPong(Time.time * velocidad, distancia) + rango;
        miPosicion.transform.position = new Vector3(posX, posY, posZ);
    }
}
````
En la para referente a las variables he creado una variable de tipo Transform con el nombre miPosicion para guardar la información del componente Transform.

Creamos tres variables float públicas: velocidad, rango, distancia. Por debajo hemos creado tres variables privadas para las posiciones X, Y, Z.

Igual que en los ejercicios anteriores, obtenemos el componente Transform del objeto que tiene el script. Extraemos y guardamos la posición en X, Y, Z en posX, posY, posZ. Inicializamos los valores de las variables velocidad, distancia, rango.

En el update vamos a utilizar la posición en X y usamos la función Mathf.PingPong en donde al tiempo lo multiplicamos por velocidad y le daremos una distancia, estos son los valores por defecto. Para mejorar el recorrido le sumamos la variable rango.

Para finalizar igualamos la posición que tiene el objeto accediendo desde la variable miPosicion y le damos una nueva posición creando un nuevo Vector3 con tres valores float que son las variables que hemos creado.

Veremos con más detenimiento los Inputs, pero puede ir probando estos códigos para comenzar a interactuar con los GameObjects.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    public float Speed = 2.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
    }
}
````
Luego podemos hacer lo mismo para programar la dirección inversa poniendo el signo - delante del Vertor3.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    public float Speed = 2.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Speed * Time.deltaTime);
        }
    }
}
````