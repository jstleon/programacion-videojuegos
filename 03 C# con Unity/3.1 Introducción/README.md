# 3.1 Introducción

Durante los primeros capítulos hemos aprendido las bases de la programación utilizando C#, ahora sabemos que es un lenguaje orientado a objetos que está basado en clases a partir de las cuales podemos crear nuevos objetos ya sea que pertenezcan a las librerías propias del lenguaje o clases que nosotros hayamos creado manualmente.

Unity, al ser una herramienta concebida principalmente para crear videojuegos y experiencias interactivas en tiempo real, tiene disponible muchísimas librerías que vuelven a esta herramienta algo muy poderoso y relativamente sencillo de utilizar.

Algunas de las funciones que vamos a estudiar son referentes de la clase MonoBehaviour. Este primer apartado quiere ayudarte no solo a que entiendas cómo funcionan sino que aprendas también a consultar la documentación de Unity Scripting API. Puedes acceder desde el siguiente enlace:

https://docs.unity3d.com/ScriptReference/MonoBehaviour.html


En este enlace verás un apartado Mensajes que en realidad son eventos.. un evento según la programación con C# es cuando ocurre algo.

Los eventos habilitan una clase u objeto para notificarlo a otras clases u objetos. La clase que envía el evento recibe el nombre de publicador y las clases que reciben se denominan suscriptores.

Algunas características sobre los eventos:

* El publicador determina el momento en el que se genera un evento; los suscriptores determinan la acción que se lleva a cabo en respuesta al evento.

* Un evento puede tener varios suscriptores. Un suscriptor puede controlar varios eventos de varios publicadores.

* Nunca se generan eventos que no tienen suscriptores.

* Los eventos se suelen usar para indicar acciones del usuario, como los clips de los botones o las selecciones de menú en las interfaces gráficas de usuario.


> El manual nos proporciona información de cómo utilizar Unity, sus ventanas paneles y todo lo referente al programa en sí y el apartado de API es toda una recopilación de Clases, funciones, variables, etc. que podemos utilizar en nuestros scripts para programar en Unity.

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


> Fig. 3.1.4 Ventana consola mostrando mensajes

El primer mensaje que se imprime en la consola es el que estaba dentro de la función Start si te fijas verás que solo aparece una vez. El segundo mensaje se repite en este caso 346 veces. Verás que he marcado la opción Collapse para que el segundo mensaje que estaba dentro de la función Update no me salga repetido y solamente se muestre una vez con el número de repeticiones al lado.

Una de las cosas que debes comprender en desde el primer momento es que un script puede ser añadido a cualquier objeto como un **componente**.

### Variables públicas y privadas
Cuando creamos una variable también debemos definir si nuestra variable será pública o privada. Para ello lo haremos justo antes del tipo de dato de nuestra variable.

````C#
private string name1 = "John Doe";
public string name2 = "CEI";
````

La diferencia radica en que las variables públicas serán accesibles desde la ventana del Inspector, mientras que las privadas no. Otra razón para poner nuestras variables en públicas es para acceder a ellas desde otros scripts. Las variables públicas son accesibles desde otros script, las privadas no.

Si no especificas nada, por defecto la variable será privada.

También puedes crear funciones públicas para que sean accesibles desde otros scripts.

