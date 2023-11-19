using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(
                prefab,
                gameObject.transform.position,
                gameObject.transform.rotation
                );
            Destroy(go, 10);
            go.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        
    }
}
