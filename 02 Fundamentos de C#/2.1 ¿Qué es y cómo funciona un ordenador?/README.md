# 2.1 ¿Qué es y cómo funciona un ordenador?

Muchas veces aprendemos a utilizar algo sin realmente comprender cómo funciona y en computación esto cada vez es más común, estamos acostumbrados a utilizar la computadora, nuestro smartphone, televisiones y tecnología en general sin darnos cuenta de lo que real de lo que realmente está pasando con nuestro dispositivo, por lo tanto, me parece relevante que antes de aprender a programar hablemos brevemente sobre algunos puntos sobre tecnología y computación.

## ¿Qué es una computadora?
En esencia es un dispositivo capaz de ejecutar una serie de operaciones. Las operaciones pueden ser lógicas y aritméticas. La manera en la que podemos indicar qué operaciones va a realizar la computadora es escribiendo código de programación. 

Basados en esta definición de lo que es una computadora podemos entender que una computadora no es solo lo que comúnmente llamamos computadora, hoy en día nuestros teléfonos, televisiones, relojes, electrodomésticos y demás tecnología también son computadoras y en su mayoría disponen de un CPU, el encargado de ejecutar estas operaciones.

## CPU

Este chip es el corazón de cada computadora, puede haber uno (o varios) dentro de tu computadora. Es también muy común que el CPU se ayude de otros chips como los de comunicación vía Wi-Fi o tecnología de comunicación celular.

Vamos a analizar cómo se compone de arquitectura básica de una computadora. Vamos a ver un modelo que podría considerarse como la base para la mayoría de las arquitecturas. Tal vez has escuchado hablar sobre la memoria, discos duros o dispositivos de entrada y salida, bueno para demostrar cómo están conectados veamos el siguiente diagrama.

![Fig. 2.1.1 Diagrama](https://github.com/jstleon/programacion-videojuegos/blob/main/02%20Fundamentos%20de%20C%23/2.1%20%C2%BFQu%C3%A9%20es%20y%20c%C3%B3mo%20funciona%20un%20ordenador%3F/img/Diagrama-ordenador%402x.png "Fig. 2.1.1 Diagrama")
// Fig. 2.1.1 Diagrama

Si hablamos de dispositivos de entrada como un teclado o dispositivo de salida con un monitor, ambos son controlados por una interfaz de entradas y salidas. Utiliza un bus de datos para comunicarse con el CPU, existen diferentes tipos de buses y para verlos de forma sencilla podemos verlos como carreteras que transforman información. 

Como programadores nos interesa más la parte de memoria y almacenamiento, ya hablamos de lo que es y cómo funciona un CPU pero ¿de dónde vienen los datos y comandos que el CPU ejecuta?

Si vemos el diagrama nos daremos cuenta de que existen tres tipos de memoria:

**Memoria caché**
**Memoria RAM**
**Disco duro**

## ¿Para qué necesitamos tres tipos de memoria?
Cada uno de estos tres niveles de almacenamiento tiene sus propias características. La memoria caché es más rápida pero también la más pequeña, es la más cercana al CPU. Un procesador moderno comúnmente tiene 12MB o algo más de esta memoria. Es la memoria más cara y esa es una de las razones principales por las cuales los fabricantes no pueden poner mucha de esta memoria, y bueno, obviamente no podemos trabajar con esa cantidad de memoria, tan solo una imagen en alta resolución tomada con una cámara moderna ocupa más espacio de lo que tenemos disponible de memoria caché, es por esto que se hace uso de la memoria RAM.

En las computadoras actuales es común encontrarla en cantidades de 16GB, 32GB y hasta 64GB. Es mucho más barata de fabricar la memoria caché y también es más lenta, aunque los últimos años las velocidades en este tipo de memoria se han incrementado considerablemente, el recorrido que los datos hacen desde la memoria RAM al CPU es considerablemente más grande que el recorrido desde la memoria caché. La mayoría de arquitecturas de computadora tenemos disponible una memoria o dispositivo de almacenamiento masivo, en este caso estamos hablando de un disco duro. generalmente podemos ver configuraciones de computadoras con 1 TB o más utilizando dispositivos magnéticos, sin embargo, la popularidad de nuevas tecnologías como los discos en estado sólido ha ido en aumento, aunque su costo es considerablemente mayor, no han logrado ser tan rápidos como la memoria RAM, además de que el recorrido de los datos es aún mayor.

## Unidades de almacenamiento
Empezando por el bit, es la unidad mínima de información. y solo puede tener dos valores (cero o uno). En los sistemas de lógica binaria todas sus variables y operaciones lógicas están basadas en combinaciones del uno y el cero.

Ahora si en un bit solo cabe uno de estos dos números, ¿Cómo puedo hacer combinaciones? Aquí es donde podemos hacer uso del byte, que también es una unidad de almacenamiento. Un byte es equivalente a un conjunto ordenado de ocho bits.

En computación no le podemos mandar bits individuales a un CPU. La unidad mínima que podemos utilizar es 1 byte, estaríamos hablando de un CPU de ocho bits. Los chips más modernos no suelen utilizar 8 bits, después de pasar por los 16 y 32, en la actualidad los equipos utilizan 64 bits como unidad individual de información. A este paquete también se le conoce como palabra, es decir un conjunto finito de bits que el CPU puede manejar a la vez.


Si entendiste correctamente el párrafo anterior es sencillo darse cuenta de que estas unidades son unidades de almacenamiento, aquí dejo una tabla nos va a dejar más clara la relación entre estas unidades.

![Fig. 2.1.2 Tabla unidades de almacenamiento](https://github.com/jstleon/programacion-videojuegos/blob/main/02%20Fundamentos%20de%20C%23/2.1%20%C2%BFQu%C3%A9%20es%20y%20c%C3%B3mo%20funciona%20un%20ordenador%3F/img/tabla_unidades_de_almacenamiento.png"Fig. 2.1.2 Tabla unidades de almacenamiento")
// Figure 2.1.2 Tabla

Las computadoras sólo entienden el lenguaje usando bits y empaquetado en bits, cuando nosotros hacemos código para crear un programa lo que estamos haciendo es comunicarnos con la computadora; sin embargo, sería muy complicado usar el lenguaje máquina.

Para hacerlo mucho más entendible para los seres humanos y poder comunicarnos con una computadora de manera mucho más sencilla usamos los lenguajes de programación.

Enlaces:
[¿Qué es el byte?](https://www.tecnologia-informatica.com/que-es-el-bit-byte/ "¿Qué es el byte?")

