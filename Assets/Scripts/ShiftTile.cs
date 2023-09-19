using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShiftTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5) {
            transform.Translate(Vector3.left * 5);
        } else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 5) {
            transform.Translate(Vector3.right * 5);
        }
    }
}
