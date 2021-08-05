using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // TODO: Obtener la entrada horizontal del usuario
    public GameObject proyectil;
    public float entradaHorizontal;
    public float velocidad = 10.0f;

    public float RangoX = 10;

    // Se llama al inicio antes de la primera actualización de la pantalla
    void Start()
    {
        
    }

    // La actualización se llama una vez por fotograma
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectil, transform.position, proyectil.transform.rotation);
        }

        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * entradaHorizontal * Time.deltaTime * velocidad);

        if (transform.position.x < -RangoX){
            transform.position = new Vector3(-RangoX, transform.position.y, transform.position.z );
        }

        if(transform.position.x > RangoX){
            transform.position = new Vector3(RangoX, transform.position.y, transform.position.z );
        }

    }
}
