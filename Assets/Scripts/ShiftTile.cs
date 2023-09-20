using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShiftTile : MonoBehaviour
{
    private GameObject player;
    private GameObject currentSection;
    private GameObject prevSection;

    private Transform leftTile;
    private Transform rightTile;

    private Vector3 leftShift = Vector3.left * 5;
    private Vector3 rightShift = Vector3.right * 5;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Robot Kyle");

        currentSection = transform.parent.GameObject();
        int zPos = int.Parse(currentSection.name);
        int prevZPos = zPos - 25;
        prevSection = GameObject.Find(prevZPos.ToString());

        leftTile = transform.GetChild(0);
        rightTile = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z < transform.position.z - 2.5 && (prevSection == null ||
        player.transform.position.z > prevSection.transform.Find("Obstacle").position.z - 2.5)) {
            if (Input.GetKeyDown(KeyCode.RightArrow)) {
                if (rightTile.position.x == 0) {
                    rightTile.Translate(rightShift);
                } else if (leftTile.position.x == -5) {
                    leftTile.Translate(rightShift);
                }
            } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                if (leftTile.position.x == 0) {
                    leftTile.Translate(leftShift);
                } else if (rightTile.position.x == 5) {
                    rightTile.Translate(leftShift);
                }
            }
        }
    }
}
