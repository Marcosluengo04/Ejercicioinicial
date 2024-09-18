using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apunteswhile : MonoBehaviour
{
    [SerializeField] int vidas = 100;
    // Start is called before the first frame update
    void Start()
    {
        //bUCLES INFINITO NO
        //while:MIENTRAS 
        //BUCLE INDETERMINADO
        //FOR : DETERMINDADO
        while (vidas > 0) //bucle ciclo
        {
            Debug.Log("Sigo vivo");
            vidas--; //VIDAS =VIDAS -1
        }
        


    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
