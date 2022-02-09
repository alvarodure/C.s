using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T12P : MonoBehaviour
{
    // Start is called before the first frame update
    // Ejercicios capitulo 12. Bucles WHILE - DO / WHILE.
    void Start1()
    {
        // Ejercicio 1. Repitiendo Debug.Log
        // 1a. Define una variable entera "contador" inicializada a cero:
        int contador = 0;
        // 1b. Usando un bucle while y la variable "contador"
        // Haz que salga por log 10 veces el texto "Hola!":
        while (contador < 10)
        {
            Debug.Log("Quielen matal a chaos! " + contador);
            contador += 1;
        }

        // 1c. Haz que se ejecute este script y comprueba que has obtenido
        // exactamente 10 holas en el log.

        // 1d. Depura paso a paso el codigo anterior y observa su ejecucion
        // y el valor de sus variables en cada paso.

        // 1e. Modifica el codigo de la seccion 1b para que en vez de
        // mostrarse solo "Hola!" tambien se muestre el valor de "contador".
        // De forma que se vea tal que asi:
        // Hola! (0)
        // Hola! (1)
        // Hola! (2)
        // ...


        // 1f. Haz que se ejecute este script y comprueba que todo sale 
        // como esperabas.
    }
    private void Start2()
    {
        //Ejercicio 2, tablas de multiplicar

        // 2a. Define una variable entera "tablaDeMultiplicar" e inicializala a 5:
        int tablaDeMultiplicar = 2000;
        // 2b. Define una variable entera llamada "contador" inicializandola a 1:
        int contador = 1;

        // 2c. Usando un while y la variable "contador" para el condicional, saca por log 
        // la tabla de multiplicar del numero que este almacenado en "tablaDeMultiplicar":
        // Ejemplo de como deberia salir las lineas por el log:
        // X * 1 = X
        // X * 2 = X
        // X * 3 = X
        // ...
        // X * 10 = X
        // (Sabiendo que la primera X de cada linea corresponde al lugar donde sacar el valor
        // de "tablaDeMultiplicar" y la ultima X de cada linea corresponde al resultado de
        // multiplicar "tablaDeMultiplicar" por el valor correspondiente.)
        while (contador <= 10)
        {
            Debug.Log(tablaDeMultiplicar + " X " + contador + " = " + tablaDeMultiplicar * contador);
            contador += 1;
        }

        // 2d. Haz que se ejecute este script y comprueba que ha salido por log la
        // tabla del 5. Luego cambia el valor de inicializacion de "tablaDeMultiplicar"
        // por cualquier otro numero del 1 al 9 y comprueba que la tabla de multiplicar
        // que sale por log corresponde a la tabla de ese numero. 
        // (Si tuvieras algun problema, puedes iniciar una depuracion paso a paso y 
        // comprobar si todo va ejecutandose como deberia. Para eso esta la depuracion.)
    }
    private void Start3()
    {
        //Ejercicio 3, todas las tablas de multiplicar

        // 3a. Basandote en el codigo del ejercicio anterior, haz que salga
        // por log todas las tablas de multiplicar, desde la del numero 1
        // hasta la del numero 10:
        // Pista: Igual que iteras X veces incrementando "contador", ahora
        // tendras que meter todo ese codigo en otro bucle para que se ejecute 
        // X veces, usando esta vez la variable "tablaDeMultiplicar".
        // Resumiendo: Tendras que hacer un bucle que vaya del 1 al 10, y
        // dentro de ese, otro que vaya del 1 al 10. Y dentro de este ultimo, la linea
        // que saca por log el texto. (Un bucle dentro de otro bucle)
        int contanro = 1;
        while (contanro <= 10)
        {
            Debug.Log("");
            int contador = 1;  //  <-----
            while (contador <= 10)
            {
                Debug.Log("------------------------------" + contanro + " X " + contador + " = " + contanro * contador + "------------------------------");
                contador += 1;
            }
            contanro += 1;
            Debug.Log("nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn");
        }

        // 3b. Haz que se ejecute este script y comprueba que tienes las
        // 10 tablas de multiplicar completas. (Si tienes problemas, usa el
        // depurador y cualquier forma de inspeccionar el valor de las variables)        
    }
    private void Start4()
    {
        //Ejercicio 4, recorrer arrays

        // 4a. Define un array de tipo cadenas de texto llamado "mensajes", que
        // contenga las siguientes cadenas de texto en su inicializacion:
        // "Esto es", "un ejemplo", "de como", "se pueden", "recorrer todos",
        // "los elementos", "de un array":
        string[] mensajes = new string[] { "Esto", " es un ejemplo ", "de como ", "se pueden ", "recorrer todos ", "los elementos ", "de un array" };
        // 4b. Recorre todos los elementos del array, sacando su contenido por log.
        // Pista: Recuerda que los arrays empiezan en la posicion 0 y tendras que
        // hacer que el bucle se repita hasta que llegues a la ultima posicion:
        // Recuerda que para saber el total de elementos que tiene "mensajes"
        // tendras que escribir: mensajes.Length (y que si el total de elementos
        // de un array es por ejemplo 10, la ultima posicion para acceder en el
        // array sera la numero 10-1=9 debido a que se empieza a contar desde 0)
        int contador = 1;
        while (contador < mensajes.Length)
        {
            Debug.Log(mensajes[contador]);
            contador += 1;
        }

        // 4c. Haz que se ejecute este script y comprueba que salen exactamente
        // las 7 cadenas de texto del array. (Si tuvieras problemas, usa el
        // depurador y el inspector de variables)		
    }
    void Start()
    {
        // Solucion de errores mas comunes 
         int contador = 1;
         string lista = "";
         while(contador<=10){
             lista += "-["+contador+"]-";
             Debug.Log("Paso: " + (contador++));
         }
         Debug.Log(lista);
    }
}
