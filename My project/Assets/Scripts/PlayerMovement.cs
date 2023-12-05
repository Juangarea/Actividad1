using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float velocidadMovimiento = 1f;
    public float velocidadRotacion = 1f;


    // Update is called once per frame
    void Update()
    {
        MoverPersonaje();
        RotarPersonaje();
    }

    private void MoverPersonaje()
    {
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 desplazamiento = transform.forward * movimientoVertical * velocidadMovimiento * Time.deltaTime;
        transform.Translate(desplazamiento);

    }

    private void RotarPersonaje()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector3 rotacion = new Vector3(0f, movimientoHorizontal, 0f) * velocidadRotacion * Time.deltaTime;
        transform.Rotate(rotacion);

    }
}
