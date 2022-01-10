# 3.2 Clase GameObject

Como hemos hecho con los eventos, ahora vamos a acceder a la documentación de GameObject:
[https://docs.unity3d.com/ScriptReference/GameObject.html](https://docs.unity3d.com/ScriptReference/GameObject.html)

En la documentación encontramos varios aspectos importantes que vamos a tratar en este apartado, pero antes vamos a tratar de entender la diferencia entre GameObject en mayúscula y gameObject en minúscula.

Si recordamos, cuando creamos un script y lo agregamos o arrastramos encima de un gameObject, por ejemplo un cubo, dentro del script para referirnos a el cubo lo escribimos en minúscula: gameObject.

Si queremos hacer referencia a un GameObject externo o crear uno propio utilizaremos GameObject en mayúscula ya que en este caso hacemos referencia a la clase.
![Fig. 3.2.1 gameObject vs GameObject](https://github.com/jstleon/programacion-videojuegos/blob/main/03%20C%23%20con%20Unity/3.2%20clase%20GameObject/img/Fig.%203.2.1%20Cubo%20y%20esfera.png)
> Fig. 3.2.1 gameObject vs GameObject

En la imagen anterior representamos que a un cubo se le añade un script, dentro del script cuando queremos referirnos al propio objeto utilizaremos **gameObject**. En el caso de que el cubo quiera tomar referencia del objeto redondo dentro del script lo escribiremos en mayúsculas: **GameObject**.

Vamos a crear una nueva escena con los siguientes elementos: Un cubo rojo, una esfera amarilla y una cápsula azul Crea un script y llámalo Ejemplo_01 y arrástralo sobre el cubo.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo_01 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    void Update()
    {
        
    }
}
````

Si reproduces tu escena verás aparecer en la consola el nombre del cubo rojo.

![Fig 3.2.2 Escena Unity](https://github.com/jstleon/programacion-videojuegos/blob/main/03%20C%23%20con%20Unity/3.2%20clase%20GameObject/img/Fig.3.2.2%20Escena%20cubo%2C%20esfera%20y%20cilindro.png)
> Fig 3.2.2 Escena Unity

Vamos a modificar el código del script para mostrar el nombre de la esfera en la consola.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo01 : MonoBehaviour
{
    public GameObject miEsfera;

    void Start()
    {
        gameObject.name = "MiCubo";
        Debug.Log(gameObject.name);
        Debug.Log(miEsfera.name);
    }
}

````
En el código de aquí arriba hemos creado una variable pública, debemos arrastrar el objeto esfera en el inspector, concrétamente en el componente script Ejemplo01.cs del cubo rojo.

Una vez que hemos asignado la esfera, si pulsas play verás cómo cambia el nombre de cubo rojo por MiCubo y muestra el nuevo nombre en la consola y el nombre de la esfera.
También podemos buscar la esfera desde nuestro código para no tener que arrastrarla en el inspector. Analicemos el siguiente código.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo01 : MonoBehaviour
{
    public GameObject buscarEsfera;

    void Start()
    {
        gameObject.name = "MiCubo";
        Debug.Log(gameObject.name);
        buscarEsfera = GameObject.Find("Esfera Amarilla");
        Debug.Log(buscarEsfera.name);
    }
}
````
En este caso estamos utilizando el método **Find()**, el cual nos permite buscar objetos en la Jerarquía por su nombre:

````C#
buscarEsfera = GameObject.Find("Esfera Amarilla");
````

Otra forma de buscar objetos sería igual que la anterior pero utilizando **Tags** (Etiquetas). Para realizar este ejercicio vamos a utilizar otro de los Prefabs que disponemos en el proyecto: La cápsula azul.

Arrastra la cápsula a la escena, teniendo seleccionada la cápsula azul accedemos a la ventana Inspector y en el apartado Tag desplegamos su menú y seleccionamos la opción Player.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo01 : MonoBehaviour
{
    public GameObject buscarEsfera;
    public GameObject buscarCapsula;

    void Start()
    {
        gameObject.name = "MiCubo";
        Debug.Log(gameObject.name);

        buscarEsfera = GameObject.Find("Esfera Amarilla");
        Debug.Log(buscarEsfera.name);

        buscarCapsula = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(buscarCapsula.name);
    }
}
````
Para terminar este apartado tienes que saber que también puedes crear GamesObjects utilizando el constructor. El constructor de una clase GameObject tiene el objetivo de que puedas crear nuevos objetos de esa misma clase (como todos los constructores). Para que entiendas mejor a lo que me refiero es que podemos crear nuevos objetos dentro de la escena. Primero te voy a invitar a consultar la documentación accediendo a este enlace:

[https://docs.unity3d.com/ScriptReference/GameObject-ctor.html](https://docs.unity3d.com/ScriptReference/GameObject-ctor.html)

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo01 : MonoBehaviour
{
    public GameObject buscarEsfera;
    public GameObject buscarCapsula;
    private GameObject nuevo;

    void Start()
    {
        gameObject.name = "MiCubo";
        Debug.Log(gameObject.name);

        buscarEsfera = GameObject.Find("Esfera Amarilla");
        Debug.Log(buscarEsfera.name);

        buscarCapsula = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(buscarCapsula.name);

        nuevo = new GameObject("Nuevo Objeto 01");
        Debug.Log(nuevo.name);
    }
}
````
El nuevo objeto que se crea solamente tiene un elemento de transformación y nombre porque todo objeto en Unity debe tener estos componentes como mínimo. También hay que decir que este objeto no tiene nada más y por ese motivo no se puede ver en la ventana escena. A estos objetos les llamamos objetos vacíos. (Empty).



