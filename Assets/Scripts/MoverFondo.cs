using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFondo : MonoBehaviour
{
    //Objeto, clase y variable que poseen los valores de referencia del juego
    public GameObject objetoReferencia;
    public SistemaJuego valoresGenerales;
    public float velocidad;
    // Limites de pantalla para reubicar objeto
    public float izqPantalla;
    public float derPantalla;

    // Start is called before the first frame update
    void Start()
    {
        //Establece los limites laterales de reinicio
        valoresGenerales = GameObject.Find("[SISTEMASJUEGO]").GetComponent<SistemaJuego>();
        izqPantalla = valoresGenerales.izqPantalla;
        derPantalla = valoresGenerales.derPantalla;
    }

    // Update is called once per frame
    void Update()
    {
        velocidad = valoresGenerales.velocidad;
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        float posX = transform.position.x;

        if (posX < izqPantalla)
        {
            transform.position = new Vector3(derPantalla, transform.position.y);
        }
    }
}
