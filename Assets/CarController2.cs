using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController2 : MonoBehaviour
{
    public GameObject CarPrefab;
    float delta = 0;
    public Sprite RacingCar03;
    public Sprite RacingCar04;
    public Sprite RacingCar05;
    public Sprite RacingCar06;
    public Sprite RacingCar07;
    public Sprite RacingCar08;
    public Sprite RacingCar09;
    public Sprite RacingCar10;
    public Sprite RacingCar11;
    public Sprite RacingCar12;
    public Sprite RacingCar13;
    public Sprite RacingCar14;
    public Sprite RacingCar15;
    public Sprite RacingCar16;
    public Sprite RacingCar17;
    public Sprite RacingCar18;
    public Sprite RacingCar19;
    public Sprite RacingCar20;
    int random;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > level.CarSpan)
        {
            this.delta = 0;
            GameObject go = Instantiate(CarPrefab);

            int random = Random.Range(3, 21);
            if (random == 3)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar03;
            }
            else if (random == 4)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar04;
            }
            else if (random == 5)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar05;
            }
            else if (random == 6)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar06;
            }
            else if (random == 7)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar07;
            }
            else if (random == 8)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar08;
            }
            else if (random == 9)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar09;
            }
            else if (random == 10)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar10;
            }
            else if (random == 11)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar11;
            }
            else if (random == 12)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar12;
            }
            else if (random == 13)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar13;
            }
            else if (random == 14)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar14;
            }
            else if (random == 15)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar15;
            }
            else if (random == 16)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar16;
            }
            else if (random == 17)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar17;
            }
            else if (random == 18)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar18;
            }
            else if (random == 19)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar19;
            }
            else if (random == 20)
            {
                CarPrefab.GetComponent<SpriteRenderer>().sprite = RacingCar20;
            }
            float px = Random.Range(-2.85f, 2.86f);
            go.transform.position = new Vector3(px, 5, 0);
        }
    }
}
