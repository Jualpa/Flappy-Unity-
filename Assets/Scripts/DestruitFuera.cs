using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruitFuera : MonoBehaviour
{
    public SistemaJuego sistJuego;
    
    // Start is called before the first frame update
    void Start()
    {
        sistJuego = GameObject.Find("[SISTEMASJUEGO]").GetComponent<SistemaJuego>();
    }

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;
        if (posX < sistJuego.izqPantalla)
        {
            Destroy(gameObject);
        }
    }
}
