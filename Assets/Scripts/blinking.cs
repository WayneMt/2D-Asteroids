using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinking : MonoBehaviour
{

    public GameObject flashing_Label;
    private float interval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FlashLabel", 0, interval);
    }

    // Update is called once per frame
    void FlashLabel()
    {
        if (flashing_Label.activeSelf)
            flashing_Label.SetActive(false);
        else
            flashing_Label.SetActive(true);
    }
}
