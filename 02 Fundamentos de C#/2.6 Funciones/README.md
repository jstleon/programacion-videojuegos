# 2.6 Funciones
Ahora que sabemos qué son las variables, cómo podemos operar con ellas, tomar decisiones y crear repeticiones según nuestras decisiones, vamos a comprimirlo todo en una función que nos permite contener múltiples acciones dentro, y para ejecutarla solamente necesitamos el nombre de la función.

Las funciones nos van a ayudar a gestionar mejor nuestro código, agrupando el mismo en trozos más pequeños y manejables. Una función nos devuelve un resultado, la ejecución de una serie de instrucciones. 

Cuando creamos nuestras propias funciones podemos darles un tipo específico de retorno (return).
Podríamos comenzar poniendo el tipo de dato que queremos que devuelva, por ejemplo números enteros (int) y separada por un espacio el nombre de nuestra función, en este caso: multiplyByTwo

````C#
int mulplyByTwo(){
}
````

Las funciones pueden tener parámetros. Por lo tanto, necesitamos darle un cierto tipo de parámetro a esta función. Vamos a poner de nuevo enteros (int), porque es el tipo de información que quiero poder ingresar a esta máquina para poder tener un resultado de vuelta.

````C#
int multiplyByTwo(int number){
	// Aquí las instrucciones a ejecutar...
}
````
Ten en cuenta que el funcionamiento interno de nuestra máquina toma lugar entre las llaves. Entonces, mientras la variable o los parámetros estén entre los corchetes, verás que las llaves se abren y se cierran alrededor de las acciones que están dentro de nuestra función.

Donde hemos escrito **(int number)**, efectivamente hemos creado una variable temporal llamada number que es parte de nuestra función o máquina. Y vamos a usar esto para ingresar un número en esta función cuando necesitemos invocarla.

Dentro de la función vamos a crear otra variable temporal y luego vamos a realizar una operación sobre ella. Vamos a crear otro int con el nombre result, y luego vamos a igualar nuestra variable result con number multiplicado por dos.

````C#
int multiplyByTwo(int number){
	int result;
       result = number * 2;
}
````
Por último vamos a utilizar el comando **return** para que de esta manera el resultado actual de ejecutar esta función sea el que se producirá el valor de result.

````C#
int multiplyByTwo(int number){
	int result;
       result = number * 2;
return result;
}
````
