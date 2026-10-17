using UnityEngine;
using UnityEngine.SceneManagement;
public class AccesoGameObject : MonoBehaviour
{


    public GameObject pelota;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pelota.transform.position);

    }
}
