using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float scrollSpeed;
    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > (initPos + new Vector3(0, -40.0f, 0)).y)
            transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        else
            transform.position = initPos;

    }
}
