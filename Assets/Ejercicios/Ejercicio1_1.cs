using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
//1. EJERCICIOS DE MENSAJES POR CONSOLA 
//1.1.Realiza un código de tal manera que aparezca por consola el mensaje “¡Hola Mundo!”  al iniciar el juego. 
//1.2.Realiza un código de tal manera que aparezca el mensaje anterior seguido del siguiente  mensaje: “Este es el primer videojuego de <tu_nombre>” al iniciar el juego. 
//1.3.Por último, termina con una última frase del estilo: “Estoy aprendiendo C#”. 
//1.4.Incluye con un Debug.Log el mensaje “Ha pasado un frame” dentro del bloque Update. 
//1.5.Responde en cualquier parte del código con un comentario de bloque por qué aparece  tantas veces por consola este último mensaje al dar al Play. 


public class Ejercicio1_1 : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo");
        Debug.Log("Este es el primer videojuego de Marcos Luengo Oritz" );
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        //Cuando ponemos un mensaje en la funcion Update se repite por cada frame en la consola
    }
}
