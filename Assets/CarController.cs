using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public static int move = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void SceneChange()
    {
        SceneManager.LoadScene("ClearScene"); //clearscene으로 전환
    }
    public void LButton()
    {
        transform.Translate(-0.2f, 0, 0);
    }
    public void RButton()
    {
        transform.Translate(0.2f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (move == 1)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.2f, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0.2f, 0, 0);
            }
            if (transform.position.x > 3)
            {
                transform.Translate(-0.2f, 0, 0);
            }
            if (transform.position.x < -3)
            {
                transform.Translate(0.2f, 0, 0);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        if (PlayerPrefs.GetInt("bestScore") < Score.score)
        {
            PlayerPrefs.SetInt("bestScore", Score.score);
            print("ÃÖ°í Á¡¼ö º¯°æ");
        }
        Invoke("SceneChange", 1);
        move = 0;
    }

}
