using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler OnSpacePressed;
    // Start is called before the first frame update
    void Start()
    {
        OnSpacePressed += EventoEscuchado;
        MiEventoUnity.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }

    }
    
    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("el evento fue escuchado");
    }
    public void EventoUnityDisparado()
    {
        Debug.Log("el evento unity se disparo correctamente");
    }













}
