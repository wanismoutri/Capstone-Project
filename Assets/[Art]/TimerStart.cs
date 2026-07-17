using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStart : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource tickingSource;
    public AudioSource hissSound;

    public ClosingWall doorLeft;
    public ClosingWall doorRight;

    public ClosingWall diamondWallLeft;
    public ClosingWall diamondWallRight;
    public ClosingWall goldWallLeft;
    public ClosingWall goldWallRight;
    public ClosingWall silverWallLeft;
    public ClosingWall silverWallRight;
    public ClosingWall keypad;

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            hasTriggered = true;

            hissSound.Play();
            doorLeft.StartClosing();
            doorRight.StartClosing();
            keypad.StartClosing();

            float randomTime = Random.Range(20f, 30f);
            musicSource.Play();
            tickingSource.Play();
            Debug.Log("Timer started: " + randomTime + " seconds");

            StartCoroutine(StartClosingWalls(randomTime));
        }
    }

    private IEnumerator StartClosingWalls(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        tickingSource.Stop();
    
        diamondWallLeft.StartClosing();
        diamondWallRight.StartClosing();

        yield return new WaitForSeconds(1f);
        goldWallLeft.StartClosing();
        goldWallRight.StartClosing();

        yield return new WaitForSeconds(1f);

        silverWallLeft.StartClosing();
        silverWallRight.StartClosing();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
