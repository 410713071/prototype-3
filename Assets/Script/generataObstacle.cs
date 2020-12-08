using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generataObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float start_dealy = 1.0f;
    private float repetate_rate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Gobstacles", start_dealy, repetate_rate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gobstacles()
    {
        // generate obstacle prefab
        Vector3 obstacle_pos = new Vector3(25, 0, 0);
        Instantiate(obstaclePrefab, obstacle_pos, obstaclePrefab.transform.rotation);
    }
}
