//using System;
using System.Threading;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class sponer : MonoBehaviour
{
    public GameObject[] enemy;
    public float timer=0.0f;
    public float time = 5.0f;
    public static int enemysuu=0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame      2,-8.5f
    void Update()
    {

        if (time < timer||enemysuu<2)
        {
            Instantiate(enemy[0], new Vector2(Random.Range(2.0f, -8.5f), 9), transform.rotation);
            enemysuu++;
        }
        //Instantiate(tama, ShotPoint.position, ShotPoint.rotation);
    }
}
