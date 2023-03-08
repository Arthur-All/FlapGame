using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePipe : MonoBehaviour
{
    public logicManager logic;  

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicManager>();
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.layer == 3){}
        {
            logic.addScore(1);
        }
    }
}
