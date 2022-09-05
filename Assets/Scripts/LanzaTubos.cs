using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LanzaTubos : MonoBehaviour
{
    public GameObject[] tubo;
    public SistemaJuego valoresGenerales;
    public float tiempo;
    public float tiempoTranscurrido;
    public float lapso;


    // Start is called before the first frame update
    void Start()
    {
        valoresGenerales = gameObject.GetComponent<SistemaJuego>();
        tiempo = Time.time;
        lapso = 2;
        LanzarTubos();
    }

    // Update is called once per frame
    void Update()
    {

        tiempoTranscurrido = Time.time;
        

        if (tiempoTranscurrido - tiempo  > lapso && !valoresGenerales.gameOver)
        {
            LanzarTubos();
            tiempo = Time.time;
            lapso -= valoresGenerales.aumentoVelocidad;
        }
    }
    void LanzarTubos()
    {
        float posY = Random.Range(valoresGenerales.posAlturaMi, valoresGenerales.posAlturaMa);
        float posX = 10f; //Random.Range(10f, 11.5f);

        Vector3 spawnPos = new Vector3(posX, posY, 0);
        int indexTubo = Random.Range(0, tubo.Length);
        Instantiate(tubo[indexTubo], spawnPos, tubo[indexTubo].transform.rotation);
    }
}