# 3.10 Escalar objetos

Para escalar el objeto debemos mirar en la documentación de Unity el apartado de Transform.

https://docs.unity3d.com/ScriptReference/Transform.html

Si miras la documentación encontrarás en el apartado de Propiedades la opción localScale. Esta propiedad nos permite escalar el objeto mediante un vector3. Para realizar un escalado de forma progresiva y animada escribiremos el siguiente script:

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalar : MonoBehaviour
{
    public Transform escalaCubo;
    public float velocidad;

    void Start()
    {
        escalaCubo = gameObject.GetComponent<Transform>();
        velocidad = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        escalaCubo.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f) * velocidad * Time.deltaTime;
    }
}
````

En el ejercicio de aquí arriba, similar a los anteriores, creamos una variable pública para almacenar el componente Transform. También hemos creado una variable pública de tipo float que guarda la velocidad y que controlará a qué velocidad se escala.

Dentro de la función Start, utilizamos la variable escalacubo para acceder al componente Transform del propio objeto. También le damos un valor a la variable de velocidad de 2f;

Dentro de la función Update utilizaremos la variable escalaCubo para acceder a la propiedad localScale y utilizaremos el símbolo de += para sumar el propie vector localScale que es (1,1,1) con el nuevo vector3 que le agregamos que es (0.5f, 0.5f, 0.5f), a este nuevo vector lo multiplicamos por la velocidad que a su vez está multiplicado por Time.deltaTime para que tome el tiempo en segundos.

Si arrastras este script en un cubo, verás como aumenta su tamaño de manera progresiva.

