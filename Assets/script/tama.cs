using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class tama : MonoBehaviour
{
    public float xspeed = 5.0f;
    public float yspeed = 0;
    public bool playermuke;
    //public Transform player;
  //  public Transform player;
    void Start()
    {
        if (playermuke)
        {
           // transform.LookAt(player);
        }

        //
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xspeed, yspeed, 0) * Time.deltaTime);
    }
}
