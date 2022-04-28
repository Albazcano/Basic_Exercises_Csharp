# Basic_Exercises_Csharp

## Sección 1

### Tipos de datos y casting de tipos

1. Implementa un programa sencillo en el que se definan los siguientes tipos de valores: int, short, byte, long, float, double, decimal, char y bool e imprímelos por pantalla.

2. Crea un programa que convierta una cantidad prefijada de metros (por ejemplo, 3000) a millas. La equivalencia es 1 milla = 1609 metros. Usa comentarios donde te parezca adecuado.

3. Declara tres variables numéricas y asígnales el valor que quieras. Crea otra variable numérica en la que almacenes y muestres por pantalla resultado de realizar las siguientes operaciones con esos números:
a. Suma
b. Resta
c. Multiplicación
d. División

4. Realiza los cast que se plantean a continuación y muestra el resultado por pantalla.
int valor1 = 3; // Convertir a char double valor2 = 1234.5; // Convertir a int int valor3 = 546463213; // Convertir a long int valor4 = 4; // Convertir a short short valor5 = 5; // Convertir a int byte valor6 = 6; // Convertir a long

5. Dado el fragmento de código que se muestra a continuación, determina ayudándote del operador IS si los siguientes datos son de los valores que se indican. Muestra el resultado de la comprobación por pantalla:
a. dato1 es ValueType o int
b. dato2 es float o long
c. dato3 es double u objetct int dato1 = 2; string dato2 = "hello"; float dato3 = 2.3f;

### Estructuras de control

1. Implementa un programa donde se declaren dos variables tipo int y mediante estructuras condicionales muestren por pantalla los resultados de:
a. Comparar dos números e indicar cuál es mayor / menor.
b. Comprobar si los números son pares e impares.
c. Comprobar si son primos
d. Comprobar si son divisibles uno entre otro

2. Implementa un programa en el que se indique un día de la semana y se muestre por pantalla si es fin de semana o no.

3. Crea un programa para mostrar el valor absoluto de un número de la siguiente forma: si el número es positivo, se mostrará tal cual; si es negativo, se mostrará cambiado de signo. Utiliza el operador ternario para resolver el ejercicio.

4. Implementa un programa en el que dados dos números (num1 y num2) se muestre por pantalla si num1 es mayor, menor o igual que num2. Utiliza el operador ternario para resolver el ejercicio.

5. Crear un programa que dada una letra (tipo char) indicada por el usuario y diga si se trata de una vocal, una cifra numérica o una consonante.

6. Crea un programa que pida al usuario dos números y escriba sus divisores comunes. Debes usar llaves en todas las estructuras de control, aunque sólo incluyan una sentencia.

7. Crea un programa que pida al usuario su contraseña (numérica). Deberá terminar cuando introduzca como contraseña el número 1111, pero volverá a pedírsela tantas veces como sea necesario.

8. Crea un programa que pida al usuario dos números y escriba su mínimo común múltiplo. Ayuda: una solución lenta pero sencilla es probar con un "for" todos los números a partir del mayor de ambos, de forma creciente; cuando encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda.

9. Crea un programa que pida al usuario dos números y escriba su máximo común divisor Ayuda: una solución lenta pero sencilla es probar con un "for" todos los números descendiendo a partir del menor de ambos, hasta llegar a 1; cuando encuentres un número que sea divisor de ambos, interrumpes la búsqueda.

10. Crea un programa calcule cuantas cifras tiene un número entero positivo Ayuda: se puede hacer dividiendo varias veces entre 10…

11. Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo.

12. Crea un programa que escriba los números pares del 2 al 106, excepto los que sean múltiplos de 10, usando "continue".

13. Realiza un programa en el que el ordenador “piensa” en un número al azar entre 1 y 50. El usuario ha de adivinarlo en 3 oportunidades. El ordenador señalará si es mayor o menor. Una vez agotados los intentos si no se ha adivinado el número se indicará al usuario que ha perdido.

14. Implemente un programa básico haciendo uso de bucle for, while y dowhile de modo que la salida sean los números del 0 al 9. Ha de visualizarse del siguiente modo:
a. Modifica el programa anterior para que la salida por pantalla (utilizando cada tipo de bucle) sean los números pares. Ejemplo: 0 2 4 6 8
b. Modifica el programa anterior para que en el caso del bucle for la iteración finalice al llegar a 5. Ejemplo: 0 1 2 3 4
c. Modifica el programa anterior para que en el caso del bucle while se muestren por pantalla solamente los números impares. Ejemplo: 1 3 5 7 

15. Implementa un programa que calcule la tabla de multiplicar de un número dado (del 0 al 10). Realiza el ejercicio de dos maneras diferentes (for, while)

