using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
    public Vector3 posi;
    public Vector2 posi2;
    public Transform miUbicacion;
    public GameObject obstaculo;

    // Start is called before the first frame update
    void Start()
    {
        posi2 += new Vector2(3, 3);
        posi2 -= new Vector2(5, 4);
        posi = new Vector3(3, 1, 4) * 3;
    }

    // Update is called once per frame
    void Update()
    {
        //Funcion para mover el personaje
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Derecha");
            miUbicacion.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Izquierda");
            miUbicacion.position -= new Vector3(0.1f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Presionando GetKeyDown");
            Instantiate(obstaculo);

        }

    }
}
