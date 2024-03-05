


**Introducción**

En el mundo de la programación son esenciales las habilidades de resolución de problemas en este proyecto se presentan 4 ejercicios acompañados de una descripción teórica para entrar en contexto de los requerimientos, en este caso hacer uso de una estructura de datos como lo son las listas enlazadas cuyo propósito principal es el de almacenar y manipular datos de forma dinámica.

En este proyecto se trataran las estructuras de listas a partir de la información proporcionada en la Guía 3 el cual habla sobre las distintas estructuras de datos y también se resolverán 4 ejercicios tres de ellos corresponden a ejercicios de desarrollar funciones para una aplicación de consola con C# y el ultimo es un ejercicios donde se diseñara una interfaz gráfica utilizando Windows Form que permita el mostrar de interactiva y grafica las operaciones realizadas en la lista esto con el fin de comprobar las habilidades técnicas de resolución de problemas. 

**Objetivos**

Objetivo General:

Crear un programa que permita la inserción de datos en una lista enlazada utilizando el lenguaje C# que cumpla con los requerimientos que se solicitaron en los ejercicios.

Objetivos específicos:

Desarrollar un programa de consola con C# que permita realizar las funciones de insertar al frente, insertar al final, insertar en una posición especifica, eliminar al frente, mostrar lista y salir.

Diseñar con Windows Forms una interfaz gráfica para el para el programa solicitado que permita el ingresarlos datos en la lista al igual que el programa de consola con la capacidad de actualizar en tiempo de ejecución los datos ingresados o eliminados.



**Desarrollo**

La teoría del documento Guía 3 dado para realizar este proyecto menciona que una lista está compuesta por elementos llamados nodos que corresponden a objetos con la característica de contener una variable que se asigna como miembro puntero y otras variables de cualquier tipo con el fin de manejar datos.

El puntero tiene la función de enlazar cada uno de los nodos con los demás para asi conformar la lista, de esta forma es que se crea la lista el primer nodo corresponde a lo que se denomina cabeza y el ultimo se denomina cola, este mismo teniendo asignado el valor NULL como para definir que corresponde al fin de la lista.

Las listas se pueden clasificar en cuatro grupos estos de acuerdo con su estructura dependiendo de cómo se apunte a la cabeza, cola y tipo de nodo implementado.

Los cuatro grupos son:

- Listas enlazadas
- Listas doblemente enlazadas
- Listas circulares
- Listas doblemente circulares

Para los efectos de este proyecto se trabajará con la lista enlazada o también conocida como lista simplemente enlazada.

En los datos que puede contener cada nodo pueden ser desde datos básicos hasta como un entero decimal hasta datos más complejos.

La lista enlazada es una estructura de datos dinámica en este caso dinámica hace referencia a que los de los nodos que normalmente son registros de tamaño fijo se crean y se destruyen según la necesidad del programa.

En este proyecto se solicitó la resolución de 4 ejercicios a continuación se presentara el enunciado del ejercicio y los pasos que se siguieron para la resolución de este. 

**Ejercicio No. 1**

Modifique el ejemplo de forma haya un menú de opciones para acceder a los métodos que contiene la clase.

a. Insertar al Frente

b. Insertar al Final

c. Insertar en una posición específica

d. Eliminar al Frente

e. Eliminar al Final

f. Mostrar lista

g. Salir

El menú deberá estar siempre disponible hasta que el usuario seleccione la opción g es decir salir de la aplicación. 

En la clase Program.cs donde se encuentra el método Main se creó el menú el menú se creó  con la estructura do while para mantenerlo en ejecución hasta que el usuario solicite una de las opciones de ingreso de datos o presiones g para salir, mediante el char opción solicita que se ingrese una de las letras del menú se ingresa alguna no contemplada por defecto nos indica que no es una opción válida y regresa al menú para volver solicitar una de las opciones esto continua hasta que se seleccione una opción valida o la opción g que corresponde a cerrar el programa y salir, y la primera línea “Lista listanueva = new Lista();” es la encargada de crear la instancia de la clase Lista, que representa la lista enlazada.

![](https://i.ibb.co/4Ptp2Nq/Picture1.png)

**Ejercicio No. 2**

Modifique el método de insertar por posición para que en caso de que la posición seleccionada no exista envíe un mensaje de alerta y que inserte al final (es decir que inserte en la cola).

Para este ejercicio dentro de la clase lista se creó el método InsertarEnPosicion

El método se inicia con un if en cual verifica la posición solicitada para insertar el valor en caso de que la posición sea menor o igual a cero este nos indica que la posición debe de ser mayor a cero y regresa al menú del inicio, en caso de que el valor sea mayor a cero y se encuentre en una posición valida permite el ingreso de los datos en caso de que la lista este vacía y se ingrese el dato este se va al final de la lista mismo caso es si se intenta ingresar el dato a una posición que no se encuentra en las lista.

Ejemplo si una lista contiene los cinco valores “6 ->    98 ->   88 ->   99 ->   5 ->” y se intenta ingresar un valor en la posición 9 este nos envía el mensaje “La posición especificada excede la longitud de la lista. Insertando al final.” Y se inserta el valor al final.

![](https://i.ibb.co/5Bfdnwr/Picture2.png)

**Ejercicio No. 3**

Agregue un método más a la clase lista, de forma que los datos se ingresen en forma ascendente, es decir que se comparará con el primer valor que encuentra y si es menor se ingresa antes y sino sigue hasta encontrar la ubicación que le corresponde. Haga la correspondiente prueba en el Mein para verificar su funcionamiento. 

En este ejercicio se creó el método InsertarAscendente este método se compone de un if esto con el fin de realizar la verificación de la siguiente manera en primer lugar verifica si la lista está vacía o si el valor a insertar es menor o igual al valor del primer nodo. En caso de ser verdadero el nuevo nodo se enlaza al inicio de la lista y apunta al nodo anterior. En caso de que la condición sea falsa entonces el dato se almacenara ya sea en el medio o al final de la lista.

También se agregó una opción más al menú que por lo que se movió la opción de g para salir a h y en la opción g se colocó esta nueva funcionalidad.

![](https://i.ibb.co/4S26TXk/Picture3.png)

![](https://i.ibb.co/c1gq80B/Picture4.png)

**Ejercicio No. 4** 

Utilizando la clase dada, pase al entorno gráfico. De forma que los valores de los nodos ingresados se reflejen en una herramienta como ListBox u otro y al momento de suprimirlos también se actualice y el dato no aparezca más en el entorno. El diseño es totalmente libre.

Se creo una pantalla donde se realizan las operaciones solicitadas agregando un botón que permita eliminar de la siguiente forma si se selecciona cualquier elemento que se muestra en el listbox y se da click en el botón eliminar el elemento seleccionado se elimina y la lista se reacomoda todo esto en tiempo de ejecución.

Por defecto el programa inicia con la operación de Insertar al frente.

![](https://i.ibb.co/MDMMt3m/Picture5.png)

Cuando la operación que se selecciona es la de Insertar por posición un nuevo textbox se muestra para que le indiquemos la posición a la que se quiere realizar la inserción.

![](https://i.ibb.co/LZdWCPq/Picture6.png)

**Conclusiones**

En conclusión, las listas enlazadas son estructuras de datos que permiten la comprensión básica del funcionamiento del manejo de datos dinámicos y el realizar operaciones en tiempo de ejecución, el comprenderlas nos permite como futuros entender la importancia de estas ya que muchos algoritmos y aplicaciones requieren de su uso.

también son las bases para estructuras de datos más complejas y avanzadas pero que comparten sus principios fundamentales en las listas.

En cuanto a los ejercicios desarrollados estos se enfocaban en resolver problemas en un programa que ya se había avanzado en clase lo que es muy intuitivo ya que en el mundo de la programación muchas veces los requerimientos es agregar funcionalidades a un programa ya existente o como en ejercicio 4 que es readecuar el programa para que también funcione con Windows Form.



**Recomendaciones**

- Para la aplicación de consola:

Al insertar un dato en una posición específica, asegúrate de ingresar una posición válida mayor que cero.

Antes de eliminar un dato, verifica que la lista no esté vacía para evitar errores.

Cuando se muestra la lista, verifica que los datos se muestren correctamente en el orden esperado.

- Para la aplicación de Windows Forms:

Al insertar un dato en una posición específica, asegúrate de ingresar una posición válida mayor que cero.

Antes de eliminar un elemento de la lista, asegúrate de seleccionarlo en el ListBox.

Verifica que la lista se actualice correctamente después de realizar una operación de inserción o eliminación.

**En general:**

Siempre guarda tus datos antes de realizar acciones que puedan modificarlos permanentemente.

Si encuentras algún comportamiento inesperado en la aplicación, intenta reiniciarla antes de reportarlo.

Si tienes alguna sugerencia de mejora para la aplicación, no dudes en compartirla con el desarrollador.

Bibliografía

PED104. Guía N°3 
