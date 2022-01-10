# 3.1 Script como componente

Durante los primeros capítulos hemos aprendido las bases de la programación utilizando C#, ahora sabemos que es un lenguaje orientado a objetos que está basado en clases a partir de las cuales podemos crear nuevos objetos ya sea que pertenezcan a las librerías propias del lenguaje o clases que nosotros hayamos creado manualmente.

C# es el lenguaje que utilizaremos para trabajar y crear comportamientos dentro de Unity, la sintaxis y las convenciones de nombres que aprendimos hasta el momento se utilizan igual, al acceso a miembros, la inicialización de variables, la llamada de métodos, todo es absolutamente igual, lo que sí es diferente son las librerías que vamos a utilizar, Unity, al ser una herramienta concebida principalmente para crear videojuegos, tiene disponible muchísimas librerías que vuelven a esta herramienta algo muy poderoso y relativamente sencillo de utilizar, aunque como siempre, lograr algo de buena calidad requerirá de esfuerzo, constancia y paciencia, es muy importante siempre seguir practicando.

Algunas de las funciones que vamos a estudiar son referentes de la clase MonoBehaviour. Este primer apartado quiere ayudarte no solo a que entiendas cómo funcionan sino que aprendas también a consultar la documentación de Unity Scripting API. Puedes acceder desde el siguiente enlace:

https://docs.unity3d.com/ScriptReference/MonoBehaviour.html

El manual nos proporciona información de cómo utilizar Unity, sus ventanas paneles y todo lo referente al programa en sí y el apartado de API es toda una recopilación de Clases, funciones, variables, etc. que podemos utilizar en nuestros scripts para programar en Unity.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evento : MonoBehaviour
{

    void Awake()
    {
        Debug.Log("Esto es el Awake");
    }

    void Start()
    {
        Debug.Log("Esto es el Start");    
    }

   
    void Update()
    {
        Debug.Log("Esto es el Update");
    }

    void OnDisable()
    {
        Debug.Log("El objeto está desactivado");
    }

    void OnEnable()
    {
        Debug.Log("El objeto está activado");
    }

    void OnMouseDown()
    {
        Debug.Log("El ratón hace click");
    }

    void OnMouseEnter()
    {
        Debug.Log("El ratón está encima");
    }

    void OnMouseEnter()
    {
        Debug.Log("El ratón sale fuera");
    }
}

````
#### Awake
Es llamado cuando se carga el script y se utiliza para inicializar cualquier variable o estado del juego antes de que comience el juego. Este evento solo se llama una sola vez después de cargar todos los objetos.

#### Start
Es llamado cuando se habilita un script y justo antes de llamar a cualquier de los métodos de Update. Al igual que en el Awake solo se llama una sola vez y se ejecuta cuando activamos el juego.

#### Update
Repite todo lo que contenga a cada frame o cuadro. Este evento de MonoBehaviour es muy utilizado para crear comportamientos en un juego.

#### OnDisable & OnEnable
Hemos visto anteriormente cómo podemos activar y desactivar objetos desde la ventana Inspector de Unity con estas funciones podemos activar o desactivar objetos desde la ventana inspector de Unity con estas funciones podemos activar o desactivar el objeto mediante programación.
OnMouse(Enter, Down, Exit)
Nos permite saber cuando el usuario realiza una serie de acciones con el ratón.

Estas son algunas de las funcionalidades que podemos encontrar en la programación de videojuegos, a continuación iremos profundizando hasta que comprendas como funciona todo.

### Scripts como componentes
Los scripts o secuencias de comandos deben considerarse  como componentes de comportamiento en Unity. Igual que otros componentes de Unity pueden ser aplicados a objetos y pueden verse en el Inspector.

Imagina que tenemos un cubo con un rigidbody, el cual le otorga una masa física, y cuando se pulsa al play el cubo cae al suelo, ya que usa la gravedad. Al mismo cubo podemos añadirle un script que al pulsar diferentes teclas cambie el color del cubo accediendo a través de nuestro script a su componente Renderer.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColor : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
````
### Crear un Scripts en Unity
Crea un proyecto nuevo en 3D con el nombre que quieras. En la ventana Project vamos a crear dos carpetas, una para  guardar las escenas y otra para guardar los scripts llamada Scripts.

![Fig. 3.1.1 Scripts en Unity](https://github.com/jstleon/programacion-videojuegos/blob/main/03%20C%23%20con%20Unity/3.1%20Script%20como%20componente/img/Fig.%203.1.1_scripts-en-unity.png)
Fig. 3.1.1 Scripts en Unity

Ahora vamos a crear un script dentro de la carpeta Scripts que hemos creado anteriormente. Seleccionamos la carpeta Scripts y hacemos **clic con el botón derecho** del ratón y seleccionamos **Create > C# Script**, automáticamente aparecerá un script con el nombre por defecto NewBehaviourScript.cs

Haz doble clic en el archivo y se abrirá nuestro editor de código. 


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
### void Start
Hemos visto en el capítulo anterior brevemente qué es void Start. Para entender cómo funciona vamos a volver a realizar el mismo ejercicio y a explicarlo más detenidamente. Crea un mensaje para cada función que se va a mostrar por la ventana de Consola en Unity. Cuando queremos imprimir un mensaje debemos escribir Debug.Log(“”); Dentro del paréntesis de momento vamos a escribir entre comillas cuándo queremos poner texto, más adelante veremos qué opciones tenemos. A continuación te dejo el código que me gustaría que probaras.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nuestro primer mensaje");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Es mensaje se va a repetir infinitamente!");        
    }
}
````

Una vez hayas escrito el código en tu script debes guardar el archivo seleccionando en la barra de herramientas principal **File > Save**. Ahora minimizamos el editor y nos dirigimos a Unity. Debes localizar la ventana Console en la interfaz si no lo ves puedes abrir esta ventana accediendo al menú principal en la opción **Window > General > Console**. Como te muestro en la siguiente imagen.

> Fig. 3.1.2 Ventana consola

Ahora para nuestro script funcione debemos agregarlo a un objeto en la escena, como no tenemos ninguno debemos crear un GameObject vacío, o por defecto el que tú quieras y arrastrar el script encima del objeto dentro de la ventana jerarquía o con el objeto seleccionado arrastrando el script encima de sus componente como te muestro a continuación en la siguiente imagen:

> Fig. 3.1.3 Arrastrando nuestro Script sobre un GameObject

Bien agregado el script ejecutamos el juego haciendo clic en play y pasamos unos segundos veremos el siguiente mensaje en consola:




