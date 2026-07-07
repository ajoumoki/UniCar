using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    public static float speed = -0.1f;
    public static float CarSpan = 0.8f;
    float delta = 0;
    float span = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            print(speed);
            delta = 0;
            speed -= 0.025f;
            CarSpan -= 0.08f;
        }
    }
}
