using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectChoque : MonoBehaviour
{
    public SistemaJuego valoresGenerales;
    public int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        valoresGenerales = GameObject.Find("[SISTEMASJUEGO]").GetComponent<SistemaJuego>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        valoresGenerales.puntaje++;
        Debug.Log(valoresGenerales.puntaje);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D pajarito = collision.gameObject.GetComponent<Rigidbody2D>();
        //Seteos para que todo quede estatico en el lugar del impacto
        valoresGenerales.velocidad = 0;
        valoresGenerales.gameOver = true;
        pajarito.gravityScale = 0;
        pajarito.isKinematic = true;
        pajarito.velocity = Vector2.zero;
        pajarito.angularVelocity = 0;


        

    }
}
