using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T07P : MonoBehaviour
{
    //OPERADORES ARITMETICOS DE ASIGNACIÓN
    // Start is called before the first frame update
    void Start1()
    {
        //manejando puntuaciones
        int puntuacionJugador1 = 10;
        int puntuacionJugador2 = puntuacionJugador1;
        puntuacionJugador1 = puntuacionJugador1 + 5;
        puntuacionJugador2 = puntuacionJugador2 * 2;
        Debug.Log(puntuacionJugador1);
        Debug.Log(puntuacionJugador2);
    }
    private void Start2()
    {
        //edades y cadenas de texto 
        //inicializa la edad de jose en 10
        int edadJose = 10;
        //inicializa la edad de maria con la mitad de la edad de jose
        int edadMaria = edadJose / 2;
        //resta un año a los dos
        edadJose = edadJose - 1;
        edadMaria = edadMaria - 1;
        //comprueba si se obtiene 9 y 4
        Debug.Log(edadJose);
        Debug.Log(edadMaria);
        // Dos variables que tengan "Edad Jose y edad Maria"
        string textoEdadJose = "Edad de Jose: ";
        string textoEdadMaria = "Edad de Maria: ";

        Debug.Log(textoEdadJose + edadJose);
        Debug.Log(textoEdadMaria + edadMaria);

        // otra manera de hacerlo 
        // string textoEdadJose = "Edad de Jose: " + edadJose;
        // string textoEdadMaria = "Edad de Maria: " + edadMaria;
    }
    private void Start3()
    {
        //Ejercicio 3: HAY QUE USAR PARÉNTESIS

        // 3a. Haz que se ejecute este codigo y observa el resultado 11.
        // que no tiene nada que ver con hacer las operaciones de izquierda
        // a derecha, ya que asi obtendriamos 19.
        int res = (2 + 1) * (5 + 4);
        Debug.Log("Resultado de \n la operacion: " + res);
        int usopare = (2 + 2 + 3 + 6) * (55 + 2);
        Debug.Log("Uso parèntesis " + usopare);

        // 3b. Utiliza parentesis en la expresion anterior para que el resultado
        // de sumar 2 y 1 sea multiplicado por el resultado de la suma de 5 y 4.
        // Obteniendo en "res" el valor 27.

        // 3c. Observa que ocurre si quitamos el \n que hay dentro de la cadena del log. (no ocurre el salto de linea)
    }
    private void Start4() {
        //Suseción Fibonacci
        // inicializa un array con 5 valores enteros
        int[] enteros = new int[5]{0,0,0,0,0};
        /*
        O
        int[] array = new int[5]; 
        int[] array={0,0,0,0,0}; 
        */
        enteros[0]= 1; //asigna a la primera posicion el valor de 1
        enteros[1]= 2; //asigna a la segunda posicion el valor de 2
        enteros[2]= enteros[0]+enteros[1]; //asigna a la tercera posicion la suma de las dos posiciones anteriores
        enteros[3]= enteros[2]+enteros[1];//asigna a la cuarta posicion la suma de las dos posiciones anteriores
        enteros[4]= enteros[3]+enteros[2];//asigna a la quinta posicion la suma de las dos posiciones anteriores
        //saca los cinco valores separados por ','
        Debug.Log(enteros[0]+","+enteros[1]+","+enteros[2]+","+enteros[3]+","+enteros[4]);

    }
    private void Start() {
        //Solución de errores más comunes. 
        
		// Sumamos 5 y 2, y a su resultado lo multiplicamos por 3.
		int valor = ((5 + 2) * 3);
		// Concatenamos a la cadena "Resultado: " el valor de la variable "valor".
		Debug.Log("Resultado: "+valor);        
    }
}
