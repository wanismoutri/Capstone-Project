using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VaultExit : MonoBehaviour
{
    public GameObject scorePopup;
    public TextMeshProUGUI scoreText;
    public GameObject resetCube;
    public AudioSource musicSource;
    public AudioSource tickingSource;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player") && VaultEntry.hasEnteredVault)
        {
            hasTriggered = true;
            scorePopup.SetActive(true);
            scoreText.text = "You escaped with " + bagscript.score + " points! To restart, step on the red square.";
            resetCube.SetActive(true);
            musicSource.Stop();
            tickingSource.Stop();
        }
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
