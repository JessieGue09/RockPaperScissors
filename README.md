Creación del Juego "Piedra, Papel, Tijeras" utilizando las siguientes funcionalidades:

1. Seleccionar opción a jugar (piedra, papel o tijera)
2. La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
3. Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador

Se implemento con documentación y se creo un commit por punto.
Cada punto o instrucción tiene una rama donde se implementa lo necesario según el punto a tomar.

Los nombres de las ramas (branches) son las siguientes:
Para el punto 1: "feat/proyect-structure"
    Inicio del proyecto desarrollando el primer paso; El jugador tiene la opción de seleccionar una opción a jugar desde la terminal.
    (Revisar los comentarios del código: línea 5 - 25 / 133 - 136).

Para el punto 2: "feat/option"
    Programar la condición "random" para que la AI genere un número al azar en un intervalo del 1 al 3.
    (Revisar los comentarios del código: línea 26 - 36 / 138 - 140).

Para el punto 3: "feat/winner"
    Creación de condicionales utilizando switch case, en donde cada caso se muestra un ganador en concreto o si hay algun empate.
    (Revisar los comentarios del código: línea 45 - 131 / 143 - 146).