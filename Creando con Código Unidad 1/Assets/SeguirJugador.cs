using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour // Agregado a la cámara principal.
{
    public GameObject player; // Una variable para almacenar el objeto del jugador principal

    public int AlturaCamara = 5;
    public int OffsetZ = -7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, AlturaCamara, OffsetZ);
    }
}
