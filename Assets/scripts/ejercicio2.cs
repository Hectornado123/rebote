using UnityEngine;
using UnityEngine.SceneManagement;
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


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("te quemas");
        SceneManager.LoadScene("ejercicio3");
    }
}
