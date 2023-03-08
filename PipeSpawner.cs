using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnerRate = 2;
    private float timer = 0; 
    public float spawnerHeight = 10;

    // Start is called before the first frame update
    void Start()
    {
        spwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnerRate)
        {
            timer += Time.deltaTime; 
        }else{
          spwanPipe();
          timer = 0;
        }
    }

    void spwanPipe()
    {
        float lowestPoint = transform.position.y - spawnerHeight;
        float heightPoint = transform.position.y + spawnerHeight;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,heightPoint), 0), transform.rotation);
    }
}
