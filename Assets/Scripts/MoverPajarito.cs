using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPajarito : MonoBehaviour
{
    public float rotation;
    public float velocidad;
    private Rigidbody2D body;
    //Variable para poder manipular los valores de control del juego
    public SistemaJuego valoresGenerales;

    // Start is called before the first frame update
    void Start()
    {
        valoresGenerales = GameObject.Find("[SISTEMASJUEGO]").GetComponent<SistemaJuego>();
    }

    // Update is called once per frame
    void Update()
    {
       velocidad = valoresGenerales.velocidad;
       body = gameObject.GetComponent<Rigidbody2D>();
       if (Input.GetKeyDown(KeyCode.Space) && !body.isKinematic)
        {
            //Elevo la nariz del pajarito a un maximo de 30° por saltos de 45°
            rotation += 45;
            if (rotation > 30) rotation = 30;
            body.AddForce(new Vector3(0, 150, -15));

        }
        else if (!body.isKinematic)
        {
            //Hago un decaimiento de la nariz de hasta un maximo de 40°
            rotation--;
            if (rotation < -40) rotation = -40;
        }
        transform.rotation = Quaternion.AngleAxis(rotation, Vector3.forward);



    }
}
