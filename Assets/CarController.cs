using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public static int move = 1; //move static 필드를 1로 설정
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void SceneChange() //SceneChange 클래스 호출 시
    {
        SceneManager.LoadScene("ClearScene"); //clearscene으로 전환
    }
    public void LButton() //LButton 클래스 호출 시
    {
        transform.Translate(-0.2f, 0, 0); //x값을 -0.2만큼 이동하기
    }
    public void RButton() //RButton 클래스 호출 시
    {
        transform.Translate(0.2f, 0, 0); //x값을 0.2만큼 이동하기
    }

    // Update is called once per frame
    void Update()
    {
        if (move == 1) //만약 move값이 1이면
        {
            if (Input.GetKey(KeyCode.LeftArrow)) //만약 왼쪽 화살표 키를 누를 시
            {
                transform.Translate(-0.2f, 0, 0); //x값을 -0.2만큼 이동하기
            }
            if (Input.GetKey(KeyCode.RightArrow)) //만약 오른쪽 화살표 키를 누를 시
            {
                transform.Translate(0.2f, 0, 0); //x값을 0.2만큼 이동하기
            }
            if (transform.position.x > 3) //만약 x값이 3보다 크면
            {
                transform.Translate(-0.2f, 0, 0); //x값을 -0.2만큼 이동하기
            }
            if (transform.position.x < -3) //만약 x값이 -3보다 작으면
            {
                transform.Translate(0.2f, 0, 0); //x값 0.2만틈 이동하기
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision) //Trigger 충돌 발생 시
    {
        GetComponent<AudioSource>().Play(); //오디오 재생하기
        if (PlayerPrefs.GetInt("bestScore") < Score.score) //만약 bestScore값이 Score값보다 작으면
        {
            PlayerPrefs.SetInt("bestScore", Score.score);
            print("ÃÖ°í Á¡¼ö º¯°æ");
        }
        Invoke("SceneChange", 1);
        move = 0;
    }

}
