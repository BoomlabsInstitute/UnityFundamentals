using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float entradaVertical;
    public float entradaHorizontal;
    public float VelocidadGiro;

    public int Velocidad = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //  Mover el carro hacia la derecha

        entradaHorizontal = Input.GetAxis("Horizontal");

        entradaVertical = Input.GetAxis("Vertical");

        // Modificar Velocidad (diferencia en la posición en función del tiempo)
        transform.Translate(Vector3.forward * Time.deltaTime * Velocidad * entradaVertical);

        //  Mover el carro hacia la izquierda o derecha

        transform.Rotate(Vector3.up, VelocidadGiro * entradaHorizontal * Time.deltaTime); // Rotar el vehículo en vez de deslizarlo.

        //transform.Translate(Vector3.right * Time.deltaTime * VelocidadGiro * entradaHorizontal);


    }
}
