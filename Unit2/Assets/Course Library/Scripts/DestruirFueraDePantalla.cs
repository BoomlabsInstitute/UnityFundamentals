using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirFueraDePantalla : MonoBehaviour
{

    public float limiteSuperior = 100;
    public float limiteInferior = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > limiteSuperior)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < limiteInferior)
        {
            Destroy(gameObject);
        }

    }
}
