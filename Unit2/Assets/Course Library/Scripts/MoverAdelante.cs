using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAdelante : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
    }
}
