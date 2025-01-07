using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNave : MonoBehaviour
{

    public Transform mitransf;
    public Transform punta;
    public float speed;
    public GameObject balaobj;
    public Vector3 posCursor;
    public float vida;
    public int puntaje;
    public GameObject explosion;
    public Transform referencia;
    public bool tocandoFuego;
    public Text textoVida;
    public Text textopuntaje;

    //public Transform referencia;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        
        //Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Choco");
        if (collision.gameObject.tag == "enemigos")
        {
            Debug.Log("Me toco un enemigo");
            vida -= 10;
            Destroy(collision.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        }
        if (collision.gameObject.tag == "posiones")
        {
            Debug.Log("Me toco una posicion");
            vida += 10;
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Me esta tocando algo");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Me dejo de tocar algo");
    }

    // ISTRIGGER ATRAVESABLES
    public void OnTriggerEnter2D(Collider2D collison)
    {
        Debug.Log("Tocando un Trigger");
        if(collison.gameObject.tag == "fuego")
        {
            vida -= 10;
            tocandoFuego = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Tocando un Trigger");
        if (collision.gameObject.tag == "fuego")
        {
            tocandoFuego = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        textoVida.text = vida.ToString("0,0");
        textopuntaje.text = puntaje.ToString("0,0");

        if (tocandoFuego == true)
        {
            vida -= 1 * Time.deltaTime;
        }
        posCursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        referencia.position = new Vector3(posCursor.x, posCursor.y, 0);
        mitransf.rotation = Quaternion.LookRotation(new Vector3(0,0,1), mitransf.position - referencia.position);
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            mitransf.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
            Debug.Log("Espacio");
        }*/

        if (Input.GetKey(KeyCode.E))
        {
            mitransf.Rotate(new Vector3(0, 0, -1));
            Debug.Log("Rotar izquierda");
        }

        if (Input.GetKey(KeyCode.Q))
        {
            mitransf.Rotate(new Vector3(0, 0, 1));
            Debug.Log("Rotar derecha");
        }
        //mitransf.rotation = Quaternion.Euler(0, 0, 1);


        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(balaobj);
            Instantiate(balaobj, punta.position, punta.rotation);
            Debug.Log("Clic Izquierdo");
        }

        if (Input.GetKey(KeyCode.D))
        {
            mitransf.position += new Vector3(1f, 0, 0) * Time.deltaTime * speed;
            Debug.Log("Derecha");
        }

        if (Input.GetKey(KeyCode.A))
        {
            //0.1f mas lento
            mitransf.position -= new Vector3(1f, 0, 0) * Time.deltaTime * speed;
            Debug.Log("Izquierda");
        }

        if (Input.GetKey(KeyCode.W))
        {
            //0.1f mas lento
            mitransf.position += new Vector3(0, 1f, 0) * Time.deltaTime * speed;
            Debug.Log("Arriba");
        }

        if (Input.GetKey(KeyCode.S))
        {
            //0.1f mas lento
            mitransf.position -= new Vector3(0, 1f, 0) * Time.deltaTime * speed;
            Debug.Log("Abajo");
        }

    }


}
