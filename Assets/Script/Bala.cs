using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed;
    public Transform miTransf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //miTransf.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;
        miTransf.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
