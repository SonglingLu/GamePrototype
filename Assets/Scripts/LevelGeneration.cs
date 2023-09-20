using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] section;
    private int zPos = 25;
    private bool sectionGeneration = false;
    private int sectionNum;

    // Start is called before the first frame update
    void Start()
    {
        while (zPos < 150) {
            sectionNum = Random.Range(0, section.Length);
            GameObject newSection = Instantiate(section[sectionNum], new Vector3(0, 0, zPos), Quaternion.identity);
            newSection.name = zPos.ToString();
            zPos += 25;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sectionGeneration == false) {
            sectionGeneration = true;
            StartCoroutine(RandomGenerateSection());
        }
    }

    IEnumerator RandomGenerateSection() {
        sectionNum = Random.Range(0, section.Length);
        GameObject newSection = Instantiate(section[sectionNum], new Vector3(0, 0, zPos), Quaternion.identity);
        newSection.name = zPos.ToString();
        zPos += 25;
        yield return new WaitForSeconds(1);
        sectionGeneration = false;
    }
}