16. Implementa un programa donde dado un número se muestre por pantalla:
a. La suma de todos sus antecesores.
b. Los múltiplos de 3 desde la unidad hasta ese número
c. Su cuadrado y su cubo.

17. Implementa un programa donde declares 10 números (positivos y negativos). Muestra por pantalla el resultado de:
a. Sumar los +
b. Multiplicar los –

18. Implementa un programa que recorra los números del 1 al 100 y muestre por pantalla:
a. Todos los números – utiliza dos tipos de bucle diferente.
b. Los números pares – utiliza el tipo de bucle que prefieras
c. Los números pares y que además sean divisibles entre 3
d. Los números primos.

19. Implementa un programa al que se le pasen los valores de los 3 lados de un triángulo y muestre por pantalla si se trata de un triángulo: equilátero, isósceles o escaleno.

### Strings y stringBuilder

Para realizar varios de los ejercicios que se proponen a continuación será necesario invocar alguno de los siguientes métodos:
• Cadena.lenght()
• Cadena.ToUpper()
• Cadena.ToLower()
• Cadena.Replace()
• Cadena.Substring()
• Cadena.Contains()
• Cadena.StarsWith()
• Cadena.IsNullOrEmpty()
• Cadena.IndexOf()

1. Declarar dos variables de tipo cadena y asignarles un nombre y una ciudad. Mostrar por pantalla un mensaje como este: Hola <nombre>, bienvenido a <ciudad>.

2. Declara dos strings e inicialízalos con dos palabras (utiliza palabras de al menos 3 sílabas). Realiza las siguientes operaciones y muestra el resultado por pantalla:
a. Concatena las dos cadenas.
b. Calcula la longitud de las cadenas.
c. Pasa a mayúsculas y a minúsculas cada una de las cadenas.
d. Sobre una de las cadenas, reemplaza un carácter existente por otro.
e. Obtener el carácter de las posiciones 0 y 1 de la cadena.
f. Obtener una subcadena de 4 caracteres a partir del índice 1 de la cadena original.
g. Verifica si una de las cadenas contiene a la otra.
h. Verifica si una de las cadenas comienza con la otra.
i. Verifica si una de las cadenas es nula o vacía
j. Obtén la posición en la que se encuentra un carácter concreto dentro de la cadena.

3. Ingresar una frase no más de 20 caracteres y mostrar cuantas vocales tiene.

4. Dadas las siguientes cadenas:
• String1 → "Esto es una cadena"
• String2 → "Esto es Una CadEna“
a. Compáralas diferenciando mayúsculas de minúsculas.
b. Compáralas sin tener en cuenta mayúsculas y minúsculas utilizando el método compare.
c. Compáralas convirtiendo ambas cadenas a mayúsculas o minúsculas y haciendo la comparación a continuación.

5. Eliminar los espacios existentes dentro de la siguiente cadena:
• “Estoy quitando todos los espacios de esta cadena”
a. Determinar la posición en la que se encuentra ‘q’ en la cadena inicial.
b. Determinar la posición en la que se encuentra ‘q’ en la cadena resultante

6. Contar el número de palabras existentes en la siguiente cadena de texto:
• “En un lugar de la Mancha de cuyo nombre no quiero acordarme”

7. Implementa un programa en el que dada una frase, muestre esta misma frase por pantalla pero intercalando mayúsculas y minúsculas. Ejemplo:
• Frase de entrada → Hola me llamo Ana
• Frase de salida → HoLa Me LlAmO aNa

8. Implementa un programa en el que dada una letra cualquiera, muestre por pantalla una cadena formada por la repetición de esa letra 100 veces.
a. Utiliza el método de concatenación estándar de la clase string.
b. Utiliza la clase StringBuilder para crear la cadena.

9. Concatenar las cadenas que aparecen en este array en una sola cadena de la forma más eficiente posible: string[] myStrings = { "Una cadena", "Dos cadenas", "Tres cadenas", "Cuatro cadenas", "Cinco cadenas", "Seis cadenas", "Siete cadenas", "Ocho cadenas", "Nueve cadenas", "Diez cadenas", "Once cadenas", "Doce cadenas", "Muchas cadenas"};

### Datos de tipo referencia y datos avanzados

Para realizar los ejercicios que se proponen a continuación será necesario invocar alguno de los siguientes métodos:
• Array.Sort()
• Array.Length
• Array.GetValue

