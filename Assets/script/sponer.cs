//using System;
using UnityEngine;

public class sponer : MonoBehaviour
{
    public GameObject[] enemy;
    public float timer=0.0f;
    public float Stimer = 0.0f;
    private float Stimer2 = 0.0f;
    public float time = 5.0f;
    public static int enemysuu=0;
    public static int enemysum = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemysuu = 0;
        enemysum = 0;
    }

    // Update is called once per frame      2,-8.5f
    void Update()
    {
        timer += Time.deltaTime;
        Stimer += Time.deltaTime;
        Stimer2 += Time.deltaTime;

        if ( Stimer < bosatk.sponetime - 20&&time*(17/Stimer) < timer)
        {
            Instantiate(enemy[0], new Vector2(Random.Range(8f, -8.5f), 9), transform.rotation);
            enemysuu++;
            timer = 0.0f;
           
        }
        if (Stimer < bosatk.sponetime - 20 &&enemysuu < 2)
        {
            Instantiate(enemy[0], new Vector2(Random.Range(8f, -8.5f), 9), transform.rotation);
            enemysuu++;
            timer = 0.0f;
           
        }
        if (Stimer < bosatk.sponetime - 20 && 15< Stimer2)
        {
            Instantiate(enemy[2], new Vector2(Random.Range(8f, -8.5f), 9), transform.rotation);
            enemysuu++;
            Stimer2 = 0.0f;

        }
        if (Stimer > bosatk.sponetime && time< timer)
        {
            time = 15;
            Instantiate(enemy[1], new Vector2(Random.Range(8f, -8.5f), 9), transform.rotation);
            enemysuu++;
            timer = 0.0f;

        }
        //Instantiate(tama, ShotPoint.position, ShotPoint.rotation);
    }
}
