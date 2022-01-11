# 3.5 Vector3
Antes de continuar verás que hemos encontrado una estructura que es Vector3 que nos permite dar valores a las posiciones x, y, z. Te recomiendo que le eches un ojo a la documentación.

(https://docs.unity3d.com/ScriptReference/Vector3.html)

Si te fijas en la documentación verás que disponemos de una serie de variables estáticas que nos permiten resumir algunas posiciones que son muy comunes.

| Vector 3 | Variable estática |
| ---------|-------------------|
| new Vector3(0, 0, 0) | Vector3.zero |   
| new Vector3(1, 1, 1) | Vector3.one |
| new Vector3(0, 1, 0) | Vector3.up |
| new Vector3(0, 0, 1) | Vector3.forward |
| new Vector3(1, 0, 0) | Vector3.right |

También se puede acceder a los valores de la tabla anterior desde **transform** de la siguiente forma.

| transform | Variable estática |
| ---------|-------------------|
| transform.zero | Vector3.zero |   
| transform.one | Vector3.one |
| transform.up | Vector3.up |
| transform.forward | Vector3.forward |
| transform.right | Vector3.right |

Esto nos será de gran utilidad cuando aprendamos a mover nuestros objetos mediante teclado. En la siguiente imagen te represento un dibujo de como un cubo avanzaría una unidad utilizando el Vector3.forward.

![Fig. 3.5.1 Vector3.right](https://github.com/jstleon/programacion-videojuegos/blob/main/03%20C%23%20con%20Unity/3.5%20Vector3/img/Fig_3.5.1_vector3.right.png)
> Fig. 3.5.1 Vector3.right

#### Vectores y videojuegos
En el diseño de videojuegos usamos vectores para definir mallas, direcciones, y muchos otros tipos de cálculos, lo que hace algo fundamental de entender.

Un vector es una línea que se dibuja entre dos puntos, los vectores también tienen una longitud, lo que se conoce como su **magnitud**. Vamos a comenzar viendo los vectores 2D.

![Fig. 3.5.2 Magnitud de un vector](https://github.com/jstleon/programacion-videojuegos/blob/main/03%20C%23%20con%20Unity/3.5%20Vector3/img/Fig_3.5.2_magnitud_vector.png)
> Fig. 3.5.2 Magnitud de un vector

Un vector 2D es una manera de representar un punto desde el origen, la coordenada (0,0) en un gráfico, a cualquier punto en el plano de 2D. Ya que desde el origen tiene una dirección implícita. Está constituido por dos componentes, X y Y. Estos representan la distancia desde cero a lo largo de los ejes horizontal y vertical.

En el ejemplo anterior, el vector va desde el origen a la posición 14,8, la longitud de la distancia entre estos dos puntos se llama la **magnitud**, esto puede resolverse matemáticamente usando el **teorema de Pitágoras**, el cual declara que: **el cuadrado de la hipotenusa es igual a la suma de los cuadrados de los catetos**.

La hipotenusa en las matemáticas de vectores es la magnitud que estamos tratando de encontrar.

> Fig. 3.5.3 Teorema de Pitágoras

También deberías saber que un objeto en movimiento, tiene una velocidad, un cambio de posición a medida que pasa el tiempo, esto también puede expresarse como un vector.

> Fig. 3.5.4 Suma de vectores

En el diagrama de aquí arriba imaginemos que nuestro personaje se encuentra en una posición de (5, 6) con respecto al origen (0, 0) en un momento determinado y sabemos que tiene una velocidad de (12,5) por hora. Esto significa que viajará 12 unidades en el eje horizontal y 5 en el eje vertical. Para poder encontrar su posición después de una hora, vamos a añadir su vector de posición actual a su vector de velocidad, para descubrir dónde llegará, (17, 11).

Recuerda que todos los vectores están representados con relación al origen, el punto cero en el espacio y esto no es diferente a los vectores de velocidad. Del mismo modo que (5, 6) es una posición relativa a la posición cero, 12, 5 es una velocidad relativa a cero movimiento. Entonces, mientras que él podría tener la misma velocidad, 17, 11 es el nuevo vector de la posición de nuestro personaje después de una hora.

Esto es muy útil en nuestras tareas como desarrolladores de juegos que involucran predicciones. Debes tomar en cuenta que los componentes de la posición final son iguales a la suma de los componentes de los dos vectores. Esto también se aplica a la sustracción.

> Fig. 3.5.5 Sumando vectores

Los vectores tridimensionales también funcionan como los de 2D pero extrapolados en el eje Z, el mismo que representa la profundidad. También veremos vectores 3D descritos en coordenadas cartesianas. Los vectores 3D simplemente son líneas dibujadas en el mundo 3D que tienen una dirección y una longitud.

Para calcular la magnitud usamos la misma operación que hemos usado en 2D, pero en este caso con 3 valores al cuadrado sumados entre si es igual a la magnitud al cuadrado. Unity nos ayuda con todos estos cálculos gracias a su función:

#### Vector3.magnitude

(https://docs.unity3d.com/ScriptReference/Vector3-magnitude.html)

Hay un par de funciones muy útiles para vectores 3D. 

Vector A (x, y, z)
Vector B (x, y, z)

(Ax * Bx) + (Ay * By) + (Az * Bz) = Dot Product

Los productos Dot (punto) y Cross (cruz). El Dot Product (Producto punto) toma dos vectores y produce un scaler (escalador), un solo valor de ellos. Para encontrar el Dot Product de dos vectores, tomamos sus partes componentes, los valores de X, Y y Z y los multiplicamos juntos para encontrar la suma de los resultados. Con este producto puedes descubrir información sobre los dos vectores que has especificado.

Un ejemplo podría ser el conocer si dos vectores son perpendiculares. Si el Dot product de dos vectores es cero, los vectores son perpendiculares.

#### Vector3.Dot(VectorA, VectorB)

(https://docs.unity3d.com/ScriptReference/Vector3.Dot.html)

Cross Product (Producto cruzado) es una manera diferente de combinar dos vectores. En lugar de producir un scaler, un solo valor, el Cross Product produce otro vector, específicamente un vector que es perpendicular a los dos originales.

#### Vector3.Cross(VectorA, VectorB)

(https://docs.unity3d.com/ScriptReference/Vector3.Cross.html)

Una de las maneras en las que podríamos necesitar un Cross Product es para encontrar el eje alrededor del cual aplicar torsión. Ejemplo, torreta de tanque. Sabemos hacia donde estamos apuntando, dónde queremos apuntar, un Vector3.Cross serviría para encontrar el eje alrededor del cual queremos aplicar torsión rotativa.

Los vectores se pueden mover en el World Space, pero permanecen sin cambios en sí mismos. Los vectores son útiles en un contexto de motor de juego, ya que nos permite calcular distancias, ángulos relativos entre objetos, y la dirección de los objetos.

Para cambiar mi posición, mi = objeto que tiene el script
se utiliza transform (en minúsculas) 

````C#
transform.position
````

````C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    public float PosX = 5.0f;
    public float PosY = 6.0f;
    
    void Update()
    {
        transform.position = new Vector3(PosX, PosY, 0);
    }
}


````



