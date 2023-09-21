using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    public GameObject[] wrongTiles;
    public GameObject correctTile;
    private int leftRight;
    private int wrongTileNum;
    private Vector3 rightOffset = new Vector3(5, 0, 0);
    private Vector3 leftOffset = new Vector3(-5, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        leftRight = Random.Range(0, 10000) % 2;
        wrongTileNum = Random.Range(0, wrongTiles.Length);

        
        if (leftRight == 0) {       // Generate correct tile on right side
            GameObject leftTile = Instantiate(correctTile, transform.position + leftOffset, Quaternion.identity);
            GameObject rightTile = Instantiate(wrongTiles[wrongTileNum], transform.position + rightOffset, Quaternion.identity);

            leftTile.transform.parent = transform;
            rightTile.transform.parent = transform;
            rightTile.AddComponent<WrongTile>();
        } else {        //Generate correct tile on left side
            GameObject leftTile = Instantiate(wrongTiles[wrongTileNum], transform.position + leftOffset, Quaternion.identity);
            GameObject rightTile = Instantiate(correctTile, transform.position + rightOffset, Quaternion.identity);
            
            leftTile.transform.parent = transform;
            rightTile.transform.parent = transform;
            leftTile.AddComponent<WrongTile>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
