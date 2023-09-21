using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreFollow : MonoBehaviour
{
    private GameObject player;
    public Vector3 offset = new Vector3(2.8f, 4.5f, 7);
    private float score = 0;
    private float multiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Robot Kyle");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if(player.transform.position.y > 0 && player.GetComponent<Forward>().speed > 0) {
            if(score > 100 * multiplier) {
                multiplier = multiplier * 2;
            }
            Debug.Log(multiplier);
            score += Time.deltaTime * 10;
            GetComponent<TextMesh>().text = "Score: " + (int)score;
        }
    }
}
