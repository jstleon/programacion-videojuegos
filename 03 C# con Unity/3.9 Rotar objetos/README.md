# 3.9 Rotar objetos

### Rotar objetos con transform.rotation
Principalmente primero tenemos que acceder al componente Transform como hemos hecho hasta ahora, guardando la información en una variable y si recordamos cuando querías acceder a su posición escribíamos transform un punto que enlazaba con el método y posición, bien pues dentro de Transform podemos acceder a otros métodos como rotation, que nos permite rotar en modo global y localRotation que nos permite rotar en modo local.

https://docs.unity3d.com/ScriptReference/Transform-rotation.html

Si accedemos a la documentación nos encontramos que tendremos que trabajar con Quaternions para representar rotaciones. Los Quaternions se basan en números complejos y esto nos permite poder modificar el componente de rotación de un objeto utilizando los ejes (x, y, z, w). No vamos a entrar en mucho detalle, pero sí es conveniente saber cómo se utilizan.

Es importante conocer método Quaternion que es Euler que nos pide 3 valores decimales para darle una rotación a un objeto de la siguiente manera:

##### Quaternion.Euler(float x, float y, float z)

https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html 

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaciones : MonoBehaviour
{
    public Transform miRot;
    public float speed;

    void Start()
    {
        miRot = gameObject.GetComponent<Transform>();
        speed = 45f;
    }

    // Update is called once per frame
    void Update()
    {
        miRot.transform.rotation = Quaternion.Euler(0f, speed * Time.time, 0f);
    }
}
````

### Rotar objetos con transform.Rotate
A diferencia del anterior este método nos pide dos argumentos para rotar un objeto:

* Un vector 3 con un eulerAngles en donde especificamos los grados de rotación para cada eje.
* Un valor de Space que puede ser Global con Space.World o Local con Space.Self. 
Utiliza Transform.Rotate para rotar GameObjects de varias formas. La rotación a menudo se proporciona como un ángulo de Euler y no como Quaternion.

Puedes especificar una rotación en ejes globales o locales.

La rotación en los ejes globales utiliza el sistema de coordenadas de la escena, por lo que cuando comienzas a rotar un GameObject, sus ejes x, y, z están alineados con los ejes del mundo x, y, z. Entonces si giras un cubo en sus ejes globales, significa que rotará alineado con los ejes del mundo de la escena.

La rotación local utiliza el sistema de coordenadas del propio GameObject. Entonces, un cubo recién creado usa su eje x, y, z establecido en rotación 0. Al rotar el cubo se actualizan los ejes de rotación. 

Rotate funciona de manera similar a Translate, tomando, una vez más, un Vector3 como su argumento. Esta vez vamos a usar el shortcut Vector.up. Esto representa el eje alrededor del cual se gira. Este sería el primer argumento. El segundo argumento es la cantidad que se debe girar. 

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    public float Speed = 2.0f;
    public float turnSpeed = 50.0f;

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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}
````

Como hemos declarado nuestras variables como públicas, podemos realizar pruebas en el editor y cambiar el valor de **turnSpeed** desde el inspector. Observa que estas funciones están trabajando en el eje local del objeto en lugar del eje del mundo. Entonces, donde uses Vector3.forward o Vector3.up es relativo al eje del GameObject al cual se le aplica.

Debes tener en cuenta, que si quieres mover un objeto con un colisionador, algo que va a interactuar con la física, entonces quizás no quieras usar Translate o Rotate y en su lugar deberías usar la función Physics.

Rotar toma un argumento Vector3 como un ángulo de Euler. El segundo argumento son los ejes de rotación, que se pueden establecer en el eje local (Space.Self) o en el eje global (Space.World). La rotación es por la cantidad de Euler.

La implementación de este método aplica una rotación de grados zAngle alrededor del eje z, grados xAngle alrededor del eje x y grados yAngle alrededor del eje y (en ese orden).

Rotar puede tener el ángulo de Euler especificado en 3 flotantes para X, Y y Z.

El siguiente ejemplo muestra dos cubos: un cubo usa Space.Self (el espacio local y los ejes del GameObject) y el otro usa Space.World (el espacio y los ejes en relación con / Scene /). Ambos se giran primero 90 en el eje X para que no estén alineados con el eje del mundo de forma predeterminada. Utilice los valores xAngle, yAngle y zAngle expuestos en el inspector para ver cómo se aplican los diferentes valores de rotación a ambos cubos. Puede notar que la forma en que los cubos giran visualmente depende de la orientación actual y la opción de Espacio utilizada. Juegue con los valores mientras selecciona los cubos en la vista de escena para tratar de comprender cómo interactúan los valores.

````C#
using UnityEngine;

// Transform.Rotate example
//
// This script creates two different cubes: one red which is rotated using Space.Self; one green which is rotated using Space.World.
// Add it onto any GameObject in a scene and hit play to see it run. The rotation is controlled using xAngle, yAngle and zAngle, modifiable on the inspector.

public class ExampleScript : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

   private GameObject cube1, cube2;

   void Awake()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        cube1.GetComponent<Renderer>().material.color = Color.red;
        cube1.name = "Self";

        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(-0.75f, 0.0f, 0.0f);
        cube2.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        cube2.GetComponent<Renderer>().material.color = Color.green;
        cube2.name = "World";
    }

   void Update()
    {
        cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        cube2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }
}
````
