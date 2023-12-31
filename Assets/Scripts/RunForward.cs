using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    public float speed = 3.0f;
    private float MAX_SPEED = 23.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0) {
            StopAllCoroutines();
            GameObject.Find("Score").GetComponent<TextMesh>().text = "GAME OVER!!";
            GameObject.Find("Score").GetComponent<TextMesh>().fontSize = 30;
            GameObject.Find("Score").GetComponent<ScoreFollow>().offset = new Vector3(-7, 4.5f, 7);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(speed < MAX_SPEED) {
            speed += 0.003f;
        }
    }
}
