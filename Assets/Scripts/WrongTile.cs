using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongTile : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Robot Kyle");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == 0 && player.transform.position.z < transform.position.z && 
        transform.position.z - player.transform.position.z < 1) {
            player.GetComponent<Forward>().speed = 0;
            GameObject.Find("Score").GetComponent<TextMesh>().text = "GAME OVER!!";
            GameObject.Find("Score").GetComponent<TextMesh>().fontSize = 30;
            GameObject.Find("Score").GetComponent<ScoreFollow>().offset = new Vector3(-7, 4.5f, 7);
        }
    }
}
