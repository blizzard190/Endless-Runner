using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {

    [SerializeField]
    private GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset.x = transform.position.x - player.transform.position.x;
    }

    void Update()
    {
        offset.y = -player.transform.position.y;
        offset.z = -10;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
