# 1.7 Ventana Jerarquía (Hierarchy window)
La ventana Jerarquía contiene una lista de todos los GameObject (objetos, luces, cámaras) que encontramos en nuestra escena. Cuando agregamos un objeto a la escena este aparecerá en la lista y cuando eliminemos un objeto este también desaparecerá de esta lista. La lista se crea en el orden que vamos añadiendo o creando objetos. Puedes ver en la escena que tenemos en el proyecto como están organizados los objetos.

![Ventana Jerarquía 1.7.1](https://github.com/jstleon/programacion-videojuegos/blob/main/01%20Introducci%C3%B3n%20a%20Unity/1.7%20Ventana%20Jerarqu%C3%ADa/img/1.7_ventana-jerarquia_1.7.1.png "Ventana Jerarquía")
Figure 1.7.1

En esta ventana también podemos efectuar varias acciones. Podemos cambiar el orden de nuestros objetos de la lista. Para cambiar el orden debemos seleccionar un objeto de la lista por ejemplo el último elemento que es Capsule y arrastrarlo hacia arriba hasta el tercer lugar que quede entre Directional Light y Plane.

![Ventana Jerarquía 1.7.2](https://github.com/jstleon/programacion-videojuegos/blob/main/01%20Introducci%C3%B3n%20a%20Unity/1.7%20Ventana%20Jerarqu%C3%ADa/img/1.7_ventana_jerarquia_cambio_orden_1.7.2.png "Ventana Jerarquía 1.7.2")
Figure 1.7.2

Otra acción que podemos hacer es emparentar objetos. Para que quede más claro vamos a coger dos objetos, la esfera y el cubo. En este ejemplo vamos a hacer que la esfera sea hijo y el cubo el padre, esto quiere decir que cuando movamos el cubo, la esfera también se moverá. Selecciona de la lista la esfera y arrastrala encima del Cubo. Automáticamente se creará en cubo un subobjeto que es esfera.

/img 1.7.3

Un objeto puede tener varios hijos, y a su vez los hijos pueden ser padres y tener hijos como te muestro a continuación.

/img 1.7.4

En la imagen anterior puedes ver cómo el objeto Cube tiene como hijos a Plane, Capsule y Sphere, y a su vez Sphere es padre de Cylinder.

También podemos cambiar el nombre de los objetos haciendo primero un clic para seleccionar y luego otro clic encima del nombre de los objetos, este se convertirá en una caja de texto donde puedes escribir el nombre.
