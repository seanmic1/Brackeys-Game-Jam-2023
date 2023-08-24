using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x <= -1.5f)
        {
            transform.position = new Vector3(-1.5f,player.position.y+2,transform.position.z);
        }
        else
        {
            transform.position = new Vector3(player.position.x,player.position.y+2,transform.position.z);
        }
    }
}
