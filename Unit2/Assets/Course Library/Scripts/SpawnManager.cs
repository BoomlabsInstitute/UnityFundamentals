using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animales;

    public float rangoNacimientoX = 20;
    public float posicionNacimientoZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var indexAnimal = Random.Range(0, animales.Length);

        if(Input.GetKeyDown(KeyCode.S)){

            // TODO: Aleatorizar la posición en la que nacen los animales
            var valorRandom = Random.Range(-rangoNacimientoX, rangoNacimientoX);

            var posicionNacimiento = new Vector3(valorRandom,  0 ,  posicionNacimientoZ);


            Instantiate(animales[indexAnimal], posicionNacimiento, 
            animales[indexAnimal].transform.rotation);
        }
    }
}
