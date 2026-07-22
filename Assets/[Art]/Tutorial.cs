using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public AudioSource npcAudio;
    public Animator robotAnimator;
    private bool hasTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if(!hasTriggered && other.CompareTag("Player"))
        {
            hasTriggered = true;
            npcAudio.Play();
            robotAnimator.SetBool("Open_Anim", true);
        }
    }

    public void StopTutorial()
    {
        npcAudio.Stop();
        robotAnimator.SetBool("Open_Anim", false);
        hasTriggered = true;
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
