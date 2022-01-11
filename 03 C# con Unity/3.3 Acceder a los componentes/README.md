# 3.3 Acceder a los componentes
Seguimos con los GameObjects pero esta vez vamos a ver cómo acceder a los componentes de estos mismos. En los primeros ejemplos hemos visto cómo crear gameObjects y cómo añadir componentes como un script, un collider o materiales. Ahora vamos a ver cómo podemos hacer esto mediante scripts.

Supongo que te preguntarás por qué tienes que aprender a hacerlo mediante scripts, cuando puedes hacerlo en el editor; pues la respuesta es muy simple, en ocasiones deberás acceder mediante scripts para poder automatizar componentes en concreto, y porque te da una libertad increíble para trabajar en tus futuros proyectos.

En un gameObject vacío le añadimos un script llamado Components. cuando crees el nuevo script y le hayas puesto nombre guárdalo en la carpeta Scripts para mantener ordenado el proyecto.

Dentro de scripts Components vamos a cambiar el nombre y vamos a mostrar la posición en (x, y, z) a sus componentes, el del nombre ya lo hemos visto en el apartado anterior.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{

    void Start()
    {
        gameObject.name = "Esfera";
    }

    void Update()
    {
        Debug.Log(gameObject.transform.position);
    }
}
````

Este ejemplo anterior simplemente es para mostrarte que mediante programación podemos controlar con mucha precisión ciertos aspectos de los objetos. También verás que por consola solamente nos muestra un decimal en la posición. Antes de continuar quiero que entiendas que las transformaciones son de tres tipos:

#### **Posición**
Que nos permiten desplazar los objetos por toda la escena

#### Rotación
Nos permite rotar los objetos

#### Escalado
Que nos permite cambiar el tamaño de los objetos

Todas las transformaciones se basan principalmente en tres ejes X, Y, Z que nos dan una posición, una rotación y un escalado más precisos. Estas tres coordenadas pueden ser utilizadas de un modo Global o un modo Local. De momento vamos a ir viendo poco a poco los 3 tipos y cómo podemos acceder a ellos.

Ahora vamos a crear un nuevo script que llamaremos ComponenteExterior.cs; vamos 
a ver cómo accedemos al componente transform de un objeto externo, en este caso, el objeto Cubo Rojo. Primero selecciona el GameObject vacío y le borramos el script: Componets.cs

Creamos un script nuevo: ComponenteExterior.cs

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteExterior : MonoBehaviour
{
    public GameObject myCube;
    public float cubeX;
    public float cubeY;
    public float cubeZ;

    void Start()
    {
        myCube = GameObject.Find("Cubo Rojo");
        cubeX = myCube.transform.position.x;
        cubeY = myCube.transform.position.y;
        cubeZ = myCube.transform.position.z;
        Debug.Log(cubeX);
        Debug.Log(cubeY);
        Debug.Log(cubeZ);
    }
}
````

¿Cómo lo hacemos para acceder a los otros componentes? Por ejemplo ¿Cómo podemos acceder al collider del cubo y cambiarle el tamaño de su collider?

El Cubo Rojo tiene un componente llamado Box Collider. Dentro de este componente tiene un parámetro llamado Size que es el encargado de darle un tamaño en los ejes X, Y, Z. Para poder guardar la información en una variable  de este componente utilizamos un método llamado GetComponent.

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCollider : MonoBehaviour
{
    public GameObject myCube;
    public BoxCollider myCollider;

    void Start()
    {
        myCube = GameObject.Find("Cubo Rojo");
        myCollider = myCube.GetComponent<BoxCollider>();
        myCollider.size = new Vector3(3f, 3f, 3f);
    }
}
````
Primero debemos crear una variable pública de tipo GameObject para contener al cubo que hemos llamado Cubo Rojo y luego necesitamos un contenedor de tipo BoxCollider para almacenar la información de Collider del cubo.

Dentro del Start primero vamos a buscar el objeto Cubo Rojo. En este caso usamos el método Find con el nombre Cubo Rojo.

Ahora ya tenemos el cubo dentro de una variable, pero todavía no podemos acceder a su componente BoxCollider, primero debemos obtener acceso y es por ese motivo que hemos creado la variable myCollider.

Para tener permiso utilizamos el método **GetComponent** seguido del tipo entre **<>** y acabamos con **();**

Ahora la variable myCollider puede acceder a las características del componente BoxCollider y podemos definir un tamaño.

El tamaño necesita tres parámetros o valores decimales y por eso hemos creado un Vector3. Estudiaremos Vector3 en breve. De momento, si todo ha ido bien, deberías ver como el collider el cubo se hace 3 unidades más grande.


