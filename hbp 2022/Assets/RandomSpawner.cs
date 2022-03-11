using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public float radius = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) SpawnObjectAtRandom();
    }

    void SpawnObjectAtRandom(){
        Vector3 randomPos = Random.insideUnitCircle * radius;
       // instantiate(asteroid, randomPos, Quaternion.identity);
    }
}
