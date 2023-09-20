using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float cameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + ((player.GetComponent<Transform>().position.x - transform.position.x) / cameraSpeed * Time.deltaTime),
                                         transform.position.y + ((player.GetComponent<Transform>().position.y - transform.position.y) / cameraSpeed * Time.deltaTime), 
                                         -10);
    }
}
