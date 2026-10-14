using UnityEngine;

public class ejercicio1 : MonoBehaviour
{

    float velocidad = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        


       transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (transform.position.x > 10f)
        {

            velocidad = -velocidad;
        }

        if (transform.position.x < -10f)
        {

            velocidad = -velocidad;

        }
    }
}
