using UnityEngine;

public class ejercicio2 : MonoBehaviour
{

    float velocidad = 3;
  

    
    void Update()
    {




        if (transform.position.x > 3.78f)
        {

            velocidad = -velocidad;
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        if (transform.position.x < -1.78f)
        {

            velocidad = -velocidad;
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }


  
}