**Es una buena práctica poner todas las variables privadas, a menos que necesiten ser públicas.**

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass
{
    public int apples;
    public int bananas;

    private int stapler;
    private int sellotape;

    public void FruitMachine(int a, int b) {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void OfficeSort(int a, int b) {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}

````
Observa el código de aquí arriba. Tiene dos variables públicas y dos privadas. También tiene una función pública y otra privada. Si quiero acceder a este script desde otro script lo haremos de la siguiente manera.
````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoClass : MonoBehaviour
{

    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(myOtherClass.apples, myOtherClass.bananas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
````

Crearemos una variable con el nombre que hayamos dado a nuestro script, en este caso **AnotherClass**, y le ponemos un nombre a nuestra variable, en este caso **myOtherClass**.
````C#
private AnotherClass myOtherClass;
````

Luego le asignamos un valor a nuestra variable con:

````C#
myOtherClass = new AnotherClass();
````

A partir de este momento tenemos acceso tanto a las variables como las funciones que se hayan declarado públicas.

Como último ejercicio, simplemente vamos a poner en un archivo variables con diferentes tipos de dato y todas ellas públicas para manipular sus parámetros en la ventana del Inspector.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public string name = "John Doe";
    public int edad = 40;
    public float energy = 0.75f;
    public bool estaVivo = true;

    void Start()
    {
        
    }

    void Update()
    {
                
    }
}

````

> Fig.1.3.5 GameObject en la ventana del Inspector

#### Awake vs Start
Un poco más arriba hemos utilizado la función Start(), esta función, (o método) aparece por defecto junto con Update() cuando abrimos un nuevo script en C#. 

````C#
void Awake(){

}

void Start(){

}
````

Sirven para inicializar valores y parámetros de nuestro juego. Sólo se ejecutan una vez, justo antes de empezar a reproducirse el juego. 

Awake se llamará justo antes de Start

### Update vs FixedUpdate
Todo el código que se encuentre dentro de Update se ejecutará una vez por cada frame. Casi cualquier cosa que necesite cambiarse en nuestro juego, el movimiento la interacción tendrá que suceder a lo largo de una serie de frames. Cronómetros, detección de inputs, etc.

El **Update** no se invoca en una cronología regular, si un frame toma más tiempo de procesar que el siguiente; entonces, el tiempo entre invocaciones de Update será diferente.

**FixedUpdate** es una función similar a Update, pero tiene algunas diferencias importantes. **FixedUpdate** se invoca en una cronología regular y tendrá el mismo tiempo entre invocaciones.

Inmediatamente después de que se invoca FixedUpdate se realizan los cálculos de física necesarios. Por definición, cualquier cosa que afecta a un cuerpo rígido, es decir un RigidBody, debería ser ejecutado en FixedUpdate en vez de en Update.

Cuando estamos haciendo scripts de física en el bucle FixedUpdate, es buena práctica usar fuerzas para el movimiento.

### Cómo habilitar y deshabilitar componentes
Para habilitar o deshabilitar un componente en Unity puedes usar la etiqueta Enabled (Habilitado). 

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{

    private Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
````

En este ejemplo tenemos una referencia a una luz, llamada myLight y en Start estamos configurando esta variable usando la función GetComponent al componente Light anexado a nuestro objeto.

En el Update hay un condicional que hará algo si pulsamos la barra espaciadora. Y lo que va a suceder cuando pulsemos espacio es que si el componente está enabled lo deshabilitará y en caso contrario, si está desactivado, lo activará. Eso lo conseguimos haciendo un conmutador con la siguiente línea de código.

````C#
myLight.enabled = !myLight.enabled;
````

usando el NOT (!) por delante de la variable. Enabled es un booleano, solo puede ser verdadero o falso. Observa en el inspector como se activa y se desactiva el checkbox el componente Light.

> Fig. 3.1.6 Luz activada y desactivada

### Activar/desactivar GameObjects
Puedes activar o desactivar GameObjects a través de tus scripts usando la función SetActive. Es un conmutador on/off de nuestro objeto en términos de encontrarse activo en nuestra escena.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);   
    }
}
````

En este ejemplo tenemos una simple función Start que contiene un gameObject (La ‘g’ en minúsculas indica que estamos haciendo referencia al GameObject que lleva el script) seguido por un punto, seguido de la función SetActive() y como parámetro hemos puesto false.

Si le asignas este código a cualquier objeto, desaparecerá de tu escena en cuanto le des al play. Aparecerá desactivado.

Cuando trabajamos con objetos y jerarquías es importante conocer cuando desactivas a un padre, los hijos también se desactivarán. 


