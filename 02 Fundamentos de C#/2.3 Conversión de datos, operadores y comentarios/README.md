# 2.3 Conversión de datos, operadores y comentarios

## Convertir un tipo de datos en otro
En ocasiones es necesario convertir un tipo de dato en otro, anteriormente en la sección de overflowing vimos que a veces tenemos casos en los que hay que meter un número más grande del que la variable puede guardar por el tipo de la misma, incluso los IDE nos pueden sugerir hacia qué tipo debemos de cambiar nuestra variable.

Existe más de una forma en que un tipo de dato se puede convertir en otro, a veces es de forma implícita y en ocasiones de forma explícita.

## Conversión implícita
La conversión implícita se hace automáticamente, ya hablamos de números que no caben en una variable por su tipo de dato, pero también sucede que números de un tipo de dato se asignan a variables de otro tipo en donde no tendrían problemas con el espacio, por ejemplo, si tenemos las siguientes dos variables.

````C#

byte counter = 1;
int number = counter;

````
En la primera línea declaramos counter que es de tipo byte, si recuerdas la tabla de cuánto espacio necesita el tipo byte en memoria recordarás que solo necesita un byte (de ahí su nombre), en la segunda línea estamos guardando el valor de counter en la variable tipo entero number, si recuerdas, las variables tipo entero utilizan 4 bytes en memoria, por lo tanto no tenemos problemas de espacio aun cuando counter esté en su número más alto, tomamos la siguiente tabla como referencia.

| Variable | Espacio en memoria |
| ------------- | --------------|
| counter | 00000001 |
| number | 00000000 00000000 00000000 00000001 | 



