using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLoader : MonoBehaviour {
    public GameObject platform;
    public GameObject platform2;
    public Transform GenarationPoint;
    public float distance;
    private float platformWidth;

    void Update()
    {
        distance = Random.Range(7f, 15f);
        if (transform.position.x < GenarationPoint.position.x)
        {
            platform.transform.localScale = new Vector3(Random.Range(3F, 10F), 1.456919F, 1);
            platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
            transform.position = new Vector3(transform.position.x + platformWidth + distance, transform.position.y, transform.position.z);
            for(int i = 0; i < 1; i++)
            {
                GameObject obj = Instantiate(platform, transform.position, transform.rotation);
                DestroyObject(obj, 15.0f);
                DestroyObject(platform2, 15.0f);
            }
        }   
    }
}
