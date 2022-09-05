using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComporTubo : MonoBehaviour
{
    //Vinculo a la seccion superior del tubo 
    public GameObject prefabTuboSup;
    //Vinculo a los datos de control del juego
    public SistemaJuego valoresGenerales;
    public float velocidad;
    public float gapTubos;
    public float separacionMaxTubos;
    public float separacionMinTubos;
    // constante para que los tubos no se toquen entre si
    private const float difEntreTubos = 11.5f;

    // Start is called before the first frame update
    void Start()
    {
        float posx = transform.position.x;
        //Variable que contiene la posicion del tubo superior en eje Y
        float posTuboSupy = transform.position.y + difEntreTubos;

        valoresGenerales = GameObject.Find("[SISTEMASJUEGO]").GetComponent<SistemaJuego>();
        separacionMaxTubos = valoresGenerales.separacionMaxTubos;
        separacionMinTubos = valoresGenerales.separacionMinTubos;
        gapTubos = Random.Range(separacionMinTubos, separacionMaxTubos);
        prefabTuboSup.transform.position = new Vector3(posx, posTuboSupy + gapTubos);
    }

    // Update is called once per frame
    void Update()
    {
        velocidad = valoresGenerales.velocidad;
        transform.Translate(velocidad * Time.deltaTime, 0, 0);   


        

    }
}
