using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaeCaja : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Script para que reaparezcan las cajas si se caen por una trampa
        if (other.tag == "Caja1")
        {
            //Recolocar
        }
        else if (other.tag == "Caja2")
        {
            //Recolocar
        }
        else if (other.tag == "Caja3")
        {
            //Recolocar
        }
    }
}
