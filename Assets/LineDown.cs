using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LineDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() 
    {
        if (CarController.move == 1)
        {
            transform.Translate(new Vector3(0, -0.1f, 0));
            if (transform.position.y < -5.5)
            {
                transform.position = new Vector3(0, 5.5f, 0);
            }
        }
    }

}
