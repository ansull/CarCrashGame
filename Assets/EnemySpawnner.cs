using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnner : MonoBehaviour
{
    public float delaytimer = 1.5f;
    float timer;
    public GameObject[] enemyPrefab;
    public float maxEnemyLeft;
    public float maxEnemyRight;
    // Start is called before the first frame update
    void Start()
    {
        timer = delaytimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Vector3 spawnpos = new Vector3(Random.Range(maxEnemyLeft, maxEnemyRight),transform.position.y,transform.position.z);
            int randomIndex = Random.Range(0, 2);
            Instantiate(enemyPrefab[randomIndex], spawnpos, transform.rotation);
            timer = delaytimer;
        }
    }
        
}
