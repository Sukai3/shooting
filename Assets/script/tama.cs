using UnityEngine;

public class tama : MonoBehaviour
{
    public float xspeed = 5.0f;
    public float yspeed = 0;
    public bool playermuke;
  //  public Transform player;
    void Start()
    {
        //if (playermuke) 
        //{
        //    xspeed= (transform.position.x-player.position.x);
        //    yspeed= (transform.position.y-player.position.y);
        //}

        //transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xspeed, yspeed, 0) * Time.deltaTime);
    }
}
