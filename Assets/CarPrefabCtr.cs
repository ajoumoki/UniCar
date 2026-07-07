using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CarPrefabCtr : MonoBehaviour
{
    public GameObject Score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CarController.move == 1)
        {
            transform.Translate(0, level.speed , 0);
            if (transform.position.y < -8.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
