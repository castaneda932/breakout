using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Explosivo : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 3;
    }

    // Update is called once per frame
    public override void RebotarBola()
    {
        base.RebotarBola();
    }

}
