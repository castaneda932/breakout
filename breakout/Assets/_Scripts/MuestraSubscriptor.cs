using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraSuscriptor : MonoBehaviour
{
   
    MuestraEventos subscriptor;
    // Start is called before the first frame update
    void Start()
    {
        subscriptor = GetComponent<MuestraEventos>();
        subscriptor.OnSpacePressed += MensajeEscuchadoPorElSubscriptor;

    }
    
    private void MensajeEscuchadoPorElSubscriptor(object sender, EventArgs e)
    {
        Debug.Log("el evento ha sido escuchado desde otra clase");
        subscriptor.OnSpacePressed -= MensajeEscuchadoPorElSubscriptor;
    }

    

}
