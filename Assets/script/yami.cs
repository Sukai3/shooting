using UnityEngine;

public class yami : MonoBehaviour
{
    private Animator anim;
    private int a = 0;
    public static bool key = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        key = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (key&&a==0)
        {
            anim.SetBool("yami", true);
            a++;
        }
    }
}
