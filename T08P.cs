using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class T08P : MonoBehaviour
{
    //OPERADORES LÓGICOS Y DE COMPARACIÓN 

    // Start is called before the first frame update
    void StartA()
    {
        // int rnd = Random.Range(0,5);
        // int[] via = new int[] { 1, 2, 3, 4 };
        // Debug.Log("El contenido de la posicion" + rnd + " es:" + via[rnd]);

        //OPERADORES LÓGICOS
        // bool tengohambre=true;
        // bool esdedia=false;
        // bool soyprogramador=true;

        // AND : devuelve true si y solo si las dos proposicione son verdaderas
        // true&&true=true
        // true&&false=false
        // false&&false=false
        // OR  : devuelve true si almenos una de las dos proposiciones son verdaderas
        // true||true= true
        // true||false=true
        // false||false=false
        // NOT : Niega la propsición, invierte el valor lógico
        // !true=false 
        // !false=true
        // !!!true=false

        // OPERADORES DE COMPARACIÓN
        // !=
        // ==
        // <
        // <=
        // >
        // >=
    }
    private void StartB()
    {
        //OPERADOR LOGICO DE NEGACION 
        //define una variable logica con valor tue
        bool a = true;
        bool b = !a;
        Debug.Log(b);
    }
    private void StartC()
    {
        //ejercicio 2, operadores AND(&&) y OR(||) 
        //adivina que valores saldran por el log
        bool trueANDtrue = true && true; 
        bool trueANDfalse = true && false;
        bool falseANDtrue = false && true;
        bool falseANDfalse = false && false;
        Debug.Log("True AND true : " + trueANDtrue);
        Debug.Log("true and false : " + trueANDfalse);
        Debug.Log("false and true : " + falseANDtrue);
        Debug.Log("false and false: " + falseANDfalse);

        bool trueORtrue = true || true;
        bool trueORfalse = true || false;
        bool falseORtrue = false || true;
        bool falseORfalse = false || false;
        Debug.Log("True OR true : " + trueORtrue);
        Debug.Log("true OR false : " + trueORfalse);
        Debug.Log("false OR true : " + falseORtrue);
        Debug.Log("false OR false : " + falseORfalse);
    }
    private void StartD() {
            //ejercicio 3, adivina que valores saldran por el log 
            bool estoyprogramando=true, vivoenmarte=false,panempiezaconP=true;
            bool resul1=estoyprogramando&& !vivoenmarte; 
            bool resul2=vivoenmarte || (estoyprogramando&&panempiezaconP); 
            bool resul3= !( (!estoyprogramando||vivoenmarte) || panempiezaconP );    
            Debug.Log("RESULTADO 1: "+resul1);
            Debug.Log("RESULTADO 2: "+resul2);
            Debug.Log("RESULTADO 3: "+resul3);
    }
    private void Start() {
            // ejercicio 4, edades y comparaciones 
            int edad= 17;
            int[] edades = new int []{18,20,23,12,11,15};
            Debug.Log(edad);
            Debug.Log(edades.Length);            
    }
}
