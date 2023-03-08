using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float PipeSpeed = 10;
    public float DeadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * PipeSpeed) * Time.deltaTime;

        if(transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}
