using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T06P : MonoBehaviour
{
    //VIENDO TEORIA
    // Start is called before the first frame update
    void StartA()
    {
        /*
        Practica Inicializacion de arrays
            bool int float string
        */
        string[] jugadores = new string[2];
        bool[] vivos = new bool[5];
        int[] puntajes = new int[5];
        float[] promedio_puntajes = new float[5];
        //formas de inicializar un array int
        int[] iniciaA = new int[5]{1,2,3,4,5};
        int[] iniciaB = new int[]{1,2,3,4,5,6,7,8,9};
        int[] iniciaC = {1,2,3,4};
        //Inicializacion string
        string[] iniciaD = {"Lalo","Jorge","Fatima","Maria","Arami"};
        //INICIALIZANDO bool
        bool[] muertos = {true,true,false,true,false};
        // Debug.Log(muertos);
        jugadores[0]="Alvaro";
        jugadores[1]="Yonaguni";
    }
    //EJERCICIOS
    private void StartB() {
        //una variable de tipo array de tres valores logicos
        //haciendo alusion a que aun no comenzamos los 3 niveles, todos llevan false
        bool[] nivels = {false,false,false};
        //marcar como completado el primer nivel del array
        nivels[0]=true;
        // saca por log el valor de cada una de las tres casillas del array definido 
        Debug.Log(nivels[0]);
        Debug.Log(nivels[1]);
        Debug.Log(nivels[2]);
    }
    private void StartC() {
        //define una variable de tipo array con cinco valores enteros
        // todos inicializados a 1
        int[] ENTEROSINICIA = new int[2]{1,1};
        int[] enteros = new int[5]{1,1,1,1,1};
        //saca por log el numero de elementos que tiene el array
        Debug.Log(enteros.Length);
        // int arraylongitud = enteros.Length;  guardamos la longitud en una variable
        // Debug.Log(arraylongitud);
        enteros[0]=42;
        enteros[4]=42;
        Debug.Log(enteros[0]);
        Debug.Log(enteros[1]);
        Debug.Log(enteros[2]);
        Debug.Log(enteros[3]);
        Debug.Log(enteros[4]);
    }
    private void Start() {
        //define una variable de tipo array con cinco frases que digan predicciones del futuro
        string[] predicciones = {"Llovera","Estara nublado","Estara Soleado","Caera un aguacero","Tu suerte mejorará"};
        // genera un numero aleatorio
        int random = Random.Range(0,5);
        /*
         saca por log el valor del array en la posicion randomica generada, y veras como se
         imprime una frase distinta al azar cada que se ejecuta el codigo 
         */
        Debug.Log(predicciones[random]);
    }
}
