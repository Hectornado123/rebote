using UnityEngine;

public class ejercicio2 : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Hola mundo");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, 0.01f);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -0.01f);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(0.01f, 0, 0);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-0.01f, 0, 0);
    }
}
