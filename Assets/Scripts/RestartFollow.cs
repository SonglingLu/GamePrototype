using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartFollow : MonoBehaviour
{
    private GameObject player;
    public Vector3 offset = new Vector3(2.8f, 4.5f, 7);
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
