using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComet : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
     transform.position += move * speed * Time.deltaTime;


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Asteroid"){
            Debug.Log("asteroid hit");
        }
    }
}