1. Implemente una clase Numero que tenga una única propiedad de tipo entero denominada Elemento. En un método main cree dos variables:
• int i = 2
• Numero numero = new Numero{Elemento= 3};
a) Cree un método con un parámetro de entrada de modo que asigne valor 0 al int pasado como parámetro ó a la propiedad Elemento si se pasa un objeto de tipo Numero.
b) Invoque al método con estas dos variables y observe el resultado obtenido para cada una de ellas.
c) Realice una modificación en el código de modo que ahora las variables se pasen por referencia en lugar de por valor. Observe los resultados obtenidos.

2. Declara e inicializa un array de 5 posiciones de tres maneras diferentes. Mostrar el resultado por pantalla ayudándose de un bucle for:
a) Definiendo el array con tamaño 5 y añadiendo los valores a posteriori.
b) Definiendo el array con tamaño 5 y añadiendo los valores al mismo tiempo.
c) Definiendo el array sin especificar el tamaño ya que se obtendrá directamente de la inicialización.

3. Dado el siguiente array de enteros:
• ARRAY → 2, 12, 1, 5, 789, 6, 87 , 2 , 24, 5, 48
a) Muéstralo por pantalla.
b) Suma sus valores y muestra el resultado por pantalla.
c) Haz la media de los valores y muestra el resultado por pantalla.
d) Multiplica todos los elementos del array por un número y muestra el resultado.
e) Cuenta los elementos duplicados
f) Ordena el array con el método Sort y muestra el resultado.
g) Muestra por pantalla el mayor y el menor valor existente en el array.
h) Muestra por pantalla el valor del 5º elemento

4. Dados los siguientes arrays de enteros:
• ARRAY 1 → 4, 87 , 6 , 47 , 5
• ARRAY 2 → 13, 9, 24, 62, 7, 38
a) Fusiona los dos arrays en uno solo.
b) Ordénalos ascendentemente.

5. Dado el siguiente array de enteros, crea dos arrays diferentes, uno que almacene los números pares y otro que almacene los números impares.
ARRAY → 28, 47, 1 , 32 , 4, 95, 68, 20, 74, 7 51, 28, 94, 3

## Sección 2

### Modificadores de acceso
1. Cree una clase donde defina cuatro métodos con los distintos modificadores de visibilidad(public, private, internal, protected). Cree un objeto de esta clase e intente acceder a los diversos métodos definidos. Ayuda: La clase donde se definen los métodos y el main han de definirse en clases separadas, pero con el mismo namespace.

