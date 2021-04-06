using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player; 
    public Vector3 pos_offset; 
    public float time_offset;
    public Vector3 velocity; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + pos_offset, ref velocity, time_offset);
    }
}
