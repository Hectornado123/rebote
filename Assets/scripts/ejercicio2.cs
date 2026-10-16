using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public float velocidad;

    void Update()
    {
        if (transform.position.x > 6)
        {
            velocidad = -velocidad;
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        if (transform.position.x < -2)
        {
            velocidad = -velocidad;
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }




}