### Clases - Paso por valor / referencia
1. Completa el siguiente programa siguiendo las especificaciones indicadas y responde a las siguientes preguntas:
a. ¿Cuál es el primer valor que se muestra por pantalla?
b. Cuando se invoca al método, ¿qué valor se imprime por pantalla?
c. Al volver al Main(), ¿cuál es el valor que toma la variable? ¿Por qué? using System; public static class Ejercicio1 { public static void CambiaPalabra1(string Palabra) { // Asígnale un nuevo valor a Palabra, por ejemplo → Palabra = “Adios” // Muestra el valor por pantalla de la variable por pantalla } public static void Main() { // 1. Declara una variable de tipo string y asígnale un Valor, por ejemplo → String saludo = “hola”. // 2. Muestra el valor del string por pantalla. // 3. Invoca al método CambiaPalabra1 pasándole la variable que has creado // 4. Muestra de nuevo el valor del string por pantalla. } }

2. Tomando como partida el ejemplo del ejercicio1, realiza los siguientes cambios.
- Añade a la clase Ejercicio1 un nuevo método CambiaPalabra2 que reciba un string, pero en este caso por referencia → CambiaPalabra2 (ref palabra). Modifica su valor y muestra el resultado por pantalla.
- Añade una invocación a este nuevo método CambiaPalabra2 desde el Main() en el que le pases otro string, pero en este caso por referencia → CambiaPalabra2(ref miPalabra). Muestra por pantalla el valor de esta palabra antes y después de llamar al método CambiaPalabra2.
- Al igual que en el caso anterior, responde a las siguientes preguntas:
a. ¿Cuál es el primer valor que se muestra por pantalla?
b. Cuando se invoca al método, ¿qué valor se imprime por pantalla?
c. Al volver al Main(), ¿cuál es el valor que toma la variable? ¿Por qué?

3. Crea un programa que permita realizar operaciones aritméticas básicas y que tenga las siguientes características:
a. Implementa una clase operaciones. Dicha clase tendrá 4 métodos diferentes que serán invocados desde el Main(), uno por cada tipo de operación: suma, resta, multiplicación y división.
i. Implementa los métodos de manera que el resultado de la operación se imprima directamente desde el método.
ii. Implementa los métodos de manera que retornen el resultado de la operación y la información se muestre por pantalla desde el Main()
iii. Declara los métodos como VOID y busca una alternativa para retornar el resultado al Main y que sea desde aquí donde se muestre la información por pantalla.
b. Desde el Main(), declara las variables necesarias para poder invocar a los métodos correspondientes.

### Clases - Constructores

1. Crea una clase Coche con las siguientes características:
Atributos de la clase:
• Tipo string: marca, modelo, color.
• Tipo int: cilindrada.
Métodos:
• Constructores → crear constructores que permitan inicializar los valores del coche en función de los parámetros que le pasemos al constructor.
• Arrancar () → Simplemente mostrará un mensaje por pantalla indicando que ha arrancado.
• Parar () → Simplemente mostrará un mensaje por pantalla indicando que ha frenado.
Main:
• Crear 5 objetos de tipo coche e inicializar el valor de los atributos invocando los diferentes constructores
• Mostrar por pantalla los valores de los diferentes atributos.

2. Desarrollar un programa con una clase Triángulo con las siguientes características:
Atributos de la clase:
• Tipo: int: lado1, lado2, lado3
Métodos
a. LadoMayor () → Imprime por pantalla el valor del lado mayor.
b. EsEquilatero() → Imprime por pantalla si el triángulo es equilátero o no.
c. Constructor → Inicializa los atributos en caso de que no se asignen valores específicos en el Main()

3. Crea una clase Puerta con las siguientes características:
Atributos:
• Tipo int: ancho, alto.
• Tipo string: color
• Tipo bool: abierta
Métodos (void):
• Constructor → asigna valores por defecto
• Abrir → abierta = true;
• Cerrar → abierta = false;
Crea en el Main () dos objetos de tipo puerta: puerta1 y puerta 2.
a. Asigna manualmente los valores de los atributos de puerta1.
b. La puerta2 tomará los valores a partir del constructor.
c. Invoca al método Abrir() y muestra por pantalla el estado de las puertas
d. Invoca al método Cerrar() y muestra por pantalla el estado de las puertas

### Clases - Propiedades

1. Queremos guardar información sobre libros, por lo que vamos a crear una clase Libro con las siguientes características:
Atributos:
• Tipo string: autor, título, ubicación.
Propiedades:
• Get y Set para cada atributo, permitiendo leer y modificar el valor de los mismos.
Main():
• Crea diferentes objetos de la clase libro y asigna valor a sus atributos.
• Muestra la información de cada libro creado por pantalla.

2. Crear un problema que cuente con dos clases, una clase Club y otra clase Socio. En el Main() únicamente se creará un objeto de tipo Club y se llamará al método que calcula la antigüedad de los socios en el club.
Características de la clase Socio:
Atributos: deben ser privados y contar con propiedades que permitan acceder a ellos.
• Tipo string: nombre, apellido, ciudad.
• Tipo int: año de alta en el club.
Propiedades: Definir dos propiedades para poder acceder al nombre y al año en el que el socio se dio de alta en el club (no permitir cargar un valor negativo en el parámetro).
Características de la clase Club:
Atributos:
• 3 objetos de la clase Socio.
Métodos:
• Crear un método constructor que se encargue de inicializar los datos de los socios.
• Definir un método que permita imprimir el nombre del socio con mayor antigüedad en el club y que indique el número de años que lleva siendo socio.

### Clases – Static

1. Implementa una clase llamada Operacion. Define dos métodos estáticos que permitan sumar y restar dos valores enteros.
2. Implementa una clase llamada VectorEnteros. Define tres métodos estáticos que reciban como parámetro un vector de enteros.
• El primero retorna el mayor elemento del vector
• El segundo retorna el menor elemento.
• El tercero retorna la suma de sus componentes.
3. Implementa un programa siguiendo las siguientes especificaciones:
a. Crea una clase llamada Persona que cuente con los siguientes atributos:
▪ Un atributo privado tipo string para almacenar el nombre.
▪ Un atributo privado tipo int para almacenar la edad.
▪ Un atributo público estático tipo int que se utilizará para almacenar la cantidad de objetos tipo Persona que se creen desde el Main()
b. La clase Persona contará con dos métodos:
▪ Un Constructor que recibirá como parámetros el nombre y la edad de la persona permitiéndonos inicializar los atributos. Dentro del constructor incrementaremos el atributo estático en una unidad, lo cual nos permitirá ir contabilizando el número de objetos tipo Persona que vamos creando.
▪ Un método ImprimirPersona que mostrará por pantalla el nombre y la edad de la persona indicada.
c. En el Main() crea diferentes objetos tipo persona e inicialízalos por medio del constructor. Entre cada “persona creada” muestra por pantalla el valor que toma el atributo estático que hemos definido para contar el número de personas creadas. Ayuda: Recuerda que no es necesario crear un objeto tipo Persona para poder acceder a este valor, puedes hacerlo directamente.
