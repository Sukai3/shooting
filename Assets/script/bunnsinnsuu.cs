using UnityEngine;

public class bunnsinnsuu : MonoBehaviour
{
    public int suuji;
    public int tani;
    AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tani==0)
        suuji = player.bunnsinn % 10;
        if (tani == 1)
        suuji = (player.bunnsinn / 10) % 10;
        if (tani == 0)
        suuji= (player.bunnsinn / 100) % 10;

    }
}
