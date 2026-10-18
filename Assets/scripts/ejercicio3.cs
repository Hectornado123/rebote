using UnityEngine;
using UnityEngine.SceneManagement;
public class ejercicio3 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float velocidad;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    float velocidad2 = 1f;
    float velocidad3 = 1f;
    float velocidad4 = 1f;
    float velocidad5 = 1f;
    void Start()
    {
        Debug.Log("Hola mundo");
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
       /* if (transform.position.y < fallLimit)
        {
            rb.linearVelocity = Vector3.zero;
            transform.position = respawnPoint;


        }*/
        //enemigo1
        if (enemy1.transform.position.x > 3.78f)
        {

            velocidad = -velocidad;
        }

        if (enemy1.transform.position.x < -1.78f)
        {

            velocidad = -velocidad;
        }
        enemy1.transform.Translate(velocidad * Time.deltaTime, 0, 0);


        if (enemy2.transform.position.z > -2.66)
        {

            velocidad2 = -velocidad2;
        }

        if (enemy2.transform.position.z < 3.78f)
        {

            velocidad2 = -velocidad2;
        }
        enemy2.transform.Translate(0, 0, velocidad2 * Time.deltaTime);


        if (enemy3.transform.position.z > -2.66f)
        {

            velocidad3 = -velocidad3;
        }

        if (enemy3.transform.position.z < 3.78f)
        {

            velocidad3 = -velocidad3;
        }
        enemy3.transform.Translate(0, 0, velocidad3 * Time.deltaTime);


        if (enemy4.transform.position.z > 14f)
        {

            velocidad4 = -velocidad4;
        }

        if (enemy4.transform.position.z <15f)
        {

            velocidad4 = -velocidad4;
        }
        enemy4.transform.Translate(0, 0, velocidad4 * Time.deltaTime);


        if (enemy5.transform.position.x > 3.78f)
        {

            velocidad5 = -velocidad5;
        }

        if (enemy5.transform.position.x < -1.78f)
        {

            velocidad5 = -velocidad5;
        }
        enemy5.transform.Translate(velocidad5 * Time.deltaTime, 0, 0);



    }
    void FixedUpdate()
    {

        float inputHor = Input.GetAxis("Horizontal");
        float inputVer = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(inputHor, 0, inputVer);

        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("te quemas");
        SceneManager.LoadScene("ejercicio3");
    }
}