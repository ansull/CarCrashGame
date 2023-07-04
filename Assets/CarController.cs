using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    
    public Vector3 carPosition;
    public float carSpeed=5f;
    public float maxLeft, maxRight;

    // Start is called before the first frame update
    void Start()
    {
        carPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        carPosition.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp(carPosition.x, maxLeft, maxRight);
        transform.position = carPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }    
    }
}
