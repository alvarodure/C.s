using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T09P : MonoBehaviour
{
    // Start is called before the first frame update
    private void StartTeoria() {
        // Mas operadores
        // += -= *=     /= %= (estos dos ultimos no alteran el contenido de la variable ya que solo
        //                     muestran el resultado de la division)
        int a = 0;
        Debug.Log(a);
        a+=1;
        Debug.Log(a);
        a-=1;
        Debug.Log(a);
        int bb = 8;
        bb *= 2;
        Debug.Log("BB: "+bb);
        bb /= 2;  //muestra el Cociente
        Debug.Log("Cociente: "+bb);
        bb %= 2;  //muestra el Resto 
        Debug.Log("Resto: "+bb);

        //OPERADOR TERNARIO ?:
        // evaluar una expresion u otra dependiendo de un valor logico
        int edad=18;
        int dificultad = (edad<18) ? 10 : 50;
        Debug.Log("La dificultad es: "+dificultad);
        
        int edad2=10;
        string mayormenordedad = (edad2>=18) ? "Mayor de edad" : "Menor de edad";
        Debug.Log(mayormenordedad);

        int vidas = 1;
        string estado = (vidas>0) ? "Usted sigue con vidas" : "Usted ha quedado sin vidas";
        Debug.Log(estado);

    }
    void StartA()
    {
        // 1a. Define una variable entera inicializada a cero:
        int a = 0;

        // 1b. Incrementa esa variable en uno usando los operadores "=" y "+":
        a = a + 1;

        // 1c. Incrementa esa variable en uno usando el operador "+=":
        a += 1;

        // 1d. Incrementa esa variable en uno usando el operador "++":
        a++;

        // 1e. Saca por log el valor de la variable:
        Debug.Log("La variable a tiene el valor: " + a);

        // 1f. Haz que se ejecute este script para comprobar si se obtiene 3 en el log.	F           
    }
    private void StartB()
    {
        // OPERADOR --
        // 2a. Define una variable "a" entera con el valor 10:
        int a = 10;
        // 2b. Define una variable "b" entera con el valor de "a", 
        // y coloca el operador "--" a la variable "a" de forma que
        // tras ejecutarse esta linea, en "b" quede el valor 10 y 
        // en "a" el valor "9":
        int b = a--; //le asigna el valor de 10-1 a b, mientras modifica a. (preguntar)

        // 2c. Saca por log el valor de ambas variables:
        Debug.Log("A=" + a + "    B=" + b);
        // 2d. Hacer que se ejecute este script y comprobar que "a"
        // vale 9 y "b" vale 10.

        //me salio 9 para a y b ( porque hacia esto: "int b = --a";  le restaba a b 1, y le asignaba la a)
    }
    private void StartC()
    {
        // OPERADOR TERNARIO
        // 3a. Define una variable "edad" de tipo entero inicializada a 17:

        int edad=10;
        // 3b. Define una variable "texto" de tipo cadena de texto inicializandola
        // a "Mayor de edad" si "edad" es mayor o igual a 18; si no, 
        // inicializarla a "Menor de edad":
        if (edad>=18)
        {
            string cadenaedad = "Mayor de edad ";
            Debug.Log("If: "+cadenaedad);
        }else{
            string cadenaedad = "Menor de edad ";
            Debug.Log("If: "+cadenaedad);
        }        
        //CON EL OPERADOR TERNARIO
        string mayormenordedad = (edad>=18) ? "Mayor de edad" : "Menor de edad";

        // 3c. Sacar por log el contenido de "texto":
        // Debug.Log("Ternario: "+mayormenordedad);
        
        Debug.Log((edad>=18) ? "Mayor de edad" : "Menor de edad");
        // 3d. Hacer que se ejecute este script y comprobar que el texto que sale
        // por log es el texto "Menor de edad".

        // 3e. Cambiar el valor de "edad" para que se inicialize con el valor 19
        // y hacer que se ejecute este script para comprobar que el texto que sale
        // por log es el texto "Mayor de edad".

    }
    //  ejercicio 4 ADIVINA QUE PASARA 
    	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	

	void StartD() {
		
		int cont = 0;
		
		int a = ++cont; // ++ adelante; primero se incrementara cont, y luego se asigna el valor a "a"
        Debug.Log("mas mas cont: "+a);
		int b = cont++; //++ atras; primero se asigna el valor a "b", y luego se incrementa
        Debug.Log("cont mas mas: "+a);
        Debug.Log(cont);
		
		string texto = (a==1 && b==1 && cont==2) ? "Lo he entendido!" : "Sigo sin entenderlo... :(";
		
		Debug.Log(texto);
		
		// 4a. Adivinar que texto saldra por consola al hacer que se ejecute este script.
		
		// 4b. Depurar paso a paso inspeccionando en todo momento los valores de las variables: a, b y cont.
		
	}
	
    	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 5 errores!
	

	void Start () {	
		
		// Definimos cont a 0
		int cont = 0;
		
		// Incrementamos cont en uno
		cont++;
		
		// Sacamos por log "cont vale 2" si despues de incrementarlo vale 2
		// si no, sacariamos "cont no vale 2".
		Debug.Log(((++cont)==2) ? "cont vale 2" : "cont no vale 2");
    }

}
