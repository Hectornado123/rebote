using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float JumpForce;
    public Vector3 respawnPoint;
    public float fallLimit;
    void Start()
    {
        Debug.Log("Hola mundo");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if ( transform.position.y < fallLimit)
        {
            rb.linearVelocity = Vector3.zero;
            transform.position = respawnPoint;
        }

    }
    void FixedUpdate()
    {

        float inputHor = Input.GetAxis("Horizontal");
        float inputVer = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(inputHor, 0, inputVer);

        rb.AddForce(movement * speed);
    }
    



}
