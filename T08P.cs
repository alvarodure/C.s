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
            //
    }
    private void StartB() {
            //OPERADOR LOGICO DE NEGACION 
            //define una variable logica con valor tue
            bool a =true;
            bool b= !a;
            Debug.Log(b);
    }
    private void Start() {
        
    }
}
