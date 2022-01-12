# 3.4 Entender las transformaciones

Ya sabemos cómo podemos acceder a gameObjects y a sus componentes, es lo que necesitamos para empezar a trabajar con las transformaciones.

En el inspector de Unity tenemos tres opciones de transformación que son posición, rotación y escalado.

Estas tres opciones se caracterizan por un Vector3 en cada una de las transformaciones. Un Vector3 se caracteriza por un valor x, y, z. Estos valores son coordenadas que nos permiten posicionar, rotar o escalar un objeto.

Si queremos empezar a mover nuestros objetos vamos a tener que entender Vector3.

### Vector3(x, y, z)
![Fig. 3.4.1 Gizmos posición, escala y rotación](https://github.com/jstleon/programacion-videojuegos/blob/main/03%20C%23%20con%20Unity/3.4%20Entender%20las%20transformaciones/img/3.4.1_gizmo_posicion_escala_rotacion.png)
> Fig. 3.4.1 Gizmos posición, escala y rotación.

En el inspector de Unity tenemos tres opciones de transformación que son posición, rotación y escalado. Estas tres opciones se caracterizan por un Vector3 en cada una de las transformaciones.

Un Vector3 se caracteriza por un valor en x, y, z. Estos valores son coordenadas que nos permiten posicionar, rotar o escalar un objeto.

https://docs.unity3d.com/ScriptReference/Transform.html

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posiciones : MonoBehaviour
{
    public Transform direction;

    void Start()
    {
        direction = gameObject.GetComponent<Transform>();
        direction.transform.position = new Vector3(3f, 3f, 3f);
    }
}

````

Declaramos una variable de tipo Transform para almacenar la información de este tipo que se compone de la posición, la rotación y el escalado.

En la función Start accedemos al componente Transform para eso decimos que la variable direction sea igual al propio objeto y guardamos el componente de tipo Transform. Siempre usaremos este fórmula:

#### GetComponent<Tipo_de_Componente>();

Ahora podemos acceder desde la variable al componente de transformación, en concreto al de posición y para cambiar su posición creamos un Vector3 con 3 valores, una para cada eje de coordenadas (x, y, z).

### Entra en la 3ª Dimensión
Aunque estemos trabajando en un juego 2D, Unity siempre trabaja en 3D. Debemos tener un profundo conocimiento de los elementos cruciales del mundo 3D, y cómo Unity nos permite desarrollar juegos.

### Coordenadas
Entonces debemos estar familiarizados con los ejes de coordenadas cartesianas x, y, z, ya que las dimensiones, valores de rotación y en posiciones en el mundo 3D son descritos de esta manera.

(3, 5, 3) indicando los valores para (x, y, z)

Esto es principalmente por limpieza, y también debido al hecho de que en la programación, estos valores deben ser escritos de esta manera. Independientemente de su presentación, se puede asumir que cualquier conjunto de tres valores separados por comas estarán en este orden: X, Y, Z.

> Fig. 3.4.2 Vector3


### Local Space vs World Space
En todos los mundos en 3D, hay un punto de origen, a menudo referido como “origen” o “world zero”, ya que está representado por la posición (0, 0, 0).

Todas las posiciones de los objetos en 3D son relativas a world zero, para facilitar y simplificar las cosas, podemos usar también local space (también conocido como object space) para definir posiciones de los objetos en relación con los otros.

Estas relaciones se conocen como relaciones entre padres e hijos. En Unity, las relaciones entre padres e hijos se pueden establecer fácilmente arrastrando un objeto sobre otro en la jerarquía.

Esto hace que el objeto arrastrado y se convierte en un hijo, y sus coordenadas a partir de entonces se lee en términos relativos al objeto principal: Padre.

Por ejemplo, si el objeto secundario está exactamente en la misma posición WORLD que el objeto padre, su posición se dice que es (0, 0, 0), incluso si el padre no está en WORLD ZERO.

El Local space asume que cada objeto tiene su propio punto cero, que es el punto a partir del cual surgen sus ejes. Este suele ser el centro del objeto, y la creación de relaciones entre los objetos, podemos comprar sus posiciones en relación con los otros.

Tales relaciones, conocidas como relaciones entre padres e hijos, significa que podemos calcular distancias de otros objetos que utilizan espacio local, con la posición del objeto padre convirtiéndose en el nuevo punto de alguno de sus objetos secundarios cero.

Es especialmente importante a tener en cuenta cuando se trabaja en assets de arte y herramientas de modelado 3D, siempre debemos asegurarnos de crear nuestros modelos en (0, 0, 0) en el paquete que estemos utilizando. Así nos aseguramos que cuando se importe a Unity, sus ejes se leen correctamente. 

Podemos ilustrar esto en 2D, ya que se aplicarán las mismas convenciones que en 3D.

> Fig. 3.4.3 Posición Local vs Global

El primer diagrama muestra dos objetos en un espacio. Un cuadrado grande existe en las coordenadas (3, 3), y uno más pequeño en las coordenadas (6, 7).

En el segundo diagrama, el cuadrado pequeño es hijo del cuadrado grande. Las coordenadas del cuadrado pequeño son (3, 4) ya que su punto cero se encuentra en el centro del cuadrado grande.

