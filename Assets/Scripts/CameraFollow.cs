using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset = new Vector3(0, 5, -3);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Robot Kyle");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
