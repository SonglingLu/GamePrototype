using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftLeftTile : MonoBehaviour
{
    private int horizontalInput;
    public GameObject rightTile;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(transform.position.z - player.transform.position.z < 5) {
            horizontalInput = (int)Input.GetAxisRaw("Horizontal");
            if (horizontalInput == 1 && transform.position.x < 0) {
                transform.position = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
            } else if (horizontalInput == -1 && transform.position.x > -5) {
                transform.position = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z);
            }            
        // }
    }
}
