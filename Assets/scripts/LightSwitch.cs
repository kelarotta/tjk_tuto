using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    void Start() {
        light = GetComponent<Light>();

        if (Input.GetKeyDown("tab"))
        {
            light.color = new Color(0.3f, 0.4f, 0.6f, 0.3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
