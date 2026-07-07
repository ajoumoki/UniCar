using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BestScore : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "best score : " + PlayerPrefs.GetInt("bestScore");
    }
    void Update()
    {
       
    }
}

